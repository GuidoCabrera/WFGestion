namespace TPPROG3
{
    partial class frmModificarCli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBaja = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTIPBaja = new System.Windows.Forms.Label();
            this.lblCantFIltrado = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtCiu = new System.Windows.Forms.TextBox();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblCiu = new System.Windows.Forms.Label();
            this.lblProv = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txt_cant_clientes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 68);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(644, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(586, 375);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(92, 40);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "BAJA";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(31, 418);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(133, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad total de Clientes: ";
            // 
            // lblTIPBaja
            // 
            this.lblTIPBaja.AutoSize = true;
            this.lblTIPBaja.Location = new System.Drawing.Point(31, 445);
            this.lblTIPBaja.Name = "lblTIPBaja";
            this.lblTIPBaja.Size = new System.Drawing.Size(263, 13);
            this.lblTIPBaja.TabIndex = 5;
            this.lblTIPBaja.Text = "Seleccione un Cliente y pulse BAJA para darlo de baja";
            this.lblTIPBaja.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCantFIltrado
            // 
            this.lblCantFIltrado.AutoSize = true;
            this.lblCantFIltrado.Location = new System.Drawing.Point(772, 32);
            this.lblCantFIltrado.Name = "lblCantFIltrado";
            this.lblCantFIltrado.Size = new System.Drawing.Size(0, 13);
            this.lblCantFIltrado.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "Direccion",
            "Telefono",
            "Codigo Postal",
            "Provincia",
            "Ciudad",
            "DNI"});
            this.comboBox1.Location = new System.Drawing.Point(91, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(12, 27);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(67, 13);
            this.lblFiltrar.TabIndex = 10;
            this.lblFiltrar.Text = "Ordenar Por:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(419, 375);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(161, 40);
            this.btnCargar.TabIndex = 12;
            this.btnCargar.Text = "CARGAR CAMBIOS";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(779, 302);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ReadOnly = true;
            this.txtDNI.Size = new System.Drawing.Size(269, 20);
            this.txtDNI.TabIndex = 31;
            // 
            // txtCiu
            // 
            this.txtCiu.Location = new System.Drawing.Point(779, 276);
            this.txtCiu.Name = "txtCiu";
            this.txtCiu.Size = new System.Drawing.Size(269, 20);
            this.txtCiu.TabIndex = 30;
            // 
            // txtProv
            // 
            this.txtProv.Location = new System.Drawing.Point(779, 250);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(269, 20);
            this.txtProv.TabIndex = 29;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(779, 224);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(269, 20);
            this.txtCP.TabIndex = 28;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(779, 198);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(269, 20);
            this.txtTel.TabIndex = 27;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(779, 172);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(269, 20);
            this.txtDir.TabIndex = 26;
            this.txtDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDir_KeyPress);
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(779, 146);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(269, 20);
            this.txtApe.TabIndex = 25;
            this.txtApe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApe_KeyPress);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(779, 120);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(269, 20);
            this.txtNom.TabIndex = 24;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(743, 309);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(36, 13);
            this.lblDNI.TabIndex = 23;
            this.lblDNI.Text = "DNI: *";
            // 
            // lblCiu
            // 
            this.lblCiu.AutoSize = true;
            this.lblCiu.Location = new System.Drawing.Point(729, 283);
            this.lblCiu.Name = "lblCiu";
            this.lblCiu.Size = new System.Drawing.Size(50, 13);
            this.lblCiu.TabIndex = 22;
            this.lblCiu.Text = "Ciudad: *";
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Location = new System.Drawing.Point(718, 257);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(61, 13);
            this.lblProv.TabIndex = 21;
            this.lblProv.Text = "Provincia: *";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(697, 231);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(75, 13);
            this.lblCP.TabIndex = 20;
            this.lblCP.Text = "Código Postal:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(720, 205);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 19;
            this.lblTel.Text = "Telefono:";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(717, 179);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(55, 13);
            this.lblDir.TabIndex = 18;
            this.lblDir.Text = "Dirección:";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Location = new System.Drawing.Point(725, 153);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(54, 13);
            this.lblApe.TabIndex = 17;
            this.lblApe.Text = "Apellido: *";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(725, 128);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 13);
            this.lblNom.TabIndex = 16;
            this.lblNom.Text = "Nombre: *";
            // 
            // txt_cant_clientes
            // 
            this.txt_cant_clientes.Location = new System.Drawing.Point(171, 415);
            this.txt_cant_clientes.Name = "txt_cant_clientes";
            this.txt_cant_clientes.ReadOnly = true;
            this.txt_cant_clientes.Size = new System.Drawing.Size(123, 20);
            this.txt_cant_clientes.TabIndex = 32;
            // 
            // frmModificarCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1060, 482);
            this.Controls.Add(this.txt_cant_clientes);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtCiu);
            this.Controls.Add(this.txtProv);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblCiu);
            this.Controls.Add(this.lblProv);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCantFIltrado);
            this.Controls.Add(this.lblTIPBaja);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarCli";
            this.Text = "Modificar Datos De Un Cliente";
            this.Load += new System.EventHandler(this.frmModificarCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTIPBaja;
        private System.Windows.Forms.Label lblCantFIltrado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtCiu;
        private System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblCiu;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblNom;
  private System.Windows.Forms.TextBox txt_cant_clientes;
 }
}