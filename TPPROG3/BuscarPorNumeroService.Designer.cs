namespace TPPROG3
{
 partial class BuscarPorNumeroService
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
   this.lbl_num_service = new System.Windows.Forms.Label();
   this.txt_num_service = new System.Windows.Forms.TextBox();
   this.btn_buscar = new System.Windows.Forms.Button();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_num_service
   // 
   this.lbl_num_service.AutoSize = true;
   this.lbl_num_service.Location = new System.Drawing.Point(9, 9);
   this.lbl_num_service.Name = "lbl_num_service";
   this.lbl_num_service.Size = new System.Drawing.Size(199, 13);
   this.lbl_num_service.TabIndex = 0;
   this.lbl_num_service.Text = "Ingrese El Numero De Service Deseado:";
   // 
   // txt_num_service
   // 
   this.txt_num_service.Location = new System.Drawing.Point(214, 9);
   this.txt_num_service.Name = "txt_num_service";
   this.txt_num_service.Size = new System.Drawing.Size(223, 20);
   this.txt_num_service.TabIndex = 1;
   // 
   // btn_buscar
   // 
   this.btn_buscar.Location = new System.Drawing.Point(443, 7);
   this.btn_buscar.Name = "btn_buscar";
   this.btn_buscar.Size = new System.Drawing.Size(75, 23);
   this.btn_buscar.TabIndex = 2;
   this.btn_buscar.Text = "Buscar";
   this.btn_buscar.UseVisualStyleBackColor = true;
   this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(12, 35);
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.Size = new System.Drawing.Size(656, 168);
   this.grd_datos.TabIndex = 3;
   // 
   // BuscarPorNumeroService
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(679, 215);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.btn_buscar);
   this.Controls.Add(this.txt_num_service);
   this.Controls.Add(this.lbl_num_service);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "BuscarPorNumeroService";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Buscar Service Por Numero De Service";
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_num_service;
  private System.Windows.Forms.TextBox txt_num_service;
  private System.Windows.Forms.Button btn_buscar;
  private System.Windows.Forms.DataGridView grd_datos;
 }
}