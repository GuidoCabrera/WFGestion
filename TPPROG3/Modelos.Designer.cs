namespace TPPROG3
{
 partial class Modelos
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
   this.lbl_modelo = new System.Windows.Forms.Label();
   this.txt_modelo = new System.Windows.Forms.TextBox();
   this.btn_agregar = new System.Windows.Forms.Button();
   this.btn_quitar = new System.Windows.Forms.Button();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   this.cmbx_marca = new System.Windows.Forms.ComboBox();
   this.cmbx_tipo = new System.Windows.Forms.ComboBox();
   this.lbl_tipo = new System.Windows.Forms.Label();
   this.lbl_marca = new System.Windows.Forms.Label();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_modelo
   // 
   this.lbl_modelo.AutoSize = true;
   this.lbl_modelo.Location = new System.Drawing.Point(12, 9);
   this.lbl_modelo.Name = "lbl_modelo";
   this.lbl_modelo.Size = new System.Drawing.Size(148, 13);
   this.lbl_modelo.TabIndex = 0;
   this.lbl_modelo.Text = "Ingrese El Modelo De Equipo:";
   // 
   // txt_modelo
   // 
   this.txt_modelo.Location = new System.Drawing.Point(175, 5);
   this.txt_modelo.Name = "txt_modelo";
   this.txt_modelo.Size = new System.Drawing.Size(317, 20);
   this.txt_modelo.TabIndex = 1;
   // 
   // btn_agregar
   // 
   this.btn_agregar.Location = new System.Drawing.Point(498, 3);
   this.btn_agregar.Name = "btn_agregar";
   this.btn_agregar.Size = new System.Drawing.Size(105, 23);
   this.btn_agregar.TabIndex = 2;
   this.btn_agregar.Text = "Agregar Modelo";
   this.btn_agregar.UseVisualStyleBackColor = true;
   this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
   // 
   // btn_quitar
   // 
   this.btn_quitar.Location = new System.Drawing.Point(12, 416);
   this.btn_quitar.Name = "btn_quitar";
   this.btn_quitar.Size = new System.Drawing.Size(103, 23);
   this.btn_quitar.TabIndex = 3;
   this.btn_quitar.Text = "Quitar Modelo";
   this.btn_quitar.UseVisualStyleBackColor = true;
   this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(12, 86);
   this.grd_datos.MultiSelect = false;
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.ReadOnly = true;
   this.grd_datos.Size = new System.Drawing.Size(592, 324);
   this.grd_datos.TabIndex = 4;
   // 
   // cmbx_marca
   // 
   this.cmbx_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbx_marca.FormattingEnabled = true;
   this.cmbx_marca.Location = new System.Drawing.Point(175, 32);
   this.cmbx_marca.Name = "cmbx_marca";
   this.cmbx_marca.Size = new System.Drawing.Size(317, 21);
   this.cmbx_marca.TabIndex = 5;
   // 
   // cmbx_tipo
   // 
   this.cmbx_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbx_tipo.FormattingEnabled = true;
   this.cmbx_tipo.Location = new System.Drawing.Point(175, 62);
   this.cmbx_tipo.Name = "cmbx_tipo";
   this.cmbx_tipo.Size = new System.Drawing.Size(317, 21);
   this.cmbx_tipo.TabIndex = 6;
   // 
   // lbl_tipo
   // 
   this.lbl_tipo.AutoSize = true;
   this.lbl_tipo.Location = new System.Drawing.Point(12, 62);
   this.lbl_tipo.Name = "lbl_tipo";
   this.lbl_tipo.Size = new System.Drawing.Size(157, 13);
   this.lbl_tipo.TabIndex = 7;
   this.lbl_tipo.Text = "Seleccione Un Tipo De Equipo:";
   // 
   // lbl_marca
   // 
   this.lbl_marca.AutoSize = true;
   this.lbl_marca.Location = new System.Drawing.Point(12, 35);
   this.lbl_marca.Name = "lbl_marca";
   this.lbl_marca.Size = new System.Drawing.Size(119, 13);
   this.lbl_marca.TabIndex = 8;
   this.lbl_marca.Text = "Seleccione Una Marca:";
   // 
   // Modelos
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(619, 446);
   this.Controls.Add(this.lbl_marca);
   this.Controls.Add(this.lbl_tipo);
   this.Controls.Add(this.cmbx_tipo);
   this.Controls.Add(this.cmbx_marca);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.btn_quitar);
   this.Controls.Add(this.btn_agregar);
   this.Controls.Add(this.txt_modelo);
   this.Controls.Add(this.lbl_modelo);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "Modelos";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Modelos";
   this.Load += new System.EventHandler(this.Modelos_Load);
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_modelo;
  private System.Windows.Forms.TextBox txt_modelo;
  private System.Windows.Forms.Button btn_agregar;
  private System.Windows.Forms.Button btn_quitar;
  private System.Windows.Forms.DataGridView grd_datos;
  private System.Windows.Forms.ComboBox cmbx_marca;
  private System.Windows.Forms.ComboBox cmbx_tipo;
  private System.Windows.Forms.Label lbl_tipo;
  private System.Windows.Forms.Label lbl_marca;
 }
}