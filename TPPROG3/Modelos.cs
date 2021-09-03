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
 public partial class Modelos : Form
 {
  public Modelos()
  {
   InitializeComponent();
  }
  void CargarDatos()
  {
   string comando = "Select Modelo_Nombre as 'Modelo',Cod_TipoE as 'Codigo De Tipo De Equipo',Cod_Modelo as 'Codigo De Modelo',Cod_Marca as 'Codigo De Marca' from Modelos where Estado=1";
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(comando, "Modelos");
  }
  private void btn_agregar_Click(object sender, EventArgs e)
  {
   int registros_agregados = 0;
   //////////Validaciones//////////
   Validaciones Valid = new Validaciones();
   bool Check = true;
   if (txt_modelo.Text == "")
   {
    MessageBox.Show("Este Campo No Puede Ser Nulo");
    return;
   }
   if (Valid.VerificarLongitudString(txt_modelo.Text, 50) == true)
   {
    MessageBox.Show("Longitud Maxima De Texto Excedida");
    return;
   }
   if (cmbx_marca.SelectedIndex < 0)
   {
    MessageBox.Show("Seleccione Una Marca");
    return;
   }
   if (cmbx_tipo.SelectedIndex < 0)
   {
    MessageBox.Show("Seleccione Un Tipo De Equipo");
    return;
   }
   string codmodelo = Valid.GenerarCodigoRandom();

   if (Valid.VerificarExistenciaEnTabla2(0, txt_modelo.Text, grd_datos) == true)
   {
    MessageBox.Show("El Modelo Ya Existe");
    return;
   }

   while (Check == true)
   {
    Check = Valid.VerificarExistenciaEnTabla2(2, codmodelo, grd_datos);
    if (Check == true)
    {
     codmodelo = Valid.GenerarCodigoRandom();
    }
   }
   ///////////////////////////////////////
   Consultas Consulta = new Consultas();
   string codmarca = Consulta.ObtenerCodMarca(cmbx_marca.SelectedItem.ToString());
   string codtipo = Consulta.ObtenerCodTipo(cmbx_tipo.SelectedItem.ToString());
   Tablas TBModelos = new Tablas();
   registros_agregados = TBModelos.CargarTablaEnDBModelos("execute insrt_modelo", "insrt_modelo", txt_modelo.Text, codmarca,codmodelo,codtipo,1);
   MessageBox.Show("Registros Agregados: " + registros_agregados.ToString());
   txt_modelo.Clear();
   CargarDatos();
  }

  private void Modelos_Load(object sender, EventArgs e)
  {
   CargarDatos();
   Tablas DATA = new Tablas();
   DATA.CargarCombobox("select * from marcas where Estado=1", 0, ref cmbx_marca);
   DATA.CargarCombobox("select * from tipos_de_equipo where Estado=1", 0, ref cmbx_tipo);
  }

  private void btn_quitar_Click(object sender, EventArgs e)
  {
   int registros_eliminados = 0;
   Tablas TBTipos = new Tablas();
   registros_eliminados = TBTipos.BorrarEnDBModelos("execute dlte_modelo", "dlte_modelo", grd_datos.CurrentRow.Cells["Codigo De Modelo"].Value.ToString(), 2);
   MessageBox.Show("Registros Eliminados: " + registros_eliminados.ToString());
   CargarDatos();
  }
 }
}
