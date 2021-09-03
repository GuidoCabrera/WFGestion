namespace TPPROG3
{
 partial class DetalleService
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
   this.lbl_seleccion = new System.Windows.Forms.Label();
   this.cmbx_seleccion_repuesto = new System.Windows.Forms.ComboBox();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   this.btn_realizar_cambios = new System.Windows.Forms.Button();
   this.lbl_numservice = new System.Windows.Forms.Label();
   this.lbl_cantidad = new System.Windows.Forms.Label();
   this.txt_cantidad = new System.Windows.Forms.TextBox();
   this.lbl_fecha = new System.Windows.Forms.Label();
   this.txt_fecha = new System.Windows.Forms.TextBox();
   this.cmbx_nservice = new System.Windows.Forms.ComboBox();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_seleccion
   // 
   this.lbl_seleccion.AutoSize = true;
   this.lbl_seleccion.Location = new System.Drawing.Point(12, 9);
   this.lbl_seleccion.Name = "lbl_seleccion";
   this.lbl_seleccion.Size = new System.Drawing.Size(132, 13);
   this.lbl_seleccion.TabIndex = 0;
   this.lbl_seleccion.Text = "Seleccione Un Repuesto :";
   // 
   // cmbx_seleccion_repuesto
   // 
   this.cmbx_seleccion_repuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbx_seleccion_repuesto.FormattingEnabled = true;
   this.cmbx_seleccion_repuesto.Location = new System.Drawing.Point(150, 6);
   this.cmbx_seleccion_repuesto.Name = "cmbx_seleccion_repuesto";
   this.cmbx_seleccion_repuesto.Size = new System.Drawing.Size(335, 21);
   this.cmbx_seleccion_repuesto.TabIndex = 1;
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(15, 117);
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.ReadOnly = true;
   this.grd_datos.Size = new System.Drawing.Size(721, 292);
   this.grd_datos.TabIndex = 3;
   // 
   // btn_realizar_cambios
   // 
   this.btn_realizar_cambios.Location = new System.Drawing.Point(15, 415);
   this.btn_realizar_cambios.Name = "btn_realizar_cambios";
   this.btn_realizar_cambios.Size = new System.Drawing.Size(111, 23);
   this.btn_realizar_cambios.TabIndex = 5;
   this.btn_realizar_cambios.Text = "Realizar Cambios";
   this.btn_realizar_cambios.UseVisualStyleBackColor = true;
   this.btn_realizar_cambios.Click += new System.EventHandler(this.btn_realizar_cambios_Click);
   // 
   // lbl_numservice
   // 
   this.lbl_numservice.AutoSize = true;
   this.lbl_numservice.Location = new System.Drawing.Point(12, 68);
   this.lbl_numservice.Name = "lbl_numservice";
   this.lbl_numservice.Size = new System.Drawing.Size(103, 13);
   this.lbl_numservice.TabIndex = 6;
   this.lbl_numservice.Text = "Numero De Service:";
   // 
   // lbl_cantidad
   // 
   this.lbl_cantidad.AutoSize = true;
   this.lbl_cantidad.Location = new System.Drawing.Point(12, 39);
   this.lbl_cantidad.Name = "lbl_cantidad";
   this.lbl_cantidad.Size = new System.Drawing.Size(120, 13);
   this.lbl_cantidad.TabIndex = 8;
   this.lbl_cantidad.Text = "Cantidad Del Repuesto:";
   // 
   // txt_cantidad
   // 
   this.txt_cantidad.Location = new System.Drawing.Point(150, 36);
   this.txt_cantidad.Name = "txt_cantidad";
   this.txt_cantidad.Size = new System.Drawing.Size(335, 20);
   this.txt_cantidad.TabIndex = 9;
   // 
   // lbl_fecha
   // 
   this.lbl_fecha.AutoSize = true;
   this.lbl_fecha.Location = new System.Drawing.Point(12, 94);
   this.lbl_fecha.Name = "lbl_fecha";
   this.lbl_fecha.Size = new System.Drawing.Size(40, 13);
   this.lbl_fecha.TabIndex = 10;
   this.lbl_fecha.Text = "Fecha:";
   // 
   // txt_fecha
   // 
   this.txt_fecha.Location = new System.Drawing.Point(150, 91);
   this.txt_fecha.Name = "txt_fecha";
   this.txt_fecha.ReadOnly = true;
   this.txt_fecha.Size = new System.Drawing.Size(335, 20);
   this.txt_fecha.TabIndex = 11;
   // 
   // cmbx_nservice
   // 
   this.cmbx_nservice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbx_nservice.FormattingEnabled = true;
   this.cmbx_nservice.Location = new System.Drawing.Point(150, 62);
   this.cmbx_nservice.Name = "cmbx_nservice";
   this.cmbx_nservice.Size = new System.Drawing.Size(335, 21);
   this.cmbx_nservice.TabIndex = 12;
   // 
   // DetalleService
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(754, 450);
   this.Controls.Add(this.cmbx_nservice);
   this.Controls.Add(this.txt_fecha);
   this.Controls.Add(this.lbl_fecha);
   this.Controls.Add(this.txt_cantidad);
   this.Controls.Add(this.lbl_cantidad);
   this.Controls.Add(this.lbl_seleccion);
   this.Controls.Add(this.lbl_numservice);
   this.Controls.Add(this.btn_realizar_cambios);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.cmbx_seleccion_repuesto);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "DetalleService";
   this.Text = "Agregar Detalles De Service";
   this.Load += new System.EventHandler(this.DetalleService_Load);
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_seleccion;
  private System.Windows.Forms.ComboBox cmbx_seleccion_repuesto;
  private System.Windows.Forms.DataGridView grd_datos;
  private System.Windows.Forms.Button btn_realizar_cambios;
  private System.Windows.Forms.Label lbl_numservice;
  private System.Windows.Forms.Label lbl_cantidad;
  private System.Windows.Forms.TextBox txt_cantidad;
  private System.Windows.Forms.Label lbl_fecha;
  private System.Windows.Forms.TextBox txt_fecha;
  private System.Windows.Forms.ComboBox cmbx_nservice;
 }
}