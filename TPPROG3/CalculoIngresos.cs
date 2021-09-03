using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TPPROG3
{
 public partial class CalculoIngresos : Form
 {
  public CalculoIngresos()
  {
   InitializeComponent();
  }
  public int ObtenerCantidadService()
  {
   string consulta = "select MAX(Nservice) from Service";
   int Cantidad;
   Tablas Data = new Tablas();
            if (Data.BuscarCampo(consulta) == "")
            {
                return 0;
            }
            else
            {
                Cantidad = Int32.Parse(Data.BuscarCampo(consulta));
            }
   return Cantidad;
  }

  public float CalcularGanancias(){
   float total = 0;
   string consulta = "Select Detalle_Service.Cantidad_Repuesto,Repuestos.Costo from Detalle_Service inner join Repuestos on Repuestos.CodRepuesto=Detalle_Service.CodRepuesto";
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand cmd = new SqlCommand(consulta, cnDB);
   cnDB.Open();
   SqlDataReader Reader = cmd.ExecuteReader();
   while (Reader.Read() == true)
   {
    total += float.Parse(Reader[0].ToString()) * float.Parse(Reader[1].ToString());
   }
   return total;
  }
  private void CalculoIngresos_Load(object sender, EventArgs e)
  {
    if(ObtenerCantidadService() == 0)
            {
                txt_cantidad.Text = "0";
            }
    else { 
               txt_cantidad.Text = ObtenerCantidadService().ToString();
         }
     txt_recaudacion.Text = CalcularGanancias().ToString();
  }
 }
}
