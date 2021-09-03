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
 class Tablas
 {
 ////General///////////////////////////////////////////
 public string BuscarCampo (string consulta){////////busca un campo espcifico de una tabla, pasandole la consulta por parametro,el comando no debe tener mas de un campo a buscar////////
   string Cadena = "";
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand cmd = new SqlCommand(consulta, cnDB);
   cnDB.Open();
   SqlDataReader Reader = cmd.ExecuteReader();
   while (Reader.Read() == true)
   {
    Cadena = Reader[0].ToString();
   }
   cnDB.Close();
            //if (Cadena=="")
            //{
            //    MessageBox.Show("Es Igual a NULL");
            //}
            //MessageBox.Show(Cadena.ToString());
   return Cadena;
  }
   public bool VerificarCantidad(string consulta)
        {
            string aux="";
            SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(consulta, cnDB);
            cnDB.Open();
            SqlDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read() == true)
            {
                aux = Reader[0].ToString();
            }
            cnDB.Close();
            if (aux == "")
            {
                return false;
            }
            else
            {
                int cant = Int32.Parse(aux);
                if (cant >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
  public void CargarCombobox(string consulta, int NColumna,ref ComboBox lista)//////permite cargar un combobox al pasarle su direccion por referencia/////
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand comando = new SqlCommand(consulta, cnDB);
   cnDB.Open();
   SqlDataReader Reader = comando.ExecuteReader();
   while (Reader.Read() == true)
   {
    lista.Items.Add(Reader[NColumna].ToString());
   }
   cnDB.Close();
  }
  public void Cargarlistbox(string consulta, int NColumna,ref ListBox lista)/////permite cargar un Listbox al pasarle su direccion por referencia/////
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand comando = new SqlCommand(consulta, cnDB);
   cnDB.Open();
   SqlDataReader Reader = comando.ExecuteReader();
   while (Reader.Read() == true)
   {
    lista.Items.Add(Reader[NColumna].ToString());
   }
   cnDB.Close();
  }

  public DataTable TraerTabla(string comando, string Nombre)///permite cargar un datatable al pasar por parametro el SQl Command y el nombre de la tabla///
  {
   DataSet Items = new DataSet();
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlDataAdapter ADAPT1 = new SqlDataAdapter(comando, cnDB);
   ADAPT1.Fill(Items, Nombre);
   DataTable Tabla = Items.Tables[Nombre];
   cnDB.Close();
   return Tabla;
  }

  /////////////////////////////////////////////////////////////////////////////////////////////
  //////////Marcas/////////////////////////////////////////////
 public int CargarTablaEnDBMarcas (string ComandoSql, string NombreSP,string marca,string codmarca,int estado)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@Marca", SqlDbType.VarChar,50);
   SqlParametros.Value = marca;
   SqlParametros = Comando.Parameters.Add("@CodMarca", SqlDbType.NChar, 10);
   SqlParametros.Value = codmarca;
   SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
   SqlParametros.Value = estado;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }
  public int BorrarEnDBMarcas(string ComandoSql, string NombreSP, string codmarca,int estado)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
   SqlParametros.Value = estado;
   SqlParametros = Comando.Parameters.Add("@Cod_Marca", SqlDbType.NChar, 10);
   SqlParametros.Value = codmarca;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }
  /////////////////////////////////////////////////////////
  //////////Tipos de equipo/service/////////////////////////////////////////////
  public int CargarTablaEnDBTipos(string ComandoSql, string NombreSP, string tipo, string codtipo,int estado)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@Tipo", SqlDbType.VarChar, 50);
   SqlParametros.Value = tipo;
   SqlParametros = Comando.Parameters.Add("@CodTipo", SqlDbType.NChar, 10);
   SqlParametros.Value = codtipo;
   SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
   SqlParametros.Value = estado;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }
  public int BorrarEnDBTipos(string ComandoSql, string NombreSP, string codtipo, int estado)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
   SqlParametros.Value = estado;
   SqlParametros = Comando.Parameters.Add("@CodTipo", SqlDbType.NChar, 10);
   SqlParametros.Value = codtipo;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }
  /////////////////////////////////////////////////////////////
  //////////Modelos/////////////////////////////////////////////
  public int CargarTablaEnDBModelos(string ComandoSql, string NombreSP, string modelo, string codmarca,string codmodelo,string codtipo,int estado)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@Modelo", SqlDbType.VarChar, 50);
   SqlParametros.Value = modelo;
   SqlParametros = Comando.Parameters.Add("@CodMarca", SqlDbType.NChar, 10);
   SqlParametros.Value = codmarca;
   SqlParametros = Comando.Parameters.Add("@CodModelo", SqlDbType.NChar, 10);
   SqlParametros.Value = codmodelo;
   SqlParametros = Comando.Parameters.Add("@CodTipo", SqlDbType.NChar, 10);
   SqlParametros.Value = codtipo;
   SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
   SqlParametros.Value = estado;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }
  public int BorrarEnDBModelos(string ComandoSql, string NombreSP, string codmodelo,int estado)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@CodModelo", SqlDbType.NChar, 10);
   SqlParametros.Value = codmodelo;
   SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
   SqlParametros.Value = estado;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }
  /////////////////////////////////////////////////////////
  //////////Equipos/////////////////////////////////////////////
  public int CargarTablaEnDBEquipos(string ComandoSql, string NombreSP, string numserie,int numequipo, string codmarca, string codmodelo, string codtipo,string dni)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@Numserie", SqlDbType.VarChar, 50);
   SqlParametros.Value = numserie;
   SqlParametros = Comando.Parameters.Add("@Numequipo", SqlDbType.Int);
   SqlParametros.Value = numequipo;
   SqlParametros = Comando.Parameters.Add("@CodMarca", SqlDbType.NChar, 10);
   SqlParametros.Value = codmarca;
   SqlParametros = Comando.Parameters.Add("@CodModelo", SqlDbType.NChar, 10);
   SqlParametros.Value = codmodelo;
   SqlParametros = Comando.Parameters.Add("@CodTipo", SqlDbType.NChar, 10);
   SqlParametros.Value = codtipo;
   SqlParametros = Comando.Parameters.Add("@DNI", SqlDbType.VarChar, 20);
   SqlParametros.Value = dni;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }
  public int ModificarTablaEnDBEquipos(string ComandoSql, string NombreSP, int numequipo, string codmarca, string codmodelo, string codtipo, string dni)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@Numequipo", SqlDbType.Int);
   SqlParametros.Value = numequipo;
   SqlParametros = Comando.Parameters.Add("@CodMarca", SqlDbType.NChar, 10);
   SqlParametros.Value = codmarca;
   SqlParametros = Comando.Parameters.Add("@CodModelo", SqlDbType.NChar, 10);
   SqlParametros.Value = codmodelo;
   SqlParametros = Comando.Parameters.Add("@CodTipo", SqlDbType.NChar, 10);
   SqlParametros.Value = codtipo;
   SqlParametros = Comando.Parameters.Add("@DNI", SqlDbType.VarChar, 20);
   SqlParametros.Value = dni;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }
  /////////////////////////////////////////////////////////Repuestos///////////////////
  public int CargarTablaEnDBRepuesto(string ComandoSql, string NombreSP, string CodRep, string tipo, float costo, string marca, string descripcion, int stock,int puntopedido,int estado)/////sirve para cargar o modificar datos en la tabla repuestos
        {
            SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
            SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Codrep", SqlDbType.VarChar, 10);
            SqlParametros.Value = CodRep;
            SqlParametros = Comando.Parameters.Add("@Tipo", SqlDbType.VarChar,30);
            SqlParametros.Value = tipo;
            SqlParametros = Comando.Parameters.Add("@Costo", SqlDbType.Money);
            SqlParametros.Value = costo;
            SqlParametros = Comando.Parameters.Add("@Marca", SqlDbType.VarChar, 30);
            SqlParametros.Value = marca;
            SqlParametros = Comando.Parameters.Add("@descripcion", SqlDbType.VarChar, 50);
            SqlParametros.Value = descripcion;
            SqlParametros = Comando.Parameters.Add("@Stock", SqlDbType.Int);
            SqlParametros.Value = stock;
            SqlParametros = Comando.Parameters.Add("@PuntoPedido", SqlDbType.Int);
            SqlParametros.Value = puntopedido;
            SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
            SqlParametros.Value = estado;
            int FilasCambiadas = 0;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = NombreSP;
            cnDB.Open();
            FilasCambiadas = Comando.ExecuteNonQuery();
            cnDB.Close();
            return FilasCambiadas;
        }
        public int BorrarEnDBRepuesto(string ComandoSql, string NombreSP, string codRep,int estado)
        {
            SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
            SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@CodRep", SqlDbType.VarChar, 10);
            SqlParametros.Value = codRep;
            SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
            SqlParametros.Value = estado;
            int FilasCambiadas = 0;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = NombreSP;
            cnDB.Open();
            FilasCambiadas = Comando.ExecuteNonQuery();
            cnDB.Close();
            return FilasCambiadas;
        }
  public int ModificarStockDBRepuesto(string ComandoSql, string NombreSP, string codRep, int stock)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@CodRep", SqlDbType.VarChar, 10);
   SqlParametros.Value = codRep;
   SqlParametros = Comando.Parameters.Add("@Stock", SqlDbType.Int);
   SqlParametros.Value = stock;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }

  ///////////////////////CLIENTES//////////////////////////////////

  public int CargarTablaEnDBClientes(string ComandoSql, string NombreSP, string Nombre, string Apellido, string Direccion, string Telefono, string CodPostal, string Provincia, string Ciudad, string DNI,int estado)////sirve para cargar o modificar datos en la tabla clientes
        {
            SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
            SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
            SqlParametros.Value = Nombre;
            SqlParametros = Comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50);
            SqlParametros.Value = Apellido;
            SqlParametros = Comando.Parameters.Add("@Direccion", SqlDbType.VarChar, 50);
            SqlParametros.Value = Direccion;
            SqlParametros = Comando.Parameters.Add("@Telefono", SqlDbType.VarChar, 30);
            SqlParametros.Value = Telefono;
            SqlParametros = Comando.Parameters.Add("@CodPostal", SqlDbType.VarChar, 10);
            SqlParametros.Value = CodPostal;
            SqlParametros = Comando.Parameters.Add("@Provincia", SqlDbType.VarChar, 30);
            SqlParametros.Value = Provincia;
            SqlParametros = Comando.Parameters.Add("@Ciudad", SqlDbType.VarChar, 50);
            SqlParametros.Value = Ciudad;
            SqlParametros = Comando.Parameters.Add("@DNI", SqlDbType.VarChar, 20);
            SqlParametros.Value = DNI;
            SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
            SqlParametros.Value = estado;
            int FilasCambiadas = 0;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = NombreSP;
            cnDB.Open();
            FilasCambiadas = Comando.ExecuteNonQuery();
            cnDB.Close();
            return FilasCambiadas;
        }

        public int BorrarEnDBCliente(string ComandoSql, string NombreSP, string DNI,int estado)
        {
            SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
            SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@DNI", SqlDbType.VarChar, 20);
            SqlParametros.Value = DNI;
            SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
            SqlParametros.Value = estado;
            int FilasCambiadas = 0;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = NombreSP;
            cnDB.Open();
            FilasCambiadas = Comando.ExecuteNonQuery();
            cnDB.Close();
            return FilasCambiadas;
        }

  //////////////////////////////////usuarios/////////////////////////////
  public int InsertarEnDbUsuarios(string ComandoSql, string NombreSP,string codusuario, string nombre, string password,int lectura,int escritura,int admin,int estado)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@CodUsuario", SqlDbType.NChar, 10);
   SqlParametros.Value = codusuario;
   SqlParametros = Comando.Parameters.Add("@Nombre", SqlDbType.VarChar,10);
   SqlParametros.Value = nombre;
   SqlParametros = Comando.Parameters.Add("@Permiso_Lectura", SqlDbType.Int);
   SqlParametros.Value = lectura;
   SqlParametros = Comando.Parameters.Add("@Permiso_Escritura", SqlDbType.Int);
   SqlParametros.Value = escritura;
   SqlParametros = Comando.Parameters.Add("@Status_Admin", SqlDbType.Int);
   SqlParametros.Value = admin;
   SqlParametros = Comando.Parameters.Add("@Password", SqlDbType.VarChar,10);
   SqlParametros.Value = password;
   SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
   SqlParametros.Value = estado;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }


  public int BorrarEnDBUsuarios(string ComandoSql, string NombreSP, string codusuario, int estado)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@CodUsuario", SqlDbType.NChar, 10);
   SqlParametros.Value = codusuario;
   SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
   SqlParametros.Value = estado;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }

  public int ModificarEnDbUsuarios(string ComandoSql, string NombreSP, string codusuario, int lectura, int escritura, int admin)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@CodUsuario", SqlDbType.NChar, 10);
   SqlParametros.Value = codusuario;
   SqlParametros = Comando.Parameters.Add("@Permiso_Lectura", SqlDbType.Int);
   SqlParametros.Value = lectura;
   SqlParametros = Comando.Parameters.Add("@Permiso_Escritura", SqlDbType.Int);
   SqlParametros.Value = escritura;
   SqlParametros = Comando.Parameters.Add("@Status_Admin", SqlDbType.Int);
   SqlParametros.Value = admin;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }

        public int InsertarEnDbService(string ComandoSql,string NombreSP, int Nserv, string Tiposerv, string Nserie, int Nequipo, DateTime fec,string Descrip,int estado)
        {
            SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
            SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Nservice", SqlDbType.Int);
            SqlParametros.Value = Nserv;
            SqlParametros = Comando.Parameters.Add("@CodTipo", SqlDbType.NChar, 10);
            SqlParametros.Value = Tiposerv;
            SqlParametros = Comando.Parameters.Add("@Nserie", SqlDbType.VarChar,50);
            SqlParametros.Value = Nserie;
            SqlParametros = Comando.Parameters.Add("@Nequipo", SqlDbType.Int);
            SqlParametros.Value = Nequipo;
            SqlParametros = Comando.Parameters.Add("@Fecha", SqlDbType.Date);
            SqlParametros.Value = fec;
            SqlParametros = Comando.Parameters.Add("@Descripcion", SqlDbType.VarChar,50);
            SqlParametros.Value = Descrip;
            SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
            SqlParametros.Value = estado;

            int FilasCambiadas = 0;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = NombreSP;
            cnDB.Open();
            FilasCambiadas = Comando.ExecuteNonQuery();
            cnDB.Close();
            return FilasCambiadas;
        }

  public int InsertarEnDbDetalleService(string ComandoSql, string NombreSP, int Nserv, string codrepuesto, string Nserie, int Nequipo, DateTime fec, string tipor,int cantidad, int estado)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@Nservice", SqlDbType.Int);
   SqlParametros.Value = Nserv;
   SqlParametros = Comando.Parameters.Add("@CodRepuesto", SqlDbType.VarChar, 10);
   SqlParametros.Value = codrepuesto;
   SqlParametros = Comando.Parameters.Add("@Nserie", SqlDbType.VarChar, 50);
   SqlParametros.Value = Nserie;
   SqlParametros = Comando.Parameters.Add("@Nequipo", SqlDbType.Int);
   SqlParametros.Value = Nequipo;
   SqlParametros = Comando.Parameters.Add("@Fecha", SqlDbType.Date);
   SqlParametros.Value = fec;
   SqlParametros = Comando.Parameters.Add("@TipoR", SqlDbType.VarChar, 30);
   SqlParametros.Value = tipor;
   SqlParametros = Comando.Parameters.Add("@CantRep", SqlDbType.Int);
   SqlParametros.Value = cantidad;
   SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
   SqlParametros.Value = estado;

   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }
  ///////////////////////////////////////////////////////////////////////
 }
}
