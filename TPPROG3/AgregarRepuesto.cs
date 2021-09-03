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
    public partial class AgregarRepuesto : Form
    {
        public AgregarRepuesto()
        {
            InitializeComponent();
        }

        void resetxt()
        {
            TextBox[] X = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
            for(int i = 0; i < 7; i++)
            {
                X[i].ResetText();
            }
        }

        void MostrarTodos()
        {
            Tablas Ta = new Tablas();
            dataGridView1.DataSource = Ta.TraerTabla("select * From Repuestos where Estado = 1", "Repuestos");
        }

  

        bool VerificarTexto2(TextBox[] T)
        {
            bool aux = true;
            String[] A = new String[] { "Codigo de repuesto", "Tipo", "Costo", "Marca", "Descripción", "Stock", "Punto de Pedido" };
            for (int i = 0; i < 7; i++)
            {
                if (T[i].Text == "")
                {
                    aux = false;
                    return aux;
                }
            }
            return aux;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] T = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
            int Reg_ag = 0;
            Validaciones val = new Validaciones();
           

            if (VerificarTexto2(T)==false) {
            MessageBox.Show("Ningun Campo Debe Quedar Vacio");
            return;
             }
             if(val.VerficarCampoNumerico(textBox3.Text)==false){
             MessageBox.Show("El Campo Costo Debe Ser Numerico");
             return;
             }
             if (val.VerficarCampoNumerico(textBox6.Text) == false)
             {
              MessageBox.Show("El Campo Stock Debe Ser Numerico");
              return;
             }
             if (val.VerficarCampoNumerico(textBox7.Text) == false)
             {
              MessageBox.Show("El Campo Punto De Pedido Debe Ser Numerico");
              return;
             }
             if (val.VerificarLongitudString(textBox1.Text,10)==true){
              MessageBox.Show("Codigo De Repuesto Excedido En Longitud");
              return;
             }
             if (val.VerificarLongitudString(textBox2.Text, 30) == true)
             {
              MessageBox.Show("Tipo De Repuesto Excedido En Longitud");
              return;
             }
             if (val.VerificarLongitudString(textBox4.Text, 30) == true)
             {
              MessageBox.Show("Marca Excedida En Longitud");
              return;
             }
             if (val.VerificarLongitudString(textBox5.Text, 50) == true)
             {
              MessageBox.Show("Descripcion Excedida En Longitud");
              return;
             }
             if(Int32.Parse(textBox6.Text)<Int32.Parse(textBox7.Text)){
             MessageBox.Show("El Stock Debe Ser Mayor Al Punto De Pedido");
             return;
             }

             float C = float.Parse(textBox3.Text);
             int D = Int32.Parse(textBox6.Text);
             int F = Int32.Parse(textBox7.Text);

             if (val.VerificarExistenciaEnTabla2(0, textBox1.Text, dataGridView1))
                  {
                   MessageBox.Show("Codigo de repuesto ya ingresado");
                   return;
                  }
             if (val.VerificarExistenciaEnTabla2(4, textBox5.Text, dataGridView1))
             {
              MessageBox.Show("La Descripcion Ingresada Ya Existe");
              return;
             }

   Tablas Data = new Tablas();
          Reg_ag = Data.CargarTablaEnDBRepuesto("execute insertRep", "insertRep", textBox1.Text, textBox2.Text, C, textBox4.Text, textBox5.Text, D, F, 1);
          MessageBox.Show("Repuesto Agregado Satisfactoriamente");
          resetxt();
          MostrarTodos();
        }




        private void AgregarRepuesto_Load(object sender, EventArgs e)
        {
            MostrarTodos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tablas Data = new Tablas();
            string A = dataGridView1.CurrentRow.Cells["CodRepuesto"].Value.ToString();
            int Reg_ag = 0;
            Reg_ag = Data.BorrarEnDBRepuesto("Execute dltRep", "dltRep", A,2);
            MessageBox.Show("Repuesto Borrado Satisfactoriamente");
            MostrarTodos();
        }
    }
}
