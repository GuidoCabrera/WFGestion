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
 public partial class BuscarPorModelo : Form
 {
  public BuscarPorModelo()
  {
   InitializeComponent();
  }
  void CargarComboboxModelo()
  {
   Tablas DATA = new Tablas();
   DATA.CargarCombobox("select * from modelos where Estado=1", 0, ref cmbx_modelo);
  }
  private void btn_buscar_Click(object sender, EventArgs e)
  {
   if (cmbx_modelo.SelectedIndex < 0)
   {
    MessageBox.Show("Seleccione Un Modelo");
    return;
   }
   Consultas BusquedaEquipo = new Consultas();
   string comando = BusquedaEquipo.CrearConsultaEquipo(4, 9, cmbx_modelo.SelectedItem.ToString());
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(comando, "EquiposBuscados");
  }

  private void BuscarPorModelo_Load(object sender, EventArgs e)
  {
   CargarComboboxModelo();
  }
 }
}
