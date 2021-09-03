namespace TPPROG3
{
 partial class BuscarServicePorCliente
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
   this.lbl_cliente = new System.Windows.Forms.Label();
   this.btn_buscar = new System.Windows.Forms.Button();
   this.cmbx_dni = new System.Windows.Forms.ComboBox();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_cliente
   // 
   this.lbl_cliente.AutoSize = true;
   this.lbl_cliente.Location = new System.Drawing.Point(12, 9);
   this.lbl_cliente.Name = "lbl_cliente";
   this.lbl_cliente.Size = new System.Drawing.Size(64, 13);
   this.lbl_cliente.TabIndex = 0;
   this.lbl_cliente.Text = "DNI Cliente:";
   // 
   // btn_buscar
   // 
   this.btn_buscar.Location = new System.Drawing.Point(417, 7);
   this.btn_buscar.Name = "btn_buscar";
   this.btn_buscar.Size = new System.Drawing.Size(75, 23);
   this.btn_buscar.TabIndex = 2;
   this.btn_buscar.Text = "Buscar";
   this.btn_buscar.UseVisualStyleBackColor = true;
   this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
   // 
   // cmbx_dni
   // 
   this.cmbx_dni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbx_dni.FormattingEnabled = true;
   this.cmbx_dni.Location = new System.Drawing.Point(82, 9);
   this.cmbx_dni.Name = "cmbx_dni";
   this.cmbx_dni.Size = new System.Drawing.Size(329, 21);
   this.cmbx_dni.TabIndex = 4;
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(15, 36);
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.Size = new System.Drawing.Size(724, 306);
   this.grd_datos.TabIndex = 5;
   // 
   // BuscarServicePorCliente
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(751, 354);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.cmbx_dni);
   this.Controls.Add(this.btn_buscar);
   this.Controls.Add(this.lbl_cliente);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "BuscarServicePorCliente";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Buscar Service Por Cliente";
   this.Load += new System.EventHandler(this.BuscarServicePorCliente_Load);
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_cliente;
  private System.Windows.Forms.Button btn_buscar;
  private System.Windows.Forms.ComboBox cmbx_dni;
  private System.Windows.Forms.DataGridView grd_datos;
 }
}