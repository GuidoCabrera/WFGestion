namespace TPPROG3
{
 partial class BuscarServicePorFecha
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
   this.lbl_fecha = new System.Windows.Forms.Label();
   this.dtpk_service = new System.Windows.Forms.DateTimePicker();
   this.btn_buscar = new System.Windows.Forms.Button();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_fecha
   // 
   this.lbl_fecha.AutoSize = true;
   this.lbl_fecha.Location = new System.Drawing.Point(12, 9);
   this.lbl_fecha.Name = "lbl_fecha";
   this.lbl_fecha.Size = new System.Drawing.Size(157, 13);
   this.lbl_fecha.TabIndex = 0;
   this.lbl_fecha.Text = "Seleccione La Fecha Deseada:";
   // 
   // dtpk_service
   // 
   this.dtpk_service.Location = new System.Drawing.Point(175, 7);
   this.dtpk_service.Name = "dtpk_service";
   this.dtpk_service.Size = new System.Drawing.Size(248, 20);
   this.dtpk_service.TabIndex = 1;
   // 
   // btn_buscar
   // 
   this.btn_buscar.Location = new System.Drawing.Point(429, 7);
   this.btn_buscar.Name = "btn_buscar";
   this.btn_buscar.Size = new System.Drawing.Size(75, 20);
   this.btn_buscar.TabIndex = 2;
   this.btn_buscar.Text = "Buscar";
   this.btn_buscar.UseVisualStyleBackColor = true;
   this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(12, 33);
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.Size = new System.Drawing.Size(758, 219);
   this.grd_datos.TabIndex = 3;
   // 
   // BuscarServicePorFecha
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(782, 270);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.btn_buscar);
   this.Controls.Add(this.dtpk_service);
   this.Controls.Add(this.lbl_fecha);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "BuscarServicePorFecha";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Buscar Service Por Fecha";
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_fecha;
  private System.Windows.Forms.DateTimePicker dtpk_service;
  private System.Windows.Forms.Button btn_buscar;
  private System.Windows.Forms.DataGridView grd_datos;
 }
}