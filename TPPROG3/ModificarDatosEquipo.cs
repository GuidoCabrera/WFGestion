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
 public partial class ModificarDatosEquipo : Form
 {
  public ModificarDatosEquipo()
  {
   InitializeComponent();
  }
  void CargarDatos()
  {
   Consultas BusquedaEquipo = new Consultas();
   string comando = BusquedaEquipo.CrearConsultaEquipo(0, 1, "");
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(comando, "EquiposBuscados");
  }
  void CargarComboboxMarca()
  {
   Tablas DATA = new Tablas();
   DATA.CargarCombobox("select * from marcas where Estado=1", 0, ref cmbx_marca);
  }
  void CargarComboboxModelo(string marca)
  {
   Tablas DATA = new Tablas();
   DATA.CargarCombobox("select * from modelos inner join marcas on Marcas.Cod_Marca=Modelos.Cod_Marca where Marcas.Marca_Nombre=" + "'" + marca + "' and Modelos.Estado=1", 0, ref cmbx_modelo);
  }
 
  void CargarComboboxDNI()
  {
   Tablas DATA = new Tablas();
   DATA.CargarCombobox("select DNI from Clientes where Estado=1", 0, ref cmbx_DNI);
  }
  void CargarDatosEquipo()
  {
   txt_numero_equipo.Text = grd_datos.CurrentRow.Cells["Numero De Equipo"].Value.ToString();
   txt_numero_serie.Text = grd_datos.CurrentRow.Cells["Numero De Serie"].Value.ToString();
   cmbx_marca.Text= grd_datos.CurrentRow.Cells["Marca"].Value.ToString();
   cmbx_modelo.Text= grd_datos.CurrentRow.Cells["Modelo"].Value.ToString();
   txt_tipo.Text= grd_datos.CurrentRow.Cells["Tipo De Equipo"].Value.ToString();
   cmbx_DNI.Text= grd_datos.CurrentRow.Cells["DNI Del Dueño"].Value.ToString();
  }
  
  private void btn_asentar_cambios_Click_1(object sender, EventArgs e)
  {
   int registros_modificados = 0;
   ////////Validdaciones/////////////////
   Validaciones Valid = new Validaciones();
   if (txt_numero_serie.Text == "")
   {
    MessageBox.Show("El Numero De Serie No Puede Ser Nulo");
    return;
   }
   if (cmbx_marca.SelectedIndex < 0)
   {
    MessageBox.Show("Seleccione Una Marca");
    return;
   }
   if (cmbx_modelo.SelectedIndex < 0)
   {
    MessageBox.Show("Seleccione Un Modelo");
    return;
   }
   if (cmbx_DNI.SelectedIndex < 0)
   {
    MessageBox.Show("Seleccione Un Cliente");
    return;
   }
   Consultas Info = new Consultas();
   string codmarca = Info.ObtenerCodMarca(cmbx_marca.SelectedItem.ToString());
   string codmodelo = Info.ObtenerCodModelo(cmbx_modelo.SelectedItem.ToString());
   string codtipo = Info.ObtenerCodTipo(txt_tipo.Text);
   ////////////////////////////////////////////
   Tablas Data = new Tablas();
   registros_modificados = Data.ModificarTablaEnDBEquipos("execute mdfr_equipo", "mdfr_equipo", int.Parse(txt_numero_equipo.Text), codmarca, codmodelo, codtipo, cmbx_DNI.SelectedItem.ToString());
   MessageBox.Show("Equipo Modificado Satisfactoriamente");
   CargarDatos();
   txt_tipo.Clear();
   cmbx_modelo.Items.Clear();
   txt_numero_equipo.Clear();
   txt_numero_serie.Clear();
  }

  private void grd_datos_CellClick(object sender, DataGridViewCellEventArgs e)
  {
   CargarDatosEquipo();
  }

  private void cmbx_marca_SelectedIndexChanged(object sender, EventArgs e)
  {
   cmbx_modelo.Items.Clear();
   txt_tipo.Clear();
   if (cmbx_modelo.Items.Count == 0)
   {
    CargarComboboxModelo(cmbx_marca.SelectedItem.ToString());
   }
  }

  private void cmbx_modelo_SelectedIndexChanged(object sender, EventArgs e)
  {
   Tablas DATA = new Tablas();
   txt_tipo.Text = DATA.BuscarCampo("select Tipos_De_Equipo.Tipo_Nombre from Tipos_De_Equipo inner join modelos on modelos.Cod_TipoE=Tipos_De_Equipo.Cod_TipoE where Modelos.Modelo_Nombre=" + "'" + cmbx_modelo.SelectedItem.ToString() + "'");
  }

  private void ModificarDatosEquipo_Load_1(object sender, EventArgs e)
  {
   CargarDatos();
   CargarComboboxMarca();
   CargarComboboxDNI();
  }

 }
}
