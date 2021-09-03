namespace TPPROG3
{
    partial class frmAgregarCli
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblProv = new System.Windows.Forms.Label();
            this.lblCiu = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.txtCiu = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(46, 39);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nombre: *";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Location = new System.Drawing.Point(46, 64);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(54, 13);
            this.lblApe.TabIndex = 1;
            this.lblApe.Text = "Apellido: *";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(38, 90);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(55, 13);
            this.lblDir.TabIndex = 2;
            this.lblDir.Text = "Dirección:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(41, 116);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 3;
            this.lblTel.Text = "Telefono:";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(18, 142);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(75, 13);
            this.lblCP.TabIndex = 4;
            this.lblCP.Text = "Código Postal:";
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Location = new System.Drawing.Point(39, 168);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(61, 13);
            this.lblProv.TabIndex = 5;
            this.lblProv.Text = "Provincia: *";
            // 
            // lblCiu
            // 
            this.lblCiu.AutoSize = true;
            this.lblCiu.Location = new System.Drawing.Point(50, 194);
            this.lblCiu.Name = "lblCiu";
            this.lblCiu.Size = new System.Drawing.Size(50, 13);
            this.lblCiu.TabIndex = 6;
            this.lblCiu.Text = "Ciudad: *";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(64, 220);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(36, 13);
            this.lblDNI.TabIndex = 7;
            this.lblDNI.Text = "DNI: *";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(100, 31);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(163, 20);
            this.txtNom.TabIndex = 8;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(100, 57);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(163, 20);
            this.txtApe.TabIndex = 9;
            this.txtApe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApe_KeyPress);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(100, 83);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(163, 20);
            this.txtDir.TabIndex = 10;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(100, 109);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(163, 20);
            this.txtTel.TabIndex = 11;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(100, 135);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(163, 20);
            this.txtCP.TabIndex = 12;
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            // 
            // txtProv
            // 
            this.txtProv.Location = new System.Drawing.Point(100, 161);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(163, 20);
            this.txtProv.TabIndex = 13;
            this.txtProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProv_KeyPress);
            // 
            // txtCiu
            // 
            this.txtCiu.Location = new System.Drawing.Point(100, 187);
            this.txtCiu.Name = "txtCiu";
            this.txtCiu.Size = new System.Drawing.Size(163, 20);
            this.txtCiu.TabIndex = 14;
            this.txtCiu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiu_KeyPress);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(100, 213);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(163, 20);
            this.txtDNI.TabIndex = 15;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(100, 266);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 43);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmAgregarCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(325, 361);
            this.Controls.Add(this.btnAceptar);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarCli";
            this.Text = "Agregar Cliente";
            this.Load += new System.EventHandler(this.frmAgregarCli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.Label lblCiu;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.TextBox txtCiu;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnAceptar;
    }
}