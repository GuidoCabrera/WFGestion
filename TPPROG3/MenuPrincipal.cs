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
 public partial class menu_principal : Form
 {
  public menu_principal()
  {
   InitializeComponent();
  }

  private void salirToolStripMenuItem_Click(object sender, EventArgs e)
  {
   Close();
  }

  private void menu_principal_Load(object sender, EventArgs e)
  {

  }
  //////Variables de Inicio de sesion/////
  public static int lectura = 0;
  public static int escritura = 0;
  public static int admin = 0;
  public static string usuario = "";
  /////////////////////////////////////////

  public bool VerificarLogin(string nombre){
  if(nombre==""){
    MessageBox.Show("Inicie Sesion Para Continuar");
    return false;
  }
   return true;
  }


  private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
  {
   AcercaDe Acerca = new AcercaDe();
   Acerca.Show();
  }

  ///////////////////////////////////
  ///Menu Equipos///////////////////
  private void modificarDatosEquipo_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   if (escritura != 1)
   {
    MessageBox.Show("Acceso Denegado");
    return;
   }
   ModificarDatosEquipo ModificarEquipo = new ModificarDatosEquipo();
   ModificarEquipo.Show();
  }

  private void agregarEquipo_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   if (escritura != 1)
   {
    MessageBox.Show("Acceso Denegado");
    return;
   }
   AgregarEquipo AgregarEquipoNuevo = new AgregarEquipo();
   AgregarEquipoNuevo.Show();
  }

  private void porNumEquipo_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   BuscarPorNumEquipo BusquedaNumEquipo = new BuscarPorNumEquipo();
   BusquedaNumEquipo.Show();
  }

  private void porNDeSerie_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   BuscarPorNumSerie BusquedaNumSerie = new BuscarPorNumSerie();
   BusquedaNumSerie.Show();
  }

  private void verListadoEquipos_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   ListadoEquipos Equipos = new ListadoEquipos();
   Equipos.Show();
  }

  private void agregarQuitarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
  {
  if (VerificarLogin(usuario)==false){
    return;
  }
   if(escritura!=1){
    MessageBox.Show("Acceso Denegado");
    return;
   }
   Marcas Marca = new Marcas();
   Marca.Show();
  }

  private void agregarQuitarModelosToolStripMenuItem_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   if (escritura != 1)
   {
    MessageBox.Show("Acceso Denegado");
    return;
   }
   Modelos Modelo = new Modelos();
   Modelo.Show();
  }

  private void agregarQuitarTiposDeEquipoToolStripMenuItem_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   if (escritura != 1)
   {
    MessageBox.Show("Acceso Denegado");
    return;
   }
   TiposDeEquipo Tipo = new TiposDeEquipo();
   Tipo.Show();
  }
  private void porMarcaToolStripMenuItem_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   BuscarPorMarca BuscarMarca = new BuscarPorMarca();
   BuscarMarca.Show();
  }

  private void porModeloToolStripMenuItem_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   BuscarPorModelo BuscarModelo = new BuscarPorModelo();
   BuscarModelo.Show();
  }

  private void porTipoToolStripMenuItem_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   BuscarPorTipoDeEquipo BuscarTipo = new BuscarPorTipoDeEquipo();
   BuscarTipo.Show();
  }
  ///////////////////////////////////
  
  /////Usuarios//////////////
  private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
  {
   InicioSesion Sesion = new InicioSesion();
   Sesion.Show();
  }

  private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   if (admin != 1)
   {
    MessageBox.Show("Acceso Denegado");
    return;
   }
   AdministrarUsuarios Usuarios = new AdministrarUsuarios();
   Usuarios.Show();
  }

  ///////////////////////////////////

  //////////////Service//////////////////////////////////////////

  private void ingresarServiceToolStripMenuItem_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   if (escritura != 1)
   {
    MessageBox.Show("Acceso Denegado");
    return;
   }
   IngresarService service1 = new IngresarService();
   service1.Show();
  }

  private void porNDeServiceToolStripMenuItem_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   BuscarPorNumeroService BusquedaService = new BuscarPorNumeroService();
   BusquedaService.Show();
  }

  private void porClienteToolStripMenuItem_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   BuscarServicePorCliente BusquedaService2 = new BuscarServicePorCliente();
   BusquedaService2.Show();
  }

  private void porFechaToolStripMenuItem_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   BuscarServicePorFecha BusquedaService3 = new BuscarServicePorFecha();
   BusquedaService3.Show();
  }

  private void verListadoToolStripMenuItem3_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   ListadoService ListaService = new ListadoService();
   ListaService.Show();
  }

  private void agregarQuitarTipoDeServiceToolStripMenuItem_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   if (escritura != 1)
   {
    MessageBox.Show("Acceso Denegado");
    return;
   }
   TiposDeService TipoService = new TiposDeService();
   TipoService.Show();
  }

  private void generarSalidaDeServiceToolStripMenuItem_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   if (escritura != 1)
   {
    MessageBox.Show("Acceso Denegado");
    return;
   }
   GenerarSalidaService GenerarSalida = new GenerarSalidaService();
   GenerarSalida.Show();
  }

  private void generarToolStripMenuItem_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   if (escritura != 1)
   {
    MessageBox.Show("Acceso Denegado");
    return;
   }
   DetalleService DetalleService = new DetalleService();
   DetalleService.Show();
  }

  private void verListadoDeDetallesToolStripMenuItem_Click(object sender, EventArgs e)
  {
   if (VerificarLogin(usuario) == false)
   {
    return;
   }
   ListadoDetalleService ListadoService = new ListadoDetalleService();
   ListadoService.Show();
  }
      //Repuestos//
        private void buscarRepuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         if (VerificarLogin(usuario) == false)
         {
          return;
         }
         BuscarRepuesto BR = new BuscarRepuesto();
                  BR.Show();
        }

        private void agregarRepuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if (VerificarLogin(usuario) == false)
          {
           return;
          }
          if (escritura != 1)
          {
           MessageBox.Show("Acceso Denegado");
           return;
          }
          AgregarRepuesto Ar = new AgregarRepuesto();
                   Ar.Show();
        }

        private void verListadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
          if (VerificarLogin(usuario) == false)
          {
           return;
          }
          ListadoRepuesto Lr = new ListadoRepuesto();
                   Lr.Show();
        }

        private void modificarRepuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (VerificarLogin(usuario) == false)
           {
            return;
           }
           if (escritura != 1)
           {
            MessageBox.Show("Acceso Denegado");
            return;
           }
           ModificarRepuesto Mr = new ModificarRepuesto();
                    Mr.Show();
        }

        ////////////////////////////CLIENTES////////////////////////////////////
        
        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
         if (VerificarLogin(usuario) == false)
         {
          return;
         }
         if (escritura != 1)
         {
          MessageBox.Show("Acceso Denegado");
          return;
         }
         frmAgregarCli Agregar = new frmAgregarCli();
                  Agregar.Show();
        }

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if (VerificarLogin(usuario) == false)
          {
           return;
          }
          if (escritura != 1)
          {
           MessageBox.Show("Acceso Denegado");
           return;
          }
          frmModificarCli Modificar = new frmModificarCli();
                   Modificar.Show();
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
         if (VerificarLogin(usuario) == false)
         {
          return;
         }
         frmBuscarCliXNombre BuscarNombre = new frmBuscarCliXNombre();
                  BuscarNombre.Show();
        }

        private void porNDeDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
         if (VerificarLogin(usuario) == false)
         {
          return;
         }
          frmBuscarCliXDNI BuscarDNI = new frmBuscarCliXDNI();
            BuscarDNI.Show();
        }

        private void verListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if (VerificarLogin(usuario) == false)
          {
           return;
          }
          frmVerListadoCli VerListado = new frmVerListadoCli();
                   VerListado.Show();
        }
///Informes//////////////////
  private void calcularTotalDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
  {
   CalculoIngresos ingresos = new CalculoIngresos();
   ingresos.Show();
  }

  private void calcularCantidadDeEquiposPorTipoToolStripMenuItem_Click(object sender, EventArgs e)
  {
   CalcularPorcentajeEquiposPorTipo CalcularTipos = new CalcularPorcentajeEquiposPorTipo();
   CalcularTipos.Show();
  }
  ///////////////////////////////
 }
}
