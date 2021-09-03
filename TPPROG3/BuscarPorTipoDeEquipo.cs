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
 public partial class BuscarPorTipoDeEquipo : Form
 {
  public BuscarPorTipoDeEquipo()
  {
   InitializeComponent();
  }

  private void btn_buscar_Click(object sender, EventArgs e)
  {
   if (cmbx_tipo.SelectedIndex < 0)
   {
    MessageBox.Show("Seleccione Un Tipo De Equipo");
    return;
   }
   Consultas BusquedaEquipo = new Consultas();
   string comando = BusquedaEquipo.CrearConsultaEquipo(5, 9, cmbx_tipo.SelectedItem.ToString());
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(comando, "EquiposBuscados");
  }

  private void BuscarPorTipoDeEquipo_Load(object sender, EventArgs e)
  {
   Tablas DATA = new Tablas();
   DATA.CargarCombobox("select * from tipos_de_equipo", 0, ref cmbx_tipo);
  }
 }
}
