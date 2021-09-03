namespace TPPROG3
{
 partial class InicioSesion
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
   this.cmbx_usuario = new System.Windows.Forms.ComboBox();
   this.lbl_usuario = new System.Windows.Forms.Label();
   this.lbl_password = new System.Windows.Forms.Label();
   this.txt_password = new System.Windows.Forms.TextBox();
   this.btn_ingresar = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // cmbx_usuario
   // 
   this.cmbx_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbx_usuario.FormattingEnabled = true;
   this.cmbx_usuario.Location = new System.Drawing.Point(191, 18);
   this.cmbx_usuario.Name = "cmbx_usuario";
   this.cmbx_usuario.Size = new System.Drawing.Size(217, 21);
   this.cmbx_usuario.TabIndex = 0;
   // 
   // lbl_usuario
   // 
   this.lbl_usuario.AutoSize = true;
   this.lbl_usuario.Location = new System.Drawing.Point(12, 21);
   this.lbl_usuario.Name = "lbl_usuario";
   this.lbl_usuario.Size = new System.Drawing.Size(173, 13);
   this.lbl_usuario.TabIndex = 1;
   this.lbl_usuario.Text = "Seleccione El Nombre Del Usuario:";
   // 
   // lbl_password
   // 
   this.lbl_password.AutoSize = true;
   this.lbl_password.Location = new System.Drawing.Point(12, 63);
   this.lbl_password.Name = "lbl_password";
   this.lbl_password.Size = new System.Drawing.Size(146, 13);
   this.lbl_password.TabIndex = 2;
   this.lbl_password.Text = "Ingrese La Clave De Usuario:";
   // 
   // txt_password
   // 
   this.txt_password.Location = new System.Drawing.Point(191, 63);
   this.txt_password.Name = "txt_password";
   this.txt_password.PasswordChar = '#';
   this.txt_password.Size = new System.Drawing.Size(217, 20);
   this.txt_password.TabIndex = 3;
   // 
   // btn_ingresar
   // 
   this.btn_ingresar.Location = new System.Drawing.Point(306, 106);
   this.btn_ingresar.Name = "btn_ingresar";
   this.btn_ingresar.Size = new System.Drawing.Size(102, 23);
   this.btn_ingresar.TabIndex = 4;
   this.btn_ingresar.Text = "Iniciar Sesion";
   this.btn_ingresar.UseVisualStyleBackColor = true;
   this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
   // 
   // InicioSesion
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(432, 141);
   this.Controls.Add(this.btn_ingresar);
   this.Controls.Add(this.txt_password);
   this.Controls.Add(this.lbl_password);
   this.Controls.Add(this.lbl_usuario);
   this.Controls.Add(this.cmbx_usuario);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "InicioSesion";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Inicio De Sesion";
   this.Load += new System.EventHandler(this.InicioSesion_Load);
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.ComboBox cmbx_usuario;
  private System.Windows.Forms.Label lbl_usuario;
  private System.Windows.Forms.Label lbl_password;
  private System.Windows.Forms.TextBox txt_password;
  private System.Windows.Forms.Button btn_ingresar;
 }
}