using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPPROG3
{
 public partial class IngresarService : Form
 {
  public IngresarService()
  {
   InitializeComponent();
  }
  public int Autonum = 1;
  public DateTime Fecha = System.DateTime.Now;

  public void IncrementarAutonumerico(){
   string consulta = "select MAX(Nservice) from Service";
   Tablas Data = new Tablas();
   Autonum = Int32.Parse(Data.BuscarCampo(consulta))+1;
  }

  bool VerificarVacio(TextBox txtNserv,ComboBox cmbTip,TextBox txtNequip,TextBox txtDescrp) 
        {
            if (txtNserv.Text != "" && txtNequip.Text != "" && txtDescrp.Text != "" && cmbTip.Text != "")
            {
                return true;
            }
            return false;
        } 

  public void CargarTabla(){
   Consultas BusquedaEquipo = new Consultas();
   Tablas DATA = new Tablas();
   string comando = "select Service.Nservice as 'Numero De Service',Tipos_De_Service.Tipo_Nombre as 'Tipo De Service',Service.FechaIngreso as 'Fecha De Ingreso',Service.Descripcion,Service.Nserie as 'Numero De Serie',Service.Nequipo as 'Numero De Equipo' from Service inner join Tipos_De_Service on Service.Cod_Tipo=Tipos_De_Service.Cod_TipoS where Service.Estado=1";
   grd_datos.DataSource = DATA.TraerTabla(comando, "ListaService");
  }

  private void btn_agregar_Click(object sender, EventArgs e)
  {
            Validaciones val = new Validaciones();
            Tablas Ta = new Tablas();

            if (VerificarVacio(txt_nservice, cmbx_tipo_service, txt_nequipo, txt_descripcion_service)==false)
            {
                MessageBox.Show("tienen que estar todos los campos llenos");
                return;
            }
                

            int A = Int32.Parse(txt_nservice.Text);
            int B = Int32.Parse(txt_nequipo.Text);
            
            

            if (val.VerficarCampoNumerico(txt_nequipo.Text)== false)
            {
                MessageBox.Show("El campo numero de equipo debe ser numerico");
                return;
            }
            
            if (val.VerificarLongitudString(txt_descripcion_service.Text, 50) == true)
            {
                MessageBox.Show("Solo se permite una cantidad de 50 caracteres");
                return;
            }


            if(val.VerificarExistenciaEquipos("Select Nequipo from Equipos", "Equipos", txt_nequipo.Text)==false){
                MessageBox.Show("Este Numero de equipo no esta ingresado en la base de datos");
                return;
            }
            else
            {
                DataTable Dat;
                Dat=Ta.TraerTabla("select Nequipo,Nserie from Equipos", "Equipos");
                foreach (DataRow dr in Dat.Rows)
                {
                    if (dr["Nequipo"].ToString().Equals(txt_nequipo.Text))
                    {
                        txt_numserie.Text=dr["Nserie"].ToString();
                    }
                }
            }
            int reg_ag = 0;

            string X="";
            DataTable dat2;
            dat2 = Ta.TraerTabla("select Tipo_Nombre,Cod_TipoS from Tipos_De_Service", "Equipos2");

            foreach (DataRow dr in dat2.Rows)
            {
                if (dr["Tipo_Nombre"].ToString().Equals(cmbx_tipo_service.Text))
                {
                    X = dr["Cod_TipoS"].ToString();
                }
                
            }
            

            reg_ag =Ta.InsertarEnDbService("execute insrt_service", "insrt_service", A,X, txt_numserie.Text, B,Fecha , txt_descripcion_service.Text,1);
            MessageBox.Show("Service Agregado Satisfactoriamente");
            CargarTabla();
            txt_nequipo.Clear();
            txt_numserie.Clear();
            txt_descripcion_service.Clear();
            IncrementarAutonumerico();
            txt_nservice.Text = Autonum.ToString();
           }

  private void IngresarService_Load(object sender, EventArgs e)
  {
   CargarTabla();
   Tablas DATA = new Tablas();
   DATA.CargarCombobox("select * from Tipos_De_Service where Estado=1", 0, ref cmbx_tipo_service);
  string consulta2 = "select MAX(Nservice) from Service";
            if (DATA.VerificarCantidad(consulta2)) {
                IncrementarAutonumerico();
            }
   txt_nservice.Text = Autonum.ToString();
   txt_fecha.Text = Fecha.ToString();
        }
 }
}
