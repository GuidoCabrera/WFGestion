namespace TPPROG3
{
 partial class CalculoIngresos
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
   this.lbl_cantidad_service = new System.Windows.Forms.Label();
   this.lbl_total_recaudado = new System.Windows.Forms.Label();
   this.txt_cantidad = new System.Windows.Forms.TextBox();
   this.txt_recaudacion = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // lbl_cantidad_service
   // 
   this.lbl_cantidad_service.AutoSize = true;
   this.lbl_cantidad_service.Location = new System.Drawing.Point(26, 31);
   this.lbl_cantidad_service.Name = "lbl_cantidad_service";
   this.lbl_cantidad_service.Size = new System.Drawing.Size(158, 13);
   this.lbl_cantidad_service.TabIndex = 0;
   this.lbl_cantidad_service.Text = "Cantidad De Service realizados:";
   // 
   // lbl_total_recaudado
   // 
   this.lbl_total_recaudado.AutoSize = true;
   this.lbl_total_recaudado.Location = new System.Drawing.Point(26, 57);
   this.lbl_total_recaudado.Name = "lbl_total_recaudado";
   this.lbl_total_recaudado.Size = new System.Drawing.Size(108, 13);
   this.lbl_total_recaudado.TabIndex = 1;
   this.lbl_total_recaudado.Text = "Total Recaudado ($):";
   // 
   // txt_cantidad
   // 
   this.txt_cantidad.Location = new System.Drawing.Point(190, 28);
   this.txt_cantidad.Name = "txt_cantidad";
   this.txt_cantidad.ReadOnly = true;
   this.txt_cantidad.Size = new System.Drawing.Size(169, 20);
   this.txt_cantidad.TabIndex = 2;
   this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // txt_recaudacion
   // 
   this.txt_recaudacion.Location = new System.Drawing.Point(190, 54);
   this.txt_recaudacion.Name = "txt_recaudacion";
   this.txt_recaudacion.ReadOnly = true;
   this.txt_recaudacion.Size = new System.Drawing.Size(169, 20);
   this.txt_recaudacion.TabIndex = 3;
   this.txt_recaudacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // CalculoIngresos
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(406, 115);
   this.Controls.Add(this.txt_recaudacion);
   this.Controls.Add(this.txt_cantidad);
   this.Controls.Add(this.lbl_total_recaudado);
   this.Controls.Add(this.lbl_cantidad_service);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "CalculoIngresos";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Calculo De Ingresos ($)";
   this.Load += new System.EventHandler(this.CalculoIngresos_Load);
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_cantidad_service;
  private System.Windows.Forms.Label lbl_total_recaudado;
  private System.Windows.Forms.TextBox txt_cantidad;
  private System.Windows.Forms.TextBox txt_recaudacion;
 }
}