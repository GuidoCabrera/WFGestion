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
 public partial class TiposDeEquipo : Form
 {
  public TiposDeEquipo()
  {
   InitializeComponent();
  }
  void CargarDatos()
  {
   string comando = "Select Tipo_Nombre as 'Tipo',Cod_TipoE as 'Codigo De Tipo De Equipo' from Tipos_De_Equipo where Estado=1";
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(comando, "TiposEquipo");
  }
  private void btn_agregar_Click(object sender, EventArgs e)
  {
   int registros_agregados = 0;
   //////////Validaciones//////////
   Validaciones Valid = new Validaciones();
   bool Check = true;
   if (txt_tipo.Text == "")
   {
    MessageBox.Show("Este Campo No Puede Ser Nulo");
    return;
   }
   if (Valid.VerificarLongitudString(txt_tipo.Text, 50) == true)
   {
    MessageBox.Show("Longitud Maxima De Texto Excedida");
    return;
   }
   string codtipo = Valid.GenerarCodigoRandom();

   if (Valid.VerificarExistenciaEnTabla2(0, txt_tipo.Text, grd_datos) == true)
   {
    MessageBox.Show("El Tipo De Equipo Ya Existe");
    return;
   }

   while (Check == true)
   {
    Check = Valid.VerificarExistenciaEnTabla2(1, codtipo, grd_datos);
    if (Check == true)
    {
     codtipo = Valid.GenerarCodigoRandom();
    }
   }
   ///////////////////////////////////////
   Tablas TBTipos = new Tablas();
   registros_agregados = TBTipos.CargarTablaEnDBTipos("execute insrt_tipo_equipo", "insrt_tipo_equipo", txt_tipo.Text, codtipo,1);
   MessageBox.Show("Registros Agregados: " + registros_agregados.ToString());
   txt_tipo.Clear();
   CargarDatos();
  }

  private void TiposDeEquipo_Load(object sender, EventArgs e)
  {
   CargarDatos();
  }

  private void btn_quitar_Click(object sender, EventArgs e)
  {
   int registros_eliminados = 0;
   Tablas TBTipos = new Tablas();
   registros_eliminados = TBTipos.BorrarEnDBTipos("execute dlte_tipo_equipo", "dlte_tipo_equipo", grd_datos.CurrentRow.Cells["Codigo De Tipo De Equipo"].Value.ToString(), 2);
   MessageBox.Show("Registros Eliminados: " + registros_eliminados.ToString());
   CargarDatos();
  }
 }
}
