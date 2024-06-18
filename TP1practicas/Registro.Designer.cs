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
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.txtContraseña1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblContraseña2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContraseña1 = new System.Windows.Forms.Label();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.mskFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.mskDni = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtApellido.Location = new System.Drawing.Point(367, 126);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(217, 22);
            this.txtApellido.TabIndex = 29;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtNombre.Location = new System.Drawing.Point(367, 93);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 22);
            this.txtNombre.TabIndex = 28;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblDni
            // 
            this.lblDni.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(111, 200);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(36, 16);
            this.lblDni.TabIndex = 27;
            this.lblDni.Text = "D.N.I";
            // 
            // lblApellido
            // 
            this.lblApellido.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(111, 135);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 26;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(111, 101);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(111, 167);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(135, 16);
            this.lblFechaNac.TabIndex = 23;
            this.lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtContraseña2.Location = new System.Drawing.Point(367, 286);
            this.txtContraseña2.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.PasswordChar = '*';
            this.txtContraseña2.Size = new System.Drawing.Size(217, 22);
            this.txtContraseña2.TabIndex = 39;
            // 
            // txtContraseña1
            // 
            this.txtContraseña1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtContraseña1.Location = new System.Drawing.Point(367, 254);
            this.txtContraseña1.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña1.Name = "txtContraseña1";
            this.txtContraseña1.PasswordChar = '*';
            this.txtContraseña1.Size = new System.Drawing.Size(217, 22);
            this.txtContraseña1.TabIndex = 38;
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtEmail.Location = new System.Drawing.Point(367, 222);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 22);
            this.txtEmail.TabIndex = 37;
            // 
            // lblContraseña2
            // 
            this.lblContraseña2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblContraseña2.AutoSize = true;
            this.lblContraseña2.Location = new System.Drawing.Point(111, 296);
            this.lblContraseña2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña2.Name = "lblContraseña2";
            this.lblContraseña2.Size = new System.Drawing.Size(131, 16);
            this.lblContraseña2.TabIndex = 36;
            this.lblContraseña2.Text = "Repita la contraseña";
            // 
            // lblEmail
            // 
            this.lblEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(111, 231);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(109, 16);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "Ingrese un e-mail";
            // 
            // lblContraseña1
            // 
            this.lblContraseña1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblContraseña1.AutoSize = true;
            this.lblContraseña1.Location = new System.Drawing.Point(111, 263);
            this.lblContraseña1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña1.Name = "lblContraseña1";
            this.lblContraseña1.Size = new System.Drawing.Size(139, 16);
            this.lblContraseña1.TabIndex = 34;
            this.lblContraseña1.Text = "Ingrese su contraseña";
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Location = new System.Drawing.Point(156, 413);
            this.lblLeyenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(0, 16);
            this.lblLeyenda.TabIndex = 41;
            this.lblLeyenda.Visible = false;
            // 
            // mskFechaNac
            // 
            this.mskFechaNac.Location = new System.Drawing.Point(367, 155);
            this.mskFechaNac.Mask = "00/00/0000";
            this.mskFechaNac.Name = "mskFechaNac";
            this.mskFechaNac.Size = new System.Drawing.Size(91, 22);
            this.mskFechaNac.TabIndex = 44;
            this.mskFechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // mskDni
            // 
            this.mskDni.Location = new System.Drawing.Point(367, 193);
            this.mskDni.Mask = "00.000.000";
            this.mskDni.Name = "mskDni";
            this.mskDni.Size = new System.Drawing.Size(91, 22);
            this.mskDni.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(111, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Para crear una cuenta ingrese los datos solicitados a continuación:";
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCrearCuenta.Location = new System.Drawing.Point(254, 341);
            this.btnCrearCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(154, 36);
            this.btnCrearCuenta.TabIndex = 47;
            this.btnCrearCuenta.Text = "Crear Cuenta Nueva";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            this.btnCrearCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCrearCuenta_KeyPress);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 451);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskDni);
            this.Controls.Add(this.mskFechaNac);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.txtContraseña2);
            this.Controls.Add(this.txtContraseña1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblContraseña2);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContraseña1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFechaNac);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.TextBox txtContraseña1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblContraseña2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContraseña1;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.MaskedTextBox mskFechaNac;
        private System.Windows.Forms.MaskedTextBox mskDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearCuenta;
    }
}