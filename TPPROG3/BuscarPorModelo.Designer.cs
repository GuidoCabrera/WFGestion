namespace TPPROG3
{
 partial class BuscarPorModelo
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
   this.btn_buscar = new System.Windows.Forms.Button();
   this.cmbx_modelo = new System.Windows.Forms.ComboBox();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(12, 51);
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.Size = new System.Drawing.Size(819, 264);
   this.grd_datos.TabIndex = 7;
   // 
   // btn_buscar
   // 
   this.btn_buscar.Location = new System.Drawing.Point(324, 9);
   this.btn_buscar.Name = "btn_buscar";
   this.btn_buscar.Size = new System.Drawing.Size(75, 23);
   this.btn_buscar.TabIndex = 5;
   this.btn_buscar.Text = "Buscar";
   this.btn_buscar.UseVisualStyleBackColor = true;
   this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
   // 
   // cmbx_modelo
   // 
   this.cmbx_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbx_modelo.FormattingEnabled = true;
   this.cmbx_modelo.Location = new System.Drawing.Point(12, 9);
   this.cmbx_modelo.Name = "cmbx_modelo";
   this.cmbx_modelo.Size = new System.Drawing.Size(306, 21);
   this.cmbx_modelo.TabIndex = 8;
   // 
   // BuscarPorModelo
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(843, 328);
   this.Controls.Add(this.cmbx_modelo);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.btn_buscar);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "BuscarPorModelo";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Buscar Equipo Por Modelo";
   this.Load += new System.EventHandler(this.BuscarPorModelo_Load);
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion
  private System.Windows.Forms.DataGridView grd_datos;
  private System.Windows.Forms.Button btn_buscar;
  private System.Windows.Forms.ComboBox cmbx_modelo;
 }
}