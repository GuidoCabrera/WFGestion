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
 public partial class ListadoDetalleService : Form
 {
  public ListadoDetalleService()
  {
   InitializeComponent();
  }
  public int opcion = 1;
  public void CargarTabla()
  {
   Consultas BusquedaDetalleService = new Consultas();
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(BusquedaDetalleService.GenerarConsultaDetalleService(opcion), "DetallesSerivce");
  }
  private void rbtn_cliente_Click(object sender, EventArgs e)
  {
   opcion = 1;
   CargarTabla();
  }

  private void rbtn_nservice_Click(object sender, EventArgs e)
  {
   opcion = 2;
   CargarTabla();
  }

  private void ListadoDetalleService_Load(object sender, EventArgs e)
  {
   CargarTabla();
  }
 }
}
