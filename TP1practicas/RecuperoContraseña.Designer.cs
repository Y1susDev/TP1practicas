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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperoContraseña));
            this.btnEnviarCodigo = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.btnIngresarCodigo = new System.Windows.Forms.Button();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.lblIngreseCodigo = new System.Windows.Forms.Label();
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.mskFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.mskCodigoEnviado = new System.Windows.Forms.MaskedTextBox();
            this.lblInicieSesion = new System.Windows.Forms.Label();
            this.btnMinizar2 = new System.Windows.Forms.Button();
            this.btnCerrar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnviarCodigo
            // 
            this.btnEnviarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCodigo.Location = new System.Drawing.Point(189, 257);
            this.btnEnviarCodigo.Name = "btnEnviarCodigo";
            this.btnEnviarCodigo.Size = new System.Drawing.Size(440, 36);
            this.btnEnviarCodigo.TabIndex = 5;
            this.btnEnviarCodigo.Text = "Enviar código";
            this.btnEnviarCodigo.UseVisualStyleBackColor = true;
            this.btnEnviarCodigo.Click += new System.EventHandler(this.btnEnviarCodigo_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(412, 148);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(217, 30);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoKey);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(412, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 30);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreKey);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(184, 216);
            this.lblDni.Margin = new System.Windows.Forms.Padding(3);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(55, 25);
            this.lblDni.TabIndex = 16;
            this.lblDni.Text = "D.N.I";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(184, 151);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(3);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(98, 25);
            this.lblApellido.TabIndex = 15;
            this.lblApellido.Text = "Apellido/s";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(184, 117);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(3);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 25);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre/s";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(184, 183);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(3);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(193, 25);
            this.lblFechaNac.TabIndex = 12;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            this.lblFechaNac.Click += new System.EventHandler(this.lblFechaNac_Click);
            // 
            // btnIngresarCodigo
            // 
            this.btnIngresarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnIngresarCodigo.Enabled = false;
            this.btnIngresarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarCodigo.Location = new System.Drawing.Point(189, 404);
            this.btnIngresarCodigo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.btnIngresarCodigo.Name = "btnIngresarCodigo";
            this.btnIngresarCodigo.Size = new System.Drawing.Size(440, 36);
            this.btnIngresarCodigo.TabIndex = 7;
            this.btnIngresarCodigo.Text = "Reestablecer";
            this.btnIngresarCodigo.UseVisualStyleBackColor = false;
            this.btnIngresarCodigo.Click += new System.EventHandler(this.btnIngresarCodigo_Click);
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.Location = new System.Drawing.Point(189, 308);
            this.lblLeyenda.Margin = new System.Windows.Forms.Padding(3);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(438, 36);
            this.lblLeyenda.TabIndex = 42;
            this.lblLeyenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLeyenda.Visible = false;
            this.lblLeyenda.Click += new System.EventHandler(this.lblLeyenda_Click);
            // 
            // lblIngreseCodigo
            // 
            this.lblIngreseCodigo.AutoSize = true;
            this.lblIngreseCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseCodigo.Location = new System.Drawing.Point(184, 359);
            this.lblIngreseCodigo.Margin = new System.Windows.Forms.Padding(3);
            this.lblIngreseCodigo.Name = "lblIngreseCodigo";
            this.lblIngreseCodigo.Size = new System.Drawing.Size(160, 25);
            this.lblIngreseCodigo.TabIndex = 44;
            this.lblIngreseCodigo.Text = "Ingrese el código\r\n";
            this.lblIngreseCodigo.Click += new System.EventHandler(this.lblIngreseCodigo_Click);
            // 
            // mskDNI
            // 
            this.mskDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDNI.Location = new System.Drawing.Point(412, 213);
            this.mskDNI.Mask = "00.000.000";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(97, 30);
            this.mskDNI.TabIndex = 4;
            this.mskDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskDNI.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDNI_MaskInputRejected);
            // 
            // mskFechaNacimiento
            // 
            this.mskFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFechaNacimiento.Location = new System.Drawing.Point(412, 180);
            this.mskFechaNacimiento.Mask = "00/00/0000";
            this.mskFechaNacimiento.Name = "mskFechaNacimiento";
            this.mskFechaNacimiento.Size = new System.Drawing.Size(97, 30);
            this.mskFechaNacimiento.TabIndex = 3;
            this.mskFechaNacimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskFechaNacimiento.ValidatingType = typeof(System.DateTime);
            this.mskFechaNacimiento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskFechaNacimiento_MaskInputRejected);
            // 
            // mskCodigoEnviado
            // 
            this.mskCodigoEnviado.Enabled = false;
            this.mskCodigoEnviado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCodigoEnviado.Location = new System.Drawing.Point(412, 359);
            this.mskCodigoEnviado.Mask = "00000";
            this.mskCodigoEnviado.Name = "mskCodigoEnviado";
            this.mskCodigoEnviado.Size = new System.Drawing.Size(97, 30);
            this.mskCodigoEnviado.TabIndex = 6;
            this.mskCodigoEnviado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCodigoEnviado.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCodigoEnviado_MaskInputRejected);
            // 
            // lblInicieSesion
            // 
            this.lblInicieSesion.AutoSize = true;
            this.lblInicieSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicieSesion.Location = new System.Drawing.Point(40, 61);
            this.lblInicieSesion.Margin = new System.Windows.Forms.Padding(3);
            this.lblInicieSesion.Name = "lblInicieSesion";
            this.lblInicieSesion.Size = new System.Drawing.Size(885, 25);
            this.lblInicieSesion.TabIndex = 53;
            this.lblInicieSesion.Text = "Ingrese los datos solicitados para enviar un código de recuperación a su correo e" +
    "lectrónico\r\n";
            this.lblInicieSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInicieSesion.Click += new System.EventHandler(this.lblInicieSesion_Click);
            // 
            // btnMinizar2
            // 
            this.btnMinizar2.BackColor = System.Drawing.Color.LightCyan;
            this.btnMinizar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinizar2.Image = ((System.Drawing.Image)(resources.GetObject("btnMinizar2.Image")));
            this.btnMinizar2.Location = new System.Drawing.Point(633, 2);
            this.btnMinizar2.Name = "btnMinizar2";
            this.btnMinizar2.Size = new System.Drawing.Size(89, 36);
            this.btnMinizar2.TabIndex = 52;
            this.btnMinizar2.TabStop = false;
            this.btnMinizar2.UseVisualStyleBackColor = false;
            this.btnMinizar2.Click += new System.EventHandler(this.btnMinizar2_Click);
            // 
            // btnCerrar2
            // 
            this.btnCerrar2.BackColor = System.Drawing.Color.MistyRose;
            this.btnCerrar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar2.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar2.Image")));
            this.btnCerrar2.Location = new System.Drawing.Point(728, 2);
            this.btnCerrar2.Name = "btnCerrar2";
            this.btnCerrar2.Size = new System.Drawing.Size(89, 36);
            this.btnCerrar2.TabIndex = 51;
            this.btnCerrar2.TabStop = false;
            this.btnCerrar2.UseVisualStyleBackColor = false;
            this.btnCerrar2.Click += new System.EventHandler(this.btnCerrar2_Click);
            // 
            // RecuperoContraseña
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(819, 444);
            this.ControlBox = false;
            this.Controls.Add(this.lblInicieSesion);
            this.Controls.Add(this.btnMinizar2);
            this.Controls.Add(this.btnCerrar2);
            this.Controls.Add(this.mskCodigoEnviado);
            this.Controls.Add(this.mskFechaNacimiento);
            this.Controls.Add(this.mskDNI);
            this.Controls.Add(this.lblIngreseCodigo);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.btnIngresarCodigo);
            this.Controls.Add(this.btnEnviarCodigo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFechaNac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecuperoContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperación";
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
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Button btnIngresarCodigo;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Label lblIngreseCodigo;
        private System.Windows.Forms.MaskedTextBox mskDNI;
        private System.Windows.Forms.MaskedTextBox mskFechaNacimiento;
        private System.Windows.Forms.MaskedTextBox mskCodigoEnviado;
        private System.Windows.Forms.Button btnMinizar2;
        private System.Windows.Forms.Button btnCerrar2;
        private System.Windows.Forms.Label lblInicieSesion;
    }
}