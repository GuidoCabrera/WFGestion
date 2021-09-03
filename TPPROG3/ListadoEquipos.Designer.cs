namespace TPPROG3
{
 partial class ListadoEquipos
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
   this.rbtn_dni = new System.Windows.Forms.RadioButton();
   this.rbtn_nequipo = new System.Windows.Forms.RadioButton();
   this.rbtn_nserie = new System.Windows.Forms.RadioButton();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   this.lbl_cantidad_equipos = new System.Windows.Forms.Label();
   this.txt_cantidad_equipos = new System.Windows.Forms.TextBox();
   this.gbx_filtros.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // gbx_filtros
   // 
   this.gbx_filtros.Controls.Add(this.rbtn_dni);
   this.gbx_filtros.Controls.Add(this.rbtn_nequipo);
   this.gbx_filtros.Controls.Add(this.rbtn_nserie);
   this.gbx_filtros.Location = new System.Drawing.Point(12, 12);
   this.gbx_filtros.Name = "gbx_filtros";
   this.gbx_filtros.Size = new System.Drawing.Size(347, 72);
   this.gbx_filtros.TabIndex = 0;
   this.gbx_filtros.TabStop = false;
   this.gbx_filtros.Text = "Ordenar Por";
   // 
   // rbtn_dni
   // 
   this.rbtn_dni.AutoSize = true;
   this.rbtn_dni.Location = new System.Drawing.Point(240, 32);
   this.rbtn_dni.Name = "rbtn_dni";
   this.rbtn_dni.Size = new System.Drawing.Size(98, 17);
   this.rbtn_dni.TabIndex = 2;
   this.rbtn_dni.Text = "DNI Del Dueño";
   this.rbtn_dni.UseVisualStyleBackColor = true;
   this.rbtn_dni.CheckedChanged += new System.EventHandler(this.rbtn_dni_CheckedChanged);
   // 
   // rbtn_nequipo
   // 
   this.rbtn_nequipo.AutoSize = true;
   this.rbtn_nequipo.Location = new System.Drawing.Point(118, 32);
   this.rbtn_nequipo.Name = "rbtn_nequipo";
   this.rbtn_nequipo.Size = new System.Drawing.Size(115, 17);
   this.rbtn_nequipo.TabIndex = 1;
   this.rbtn_nequipo.Text = "Numero De Equipo";
   this.rbtn_nequipo.UseVisualStyleBackColor = true;
   this.rbtn_nequipo.CheckedChanged += new System.EventHandler(this.rbtn_nequipo_CheckedChanged);
   // 
   // rbtn_nserie
   // 
   this.rbtn_nserie.AutoSize = true;
   this.rbtn_nserie.Checked = true;
   this.rbtn_nserie.Location = new System.Drawing.Point(6, 32);
   this.rbtn_nserie.Name = "rbtn_nserie";
   this.rbtn_nserie.Size = new System.Drawing.Size(106, 17);
   this.rbtn_nserie.TabIndex = 0;
   this.rbtn_nserie.TabStop = true;
   this.rbtn_nserie.Text = "Numero De Serie";
   this.rbtn_nserie.UseVisualStyleBackColor = true;
   this.rbtn_nserie.CheckedChanged += new System.EventHandler(this.rbtn_nserie_CheckedChanged);
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.GridColor = System.Drawing.SystemColors.Window;
   this.grd_datos.Location = new System.Drawing.Point(12, 111);
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.ReadOnly = true;
   this.grd_datos.Size = new System.Drawing.Size(984, 438);
   this.grd_datos.TabIndex = 1;
   // 
   // lbl_cantidad_equipos
   // 
   this.lbl_cantidad_equipos.AutoSize = true;
   this.lbl_cantidad_equipos.Location = new System.Drawing.Point(376, 31);
   this.lbl_cantidad_equipos.Name = "lbl_cantidad_equipos";
   this.lbl_cantidad_equipos.Size = new System.Drawing.Size(107, 13);
   this.lbl_cantidad_equipos.TabIndex = 2;
   this.lbl_cantidad_equipos.Text = "Cantidad De Equipos";
   // 
   // txt_cantidad_equipos
   // 
   this.txt_cantidad_equipos.Location = new System.Drawing.Point(489, 28);
   this.txt_cantidad_equipos.Name = "txt_cantidad_equipos";
   this.txt_cantidad_equipos.ReadOnly = true;
   this.txt_cantidad_equipos.Size = new System.Drawing.Size(217, 20);
   this.txt_cantidad_equipos.TabIndex = 3;
   // 
   // ListadoEquipos
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(1008, 561);
   this.Controls.Add(this.txt_cantidad_equipos);
   this.Controls.Add(this.lbl_cantidad_equipos);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.gbx_filtros);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "ListadoEquipos";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Listado De  Equipos";
   this.Load += new System.EventHandler(this.ListadoEquipos_Load);
   this.gbx_filtros.ResumeLayout(false);
   this.gbx_filtros.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.GroupBox gbx_filtros;
  private System.Windows.Forms.DataGridView grd_datos;
  private System.Windows.Forms.RadioButton rbtn_dni;
  private System.Windows.Forms.RadioButton rbtn_nequipo;
  private System.Windows.Forms.RadioButton rbtn_nserie;
  private System.Windows.Forms.Label lbl_cantidad_equipos;
  private System.Windows.Forms.TextBox txt_cantidad_equipos;
 }
}