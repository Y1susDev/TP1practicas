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
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.mskFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnEnviarCodigo
            // 
            this.btnEnviarCodigo.Location = new System.Drawing.Point(427, 225);
            this.btnEnviarCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviarCodigo.Name = "btnEnviarCodigo";
            this.btnEnviarCodigo.Size = new System.Drawing.Size(244, 36);
            this.btnEnviarCodigo.TabIndex = 21;
            this.btnEnviarCodigo.Text = "Enviar codigo";
            this.btnEnviarCodigo.UseVisualStyleBackColor = true;
            this.btnEnviarCodigo.Click += new System.EventHandler(this.btnEnviarCodigo_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(532, 115);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(217, 22);
            this.txtApellido.TabIndex = 18;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoKey);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(532, 84);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 22);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreKey);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(276, 186);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(36, 16);
            this.lblDni.TabIndex = 16;
            this.lblDni.Text = "D.N.I";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(276, 121);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(68, 16);
            this.lblApellido.TabIndex = 15;
            this.lblApellido.Text = "Apellido/s";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(276, 87);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 16);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre/s";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblRecContraseña
            // 
            this.lblRecContraseña.AutoSize = true;
            this.lblRecContraseña.Location = new System.Drawing.Point(13, 34);
            this.lblRecContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecContraseña.Name = "lblRecContraseña";
            this.lblRecContraseña.Size = new System.Drawing.Size(1063, 16);
            this.lblRecContraseña.TabIndex = 13;
            this.lblRecContraseña.Text = "Para continuar con la recuperación de su contraseña o usuario ingrese los datos q" +
    "ue se solicitan a continuación y luego ingrese el código que se le enviara por c" +
    "orreo electrónico";
            this.lblRecContraseña.Click += new System.EventHandler(this.lblRecContraseña_Click);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(276, 153);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(132, 16);
            this.lblFechaNac.TabIndex = 12;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            this.lblFechaNac.Click += new System.EventHandler(this.lblFechaNac_Click);
            // 
            // txtCodigoIngreso
            // 
            this.txtCodigoIngreso.Location = new System.Drawing.Point(567, 284);
            this.txtCodigoIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoIngreso.Name = "txtCodigoIngreso";
            this.txtCodigoIngreso.Size = new System.Drawing.Size(183, 22);
            this.txtCodigoIngreso.TabIndex = 23;
            this.txtCodigoIngreso.TextChanged += new System.EventHandler(this.txtCodigoIngreso_TextChanged);
            // 
            // btnIngresarCodigo
            // 
            this.btnIngresarCodigo.Location = new System.Drawing.Point(427, 340);
            this.btnIngresarCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresarCodigo.Name = "btnIngresarCodigo";
            this.btnIngresarCodigo.Size = new System.Drawing.Size(244, 36);
            this.btnIngresarCodigo.TabIndex = 24;
            this.btnIngresarCodigo.Text = "Ingresar codigo";
            this.btnIngresarCodigo.UseVisualStyleBackColor = true;
            this.btnIngresarCodigo.Click += new System.EventHandler(this.btnIngresarCodigo_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.Location = new System.Drawing.Point(427, 445);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 36);
            this.button1.TabIndex = 41;
            this.button1.Text = "Volver al inicio de sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Location = new System.Drawing.Point(435, 254);
            this.lblLeyenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(0, 16);
            this.lblLeyenda.TabIndex = 42;
            this.lblLeyenda.Visible = false;
            // 
            // lblLeyenda2
            // 
            this.lblLeyenda2.AutoSize = true;
            this.lblLeyenda2.Location = new System.Drawing.Point(513, 402);
            this.lblLeyenda2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeyenda2.Name = "lblLeyenda2";
            this.lblLeyenda2.Size = new System.Drawing.Size(0, 16);
            this.lblLeyenda2.TabIndex = 43;
            this.lblLeyenda2.Visible = false;
            // 
            // lblIngreseCodigo
            // 
            this.lblIngreseCodigo.AutoSize = true;
            this.lblIngreseCodigo.Location = new System.Drawing.Point(276, 288);
            this.lblIngreseCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreseCodigo.Name = "lblIngreseCodigo";
            this.lblIngreseCodigo.Size = new System.Drawing.Size(269, 16);
            this.lblIngreseCodigo.TabIndex = 44;
            this.lblIngreseCodigo.Text = "Ingrese el codigo que se le envio por E-mail";
            // 
            // mskDNI
            // 
            this.mskDNI.Location = new System.Drawing.Point(532, 180);
            this.mskDNI.Mask = "00.000.000";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(79, 22);
            this.mskDNI.TabIndex = 45;
            this.mskDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskFechaNacimiento
            // 
            this.mskFechaNacimiento.Location = new System.Drawing.Point(532, 147);
            this.mskFechaNacimiento.Mask = "00/00/0000";
            this.mskFechaNacimiento.Name = "mskFechaNacimiento";
            this.mskFechaNacimiento.Size = new System.Drawing.Size(79, 22);
            this.mskFechaNacimiento.TabIndex = 46;
            this.mskFechaNacimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // RecuperoContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 494);
            this.Controls.Add(this.mskFechaNacimiento);
            this.Controls.Add(this.mskDNI);
            this.Controls.Add(this.lblIngreseCodigo);
            this.Controls.Add(this.lblLeyenda2);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIngresarCodigo);
            this.Controls.Add(this.txtCodigoIngreso);
            this.Controls.Add(this.btnEnviarCodigo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRecContraseña);
            this.Controls.Add(this.lblFechaNac);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecuperoContraseña";
            this.Text = "Recupero contraseña";
            this.Load += new System.EventHandler(this.RecuperoContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnviarCodigo;
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
        private System.Windows.Forms.MaskedTextBox mskDNI;
        private System.Windows.Forms.MaskedTextBox mskFechaNacimiento;
    }
}