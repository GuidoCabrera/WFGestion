namespace TPPROG3
{
 partial class BuscarPorNumEquipo
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
   this.lbl_num_equipo = new System.Windows.Forms.Label();
   this.txt_num_equipo = new System.Windows.Forms.TextBox();
   this.btn_buscar = new System.Windows.Forms.Button();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_num_equipo
   // 
   this.lbl_num_equipo.AutoSize = true;
   this.lbl_num_equipo.Location = new System.Drawing.Point(12, 22);
   this.lbl_num_equipo.Name = "lbl_num_equipo";
   this.lbl_num_equipo.Size = new System.Drawing.Size(196, 13);
   this.lbl_num_equipo.TabIndex = 0;
   this.lbl_num_equipo.Text = "Ingrese El Numero De Equipo Deseado:";
   // 
   // txt_num_equipo
   // 
   this.txt_num_equipo.Location = new System.Drawing.Point(214, 19);
   this.txt_num_equipo.Name = "txt_num_equipo";
   this.txt_num_equipo.Size = new System.Drawing.Size(393, 20);
   this.txt_num_equipo.TabIndex = 1;
   // 
   // btn_buscar
   // 
   this.btn_buscar.Location = new System.Drawing.Point(15, 180);
   this.btn_buscar.Name = "btn_buscar";
   this.btn_buscar.Size = new System.Drawing.Size(146, 23);
   this.btn_buscar.TabIndex = 2;
   this.btn_buscar.Text = "Buscar Equipo";
   this.btn_buscar.UseVisualStyleBackColor = true;
   this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(15, 57);
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.Size = new System.Drawing.Size(856, 117);
   this.grd_datos.TabIndex = 3;
   // 
   // BuscarPorNumEquipo
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(883, 209);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.btn_buscar);
   this.Controls.Add(this.txt_num_equipo);
   this.Controls.Add(this.lbl_num_equipo);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "BuscarPorNumEquipo";
   this.Text = "Buscar Por Numero De Equipo";
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_num_equipo;
  private System.Windows.Forms.TextBox txt_num_equipo;
  private System.Windows.Forms.Button btn_buscar;
  private System.Windows.Forms.DataGridView grd_datos;
 }
}