namespace TPPROG3
{
 partial class GenerarSalidaService
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
   this.txt_total = new System.Windows.Forms.TextBox();
   this.lbl_total = new System.Windows.Forms.Label();
   this.lbl_detalle = new System.Windows.Forms.Label();
   this.lbl_num_service = new System.Windows.Forms.Label();
   this.btn_buscar = new System.Windows.Forms.Button();
   this.cmbx_numservice = new System.Windows.Forms.ComboBox();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // txt_total
   // 
   this.txt_total.Location = new System.Drawing.Point(61, 346);
   this.txt_total.Name = "txt_total";
   this.txt_total.ReadOnly = true;
   this.txt_total.Size = new System.Drawing.Size(198, 20);
   this.txt_total.TabIndex = 0;
   // 
   // lbl_total
   // 
   this.lbl_total.AutoSize = true;
   this.lbl_total.Location = new System.Drawing.Point(12, 346);
   this.lbl_total.Name = "lbl_total";
   this.lbl_total.Size = new System.Drawing.Size(49, 13);
   this.lbl_total.TabIndex = 1;
   this.lbl_total.Text = "Total ($):";
   // 
   // lbl_detalle
   // 
   this.lbl_detalle.AutoSize = true;
   this.lbl_detalle.Location = new System.Drawing.Point(12, 38);
   this.lbl_detalle.Name = "lbl_detalle";
   this.lbl_detalle.Size = new System.Drawing.Size(43, 13);
   this.lbl_detalle.TabIndex = 3;
   this.lbl_detalle.Text = "Detalle:";
   // 
   // lbl_num_service
   // 
   this.lbl_num_service.AutoSize = true;
   this.lbl_num_service.Location = new System.Drawing.Point(12, 12);
   this.lbl_num_service.Name = "lbl_num_service";
   this.lbl_num_service.Size = new System.Drawing.Size(103, 13);
   this.lbl_num_service.TabIndex = 4;
   this.lbl_num_service.Text = "Numero De Service:";
   // 
   // btn_buscar
   // 
   this.btn_buscar.Location = new System.Drawing.Point(296, 9);
   this.btn_buscar.Name = "btn_buscar";
   this.btn_buscar.Size = new System.Drawing.Size(75, 23);
   this.btn_buscar.TabIndex = 6;
   this.btn_buscar.Text = "Buscar";
   this.btn_buscar.UseVisualStyleBackColor = true;
   this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
   // 
   // cmbx_numservice
   // 
   this.cmbx_numservice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbx_numservice.FormattingEnabled = true;
   this.cmbx_numservice.Location = new System.Drawing.Point(121, 9);
   this.cmbx_numservice.Name = "cmbx_numservice";
   this.cmbx_numservice.Size = new System.Drawing.Size(169, 21);
   this.cmbx_numservice.TabIndex = 7;
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(73, 38);
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.ReadOnly = true;
   this.grd_datos.Size = new System.Drawing.Size(647, 302);
   this.grd_datos.TabIndex = 8;
   // 
   // GenerarSalidaService
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(732, 378);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.cmbx_numservice);
   this.Controls.Add(this.btn_buscar);
   this.Controls.Add(this.lbl_num_service);
   this.Controls.Add(this.lbl_detalle);
   this.Controls.Add(this.lbl_total);
   this.Controls.Add(this.txt_total);
   this.Name = "GenerarSalidaService";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Generar Salida De Service";
   this.Load += new System.EventHandler(this.GenerarSalidaService_Load);
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.TextBox txt_total;
  private System.Windows.Forms.Label lbl_total;
  private System.Windows.Forms.Label lbl_detalle;
  private System.Windows.Forms.Label lbl_num_service;
  private System.Windows.Forms.Button btn_buscar;
  private System.Windows.Forms.ComboBox cmbx_numservice;
  private System.Windows.Forms.DataGridView grd_datos;
 }
}