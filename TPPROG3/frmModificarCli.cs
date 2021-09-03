using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TPPROG3
{
    public partial class frmModificarCli : Form
    {
        public frmModificarCli()
        {
            InitializeComponent();
        }

        void MostrarClientes()
        {
            string comando = "Select Nombre,Apellido,Direccion,Telefono,Codpostal as 'Codigo Postal', Provincia, Ciudad,DNI from Clientes where Estado=1";
            Tablas DATA = new Tablas();
            dataGridView1.DataSource = DATA.TraerTabla(comando, "Clientes");
        }

        private void frmModificarCli_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            txt_cant_clientes.Text = (dataGridView1.RowCount - 1).ToString();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tablas DATA = new Tablas();
            Consultas BusquedaCliente = new Consultas();
            string comando = BusquedaCliente.CrearConsultaCliente(comboBox1.SelectedIndex.ToString());
            dataGridView1.DataSource = DATA.TraerTabla(comando, "Clientes");
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Tablas Data = new Tablas();
            string A = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            int Reg_ag = 0;
            Reg_ag = Data.BorrarEnDBCliente("Execute dltCli", "dltCli", A,2);
            MessageBox.Show("Cliente Borrado Satisfactoriamente");
            MostrarClientes();
            txtNom.Text = txtApe.Text = txtDir.Text = txtTel.Text = txtCP.Text = txtProv.Text = txtCiu.Text = txtDNI.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNom.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtApe.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDir.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCP.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtProv.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtCiu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtDNI.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }


  private void label2_Click(object sender, EventArgs e)
  {

  }


  private void btnCargar_Click(object sender, EventArgs e)
        {
            Tablas Data = new Tablas();

            if (txtNom.Text == "" || txtApe.Text == "" || txtDNI.Text == "" || txtCiu.Text == "" || txtProv.Text == "")
            {
                MessageBox.Show("Complete los campos obligatorios (Marcados con asterisco)");
                return;
            }

            if (txtNom.Text == "")
            {
                MessageBox.Show("Seleccione un cliente a modificar");
                return;
            }
            else
            {
            int Reg_ag = Data.CargarTablaEnDBClientes("execute modCli", "modCli", txtNom.Text, txtApe.Text, txtDir.Text, txtTel.Text, txtCP.Text, txtProv.Text, txtCiu.Text, txtDNI.Text,1);
            MessageBox.Show("Cliente Modificado Satisfactoriamente");
                    }
            
            MostrarClientes();
            txtNom.Text = txtApe.Text = txtDir.Text = txtTel.Text = txtCP.Text = txtProv.Text = txtCiu.Text = txtDNI.Text = "";
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

                return;
            }
        }

        private void txtApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
            */
        }

        private void txtProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;

                return;
            }
        }

        private void txtDir_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCiu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;

                return;
            }
        }

    }
}
