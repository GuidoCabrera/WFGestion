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
 public partial class BuscarPorMarca : Form
 {
  public BuscarPorMarca()
  {
   InitializeComponent();
  }

  private void btn_buscar_Click(object sender, EventArgs e)
  {
   
   if (cmbx_marca.SelectedIndex<0)
   {
    MessageBox.Show("Seleccione Una Marca");
    return;
   }
   Tablas DATA = new Tablas();
   Consultas BusquedaEquipo = new Consultas();
   string comando = BusquedaEquipo.CrearConsultaEquipo(3, 9, cmbx_marca.SelectedItem.ToString());
   grd_datos.DataSource = DATA.TraerTabla(comando, "EquiposBuscados");
  }

  private void BuscarPorMarca_Load(object sender, EventArgs e)
  {
   Tablas DATA = new Tablas();
   DATA.CargarCombobox("select * from marcas where Estado=1", 0, ref cmbx_marca);
  }
 }
}
