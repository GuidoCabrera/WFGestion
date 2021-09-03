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
 public partial class InicioSesion : Form
 {
  
  public InicioSesion()
  {
   InitializeComponent();
   
  }

  private void btn_ingresar_Click(object sender, EventArgs e)
  {
   Consultas consulta = new Consultas();
   if (consulta.ObtenerPasswordUsuario(cmbx_usuario.SelectedItem.ToString())!=txt_password.Text){
    MessageBox.Show("Password Incorrecto");
    return;
   }
   menu_principal.escritura = consulta.ObtenerPermisoEscritura(cmbx_usuario.SelectedItem.ToString());
   menu_principal.lectura = consulta.ObtenerPermisoLectura(cmbx_usuario.SelectedItem.ToString());
   menu_principal.admin = consulta.ObtenerPermisoAdmin(cmbx_usuario.SelectedItem.ToString());
   menu_principal.usuario = cmbx_usuario.SelectedItem.ToString();
   MessageBox.Show("Sesion Iniciada Correctamente");
   Close();
  }

  private void InicioSesion_Load(object sender, EventArgs e)
  {
  if(menu_principal.usuario!=""){
    MessageBox.Show("Hay Un Usuario Con La Sesion Iniciada");
    Close();
  }
   Tablas data = new Tablas();
   data.CargarCombobox("select Nombre From Usuarios where Estado=1",0,ref cmbx_usuario);
  }
 }
}
