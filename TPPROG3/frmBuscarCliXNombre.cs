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
    public partial class frmBuscarCliXNombre : Form
    {
        public frmBuscarCliXNombre()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Tablas DATA = new Tablas();
            string comando = "select * from Clientes where Nombre = '" + textBox1.Text.ToString() + "'"+ " and Estado=1";
            dataGridView1.DataSource = DATA.TraerTabla(comando, "Clientes");
        }

        private void frmBuscarCliXNombre_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

                return;
            }
        }
    }
}
