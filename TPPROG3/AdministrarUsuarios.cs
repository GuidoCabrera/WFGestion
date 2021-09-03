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
 public partial class AdministrarUsuarios : Form
 {
  public AdministrarUsuarios()
  {
   InitializeComponent();
  }


  public void CargarDatos(){
   Tablas Data = new Tablas();
   grd_datos.DataSource = Data.TraerTabla("Select CodUsuario as 'Codigo De Usuario',Nombre,Permiso_Lectura as 'Permiso De Lectura',Permiso_Escritura as 'Permiso De Escritura',Status_Admin as 'Estado De Administrador' From Usuarios where Estado=1","Usuarios");
  }

  public int Lectura = 0;
  public int Escritura = 0;
  public int Admin = 0;

  public void CargarTextbox(){
   Consultas consulta = new Consultas();
   txt_nombre_usuario.Text = grd_datos.CurrentRow.Cells["Nombre"].Value.ToString();
   txt_password.Text = consulta.ObtenerPasswordUsuario(grd_datos.CurrentRow.Cells["Nombre"].Value.ToString());
  }
  private void btn_agregar_Click(object sender, EventArgs e)
  {
   Validaciones Valid = new Validaciones();
  if(txt_nombre_usuario.Text==""||txt_password.Text==""){
    MessageBox.Show("Los Campos No Pueden Quedar Vacios");
    return;
  }
  if(Valid.VerificarLongitudString(txt_nombre_usuario.Text,10)==true){
    MessageBox.Show("Nombre De Usuario Muy Largo");
    return;
  }
  if(txt_nombre_usuario.Text.Length<10){
    MessageBox.Show("El Nombre De Usuario Debe Ser De 10 Caracteres");
    return;
   }
   if (Valid.VerificarLongitudString(txt_password.Text, 10) == true)
   {
    MessageBox.Show("Password Muy Largo");
    return;
   }
   if (txt_password.Text.Length < 10)
   {
    MessageBox.Show("El Password Debe Ser De 10 Caracteres");
    return;
   }
   if (Valid.VerificarExistenciaEnTabla2(1,txt_nombre_usuario.Text,grd_datos)==true){
    MessageBox.Show("El Usuario Que Desea Agregar Ya Existe");
    return;
   }

   string codusuario = Valid.GenerarCodigoRandom();

   while (Valid.VerificarExistenciaEnTabla2(0, codusuario, grd_datos) == true)
   {
    codusuario = Valid.GenerarCodigoRandom();
   }

  

   if(chbx_lectura.Checked==true){
    Lectura = 1;
   }
   else{
    Lectura = 2;
   }

   if (chbx_escritura.Checked == true)
   {
    Escritura = 1;
   }
   else
   {
    Escritura = 2;
   }

   if (chbx_admin.Checked == true)
   {
    Admin = 1;
    Lectura = 1;
    Escritura = 1;
   }
   else
   {
    Admin = 2;
   }

   int registros_agregados = 0;
   Tablas TBUsuarios = new Tablas();
   registros_agregados = TBUsuarios.InsertarEnDbUsuarios("execute insrt_usuario", "insrt_usuario", codusuario,txt_nombre_usuario.Text,txt_password.Text,Lectura,Escritura,Admin,1);
   MessageBox.Show("Registros Agregados: " + registros_agregados.ToString());
   txt_nombre_usuario.Clear();
   txt_password.Clear();
   CargarDatos();

  }

  private void btn_quitar_Click(object sender, EventArgs e)
  {
   if(txt_nombre_usuario.Text==""){
    return;
   }
   string codusuario = grd_datos.CurrentRow.Cells["Codigo De Usuario"].Value.ToString();
   if(txt_nombre_usuario.Text== "ADMINGRAL1"){
    MessageBox.Show("El Usuario Administrador General No Puede Ser Eliminado");
    return;
   }
   int registros_agregados = 0;
   Tablas TBUsuarios = new Tablas();
   registros_agregados = TBUsuarios.BorrarEnDBUsuarios("execute dlte_usuario", "dlte_usuario", codusuario, 2);
   MessageBox.Show("Registros Eliminados: " + registros_agregados.ToString());
   CargarDatos();
  }

  private void btn_realizar_cambios_Click(object sender, EventArgs e)////////permite modificar los permisos de un usuario, si se desea cambiar el password o nombre de usuario se debera generar un usuario nuevo y quitar el viejo
  {
   if (txt_nombre_usuario.Text == "ADMINGRAL1")
   {
    MessageBox.Show("Los Parametros Del Usuario Administrador General No Pueden Ser Cambiados ");
    return;
   }
   if (chbx_lectura.Checked == true)
   {
    Lectura = 1;
   }
   else
   {
    Lectura = 2;
   }

   if (chbx_escritura.Checked == true)
   {
    Escritura = 1;
   }
   else
   {
    Escritura = 2;
   }

   if (chbx_admin.Checked == true)
   {
    Admin = 1;
    Lectura = 1;
    Escritura = 1;
   }
   else
   {
    Admin = 2;
   }
   string codusuario = grd_datos.CurrentRow.Cells["Codigo De Usuario"].Value.ToString();
   int registros_agregados = 0;
   Tablas TBUsuarios = new Tablas();
   registros_agregados = TBUsuarios.ModificarEnDbUsuarios("execute mdfr_usuario", "mdfr_usuario", codusuario,Lectura,Escritura,Admin);
   MessageBox.Show("Registros Modificados: " + registros_agregados.ToString());
   CargarDatos();
  }

  private void AdministrarUsuarios_Load(object sender, EventArgs e)
  {
   CargarDatos();  
  }


  private void chbx_lectura_Click(object sender, EventArgs e)
  {
   chbx_admin.Checked = false;
   chbx_escritura.Checked = false;
  }

  private void chbx_escritura_Click(object sender, EventArgs e)
  {
   chbx_admin.Checked = false;
   chbx_lectura.Checked = true;
  }

  private void chbx_admin_Click(object sender, EventArgs e)
  {
   chbx_escritura.Checked = false;
   chbx_lectura.Checked = false;
  }

  private void grd_datos_CellClick(object sender, DataGridViewCellEventArgs e)
  {
   CargarTextbox();
  }
 }
}
