namespace TPPROG3
{
    partial class frmVerListadoCli
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
   this.gboxFiltrar = new System.Windows.Forms.GroupBox();
   this.rbDESC = new System.Windows.Forms.RadioButton();
   this.rbASC = new System.Windows.Forms.RadioButton();
   this.lblCant = new System.Windows.Forms.Label();
   this.lblcant_num = new System.Windows.Forms.Label();
   ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
   this.gboxFiltrar.SuspendLayout();
   this.SuspendLayout();
   // 
   // dataGridView1
   // 
   this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
   this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dataGridView1.Location = new System.Drawing.Point(29, 87);
   this.dataGridView1.Name = "dataGridView1";
   this.dataGridView1.ReadOnly = true;
   this.dataGridView1.Size = new System.Drawing.Size(930, 296);
   this.dataGridView1.TabIndex = 0;
   // 
   // gboxFiltrar
   // 
   this.gboxFiltrar.BackColor = System.Drawing.Color.DarkGray;
   this.gboxFiltrar.Controls.Add(this.rbDESC);
   this.gboxFiltrar.Controls.Add(this.rbASC);
   this.gboxFiltrar.Location = new System.Drawing.Point(29, 12);
   this.gboxFiltrar.Name = "gboxFiltrar";
   this.gboxFiltrar.Size = new System.Drawing.Size(200, 53);
   this.gboxFiltrar.TabIndex = 1;
   this.gboxFiltrar.TabStop = false;
   this.gboxFiltrar.Text = "Filtrar en";
   // 
   // rbDESC
   // 
   this.rbDESC.AutoSize = true;
   this.rbDESC.Location = new System.Drawing.Point(103, 20);
   this.rbDESC.Name = "rbDESC";
   this.rbDESC.Size = new System.Drawing.Size(89, 17);
   this.rbDESC.TabIndex = 1;
   this.rbDESC.TabStop = true;
   this.rbDESC.Text = "Descendente";
   this.rbDESC.UseVisualStyleBackColor = true;
   this.rbDESC.CheckedChanged += new System.EventHandler(this.rbDESC_CheckedChanged);
   // 
   // rbASC
   // 
   this.rbASC.AutoSize = true;
   this.rbASC.Location = new System.Drawing.Point(13, 20);
   this.rbASC.Name = "rbASC";
   this.rbASC.Size = new System.Drawing.Size(82, 17);
   this.rbASC.TabIndex = 0;
   this.rbASC.TabStop = true;
   this.rbASC.Text = "Ascendente";
   this.rbASC.UseVisualStyleBackColor = true;
   this.rbASC.CheckedChanged += new System.EventHandler(this.rbASC_CheckedChanged);
   // 
   // lblCant
   // 
   this.lblCant.AutoSize = true;
   this.lblCant.Location = new System.Drawing.Point(255, 408);
   this.lblCant.Name = "lblCant";
   this.lblCant.Size = new System.Drawing.Size(134, 13);
   this.lblCant.TabIndex = 2;
   this.lblCant.Text = "Cantidad Total de Clientes:";
   // 
   // lblcant_num
   // 
   this.lblcant_num.AutoSize = true;
   this.lblcant_num.Location = new System.Drawing.Point(396, 408);
   this.lblcant_num.Name = "lblcant_num";
   this.lblcant_num.Size = new System.Drawing.Size(0, 13);
   this.lblcant_num.TabIndex = 3;
   // 
   // frmVerListadoCli
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(971, 444);
   this.Controls.Add(this.lblcant_num);
   this.Controls.Add(this.lblCant);
   this.Controls.Add(this.gboxFiltrar);
   this.Controls.Add(this.dataGridView1);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmVerListadoCli";
   this.Text = "Listado De Clientes";
   this.Load += new System.EventHandler(this.frmVerListadoCli_Load);
   ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
   this.gboxFiltrar.ResumeLayout(false);
   this.gboxFiltrar.PerformLayout();
   this.ResumeLayout(false);
   this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gboxFiltrar;
        private System.Windows.Forms.RadioButton rbDESC;
        private System.Windows.Forms.RadioButton rbASC;
        private System.Windows.Forms.Label lblCant;
  private System.Windows.Forms.Label lblcant_num;
 }
}