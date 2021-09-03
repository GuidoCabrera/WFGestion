namespace TPPROG3
{
 partial class ListadoService
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
   this.gbx_filtros = new System.Windows.Forms.GroupBox();
   this.rbtn_fecha = new System.Windows.Forms.RadioButton();
   this.rbtn_nequipo = new System.Windows.Forms.RadioButton();
   this.rbtn_nservice = new System.Windows.Forms.RadioButton();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   this.gbx_filtros.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // gbx_filtros
   // 
   this.gbx_filtros.Controls.Add(this.rbtn_fecha);
   this.gbx_filtros.Controls.Add(this.rbtn_nequipo);
   this.gbx_filtros.Controls.Add(this.rbtn_nservice);
   this.gbx_filtros.Location = new System.Drawing.Point(12, 12);
   this.gbx_filtros.Name = "gbx_filtros";
   this.gbx_filtros.Size = new System.Drawing.Size(909, 62);
   this.gbx_filtros.TabIndex = 0;
   this.gbx_filtros.TabStop = false;
   this.gbx_filtros.Text = "Ordenar Por";
   // 
   // rbtn_fecha
   // 
   this.rbtn_fecha.AutoSize = true;
   this.rbtn_fecha.Location = new System.Drawing.Point(251, 28);
   this.rbtn_fecha.Name = "rbtn_fecha";
   this.rbtn_fecha.Size = new System.Drawing.Size(110, 17);
   this.rbtn_fecha.TabIndex = 0;
   this.rbtn_fecha.TabStop = true;
   this.rbtn_fecha.Text = "Fecha De Ingreso";
   this.rbtn_fecha.UseVisualStyleBackColor = true;
   this.rbtn_fecha.Click += new System.EventHandler(this.rbtn_fecha_Click);
   // 
   // rbtn_nequipo
   // 
   this.rbtn_nequipo.AutoSize = true;
   this.rbtn_nequipo.Checked = true;
   this.rbtn_nequipo.Location = new System.Drawing.Point(6, 28);
   this.rbtn_nequipo.Name = "rbtn_nequipo";
   this.rbtn_nequipo.Size = new System.Drawing.Size(115, 17);
   this.rbtn_nequipo.TabIndex = 1;
   this.rbtn_nequipo.TabStop = true;
   this.rbtn_nequipo.Text = "Numero De Equipo";
   this.rbtn_nequipo.UseVisualStyleBackColor = true;
   this.rbtn_nequipo.Click += new System.EventHandler(this.rbtn_nequipo_Click);
   // 
   // rbtn_nservice
   // 
   this.rbtn_nservice.AutoSize = true;
   this.rbtn_nservice.Location = new System.Drawing.Point(127, 28);
   this.rbtn_nservice.Name = "rbtn_nservice";
   this.rbtn_nservice.Size = new System.Drawing.Size(118, 17);
   this.rbtn_nservice.TabIndex = 2;
   this.rbtn_nservice.TabStop = true;
   this.rbtn_nservice.Text = "Numero De Service";
   this.rbtn_nservice.UseVisualStyleBackColor = true;
   this.rbtn_nservice.Click += new System.EventHandler(this.rbtn_nservice_Click);
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(12, 80);
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.Size = new System.Drawing.Size(909, 358);
   this.grd_datos.TabIndex = 1;
   // 
   // ListadoService
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(933, 452);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.gbx_filtros);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "ListadoService";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Listado De Ordenes De Service";
   this.Load += new System.EventHandler(this.ListadoService_Load);
   this.gbx_filtros.ResumeLayout(false);
   this.gbx_filtros.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.GroupBox gbx_filtros;
  private System.Windows.Forms.RadioButton rbtn_nequipo;
  private System.Windows.Forms.RadioButton rbtn_nservice;
  private System.Windows.Forms.RadioButton rbtn_fecha;
  private System.Windows.Forms.DataGridView grd_datos;
 }
}