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
 public partial class GenerarSalidaService : Form
 {
  public GenerarSalidaService()
  {
   InitializeComponent();
  }
  void CargarComboboxNumService()
  {
   Tablas DATA = new Tablas();
   DATA.CargarCombobox("select Nservice from Service where Estado=1", 0, ref cmbx_numservice);
  }
  public void CargarTabla()
  {
   string comando = "Select Detalle_Service.Nservice as 'Numero De Service',Detalle_Service.CodRepuesto as 'Codigo De Repuesto',Detalle_Service.TipoRepuesto as 'Tipo De Repuesto',Detalle_Service.Cantidad_Repuesto as 'Cantidad Del Repuesto',Repuestos.Costo as 'Costo Del Repuesto',Detalle_Service.Nserie as 'Numero De Serie Del Equipo',Detalle_Service.Nequipo as 'Numero De Equipo',Detalle_Service.Fsalida as'Fecha Del Detalle' from Detalle_Service inner join Repuestos on Repuestos.CodRepuesto=Detalle_Service.CodRepuesto where Detalle_Service.Nservice="+cmbx_numservice.SelectedItem.ToString()+ " and Detalle_Service.Estado=1 ";
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(comando, "DetallesSerivce");
  }
  private void GenerarSalidaService_Load(object sender, EventArgs e)
  {
   CargarComboboxNumService();
  }

  private void btn_buscar_Click(object sender, EventArgs e)
  {
   if(cmbx_numservice.SelectedIndex<0){
    MessageBox.Show("Seleccione Un Numero De Service");
    return;
   }
   CargarTabla();
   float Total = 0;
   for(int i=0;i< grd_datos.RowCount-1;i++){
    Total += float.Parse(grd_datos[3, i].Value.ToString()) * float.Parse(grd_datos[4, i].Value.ToString());
   }
   txt_total.Text = Total.ToString();
  }
 }
}
