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
 public partial class BuscarPorNumSerie : Form
 {
  public BuscarPorNumSerie()
  {
   InitializeComponent();
  }

  private void btn_buscar_Click(object sender, EventArgs e)
  {
   if (txt_num_serie.Text == "")
   {
    MessageBox.Show("Ingrese un valor por favor");
    return;
   }
   int filtro = cmbx_seleccion.SelectedIndex + 5;
   if(filtro<5){
   MessageBox.Show("Seleccione Un Filtro Por Favor");
   return;
   }
   Consultas BusquedaEquipo = new Consultas();
   string comando = BusquedaEquipo.CrearConsultaEquipo(2, filtro, txt_num_serie.Text);
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(comando, "EquiposBuscados");
  }
 }
}
