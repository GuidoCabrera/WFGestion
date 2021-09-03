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
 public partial class ListadoService : Form
 {
  public ListadoService()
  {
   InitializeComponent();
  }
  public int opcion = 1;
  private void ListadoService_Load(object sender, EventArgs e)
  {
   Consultas consulta = new Consultas();
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(consulta.CrearConsultaService(opcion), "BusquedaService");
  }

  private void rbtn_nequipo_Click(object sender, EventArgs e)
  {
   opcion = 1;
   Consultas consulta = new Consultas();
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(consulta.CrearConsultaService(opcion), "BusquedaService");
  }

  private void rbtn_nservice_Click(object sender, EventArgs e)
  {
   opcion = 2;
   Consultas consulta = new Consultas();
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(consulta.CrearConsultaService(opcion), "BusquedaService");
  }

  private void rbtn_fecha_Click(object sender, EventArgs e)
  {
   opcion = 3;
   Consultas consulta = new Consultas();
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(consulta.CrearConsultaService(opcion), "BusquedaService");
  }
 }
}
