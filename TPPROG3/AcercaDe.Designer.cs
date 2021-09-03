namespace TPPROG3
{
 partial class AcercaDe
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
   this.rchtxt_acerca_de = new System.Windows.Forms.RichTextBox();
   this.SuspendLayout();
   // 
   // rchtxt_acerca_de
   // 
   this.rchtxt_acerca_de.Font = new System.Drawing.Font("Modern No. 20", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.rchtxt_acerca_de.Location = new System.Drawing.Point(12, 12);
   this.rchtxt_acerca_de.Name = "rchtxt_acerca_de";
   this.rchtxt_acerca_de.ReadOnly = true;
   this.rchtxt_acerca_de.Size = new System.Drawing.Size(547, 424);
   this.rchtxt_acerca_de.TabIndex = 0;
   this.rchtxt_acerca_de.Text = "Desarrolladores:\n\nGuido Cabrera\n\nMarcelo Bokor\n\nEmilio Gabriel Perotti\n\n\nFecha De" +
    " Publicacion: 16/07/2018";
   // 
   // AcercaDe
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(571, 448);
   this.Controls.Add(this.rchtxt_acerca_de);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.Name = "AcercaDe";
   this.Text = "Acerca De.....";
   this.Load += new System.EventHandler(this.AcercaDe_Load);
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.RichTextBox rchtxt_acerca_de;
 }
}