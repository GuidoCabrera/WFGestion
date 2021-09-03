namespace TPPROG3
{
 partial class BuscarPorMarca
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
   this.btn_buscar = new System.Windows.Forms.Button();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   this.cmbx_marca = new System.Windows.Forms.ComboBox();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // btn_buscar
   // 
   this.btn_buscar.Location = new System.Drawing.Point(304, 9);
   this.btn_buscar.Name = "btn_buscar";
   this.btn_buscar.Size = new System.Drawing.Size(75, 23);
   this.btn_buscar.TabIndex = 0;
   this.btn_buscar.Text = "Buscar";
   this.btn_buscar.UseVisualStyleBackColor = true;
   this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(12, 51);
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.Size = new System.Drawing.Size(787, 264);
   this.grd_datos.TabIndex = 3;
   // 
   // cmbx_marca
   // 
   this.cmbx_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbx_marca.FormattingEnabled = true;
   this.cmbx_marca.Location = new System.Drawing.Point(12, 9);
   this.cmbx_marca.Name = "cmbx_marca";
   this.cmbx_marca.Size = new System.Drawing.Size(286, 21);
   this.cmbx_marca.TabIndex = 4;
   // 
   // BuscarPorMarca
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.SystemColors.ControlDark;
   this.ClientSize = new System.Drawing.Size(811, 332);
   this.Controls.Add(this.cmbx_marca);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.btn_buscar);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MinimizeBox = false;
   this.Name = "BuscarPorMarca";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Buscar Equipo Por Marca";
   this.Load += new System.EventHandler(this.BuscarPorMarca_Load);
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btn_buscar;
  private System.Windows.Forms.DataGridView grd_datos;
  private System.Windows.Forms.ComboBox cmbx_marca;
 }
}