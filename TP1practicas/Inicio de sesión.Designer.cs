﻿namespace TP1practicas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lnkolvidocontraseña = new System.Windows.Forms.LinkLabel();
            this.lnkCrearCuenta = new System.Windows.Forms.LinkLabel();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.lblInicieSesion = new System.Windows.Forms.Label();
            this.btnMinizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pcbMostrar = new System.Windows.Forms.PictureBox();
            this.pcbOcultar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOcultar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.LightGreen;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(59, 196);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(370, 36);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(188, 148);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(202, 26);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(188, 115);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(238, 26);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(57, 152);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(3);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(92, 20);
            this.lblContraseña.TabIndex = 24;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(57, 119);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(3);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 23;
            this.lblUsuario.Text = "Usuario";
            // 
            // lnkolvidocontraseña
            // 
            this.lnkolvidocontraseña.AutoSize = true;
            this.lnkolvidocontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkolvidocontraseña.Location = new System.Drawing.Point(130, 303);
            this.lnkolvidocontraseña.Margin = new System.Windows.Forms.Padding(3);
            this.lnkolvidocontraseña.Name = "lnkolvidocontraseña";
            this.lnkolvidocontraseña.Size = new System.Drawing.Size(212, 20);
            this.lnkolvidocontraseña.TabIndex = 4;
            this.lnkolvidocontraseña.TabStop = true;
            this.lnkolvidocontraseña.Text = "Olvide mi contraseña/usuario";
            this.lnkolvidocontraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkolvidocontraseña.TabStopChanged += new System.EventHandler(this.lnkolvidocontraseña_TabStopChanged);
            this.lnkolvidocontraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkolvidocontraseña_LinkClicked);
            // 
            // lnkCrearCuenta
            // 
            this.lnkCrearCuenta.AutoSize = true;
            this.lnkCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCrearCuenta.Location = new System.Drawing.Point(172, 335);
            this.lnkCrearCuenta.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.lnkCrearCuenta.Name = "lnkCrearCuenta";
            this.lnkCrearCuenta.Size = new System.Drawing.Size(132, 20);
            this.lnkCrearCuenta.TabIndex = 5;
            this.lnkCrearCuenta.TabStop = true;
            this.lnkCrearCuenta.Text = "Crear una cuenta";
            this.lnkCrearCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkCrearCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCrearCuenta_LinkClicked);
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.ForeColor = System.Drawing.Color.Red;
            this.lblLeyenda.Location = new System.Drawing.Point(59, 252);
            this.lblLeyenda.Margin = new System.Windows.Forms.Padding(3);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(370, 36);
            this.lblLeyenda.TabIndex = 35;
            this.lblLeyenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLeyenda.Visible = false;
            this.lblLeyenda.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblInicieSesion
            // 
            this.lblInicieSesion.AutoSize = true;
            this.lblInicieSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicieSesion.Location = new System.Drawing.Point(53, 61);
            this.lblInicieSesion.Margin = new System.Windows.Forms.Padding(3);
            this.lblInicieSesion.Name = "lblInicieSesion";
            this.lblInicieSesion.Size = new System.Drawing.Size(376, 20);
            this.lblInicieSesion.TabIndex = 51;
            this.lblInicieSesion.Text = "Ingrese su usuario y contraseña para acceder";
            this.lblInicieSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInicieSesion.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnMinizar
            // 
            this.btnMinizar.BackColor = System.Drawing.Color.LightCyan;
            this.btnMinizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinizar.Image")));
            this.btnMinizar.Location = new System.Drawing.Point(312, 3);
            this.btnMinizar.Name = "btnMinizar";
            this.btnMinizar.Size = new System.Drawing.Size(89, 36);
            this.btnMinizar.TabIndex = 50;
            this.btnMinizar.TabStop = false;
            this.btnMinizar.UseVisualStyleBackColor = false;
            this.btnMinizar.Click += new System.EventHandler(this.btnMinizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.MistyRose;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(407, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(89, 36);
            this.btnCerrar.TabIndex = 49;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pcbMostrar
            // 
            this.pcbMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMostrar.Image = global::TP1practicas.Properties.Resources.mostrar2;
            this.pcbMostrar.Location = new System.Drawing.Point(394, 147);
            this.pcbMostrar.Name = "pcbMostrar";
            this.pcbMostrar.Size = new System.Drawing.Size(30, 30);
            this.pcbMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbMostrar.TabIndex = 60;
            this.pcbMostrar.TabStop = false;
            this.pcbMostrar.Click += new System.EventHandler(this.pcbMostrar_Click);
            // 
            // pcbOcultar
            // 
            this.pcbOcultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbOcultar.Image = global::TP1practicas.Properties.Resources.ocultar5;
            this.pcbOcultar.Location = new System.Drawing.Point(394, 147);
            this.pcbOcultar.Name = "pcbOcultar";
            this.pcbOcultar.Size = new System.Drawing.Size(30, 30);
            this.pcbOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbOcultar.TabIndex = 59;
            this.pcbOcultar.TabStop = false;
            this.pcbOcultar.Click += new System.EventHandler(this.pcbOcultar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.btnMinizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 45);
            this.panel1.TabIndex = 61;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(12, 15);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(38, 13);
            this.lblMenu.TabIndex = 51;
            this.lblMenu.Text = "Menú";
            // 
            // InicioSesion
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(499, 441);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pcbMostrar);
            this.Controls.Add(this.pcbOcultar);
            this.Controls.Add(this.lblInicieSesion);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.lnkCrearCuenta);
            this.Controls.Add(this.lnkolvidocontraseña);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOcultar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.LinkLabel lnkolvidocontraseña;
        private System.Windows.Forms.LinkLabel lnkCrearCuenta;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Button btnMinizar;
        private System.Windows.Forms.Label lblInicieSesion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pcbMostrar;
        private System.Windows.Forms.PictureBox pcbOcultar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMenu;
    }
}