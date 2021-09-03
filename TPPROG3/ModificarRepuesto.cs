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
    public partial class ModificarRepuesto : Form
    {
        public ModificarRepuesto()
        {
            InitializeComponent();
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
  void resetxt()
        {
            TextBox[] X = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
            for (int i = 0; i < 7; i++)
            {
                X[i].ResetText();
            }
        }

        void Mostrartodos()
        {
            Tablas Ta = new Tablas();
            dataGridView1.DataSource = Ta.TraerTabla("select * From Repuestos where Estado=1", "Repuestos");
        }

    

        private void ModificarRepuesto_Load(object sender, EventArgs e)
        {
            Mostrartodos();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            int Reg_ag = 0;
   TextBox[] T = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
   Validaciones val = new Validaciones();


   if (VerificarTexto2(T) == false)
   {
    MessageBox.Show("Ningun Campo Debe Quedar Vacio");
    return;
   }
   if (val.VerficarCampoNumerico(textBox3.Text) == false)
   {
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
   if (val.VerificarLongitudString(textBox1.Text, 10) == true)
   {
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

   string B = textBox1.Text;
                float C = float.Parse(textBox3.Text);
                int D = Int32.Parse(textBox6.Text);
                int F = Int32.Parse(textBox7.Text);
                Tablas Data = new Tablas();
                Reg_ag = Data.CargarTablaEnDBRepuesto("execute ModRep", "ModRep", textBox1.Text, textBox2.Text, C, textBox4.Text, textBox5.Text, D, F,1);
                MessageBox.Show("Repuesto Modificado Satisfactoriamente");
                resetxt();
            
            Mostrartodos();
        }

  private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
  {
   textBox1.Text= dataGridView1.CurrentRow.Cells["CodRepuesto"].Value.ToString();
   textBox2.Text = dataGridView1.CurrentRow.Cells["Tipo"].Value.ToString();
   textBox3.Text = dataGridView1.CurrentRow.Cells["Costo"].Value.ToString();
   textBox4.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
   textBox5.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
   textBox6.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
   textBox7.Text = dataGridView1.CurrentRow.Cells["PuntoPedido"].Value.ToString();
  }
 }
}
