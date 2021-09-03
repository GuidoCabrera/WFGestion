namespace TPPROG3
{
 partial class TiposDeService
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
   this.lbl_tipo = new System.Windows.Forms.Label();
   this.txt_tipo = new System.Windows.Forms.TextBox();
   this.btn_agregar = new System.Windows.Forms.Button();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   this.btn_quitar = new System.Windows.Forms.Button();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_tipo
   // 
   this.lbl_tipo.AutoSize = true;
   this.lbl_tipo.Location = new System.Drawing.Point(5, 9);
   this.lbl_tipo.Name = "lbl_tipo";
   this.lbl_tipo.Size = new System.Drawing.Size(87, 13);
   this.lbl_tipo.TabIndex = 0;
   this.lbl_tipo.Text = "Tipo De Service:";
   // 
   // txt_tipo
   // 
   this.txt_tipo.Location = new System.Drawing.Point(98, 9);
   this.txt_tipo.Name = "txt_tipo";
   this.txt_tipo.Size = new System.Drawing.Size(385, 20);
   this.txt_tipo.TabIndex = 1;
   // 
   // btn_agregar
   // 
   this.btn_agregar.Location = new System.Drawing.Point(98, 35);
   this.btn_agregar.Name = "btn_agregar";
   this.btn_agregar.Size = new System.Drawing.Size(385, 23);
   this.btn_agregar.TabIndex = 2;
   this.btn_agregar.Text = "Agregar";
   this.btn_agregar.UseVisualStyleBackColor = true;
   this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(8, 76);
   this.grd_datos.MultiSelect = false;
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.ReadOnly = true;
   this.grd_datos.Size = new System.Drawing.Size(475, 299);
   this.grd_datos.TabIndex = 3;
   // 
   // btn_quitar
   // 
   this.btn_quitar.Location = new System.Drawing.Point(8, 381);
   this.btn_quitar.Name = "btn_quitar";
   this.btn_quitar.Size = new System.Drawing.Size(75, 23);
   this.btn_quitar.TabIndex = 4;
   this.btn_quitar.Text = "Quitar";
   this.btn_quitar.UseVisualStyleBackColor = true;
   this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
   // 
   // TiposDeService
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(495, 413);
   this.Controls.Add(this.btn_quitar);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.btn_agregar);
   this.Controls.Add(this.txt_tipo);
   this.Controls.Add(this.lbl_tipo);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "TiposDeService";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Agregar/Quitar Tipo De Service";
   this.Load += new System.EventHandler(this.TiposDeService_Load);
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_tipo;
  private System.Windows.Forms.TextBox txt_tipo;
  private System.Windows.Forms.Button btn_agregar;
  private System.Windows.Forms.DataGridView grd_datos;
  private System.Windows.Forms.Button btn_quitar;
 }
}