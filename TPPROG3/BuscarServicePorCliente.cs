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
 public partial class BuscarServicePorCliente : Form
 {
  public BuscarServicePorCliente()
  {
   InitializeComponent();
  }

  void CargarComboboxDNI()
  {
   Tablas DATA = new Tablas();
   DATA.CargarCombobox("select DNI from Clientes where Estado=1", 0, ref cmbx_dni);
  }
  private void btn_buscar_Click(object sender, EventArgs e)
  {
  if(cmbx_dni.SelectedIndex<0){
    MessageBox.Show("Seleccione Un Cliente Por Favor");
    return;
  }
   string comando = "select Service.Nservice as 'Numero De Service',Tipos_De_Service.Tipo_Nombre as 'Tipo De Service',Service.FechaIngreso as 'Fecha De Ingreso',Service.Descripcion,Service.Nserie as 'Numero De Serie',Service.Nequipo as 'Numero De Equipo' from Service inner join Tipos_De_Service on Service.Cod_Tipo=Tipos_De_Service.Cod_TipoS inner join Equipos on Equipos.Nequipo=Service.Nequipo where Equipos.DNIdueño= " +"'"+ cmbx_dni.SelectedItem.ToString()+"'"+ " and Service.Estado=1";
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(comando, "BusquedaService");
  }

  private void BuscarServicePorCliente_Load(object sender, EventArgs e)
  {
   CargarComboboxDNI();
  }
 }
}
