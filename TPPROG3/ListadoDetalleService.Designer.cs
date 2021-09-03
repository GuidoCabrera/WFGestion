namespace TPPROG3
{
 partial class ListadoDetalleService
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
   this.grd_datos = new System.Windows.Forms.DataGridView();
   this.gbx_filtros = new System.Windows.Forms.GroupBox();
   this.rbtn_nservice = new System.Windows.Forms.RadioButton();
   this.rbtn_cliente = new System.Windows.Forms.RadioButton();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.gbx_filtros.SuspendLayout();
   this.SuspendLayout();
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(12, 81);
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.Size = new System.Drawing.Size(684, 357);
   this.grd_datos.TabIndex = 0;
   // 
   // gbx_filtros
   // 
   this.gbx_filtros.Controls.Add(this.rbtn_nservice);
   this.gbx_filtros.Controls.Add(this.rbtn_cliente);
   this.gbx_filtros.Location = new System.Drawing.Point(12, 12);
   this.gbx_filtros.Name = "gbx_filtros";
   this.gbx_filtros.Size = new System.Drawing.Size(684, 63);
   this.gbx_filtros.TabIndex = 1;
   this.gbx_filtros.TabStop = false;
   this.gbx_filtros.Text = "Filtrar Por";
   // 
   // rbtn_nservice
   // 
   this.rbtn_nservice.AutoSize = true;
   this.rbtn_nservice.Location = new System.Drawing.Point(97, 28);
   this.rbtn_nservice.Name = "rbtn_nservice";
   this.rbtn_nservice.Size = new System.Drawing.Size(137, 17);
   this.rbtn_nservice.TabIndex = 3;
   this.rbtn_nservice.Text = "Por Numero De Service";
   this.rbtn_nservice.UseVisualStyleBackColor = true;
   this.rbtn_nservice.Click += new System.EventHandler(this.rbtn_nservice_Click);
   // 
   // rbtn_cliente
   // 
   this.rbtn_cliente.AutoSize = true;
   this.rbtn_cliente.Checked = true;
   this.rbtn_cliente.Location = new System.Drawing.Point(15, 28);
   this.rbtn_cliente.Name = "rbtn_cliente";
   this.rbtn_cliente.Size = new System.Drawing.Size(76, 17);
   this.rbtn_cliente.TabIndex = 2;
   this.rbtn_cliente.TabStop = true;
   this.rbtn_cliente.Text = "Por Cliente";
   this.rbtn_cliente.UseVisualStyleBackColor = true;
   this.rbtn_cliente.Click += new System.EventHandler(this.rbtn_cliente_Click);
   // 
   // ListadoDetalleService
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(706, 450);
   this.Controls.Add(this.gbx_filtros);
   this.Controls.Add(this.grd_datos);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "ListadoDetalleService";
   this.Text = "Listado De Detalles De Service";
   this.Load += new System.EventHandler(this.ListadoDetalleService_Load);
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.gbx_filtros.ResumeLayout(false);
   this.gbx_filtros.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.DataGridView grd_datos;
  private System.Windows.Forms.GroupBox gbx_filtros;
  private System.Windows.Forms.RadioButton rbtn_nservice;
  private System.Windows.Forms.RadioButton rbtn_cliente;
 }
}