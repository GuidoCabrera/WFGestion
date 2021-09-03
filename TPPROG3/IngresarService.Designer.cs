namespace TPPROG3
{
 partial class IngresarService
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
   this.lbl_nservice = new System.Windows.Forms.Label();
   this.lbl_tipo_service = new System.Windows.Forms.Label();
   this.lbl_nserie = new System.Windows.Forms.Label();
   this.lbl_nequipo = new System.Windows.Forms.Label();
   this.lbl_fecha_ingreso = new System.Windows.Forms.Label();
   this.lbl_descripcion = new System.Windows.Forms.Label();
   this.txt_nservice = new System.Windows.Forms.TextBox();
   this.txt_descripcion_service = new System.Windows.Forms.TextBox();
   this.cmbx_tipo_service = new System.Windows.Forms.ComboBox();
   this.txt_nequipo = new System.Windows.Forms.TextBox();
   this.btn_agregar = new System.Windows.Forms.Button();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   this.txt_numserie = new System.Windows.Forms.TextBox();
   this.txt_fecha = new System.Windows.Forms.TextBox();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_nservice
   // 
   this.lbl_nservice.AutoSize = true;
   this.lbl_nservice.Location = new System.Drawing.Point(12, 26);
   this.lbl_nservice.Name = "lbl_nservice";
   this.lbl_nservice.Size = new System.Drawing.Size(103, 13);
   this.lbl_nservice.TabIndex = 0;
   this.lbl_nservice.Text = "Numero De Service:";
   // 
   // lbl_tipo_service
   // 
   this.lbl_tipo_service.AutoSize = true;
   this.lbl_tipo_service.Location = new System.Drawing.Point(12, 55);
   this.lbl_tipo_service.Name = "lbl_tipo_service";
   this.lbl_tipo_service.Size = new System.Drawing.Size(87, 13);
   this.lbl_tipo_service.TabIndex = 1;
   this.lbl_tipo_service.Text = "Tipo De Service:";
   // 
   // lbl_nserie
   // 
   this.lbl_nserie.AutoSize = true;
   this.lbl_nserie.Location = new System.Drawing.Point(12, 82);
   this.lbl_nserie.Name = "lbl_nserie";
   this.lbl_nserie.Size = new System.Drawing.Size(146, 13);
   this.lbl_nserie.TabIndex = 2;
   this.lbl_nserie.Text = "Numero De Serie Del Equipo:";
   // 
   // lbl_nequipo
   // 
   this.lbl_nequipo.AutoSize = true;
   this.lbl_nequipo.Location = new System.Drawing.Point(12, 110);
   this.lbl_nequipo.Name = "lbl_nequipo";
   this.lbl_nequipo.Size = new System.Drawing.Size(100, 13);
   this.lbl_nequipo.TabIndex = 3;
   this.lbl_nequipo.Text = "Numero De Equipo:";
   // 
   // lbl_fecha_ingreso
   // 
   this.lbl_fecha_ingreso.AutoSize = true;
   this.lbl_fecha_ingreso.Location = new System.Drawing.Point(12, 136);
   this.lbl_fecha_ingreso.Name = "lbl_fecha_ingreso";
   this.lbl_fecha_ingreso.Size = new System.Drawing.Size(95, 13);
   this.lbl_fecha_ingreso.TabIndex = 4;
   this.lbl_fecha_ingreso.Text = "Fecha De Ingreso:";
   // 
   // lbl_descripcion
   // 
   this.lbl_descripcion.AutoSize = true;
   this.lbl_descripcion.Location = new System.Drawing.Point(12, 160);
   this.lbl_descripcion.Name = "lbl_descripcion";
   this.lbl_descripcion.Size = new System.Drawing.Size(124, 13);
   this.lbl_descripcion.TabIndex = 5;
   this.lbl_descripcion.Text = "Descripcion Del Service:";
   // 
   // txt_nservice
   // 
   this.txt_nservice.Location = new System.Drawing.Point(160, 23);
   this.txt_nservice.Name = "txt_nservice";
   this.txt_nservice.ReadOnly = true;
   this.txt_nservice.Size = new System.Drawing.Size(413, 20);
   this.txt_nservice.TabIndex = 6;
   // 
   // txt_descripcion_service
   // 
   this.txt_descripcion_service.Location = new System.Drawing.Point(160, 157);
   this.txt_descripcion_service.Name = "txt_descripcion_service";
   this.txt_descripcion_service.Size = new System.Drawing.Size(413, 20);
   this.txt_descripcion_service.TabIndex = 7;
   // 
   // cmbx_tipo_service
   // 
   this.cmbx_tipo_service.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbx_tipo_service.FormattingEnabled = true;
   this.cmbx_tipo_service.Location = new System.Drawing.Point(160, 49);
   this.cmbx_tipo_service.Name = "cmbx_tipo_service";
   this.cmbx_tipo_service.Size = new System.Drawing.Size(413, 21);
   this.cmbx_tipo_service.TabIndex = 11;
   // 
   // txt_nequipo
   // 
   this.txt_nequipo.Location = new System.Drawing.Point(160, 103);
   this.txt_nequipo.Name = "txt_nequipo";
   this.txt_nequipo.Size = new System.Drawing.Size(413, 20);
   this.txt_nequipo.TabIndex = 12;
   // 
   // btn_agregar
   // 
   this.btn_agregar.Location = new System.Drawing.Point(160, 192);
   this.btn_agregar.Name = "btn_agregar";
   this.btn_agregar.Size = new System.Drawing.Size(413, 23);
   this.btn_agregar.TabIndex = 15;
   this.btn_agregar.Text = "Agregar Orden De Service";
   this.btn_agregar.UseVisualStyleBackColor = true;
   this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(12, 221);
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.Size = new System.Drawing.Size(561, 365);
   this.grd_datos.TabIndex = 16;
   // 
   // txt_numserie
   // 
   this.txt_numserie.Location = new System.Drawing.Point(160, 77);
   this.txt_numserie.Name = "txt_numserie";
   this.txt_numserie.ReadOnly = true;
   this.txt_numserie.Size = new System.Drawing.Size(413, 20);
   this.txt_numserie.TabIndex = 17;
   // 
   // txt_fecha
   // 
   this.txt_fecha.Location = new System.Drawing.Point(160, 129);
   this.txt_fecha.Name = "txt_fecha";
   this.txt_fecha.ReadOnly = true;
   this.txt_fecha.Size = new System.Drawing.Size(413, 20);
   this.txt_fecha.TabIndex = 18;
   // 
   // IngresarService
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(592, 598);
   this.Controls.Add(this.txt_fecha);
   this.Controls.Add(this.txt_numserie);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.btn_agregar);
   this.Controls.Add(this.txt_nequipo);
   this.Controls.Add(this.cmbx_tipo_service);
   this.Controls.Add(this.txt_descripcion_service);
   this.Controls.Add(this.txt_nservice);
   this.Controls.Add(this.lbl_descripcion);
   this.Controls.Add(this.lbl_fecha_ingreso);
   this.Controls.Add(this.lbl_nequipo);
   this.Controls.Add(this.lbl_nserie);
   this.Controls.Add(this.lbl_tipo_service);
   this.Controls.Add(this.lbl_nservice);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "IngresarService";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Ingresar Orden De Service";
   this.Load += new System.EventHandler(this.IngresarService_Load);
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_nservice;
  private System.Windows.Forms.Label lbl_tipo_service;
  private System.Windows.Forms.Label lbl_nserie;
  private System.Windows.Forms.Label lbl_nequipo;
  private System.Windows.Forms.Label lbl_fecha_ingreso;
  private System.Windows.Forms.Label lbl_descripcion;
  private System.Windows.Forms.TextBox txt_nservice;
  private System.Windows.Forms.TextBox txt_descripcion_service;
  private System.Windows.Forms.ComboBox cmbx_tipo_service;
  private System.Windows.Forms.TextBox txt_nequipo;
  private System.Windows.Forms.Button btn_agregar;
  private System.Windows.Forms.DataGridView grd_datos;
  private System.Windows.Forms.TextBox txt_numserie;
  private System.Windows.Forms.TextBox txt_fecha;
 }
}