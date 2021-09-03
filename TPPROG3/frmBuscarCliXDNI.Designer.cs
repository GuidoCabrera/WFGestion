namespace TPPROG3
{
    partial class frmBuscarCliXDNI
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDNICLI = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblCiu = new System.Windows.Forms.Label();
            this.lblProv = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblDNICLI
            // 
            this.lblDNICLI.AutoSize = true;
            this.lblDNICLI.Location = new System.Drawing.Point(31, 32);
            this.lblDNICLI.Name = "lblDNICLI";
            this.lblDNICLI.Size = new System.Drawing.Size(119, 13);
            this.lblDNICLI.TabIndex = 4;
            this.lblDNICLI.Text = "Ingrese DNI De Cliente:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(109, 269);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 15;
            this.lblDNI.Text = "DNI:";
            // 
            // lblCiu
            // 
            this.lblCiu.AutoSize = true;
            this.lblCiu.Location = new System.Drawing.Point(95, 243);
            this.lblCiu.Name = "lblCiu";
            this.lblCiu.Size = new System.Drawing.Size(43, 13);
            this.lblCiu.TabIndex = 14;
            this.lblCiu.Text = "Ciudad:";
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Location = new System.Drawing.Point(87, 217);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(51, 13);
            this.lblProv.TabIndex = 13;
            this.lblProv.Text = "Provincia";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(63, 191);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(75, 13);
            this.lblCP.TabIndex = 12;
            this.lblCP.Text = "Código Postal:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(86, 165);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 11;
            this.lblTel.Text = "Telefono:";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(83, 139);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(55, 13);
            this.lblDir.TabIndex = 10;
            this.lblDir.Text = "Dirección:";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Location = new System.Drawing.Point(91, 113);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(47, 13);
            this.lblApe.TabIndex = 9;
            this.lblApe.Text = "Apellido:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(91, 88);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 13);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nombre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(312, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmBuscarCliXDNI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(658, 320);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblCiu);
            this.Controls.Add(this.lblProv);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDNICLI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarCliXDNI";
            this.Text = "Buscar Cliente Por DNI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDNICLI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblCiu;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnBuscar;
    }
}