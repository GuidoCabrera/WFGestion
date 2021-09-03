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
 public partial class Marcas : Form
 {
  public Marcas()
  {
   InitializeComponent();
  }

  void CargarDatos(){
   string comando = "Select Marca_Nombre as 'Marca',Cod_Marca as 'Codigo De Marca' from Marcas where Estado=1";
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(comando, "Marcas");
  }

 
  private void btn_agregar_Click(object sender, EventArgs e)
  {
   int registros_agregados = 0;
   //////////Validaciones//////////
   Validaciones Valid = new Validaciones();
   bool Check = true;
   if (txt_marca.Text==""){
    MessageBox.Show("Este Campo No Puede Ser Nulo");
    return;
    }
   if(Valid.VerificarLongitudString(txt_marca.Text,50)==true){
    MessageBox.Show("Longitud Maxima De Texto Excedida");
    return;
   }
   string codmarca = Valid.GenerarCodigoRandom();

  if(Valid.VerificarExistenciaEnTabla2(0,txt_marca.Text,grd_datos)==true){
    MessageBox.Show("La Marca Ya Existe");
    return;
  }

   while (Check==true){
    Check = Valid.VerificarExistenciaEnTabla2(1, codmarca, grd_datos);
    if(Check==true){
     codmarca = Valid.GenerarCodigoRandom();
    }
   }
   ///////////////////////////////////////
   Tablas TBMarcas = new Tablas();
   registros_agregados=TBMarcas.CargarTablaEnDBMarcas("execute insrt_marca", "insrt_marca",txt_marca.Text,codmarca,1);
   MessageBox.Show("Registros Agregados: " + registros_agregados.ToString());
   txt_marca.Clear();
   CargarDatos();
  }
  
  private void Marcas_Load(object sender, EventArgs e)
  {
   CargarDatos();
  }

  private void btn_quitar_Click(object sender, EventArgs e)
  {
   int registros_eliminados = 0;
   Tablas TBMarcas = new Tablas();
   registros_eliminados = TBMarcas.BorrarEnDBMarcas("execute dlte_marca", "dlte_marca", grd_datos.CurrentRow.Cells["Codigo De Marca"].Value.ToString(), 2);
   MessageBox.Show("Registros Eliminados: " + registros_eliminados.ToString());
   CargarDatos();
  }
 }
}

