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
 public partial class BuscarPorNumeroService : Form
 {
  public BuscarPorNumeroService()
  {
   InitializeComponent();
  }

  private void btn_buscar_Click(object sender, EventArgs e)
  {
  if(txt_num_service.Text==""){
    MessageBox.Show("Ingrese Un Numero De Serivce");
    return;
  }
   Validaciones valid = new Validaciones();
   if(valid.VerficarCampoNumerico(txt_num_service.Text)==false){
    MessageBox.Show("El Campo Numero De Service Debe Ser Numerico");
    return;
   }
   string comando = "select Service.Nservice as 'Numero De Service',Tipos_De_Service.Tipo_Nombre as 'Tipo De Service',Service.FechaIngreso as 'Fecha De Ingreso',Service.Descripcion,Service.Nserie as 'Numero De Serie',Service.Nequipo as 'Numero De Equipo' from Service inner join Tipos_De_Service on Service.Cod_Tipo=Tipos_De_Service.Cod_TipoS where Service.Nservice= "+txt_num_service.Text+" and Service.Estado=1";
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(comando, "BusquedaService");
   txt_num_service.Clear();
  }
 }
}
