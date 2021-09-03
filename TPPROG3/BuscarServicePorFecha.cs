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
 public partial class BuscarServicePorFecha : Form
 {
  public BuscarServicePorFecha()
  {
   InitializeComponent();
  }

  private void btn_buscar_Click(object sender, EventArgs e)
  {
   string comando = "select Service.Nservice as 'Numero De Service',Tipos_De_Service.Tipo_Nombre as 'Tipo De Service',Service.FechaIngreso as 'Fecha De Ingreso',Service.Descripcion,Service.Nserie as 'Numero De Serie',Service.Nequipo as 'Numero De Equipo' from Service inner join Tipos_De_Service on Service.Cod_Tipo=Tipos_De_Service.Cod_TipoS where Service.FechaIngreso= "+ "'"+dtpk_service.Value.ToShortDateString()+"'"+ " and Service.Estado=1";
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(comando, "BusquedaService");
   }
 }
}
