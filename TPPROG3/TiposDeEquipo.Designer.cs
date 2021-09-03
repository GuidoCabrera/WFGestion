namespace TPPROG3
{
 partial class TiposDeEquipo
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
   this.btn_agregar = new System.Windows.Forms.Button();
   this.btn_quitar = new System.Windows.Forms.Button();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   this.txt_tipo = new System.Windows.Forms.TextBox();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_tipo
   // 
   this.lbl_tipo.AutoSize = true;
   this.lbl_tipo.Location = new System.Drawing.Point(5, 9);
   this.lbl_tipo.Name = "lbl_tipo";
   this.lbl_tipo.Size = new System.Drawing.Size(134, 13);
   this.lbl_tipo.TabIndex = 0;
   this.lbl_tipo.Text = "Ingrese El Tipo De Equipo:";
   // 
   // btn_agregar
   // 
   this.btn_agregar.Location = new System.Drawing.Point(436, 3);
   this.btn_agregar.Name = "btn_agregar";
   this.btn_agregar.Size = new System.Drawing.Size(157, 23);
   this.btn_agregar.TabIndex = 2;
   this.btn_agregar.Text = "Agregar Tipo De Equipo";
   this.btn_agregar.UseVisualStyleBackColor = true;
   this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
   // 
   // btn_quitar
   // 
   this.btn_quitar.Location = new System.Drawing.Point(8, 384);
   this.btn_quitar.Name = "btn_quitar";
   this.btn_quitar.Size = new System.Drawing.Size(157, 23);
   this.btn_quitar.TabIndex = 3;
   this.btn_quitar.Text = "Quitar Tipo De Equipo";
   this.btn_quitar.UseVisualStyleBackColor = true;
   this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(8, 32);
   this.grd_datos.MultiSelect = false;
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.ReadOnly = true;
   this.grd_datos.Size = new System.Drawing.Size(585, 346);
   this.grd_datos.TabIndex = 4;
   // 
   // txt_tipo
   // 
   this.txt_tipo.Location = new System.Drawing.Point(145, 6);
   this.txt_tipo.Name = "txt_tipo";
   this.txt_tipo.Size = new System.Drawing.Size(285, 20);
   this.txt_tipo.TabIndex = 1;
   // 
   // TiposDeEquipo
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(601, 416);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.btn_quitar);
   this.Controls.Add(this.btn_agregar);
   this.Controls.Add(this.txt_tipo);
   this.Controls.Add(this.lbl_tipo);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "TiposDeEquipo";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Tipos De Equipo";
   this.Load += new System.EventHandler(this.TiposDeEquipo_Load);
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_tipo;
  private System.Windows.Forms.Button btn_agregar;
  private System.Windows.Forms.Button btn_quitar;
  private System.Windows.Forms.DataGridView grd_datos;
  private System.Windows.Forms.TextBox txt_tipo;
 }
}