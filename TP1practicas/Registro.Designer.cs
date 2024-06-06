namespace TP1practicas
{
    partial class FrmRegistro
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
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtFechaNac = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.txtContraseña1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblContraseña2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContraseña1 = new System.Windows.Forms.Label();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCrearCuenta.Location = new System.Drawing.Point(325, 277);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(183, 29);
            this.btnCrearCuenta.TabIndex = 32;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // txtDni
            // 
            this.txtDni.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtDni.Location = new System.Drawing.Point(407, 152);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(164, 20);
            this.txtDni.TabIndex = 31;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtFechaNac.Location = new System.Drawing.Point(407, 126);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(164, 20);
            this.txtFechaNac.TabIndex = 30;
            // 
            // txtApellido
            // 
            this.txtApellido.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtApellido.Location = new System.Drawing.Point(407, 100);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(164, 20);
            this.txtApellido.TabIndex = 29;
            // 
            // txtNombre
            // 
            this.txtNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtNombre.Location = new System.Drawing.Point(407, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 20);
            this.txtNombre.TabIndex = 28;
            // 
            // lblDni
            // 
            this.lblDni.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(215, 160);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(32, 13);
            this.lblDni.TabIndex = 27;
            this.lblDni.Text = "D.N.I";
            // 
            // lblApellido
            // 
            this.lblApellido.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(215, 107);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 26;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(215, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(237, 34);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(320, 13);
            this.lblRegistro.TabIndex = 24;
            this.lblRegistro.Text = "Para crear una cuenta ingrese los datos solicitados a continuación";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(215, 133);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNac.TabIndex = 23;
            this.lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtContraseña2.Location = new System.Drawing.Point(407, 230);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.Size = new System.Drawing.Size(164, 20);
            this.txtContraseña2.TabIndex = 39;
            // 
            // txtContraseña1
            // 
            this.txtContraseña1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtContraseña1.Location = new System.Drawing.Point(407, 204);
            this.txtContraseña1.Name = "txtContraseña1";
            this.txtContraseña1.Size = new System.Drawing.Size(164, 20);
            this.txtContraseña1.TabIndex = 38;
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtEmail.Location = new System.Drawing.Point(407, 178);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(164, 20);
            this.txtEmail.TabIndex = 37;
            // 
            // lblContraseña2
            // 
            this.lblContraseña2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblContraseña2.AutoSize = true;
            this.lblContraseña2.Location = new System.Drawing.Point(215, 238);
            this.lblContraseña2.Name = "lblContraseña2";
            this.lblContraseña2.Size = new System.Drawing.Size(105, 13);
            this.lblContraseña2.TabIndex = 36;
            this.lblContraseña2.Text = "Repita la contraseña";
            // 
            // lblEmail
            // 
            this.lblEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(215, 185);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(87, 13);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "Ingrese un e-mail";
            // 
            // lblContraseña1
            // 
            this.lblContraseña1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblContraseña1.AutoSize = true;
            this.lblContraseña1.Location = new System.Drawing.Point(215, 211);
            this.lblContraseña1.Name = "lblContraseña1";
            this.lblContraseña1.Size = new System.Drawing.Size(112, 13);
            this.lblContraseña1.TabIndex = 34;
            this.lblContraseña1.Text = "Ingrese su contraseña";
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Location = new System.Drawing.Point(417, 371);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(0, 13);
            this.lblLeyenda.TabIndex = 41;
            this.lblLeyenda.Visible = false;
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnInicioSesion.Location = new System.Drawing.Point(325, 339);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(183, 29);
            this.btnInicioSesion.TabIndex = 42;
            this.btnInicioSesion.Text = "Volver al inicio de sesion";
            this.btnInicioSesion.UseVisualStyleBackColor = true;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.txtContraseña2);
            this.Controls.Add(this.txtContraseña1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblContraseña2);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContraseña1);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblFechaNac);
            this.Name = "FrmRegistro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtFechaNac;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.TextBox txtContraseña1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblContraseña2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContraseña1;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Button btnInicioSesion;
    }
}