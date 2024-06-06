namespace TP1practicas
{
    partial class RecuperoContraseña
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
            this.btnEnviarCodigo = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtFechaNac = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRecContraseña = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtCodigoIngreso = new System.Windows.Forms.TextBox();
            this.btnIngresarCodigo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.lblLeyenda2 = new System.Windows.Forms.Label();
            this.lblIngreseCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviarCodigo
            // 
            this.btnEnviarCodigo.Location = new System.Drawing.Point(316, 169);
            this.btnEnviarCodigo.Name = "btnEnviarCodigo";
            this.btnEnviarCodigo.Size = new System.Drawing.Size(183, 29);
            this.btnEnviarCodigo.TabIndex = 21;
            this.btnEnviarCodigo.Text = "Enviar codigo";
            this.btnEnviarCodigo.UseVisualStyleBackColor = true;
            this.btnEnviarCodigo.Click += new System.EventHandler(this.btnEnviarCodigo_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(399, 143);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(164, 20);
            this.txtDni.TabIndex = 20;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(399, 117);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(164, 20);
            this.txtFechaNac.TabIndex = 19;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(399, 91);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(164, 20);
            this.txtApellido.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(399, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(207, 151);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(32, 13);
            this.lblDni.TabIndex = 16;
            this.lblDni.Text = "D.N.I";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(207, 98);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 15;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(207, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRecContraseña
            // 
            this.lblRecContraseña.AutoSize = true;
            this.lblRecContraseña.Location = new System.Drawing.Point(12, 25);
            this.lblRecContraseña.Name = "lblRecContraseña";
            this.lblRecContraseña.Size = new System.Drawing.Size(777, 13);
            this.lblRecContraseña.TabIndex = 13;
            this.lblRecContraseña.Text = "Para continuar con el recupero de su contraseña y/o usuario ingrese los datos que" +
    " se solicitan a continuacion y luego ingrese el codigo que se le enviara por e-m" +
    "ail";
            this.lblRecContraseña.Click += new System.EventHandler(this.lblRecContraseña_Click);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(207, 124);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNac.TabIndex = 12;
            this.lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // txtCodigoIngreso
            // 
            this.txtCodigoIngreso.Location = new System.Drawing.Point(425, 231);
            this.txtCodigoIngreso.Name = "txtCodigoIngreso";
            this.txtCodigoIngreso.Size = new System.Drawing.Size(138, 20);
            this.txtCodigoIngreso.TabIndex = 23;
            this.txtCodigoIngreso.TextChanged += new System.EventHandler(this.txtCodigoIngreso_TextChanged);
            // 
            // btnIngresarCodigo
            // 
            this.btnIngresarCodigo.Location = new System.Drawing.Point(320, 276);
            this.btnIngresarCodigo.Name = "btnIngresarCodigo";
            this.btnIngresarCodigo.Size = new System.Drawing.Size(183, 29);
            this.btnIngresarCodigo.TabIndex = 24;
            this.btnIngresarCodigo.Text = "Ingresar codigo";
            this.btnIngresarCodigo.UseVisualStyleBackColor = true;
            this.btnIngresarCodigo.Click += new System.EventHandler(this.btnIngresarCodigo_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.Location = new System.Drawing.Point(320, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 29);
            this.button1.TabIndex = 41;
            this.button1.Text = "Volver al inicio de sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Location = new System.Drawing.Point(326, 206);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(0, 13);
            this.lblLeyenda.TabIndex = 42;
            this.lblLeyenda.Visible = false;
            // 
            // lblLeyenda2
            // 
            this.lblLeyenda2.AutoSize = true;
            this.lblLeyenda2.Location = new System.Drawing.Point(385, 327);
            this.lblLeyenda2.Name = "lblLeyenda2";
            this.lblLeyenda2.Size = new System.Drawing.Size(0, 13);
            this.lblLeyenda2.TabIndex = 43;
            this.lblLeyenda2.Visible = false;
            // 
            // lblIngreseCodigo
            // 
            this.lblIngreseCodigo.AutoSize = true;
            this.lblIngreseCodigo.Location = new System.Drawing.Point(207, 234);
            this.lblIngreseCodigo.Name = "lblIngreseCodigo";
            this.lblIngreseCodigo.Size = new System.Drawing.Size(212, 13);
            this.lblIngreseCodigo.TabIndex = 44;
            this.lblIngreseCodigo.Text = "Ingrese el codigo que se le envio por E-mail";
            // 
            // RecuperoContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 401);
            this.Controls.Add(this.lblIngreseCodigo);
            this.Controls.Add(this.lblLeyenda2);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIngresarCodigo);
            this.Controls.Add(this.txtCodigoIngreso);
            this.Controls.Add(this.btnEnviarCodigo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRecContraseña);
            this.Controls.Add(this.lblFechaNac);
            this.Name = "RecuperoContraseña";
            this.Text = "Recupero contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnviarCodigo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtFechaNac;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRecContraseña;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtCodigoIngreso;
        private System.Windows.Forms.Button btnIngresarCodigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Label lblLeyenda2;
        private System.Windows.Forms.Label lblIngreseCodigo;
    }
}