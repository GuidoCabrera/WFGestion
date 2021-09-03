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
    public partial class frmAgregarCli : Form
    {
        public frmAgregarCli()
        {
            InitializeComponent();
        }

        private void frmAgregarCli_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int added_reg = 0;
            Validaciones val = new Validaciones();
            if(txtNom.Text == "" || txtApe.Text == "" || txtDNI.Text == "" || txtCiu.Text == "" || txtProv.Text == "")
            {
                MessageBox.Show("Complete los campos obligatorios (Marcados con asterisco)");
                return;
            }

            if (val.VerificarExistenciaEnClientes("Select * from Clientes", "Clientes", txtDNI.Text))
            {
                MessageBox.Show("Cliente ya registrado");
                return;
            }

            ///
            Tablas Data = new Tablas();
            added_reg = Data.CargarTablaEnDBClientes("execute insrt_clientes", "insrt_clientes", txtNom.Text, txtApe.Text, txtDir.Text, txtTel.Text, txtCP.Text, txtProv.Text, txtCiu.Text, txtDNI.Text,1);
            MessageBox.Show("Cliente Agregado Satisfactoriamente");
            txtNom.Text = txtApe.Text = txtDir.Text = txtTel.Text = txtCP.Text = txtProv.Text = txtCiu.Text = txtDNI.Text = "";
            return;

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

        private void txtCiu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;

                return;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }
    }
}
