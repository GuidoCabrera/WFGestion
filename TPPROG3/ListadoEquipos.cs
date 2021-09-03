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
 public partial class ListadoEquipos : Form
 {
  public int Filtro = 1;
  public ListadoEquipos()
  {
   InitializeComponent();
  }
  void CargarDatos(){
   Consultas BusquedaEquipo = new Consultas();
   string comando = BusquedaEquipo.CrearConsultaEquipo(0, Filtro, "");
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(comando, "EquiposBuscados");
  }
  void ContarEquipos(){
   txt_cantidad_equipos.Text = (grd_datos.RowCount-1).ToString();
  }
  private void rbtn_nserie_CheckedChanged(object sender, EventArgs e)
  {
   Filtro = 1;
   CargarDatos();
  }

  private void rbtn_nequipo_CheckedChanged(object sender, EventArgs e)
  {
   Filtro = 2;
   CargarDatos();
  }

  private void rbtn_dni_CheckedChanged(object sender, EventArgs e)
  {
   Filtro = 3;
   CargarDatos();
  }

  private void ListadoEquipos_Load(object sender, EventArgs e)
  {
   CargarDatos();
   ContarEquipos();
  }
 }
}
