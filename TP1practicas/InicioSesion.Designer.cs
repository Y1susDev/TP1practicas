namespace TP1practicas
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lnkolvidocontraseña = new System.Windows.Forms.LinkLabel();
            this.lnkCrearCuenta = new System.Windows.Forms.LinkLabel();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(130, 203);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(195, 34);
            this.btnIngresar.TabIndex = 30;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(175, 118);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(217, 22);
            this.txtContraseña.TabIndex = 27;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(175, 85);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(217, 22);
            this.txtUsuario.TabIndex = 26;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(27, 122);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(76, 16);
            this.lblContraseña.TabIndex = 24;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(27, 89);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 23;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(64, 42);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(309, 16);
            this.lblTexto.TabIndex = 31;
            this.lblTexto.Text = "Para iniciar sesión ingrese su usuario y contraseña";
            this.lblTexto.Click += new System.EventHandler(this.lblTexto_Click);
            // 
            // lnkolvidocontraseña
            // 
            this.lnkolvidocontraseña.AutoSize = true;
            this.lnkolvidocontraseña.Location = new System.Drawing.Point(127, 304);
            this.lnkolvidocontraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkolvidocontraseña.Name = "lnkolvidocontraseña";
            this.lnkolvidocontraseña.Size = new System.Drawing.Size(181, 16);
            this.lnkolvidocontraseña.TabIndex = 32;
            this.lnkolvidocontraseña.TabStop = true;
            this.lnkolvidocontraseña.Text = "Olvide mi contraseña/usuario";
            this.lnkolvidocontraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkolvidocontraseña_LinkClicked);
            // 
            // lnkCrearCuenta
            // 
            this.lnkCrearCuenta.AutoSize = true;
            this.lnkCrearCuenta.Location = new System.Drawing.Point(165, 335);
            this.lnkCrearCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkCrearCuenta.Name = "lnkCrearCuenta";
            this.lnkCrearCuenta.Size = new System.Drawing.Size(108, 16);
            this.lnkCrearCuenta.TabIndex = 34;
            this.lnkCrearCuenta.TabStop = true;
            this.lnkCrearCuenta.Text = "Crear una cuenta";
            this.lnkCrearCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCrearCuenta_LinkClicked);
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Location = new System.Drawing.Point(204, 167);
            this.lblLeyenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(0, 16);
            this.lblLeyenda.TabIndex = 35;
            this.lblLeyenda.Visible = false;
            this.lblLeyenda.Click += new System.EventHandler(this.label1_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 373);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.lnkCrearCuenta);
            this.Controls.Add(this.lnkolvidocontraseña);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InicioSesion";
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.LinkLabel lnkolvidocontraseña;
        private System.Windows.Forms.LinkLabel lnkCrearCuenta;
        private System.Windows.Forms.Label lblLeyenda;
    }
}