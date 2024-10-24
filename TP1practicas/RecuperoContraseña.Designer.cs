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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.btnIngresarCodigo = new System.Windows.Forms.Button();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.lblIngreseCodigo = new System.Windows.Forms.Label();
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.lblInicieSesion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.pctCandado = new System.Windows.Forms.PictureBox();
            this.pctKey = new System.Windows.Forms.PictureBox();
            this.btnMinizar2 = new System.Windows.Forms.Button();
            this.btnCerrar2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCandado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKey)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviarCodigo
            // 
            this.btnEnviarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCodigo.Location = new System.Drawing.Point(15, 257);
            this.btnEnviarCodigo.Name = "btnEnviarCodigo";
            this.btnEnviarCodigo.Size = new System.Drawing.Size(440, 36);
            this.btnEnviarCodigo.TabIndex = 4;
            this.btnEnviarCodigo.Text = "Enviar código";
            this.btnEnviarCodigo.UseVisualStyleBackColor = true;
            this.btnEnviarCodigo.Click += new System.EventHandler(this.btnEnviarCodigo_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(238, 114);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(217, 30);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioKey);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(10, 216);
            this.lblDni.Margin = new System.Windows.Forms.Padding(3);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(55, 25);
            this.lblDni.TabIndex = 16;
            this.lblDni.Text = "D.N.I";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(10, 117);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(3);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 25);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsuario.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(10, 166);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(3);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(173, 25);
            this.lblFechaNac.TabIndex = 12;
            this.lblFechaNac.Text = "Correo Electronico";
            this.lblFechaNac.Click += new System.EventHandler(this.lblFechaNac_Click);
            // 
            // btnIngresarCodigo
            // 
            this.btnIngresarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnIngresarCodigo.Enabled = false;
            this.btnIngresarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarCodigo.Location = new System.Drawing.Point(15, 404);
            this.btnIngresarCodigo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.btnIngresarCodigo.Name = "btnIngresarCodigo";
            this.btnIngresarCodigo.Size = new System.Drawing.Size(440, 36);
            this.btnIngresarCodigo.TabIndex = 6;
            this.btnIngresarCodigo.Text = "Aceptar";
            this.btnIngresarCodigo.UseVisualStyleBackColor = false;
            this.btnIngresarCodigo.Click += new System.EventHandler(this.btnIngresarCodigo_Click);
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.ForeColor = System.Drawing.Color.Red;
            this.lblLeyenda.Location = new System.Drawing.Point(15, 308);
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
            this.lblIngreseCodigo.Location = new System.Drawing.Point(10, 364);
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
            this.mskDNI.Location = new System.Drawing.Point(238, 213);
            this.mskDNI.Mask = "00.000.000";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(97, 30);
            this.mskDNI.TabIndex = 3;
            this.mskDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskDNI.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDNI_MaskInputRejected);
            // 
            // lblInicieSesion
            // 
            this.lblInicieSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicieSesion.Location = new System.Drawing.Point(-22, 51);
            this.lblInicieSesion.Margin = new System.Windows.Forms.Padding(3);
            this.lblInicieSesion.Name = "lblInicieSesion";
            this.lblInicieSesion.Size = new System.Drawing.Size(515, 55);
            this.lblInicieSesion.TabIndex = 53;
            this.lblInicieSesion.Text = "Ingrese los datos solicitados para enviar un código de recuperación a su correo e" +
    "lectrónico\r\n";
            this.lblInicieSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInicieSesion.Click += new System.EventHandler(this.lblInicieSesion_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMinizar2);
            this.panel1.Controls.Add(this.btnCerrar2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 45);
            this.panel1.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Recuperación";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(238, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 30);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(236, 361);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(217, 30);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // pctCandado
            // 
            this.pctCandado.Image = global::TP1practicas.Properties.Resources.candado;
            this.pctCandado.Location = new System.Drawing.Point(473, 257);
            this.pctCandado.Name = "pctCandado";
            this.pctCandado.Size = new System.Drawing.Size(150, 150);
            this.pctCandado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCandado.TabIndex = 56;
            this.pctCandado.TabStop = false;
            // 
            // pctKey
            // 
            this.pctKey.Image = global::TP1practicas.Properties.Resources.key;
            this.pctKey.Location = new System.Drawing.Point(473, 86);
            this.pctKey.Name = "pctKey";
            this.pctKey.Size = new System.Drawing.Size(150, 150);
            this.pctKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctKey.TabIndex = 55;
            this.pctKey.TabStop = false;
            // 
            // btnMinizar2
            // 
            this.btnMinizar2.BackColor = System.Drawing.Color.LightCyan;
            this.btnMinizar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinizar2.Image = ((System.Drawing.Image)(resources.GetObject("btnMinizar2.Image")));
            this.btnMinizar2.Location = new System.Drawing.Point(453, 5);
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
            this.btnCerrar2.Location = new System.Drawing.Point(548, 5);
            this.btnCerrar2.Name = "btnCerrar2";
            this.btnCerrar2.Size = new System.Drawing.Size(89, 36);
            this.btnCerrar2.TabIndex = 51;
            this.btnCerrar2.TabStop = false;
            this.btnCerrar2.UseVisualStyleBackColor = false;
            this.btnCerrar2.Click += new System.EventHandler(this.btnCerrar2_Click);
            // 
            // RecuperoContraseña
            // 
            this.AcceptButton = this.btnEnviarCodigo;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(640, 444);
            this.ControlBox = false;
            this.Controls.Add(this.pctCandado);
            this.Controls.Add(this.pctKey);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInicieSesion);
            this.Controls.Add(this.mskDNI);
            this.Controls.Add(this.lblIngreseCodigo);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.btnIngresarCodigo);
            this.Controls.Add(this.btnEnviarCodigo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblFechaNac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecuperoContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperación";
            this.Load += new System.EventHandler(this.RecuperoContraseña_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCandado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnviarCodigo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Button btnIngresarCodigo;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Label lblIngreseCodigo;
        private System.Windows.Forms.MaskedTextBox mskDNI;
        private System.Windows.Forms.Button btnMinizar2;
        private System.Windows.Forms.Button btnCerrar2;
        private System.Windows.Forms.Label lblInicieSesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.PictureBox pctKey;
        private System.Windows.Forms.PictureBox pctCandado;
    }
}