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
 public partial class CalcularPorcentajeEquiposPorTipo : Form
 {
  public CalcularPorcentajeEquiposPorTipo()
  {
   InitializeComponent();
  }
  void CargarDatosTipos(string comando)
  {
   Consultas BusquedaEquipo = new Consultas();
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(comando, "Busqueda");
  }


  private void CalcularCantidadEquipoPorTipo_Load(object sender, EventArgs e)
  {
   CargarDatosTipos("select Tipo_Nombre as 'Tipo De Equipo' from Tipos_De_Equipo");
   txt_porcentaje.Text = "0";
  }

  private void grd_datos_CellClick(object sender, DataGridViewCellEventArgs e)
  {
   Tablas DATA = new Tablas();
   float porcentaje = (float.Parse(DATA.BuscarCampo("select COUNT(Equipos.Nequipo) from Equipos inner join Tipos_De_Equipo on Equipos.Tipo = Tipos_De_Equipo.Cod_TipoE where Tipos_De_Equipo.Tipo_Nombre = '" + grd_datos.CurrentRow.Cells["Tipo De Equipo"].Value.ToString() + "'")) / float.Parse(DATA.BuscarCampo("select COUNT(Equipos.Nequipo) from Equipos "))) * 100;
   txt_porcentaje.Text=porcentaje.ToString();
  }
 }
}
