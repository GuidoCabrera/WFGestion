namespace TPPROG3
{
 partial class Marcas
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
   this.lbl_marca = new System.Windows.Forms.Label();
   this.txt_marca = new System.Windows.Forms.TextBox();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   this.btn_agregar = new System.Windows.Forms.Button();
   this.btn_quitar = new System.Windows.Forms.Button();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_marca
   // 
   this.lbl_marca.AutoSize = true;
   this.lbl_marca.Location = new System.Drawing.Point(12, 24);
   this.lbl_marca.Name = "lbl_marca";
   this.lbl_marca.Size = new System.Drawing.Size(162, 13);
   this.lbl_marca.TabIndex = 0;
   this.lbl_marca.Text = "Ingrese El Nombre De La Marca:";
   // 
   // txt_marca
   // 
   this.txt_marca.Location = new System.Drawing.Point(180, 24);
   this.txt_marca.Name = "txt_marca";
   this.txt_marca.Size = new System.Drawing.Size(289, 20);
   this.txt_marca.TabIndex = 1;
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(16, 51);
   this.grd_datos.MultiSelect = false;
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.ReadOnly = true;
   this.grd_datos.Size = new System.Drawing.Size(573, 329);
   this.grd_datos.TabIndex = 2;
   // 
   // btn_agregar
   // 
   this.btn_agregar.Location = new System.Drawing.Point(475, 22);
   this.btn_agregar.Name = "btn_agregar";
   this.btn_agregar.Size = new System.Drawing.Size(113, 23);
   this.btn_agregar.TabIndex = 3;
   this.btn_agregar.Text = "Agregar Marca";
   this.btn_agregar.UseVisualStyleBackColor = true;
   this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
   // 
   // btn_quitar
   // 
   this.btn_quitar.Location = new System.Drawing.Point(12, 386);
   this.btn_quitar.Name = "btn_quitar";
   this.btn_quitar.Size = new System.Drawing.Size(113, 23);
   this.btn_quitar.TabIndex = 4;
   this.btn_quitar.Text = "Quitar Marca";
   this.btn_quitar.UseVisualStyleBackColor = true;
   this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
   // 
   // Marcas
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(601, 421);
   this.Controls.Add(this.btn_quitar);
   this.Controls.Add(this.btn_agregar);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.txt_marca);
   this.Controls.Add(this.lbl_marca);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "Marcas";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Marcas";
   this.Load += new System.EventHandler(this.Marcas_Load);
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_marca;
  private System.Windows.Forms.TextBox txt_marca;
  private System.Windows.Forms.DataGridView grd_datos;
  private System.Windows.Forms.Button btn_agregar;
  private System.Windows.Forms.Button btn_quitar;
 }
}