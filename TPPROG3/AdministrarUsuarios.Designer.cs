namespace TPPROG3
{
 partial class AdministrarUsuarios
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
   this.btn_agregar = new System.Windows.Forms.Button();
   this.btn_quitar = new System.Windows.Forms.Button();
   this.lbl_nombre = new System.Windows.Forms.Label();
   this.btn_realizar_cambios = new System.Windows.Forms.Button();
   this.lbl_password = new System.Windows.Forms.Label();
   this.txt_password = new System.Windows.Forms.TextBox();
   this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
   this.chbx_lectura = new System.Windows.Forms.CheckBox();
   this.chbx_escritura = new System.Windows.Forms.CheckBox();
   this.chbx_admin = new System.Windows.Forms.CheckBox();
   this.lbl_estado_1 = new System.Windows.Forms.Label();
   this.lbl_estado_2 = new System.Windows.Forms.Label();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(12, 123);
   this.grd_datos.MultiSelect = false;
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.ReadOnly = true;
   this.grd_datos.Size = new System.Drawing.Size(693, 308);
   this.grd_datos.TabIndex = 0;
   this.grd_datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_datos_CellClick);
   // 
   // btn_agregar
   // 
   this.btn_agregar.Location = new System.Drawing.Point(120, 58);
   this.btn_agregar.Name = "btn_agregar";
   this.btn_agregar.Size = new System.Drawing.Size(204, 23);
   this.btn_agregar.TabIndex = 1;
   this.btn_agregar.Text = "Agregar Usuario";
   this.btn_agregar.UseVisualStyleBackColor = true;
   this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
   // 
   // btn_quitar
   // 
   this.btn_quitar.Location = new System.Drawing.Point(12, 437);
   this.btn_quitar.Name = "btn_quitar";
   this.btn_quitar.Size = new System.Drawing.Size(168, 23);
   this.btn_quitar.TabIndex = 2;
   this.btn_quitar.Text = "Quitar Usuario";
   this.btn_quitar.UseVisualStyleBackColor = true;
   this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
   // 
   // lbl_nombre
   // 
   this.lbl_nombre.AutoSize = true;
   this.lbl_nombre.Location = new System.Drawing.Point(9, 9);
   this.lbl_nombre.Name = "lbl_nombre";
   this.lbl_nombre.Size = new System.Drawing.Size(105, 13);
   this.lbl_nombre.TabIndex = 3;
   this.lbl_nombre.Text = "Nombre Del Usuario:";
   // 
   // btn_realizar_cambios
   // 
   this.btn_realizar_cambios.Location = new System.Drawing.Point(186, 437);
   this.btn_realizar_cambios.Name = "btn_realizar_cambios";
   this.btn_realizar_cambios.Size = new System.Drawing.Size(173, 23);
   this.btn_realizar_cambios.TabIndex = 4;
   this.btn_realizar_cambios.Text = "Realizar Cambios";
   this.btn_realizar_cambios.UseVisualStyleBackColor = true;
   this.btn_realizar_cambios.Click += new System.EventHandler(this.btn_realizar_cambios_Click);
   // 
   // lbl_password
   // 
   this.lbl_password.AutoSize = true;
   this.lbl_password.Location = new System.Drawing.Point(9, 35);
   this.lbl_password.Name = "lbl_password";
   this.lbl_password.Size = new System.Drawing.Size(93, 13);
   this.lbl_password.TabIndex = 5;
   this.lbl_password.Text = "Clave De Usuario:";
   // 
   // txt_password
   // 
   this.txt_password.Location = new System.Drawing.Point(120, 32);
   this.txt_password.Name = "txt_password";
   this.txt_password.PasswordChar = '#';
   this.txt_password.Size = new System.Drawing.Size(204, 20);
   this.txt_password.TabIndex = 6;
   // 
   // txt_nombre_usuario
   // 
   this.txt_nombre_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
   this.txt_nombre_usuario.Location = new System.Drawing.Point(120, 6);
   this.txt_nombre_usuario.Name = "txt_nombre_usuario";
   this.txt_nombre_usuario.Size = new System.Drawing.Size(204, 20);
   this.txt_nombre_usuario.TabIndex = 7;
   // 
   // chbx_lectura
   // 
   this.chbx_lectura.AutoSize = true;
   this.chbx_lectura.Checked = true;
   this.chbx_lectura.CheckState = System.Windows.Forms.CheckState.Checked;
   this.chbx_lectura.Location = new System.Drawing.Point(12, 100);
   this.chbx_lectura.Name = "chbx_lectura";
   this.chbx_lectura.Size = new System.Drawing.Size(62, 17);
   this.chbx_lectura.TabIndex = 8;
   this.chbx_lectura.Text = "Lectura";
   this.chbx_lectura.UseVisualStyleBackColor = true;
   this.chbx_lectura.Click += new System.EventHandler(this.chbx_lectura_Click);
   // 
   // chbx_escritura
   // 
   this.chbx_escritura.AutoSize = true;
   this.chbx_escritura.Location = new System.Drawing.Point(82, 100);
   this.chbx_escritura.Name = "chbx_escritura";
   this.chbx_escritura.Size = new System.Drawing.Size(67, 17);
   this.chbx_escritura.TabIndex = 9;
   this.chbx_escritura.Text = "Escritura";
   this.chbx_escritura.UseVisualStyleBackColor = true;
   this.chbx_escritura.Click += new System.EventHandler(this.chbx_escritura_Click);
   // 
   // chbx_admin
   // 
   this.chbx_admin.AutoSize = true;
   this.chbx_admin.Location = new System.Drawing.Point(155, 100);
   this.chbx_admin.Name = "chbx_admin";
   this.chbx_admin.Size = new System.Drawing.Size(89, 17);
   this.chbx_admin.TabIndex = 10;
   this.chbx_admin.Text = "Administrador";
   this.chbx_admin.UseVisualStyleBackColor = true;
   this.chbx_admin.Click += new System.EventHandler(this.chbx_admin_Click);
   // 
   // lbl_estado_1
   // 
   this.lbl_estado_1.AutoSize = true;
   this.lbl_estado_1.Location = new System.Drawing.Point(397, 13);
   this.lbl_estado_1.Name = "lbl_estado_1";
   this.lbl_estado_1.Size = new System.Drawing.Size(108, 13);
   this.lbl_estado_1.TabIndex = 11;
   this.lbl_estado_1.Text = "Estado 1 = Habilitado";
   // 
   // lbl_estado_2
   // 
   this.lbl_estado_2.AutoSize = true;
   this.lbl_estado_2.Location = new System.Drawing.Point(397, 32);
   this.lbl_estado_2.Name = "lbl_estado_2";
   this.lbl_estado_2.Size = new System.Drawing.Size(125, 13);
   this.lbl_estado_2.TabIndex = 12;
   this.lbl_estado_2.Text = "Estado 2 = No Habilitado";
   // 
   // AdministrarUsuarios
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(717, 469);
   this.Controls.Add(this.lbl_estado_2);
   this.Controls.Add(this.lbl_estado_1);
   this.Controls.Add(this.chbx_admin);
   this.Controls.Add(this.chbx_escritura);
   this.Controls.Add(this.chbx_lectura);
   this.Controls.Add(this.txt_nombre_usuario);
   this.Controls.Add(this.txt_password);
   this.Controls.Add(this.lbl_password);
   this.Controls.Add(this.btn_realizar_cambios);
   this.Controls.Add(this.lbl_nombre);
   this.Controls.Add(this.btn_quitar);
   this.Controls.Add(this.btn_agregar);
   this.Controls.Add(this.grd_datos);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "AdministrarUsuarios";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Administrar Usuarios";
   this.Load += new System.EventHandler(this.AdministrarUsuarios_Load);
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.DataGridView grd_datos;
  private System.Windows.Forms.Button btn_agregar;
  private System.Windows.Forms.Button btn_quitar;
  private System.Windows.Forms.Label lbl_nombre;
  private System.Windows.Forms.Button btn_realizar_cambios;
  private System.Windows.Forms.Label lbl_password;
  private System.Windows.Forms.TextBox txt_password;
  private System.Windows.Forms.TextBox txt_nombre_usuario;
  private System.Windows.Forms.CheckBox chbx_lectura;
  private System.Windows.Forms.CheckBox chbx_escritura;
  private System.Windows.Forms.CheckBox chbx_admin;
  private System.Windows.Forms.Label lbl_estado_1;
  private System.Windows.Forms.Label lbl_estado_2;
 }
}