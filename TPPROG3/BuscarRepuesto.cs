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
    public partial class BuscarRepuesto : Form
    {
        public BuscarRepuesto()
        {
            InitializeComponent();
        }
        void MostrarTodo()
             {
            Tablas Ta = new Tablas();
            dataGridView1.DataSource = Ta.TraerTabla("select * From Repuestos where Estado=1", "Repuestos");
        }

             void conteodefilas()
             {
                 int c = dataGridView1.RowCount - 1;
                 label4.Text = "Cantidad total de registros encontrados:" + c.ToString();
             }

             void LlenarCombobox()
             {
                 String[] A = new String[] { "Empieza con:", "Contiene:", "Termina con:" };
                  for (int i = 0; i < 3; i++)
                  {
                   comboBox1.Items.Add(A[i]);
                   comboBox2.Items.Add(A[i]);
                  }
             }


             String Filtro()
             {
            
                 String A = "select * from Repuestos";
                 if(checkBox1.Checked==true){
                  switch (comboBox1.Text.ToString())
                  {
                   case "Empieza con:":
                    A = A + " where CodRepuesto like '" + textBox1.Text + "%'" + " and Estado=1";

                    break;
                   case "Contiene:":
                    A = A + " where CodRepuesto like '%" + textBox1.Text + "%'" + " and Estado=1";

                    break;
                 
                   case "Termina con:":
                    A = A + " where CodRepuesto like '%" + textBox1.Text + "'" + " and Estado=1";

                    break;

                  }
                 }
             


                 if (checkBox2.Checked==true)
                 {
                     switch (comboBox2.Text.ToString())
                     {
                         case "Empieza con:":
                             A = A + " where Descripcion like '" + textBox2.Text + "%'" + " and Estado=1";

                             break;
                         case "Contiene:":
                             A = A + " where Descripcion like '%" + textBox2.Text + "%'" + " and Estado=1";

                      
                             break;
                         case "Termina con:":
                             A = A + " where Descripcion like '%" + textBox2.Text+ "'" + " and Estado=1";

                             break;
                     }
                 }

                 return A;
             }


             private void button1_Click(object sender, EventArgs e)
             {
            Tablas Ta = new Tablas();
                 if (comboBox1.SelectedIndex>=0&&checkBox1.Checked==true)
                 {
                 if (textBox1.Text == "")
                 {
                  MessageBox.Show("Ingrese Un Codigo");
                  return;
                 }
                 }

                 if(comboBox2.SelectedIndex >=0 && checkBox2.Checked == true){
                 if (textBox2.Text == "")
                 {
                  MessageBox.Show("Ingrese Una Descripcion");
                  return;
                 }
                 }
                 if(checkBox1.Checked==false&&checkBox2.Checked==false){
                 MessageBox.Show("Seleccione Un Metodo De Filtrado");
                 return;
                 }
               dataGridView1.DataSource = Ta.TraerTabla(Filtro(), "Repuestos");
               conteodefilas();
               return;
              }


  private void button2_Click(object sender, EventArgs e)
             {
                 MostrarTodo();
                 comboBox1.SelectedIndex=-1;
                 textBox1.ResetText();
                 comboBox2.SelectedIndex=-1;
                 textBox2.ResetText();
                 checkBox1.Checked = false;
                 checkBox2.Checked = false;
                 conteodefilas();
             }

private void BuscarRepuesto_Load(object sender, EventArgs e)
        {
            MostrarTodo();
            LlenarCombobox();
            conteodefilas();
        }

  private void checkBox1_Click(object sender, EventArgs e)
  {
   checkBox2.Checked = false;
  }

  private void checkBox2_Click(object sender, EventArgs e)
  {
   checkBox1.Checked = false;
  }
 }
}