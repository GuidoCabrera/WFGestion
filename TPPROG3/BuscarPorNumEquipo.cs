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
 public partial class BuscarPorNumEquipo : Form
 {
  public BuscarPorNumEquipo()
  {
   InitializeComponent();
  }

  private void btn_buscar_Click(object sender, EventArgs e)
  {
   if(txt_num_equipo.Text==""){
    MessageBox.Show("Ingrese un valor por favor");
    return;
   }

   Validaciones VL1 = new Validaciones();
 if(VL1.VerficarCampoNumerico(txt_num_equipo.Text)==false){
    MessageBox.Show("Se Acepta Solamente Numeros");
    return;
   }
  
   Consultas BusquedaEquipo = new Consultas();
   string comando = BusquedaEquipo.CrearConsultaEquipo(1, 0, txt_num_equipo.Text);
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(comando, "EquiposBuscados");
  }
 }
}
