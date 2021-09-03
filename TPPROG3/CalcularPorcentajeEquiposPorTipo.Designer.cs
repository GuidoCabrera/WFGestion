namespace TPPROG3
{
 partial class CalcularPorcentajeEquiposPorTipo
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
   this.lbl_porcentaje = new System.Windows.Forms.Label();
   this.txt_porcentaje = new System.Windows.Forms.TextBox();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(29, 46);
   this.grd_datos.MultiSelect = false;
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.ReadOnly = true;
   this.grd_datos.Size = new System.Drawing.Size(600, 278);
   this.grd_datos.TabIndex = 0;
   this.grd_datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_datos_CellClick);
   // 
   // lbl_porcentaje
   // 
   this.lbl_porcentaje.AutoSize = true;
   this.lbl_porcentaje.Location = new System.Drawing.Point(26, 356);
   this.lbl_porcentaje.Name = "lbl_porcentaje";
   this.lbl_porcentaje.Size = new System.Drawing.Size(188, 13);
   this.lbl_porcentaje.TabIndex = 1;
   this.lbl_porcentaje.Text = "Porcentaje Que Representa Del Total:";
   // 
   // txt_porcentaje
   // 
   this.txt_porcentaje.Location = new System.Drawing.Point(220, 353);
   this.txt_porcentaje.Name = "txt_porcentaje";
   this.txt_porcentaje.ReadOnly = true;
   this.txt_porcentaje.Size = new System.Drawing.Size(160, 20);
   this.txt_porcentaje.TabIndex = 2;
   // 
   // CalcularPorcentajeEquiposPorTipo
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(641, 402);
   this.Controls.Add(this.txt_porcentaje);
   this.Controls.Add(this.lbl_porcentaje);
   this.Controls.Add(this.grd_datos);
   this.ForeColor = System.Drawing.Color.Black;
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "CalcularPorcentajeEquiposPorTipo";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Calcular Porcentaje De Equipos Por Tipo";
   this.Load += new System.EventHandler(this.CalcularCantidadEquipoPorTipo_Load);
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.DataGridView grd_datos;
  private System.Windows.Forms.Label lbl_porcentaje;
  private System.Windows.Forms.TextBox txt_porcentaje;
 }
}