using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TPPROG3
{
 class Consultas
 {
 ////////Consultas Equipos////////////

 public string CrearConsultaEquipo(int OpcionBusqueda,int OpcionFiltro,string Busqueda){ ////genera la consulta para la busqueda de equipos////////
   string consulta = "select Equipos.Nserie as 'Numero De Serie',Equipos.Nequipo as 'Numero De Equipo',Marcas.Marca_Nombre as 'Marca',Modelos.Modelo_Nombre as 'Modelo',Tipos_De_Equipo.Tipo_Nombre as 'Tipo De Equipo',Equipos.DNIdueño as 'DNI Del Dueño' from Equipos";
   consulta += " inner join Marcas on Marcas.Cod_Marca=Equipos.Marca inner join Modelos on Modelos.Cod_Modelo=Equipos.modelo inner join Tipos_De_Equipo on Tipos_De_Equipo.Cod_TipoE=Equipos.Tipo";

   switch (OpcionBusqueda){

    case 1:
     consulta += " where Equipos.Nequipo =" + Busqueda;
     break;
    case 2:
     switch (OpcionFiltro){////////para la busqueda de equipo por numero de serie
      case 6:
       consulta += " where Equipos.Nserie like " + "'%"+Busqueda+"'";
       break;
      case 5:
       consulta += " where Equipos.Nserie like " +"'"+ Busqueda+"%"+"'" ;
       break;
      case 7:
       consulta += " where Equipos.Nserie like "+"'%" + Busqueda+"%'";
       break;
     }
     break;
    case 3:
     consulta += "  where Marcas.Marca_Nombre =" + "'" + Busqueda + "'" + " and Marcas.Estado=1";
     break;
    case 4:
     consulta += "  where Modelos.Modelo_Nombre =" + "'" + Busqueda + "'" + " and Modelos.Estado=1";
     break;
    case 5:
     consulta += "  where Tipos_De_Equipo.Tipo_Nombre =" + "'" + Busqueda + "'" + " and Tipos_De_Equipo.Estado=1";
     break;
 
   }

   switch (OpcionFiltro){/////////para la tabla de listado de equipos////////

    case 1:
     consulta += " order by Equipos.Nserie";
     break;
    case 2:
     consulta += " order by Equipos.Nequipo";
     break;
    case 3:
     consulta += " order by Equipos.DNIdueño";
     break;
   }

   return consulta;
 }

 public string ObtenerCodMarca (string Marca){////////obtiene el codigo de marca a partir su nombre///////
   Tablas Tabla = new Tablas();
   string comando = "select Cod_Marca from Marcas where Marca_Nombre="+ "'" +Marca+ "'" + " and Marcas.Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return cadena;
  }

  public string ObtenerCodTipo(string Tipo)//////////obtiene el codigo de tipo de equipo a partir de su nombre////////
  {
   Tablas Tabla = new Tablas();
   string comando = "select Cod_TipoE from Tipos_De_Equipo where Tipo_Nombre=" + "'" +Tipo+ "'" + " and Tipos_De_Equipo.Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return cadena;
  }

  public string ObtenerCodModelo(string Modelo)
  {////////obtiene el codigo de marca a partir su nombre///////
   Tablas Tabla = new Tablas();
   string comando = "select Cod_Modelo from Modelos where Modelo_Nombre=" + "'" + Modelo + "'" + " and Modelos.Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return cadena;
  }

  public int ObtenerNumeroSerieEquipo(string Numero)
  {////////obtiene el numero de serie de un equipo a partir de su numero de equipo///////
   Tablas Tabla = new Tablas();
   string comando = "select Nserie from Equipos where Nequipo=" + "'" + Numero + "'" ;
   string cadena = Tabla.BuscarCampo(comando);
   return Int32.Parse(cadena);
  }
  ///////////Filtra clientes/////////
  public string CrearConsultaCliente(string filtro)
        {
            string consulta = "select Nombre,Apellido,Direccion,Telefono,Codpostal as 'Codigo Postal', Provincia, Ciudad,DNI from Clientes where Estado = 1";

            switch (filtro)
            {
                case "0":
                    consulta += " order by Clientes.Nombre";
                    break;
                case "1":
                    consulta += " order by Clientes.Apellido";
                    break;
                case "2":
                    consulta += " order by Clientes.Direccion";
                    break;
                case "3":
                    consulta += " order by Clientes.Telefono";
                    break;
                case "4":
                    consulta += " order by Clientes.CodPostal";
                    break;
                case "5":
                    consulta += " order by Clientes.Provincia";
                    break;
                case "6":
                    consulta += " order by Clientes.Ciudad";
                    break;
                case "7":
                    consulta += " order by Clientes.DNI";
                    break;
            }

            return consulta;
        }

///////Usuarios/////////////////////
  public string ObtenerPasswordUsuario(string Nombre)
  {////////obtiene el password de usuario a partir de su nombre///////
   Tablas Tabla = new Tablas();
   string comando = "select Password from Usuarios where Nombre=" + "'" + Nombre + "'" + " and Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return cadena;
  }
  public int ObtenerPermisoLectura(string Nombre)
  {////////obtiene el permiso de lectura un usuario a partir de su nombre///////
   Tablas Tabla = new Tablas();
   string comando = "select Permiso_Lectura from Usuarios where Nombre=" + "'" + Nombre + "'" + " and Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return Int32.Parse(cadena);
  }
  public int ObtenerPermisoEscritura(string Nombre)
  {////////obtiene el permiso de escritura un usuario a partir de su nombre///////
   Tablas Tabla = new Tablas();
   string comando = "select Permiso_Escritura from Usuarios where Nombre=" + "'" + Nombre + "'" + " and Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return Int32.Parse(cadena);
  }
  public int ObtenerPermisoAdmin(string Nombre)
  {/////////obtiene el permiso de admin un usuario a partir de su nombre///////
   Tablas Tabla = new Tablas();
   string comando = "select Status_Admin from Usuarios where Nombre=" + "'" + Nombre + "'" + " and Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return Int32.Parse(cadena);
  }
  /////////////////////////////////////
  ////////Service//////////////////
  public string CrearConsultaService(int opcion){/////para el listado de service//////
 string comando = "select Service.Nservice as 'Numero De Service',Tipos_De_Service.Tipo_Nombre as 'Tipo De Service',Service.FechaIngreso as 'Fecha De Ingreso',Service.Descripcion,Service.Nserie as 'Numero De Serie',Service.Nequipo as 'Numero De Equipo' from Service inner join Tipos_De_Service on Service.Cod_Tipo=Tipos_De_Service.Cod_TipoS where Service.Estado=1 ";
 switch (opcion){
    case 1:
     comando += "order by Service.Nequipo ";
     break;
    case 2:
     comando += "order by Service.Nservice";
     break;
    case 3:
     comando += "order by Service.FechaIngreso";
     break;
 }

  return comando;
 }

  public string ObtenerNumSerieService(string Numero)
  {////////obtiene el numero de serie de un equipo a partir su numero de service///////
   Tablas Tabla = new Tablas();
   string comando = "select Nserie from Service where Nservice=" + Numero +  " and Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return cadena;
  }
  public int ObtenerNumEquipoService(string Numero)
  {////////obtiene el numero de equipo a partir del numero de service///////
   Tablas Tabla = new Tablas();
   string comando = "select Nequipo from Service where Nservice=" + Numero + " and Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return Int32.Parse(cadena);
  }
  public string ObtenerCodRepuestoService(string Descripcion)
  {////////obtiene el codigo de repuesto a partir de su descripcion///////
   Tablas Tabla = new Tablas();
   string comando = "select CodRepuesto from Repuestos where Descripcion=" + "'" + Descripcion + "'" + " and Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return cadena;
  }
  public int ObtenerStockRepuestoService(string Codrepuesto)
  {////////obtiene el stock de un repuesto a partir de su codigo///////
   Tablas Tabla = new Tablas();
   string comando = "select Stock from repuestos where CodRepuesto=" + "'" + Codrepuesto + "'" + " and Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return Int32.Parse(cadena);
  }
  public int ObtenerStockMinRepuestoService(string Codrepuesto)
  {////////obtiene el stock minimo de un repuesto a partir de su codigo///////
   Tablas Tabla = new Tablas();
   string comando = "select PuntoPedido from repuestos where CodRepuesto=" + "'" + Codrepuesto + "'" + " and Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return Int32.Parse(cadena);
  }
  public string ObtenerTipoRepuestoService(string Codrepuesto)
  {////////obtiene el Tipo de repuesto a partir su codigo///////
   Tablas Tabla = new Tablas();
   string comando = "select Tipo from Repuestos where CodRepuesto=" + "'" + Codrepuesto + "'" + " and Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return cadena;
  }
  ////////////////////////////
  public string GenerarConsultaDetalleService(int opcion){////////para listado de detalle de service//////
   string comando = "Select Detalle_Service.Nservice as 'Numero De Service',Detalle_Service.CodRepuesto as 'Codigo De Repuesto',Detalle_Service.TipoRepuesto as 'Tipo De Repuesto',Detalle_Service.Cantidad_Repuesto as 'Cantidad Del Repuesto',Detalle_Service.Nserie as 'Numero De Serie Del Equipo',Detalle_Service.Nequipo as 'Numero De Equipo',Detalle_Service.Fsalida as'Fecha Del Detalle',Equipos.DNIdueño from Detalle_Service inner join Equipos on Equipos.Nserie=Detalle_Service.Nserie where Detalle_Service.Estado=1 ";
   switch(opcion){
    case 1:
     comando += "order by Equipos.DNIdueño";
     break;
    case 2:
     comando += "order by Detalle_Service.Nservice";
     break;
   }
   return comando;
  }
  /////////////////////////////

 }
}
