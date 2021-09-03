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
 public partial class DetalleService : Form
 {
  public DetalleService()
  {
   InitializeComponent();
  }
  public DateTime Fecha = System.DateTime.Now;
  void CargarComboboxRepuesto()
  {
   Tablas DATA = new Tablas();
   DATA.CargarCombobox("select Descripcion from Repuestos where Estado=1", 0, ref cmbx_seleccion_repuesto);
  }
  void CargarComboboxNumService()
  {
   Tablas DATA = new Tablas();
   DATA.CargarCombobox("select Nservice from Service where Estado=1", 0, ref cmbx_nservice);
  }
  public void CargarTabla(){
   Consultas BusquedaEquipo = new Consultas();
   string comando = "Select Nservice as 'Numero De Service',CodRepuesto as 'Codigo De Repuesto',TipoRepuesto as 'Tipo De Repuesto',Cantidad_Repuesto as 'Cantidad Del Repuesto',Nserie as 'Numero De Serie Del Equipo',Nequipo as 'Numero De Equipo',Fsalida as'Fecha Del Detalle' from Detalle_Service where Estado=1";
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(comando, "DetallesSerivce");
  }
  private void DetalleService_Load(object sender, EventArgs e)
  {
   CargarTabla();
   txt_fecha.Text = Fecha.ToString();
   CargarComboboxRepuesto();
   CargarComboboxNumService();
  }

  private void btn_realizar_cambios_Click(object sender, EventArgs e)
  {
   Validaciones valid = new Validaciones();
  if(cmbx_seleccion_repuesto.SelectedIndex<0){
    MessageBox.Show("Seleccione Un Repuesto");
    return;
  }
  if(valid.VerficarCampoNumerico(txt_cantidad.Text)==false){
    MessageBox.Show("Solamente Valores Numericos Para La Cantidad");
    return;
  }
  if(txt_cantidad.Text==""){
    MessageBox.Show("Ingrese Una Cantidad Por Favor");
    return;
  }
   if (cmbx_nservice.SelectedIndex<0)
   {
    MessageBox.Show("Seleccione Un Numero De Service");
    return;
   }
   int reg_ag = 0;
   Tablas Ta = new Tablas();
   Consultas consulta = new Consultas();
   string codrepuesto = consulta.ObtenerCodRepuestoService(cmbx_seleccion_repuesto.SelectedItem.ToString());
   int stock = consulta.ObtenerStockRepuestoService(codrepuesto);
   int stockmin = consulta.ObtenerStockMinRepuestoService(codrepuesto);
   string tipo = consulta.ObtenerTipoRepuestoService(codrepuesto);
   int numequipo = consulta.ObtenerNumEquipoService(cmbx_nservice.SelectedItem.ToString());
   string numserie = consulta.ObtenerNumSerieService(cmbx_nservice.SelectedItem.ToString());

   if((stock- Int32.Parse(txt_cantidad.Text))<stockmin){
    MessageBox.Show("Stock Insuficiente");
    return;
   }

   reg_ag = Ta.InsertarEnDbDetalleService("execute insrt_detalle_service", "insrt_detalle_service", Int32.Parse(cmbx_nservice.SelectedItem.ToString()), codrepuesto, numserie, numequipo, Fecha, tipo,Int32.Parse(txt_cantidad.Text), 1);
   MessageBox.Show("Detalle De Service Agregado Satisfactoriamente");
   reg_ag = Ta.ModificarStockDBRepuesto("execute modstockRep", "modstockRep", codrepuesto, stock - Int32.Parse(txt_cantidad.Text));
   MessageBox.Show("El Stock Del Repuesto Fue Modificado");
   CargarTabla();
  }
 }
}
