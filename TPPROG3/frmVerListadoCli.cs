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
    public partial class frmVerListadoCli : Form
    {
        public frmVerListadoCli()
        {
            InitializeComponent();
        }


        private void frmVerListadoCli_Load(object sender, EventArgs e)
        {
            string comando = "Select Nombre,Apellido,Direccion,Telefono,Codpostal as 'Codigo Postal', Provincia, Ciudad,DNI from Clientes where Estado=1";
            Tablas DATA = new Tablas();
            dataGridView1.DataSource = DATA.TraerTabla(comando, "Clientes");
            lblcant_num.Text = (dataGridView1.RowCount-1).ToString();
        }

        private void rbASC_CheckedChanged(object sender, EventArgs e)
        {
            string comando = "Select Nombre,Apellido,Direccion,Telefono,Codpostal as 'Codigo Postal', Provincia, Ciudad,DNI from Clientes where Estado=1 order by Nombre ASC";
            Tablas DATA = new Tablas();
            dataGridView1.DataSource = DATA.TraerTabla(comando, "Clientes");
            lblcant_num.Text = (dataGridView1.RowCount - 1).ToString();
           }

        private void rbDESC_CheckedChanged(object sender, EventArgs e)
        {
            string comando = "Select Nombre,Apellido,Direccion,Telefono,Codpostal as 'Codigo Postal', Provincia, Ciudad,DNI from Clientes where Estado=1 order by Nombre DESC";
            Tablas DATA = new Tablas();
            dataGridView1.DataSource = DATA.TraerTabla(comando, "Clientes");
            lblcant_num.Text = (dataGridView1.RowCount - 1).ToString();
           }
    }
}
