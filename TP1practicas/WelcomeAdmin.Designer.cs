﻿namespace TP1practicas
{
    partial class WelcomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgCambios = new System.Windows.Forms.DataGridView();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblTipoUser = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnSubirArchivo = new System.Windows.Forms.Button();
            this.pctAdmin = new System.Windows.Forms.PictureBox();
            this.btnMinizar2 = new System.Windows.Forms.Button();
            this.btnCerrar2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCambios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdmin)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Administrador";
            // 
            // dtgCambios
            // 
            this.dtgCambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCambios.GridColor = System.Drawing.Color.LightGray;
            this.dtgCambios.Location = new System.Drawing.Point(15, 304);
            this.dtgCambios.Name = "dtgCambios";
            this.dtgCambios.RowHeadersWidth = 51;
            this.dtgCambios.RowTemplate.Height = 24;
            this.dtgCambios.Size = new System.Drawing.Size(773, 234);
            this.dtgCambios.TabIndex = 1;
            this.dtgCambios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(309, 269);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(449, 25);
            this.lblAdmin.TabIndex = 57;
            this.lblAdmin.Text = "Utilice la siguiente grilla para gestionar los cambios";
            // 
            // lblTipoUser
            // 
            this.lblTipoUser.AutoSize = true;
            this.lblTipoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUser.Location = new System.Drawing.Point(396, 190);
            this.lblTipoUser.Name = "lblTipoUser";
            this.lblTipoUser.Size = new System.Drawing.Size(246, 25);
            this.lblTipoUser.TabIndex = 58;
            this.lblTipoUser.Text = "Usuario tipo: Administrador";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(351, 107);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(350, 38);
            this.lblWelcome.TabIndex = 59;
            this.lblWelcome.Text = "¡Bienvenido, \"USER\"!";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(15, 546);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(195, 32);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.White;
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Location = new System.Drawing.Point(593, 546);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(195, 32);
            this.btnHistorial.TabIndex = 2;
            this.btnHistorial.Text = "Historial de cambios";
            this.btnHistorial.UseVisualStyleBackColor = false;
            // 
            // btnSubirArchivo
            // 
            this.btnSubirArchivo.BackColor = System.Drawing.Color.White;
            this.btnSubirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirArchivo.Location = new System.Drawing.Point(305, 546);
            this.btnSubirArchivo.Name = "btnSubirArchivo";
            this.btnSubirArchivo.Size = new System.Drawing.Size(195, 32);
            this.btnSubirArchivo.TabIndex = 3;
            this.btnSubirArchivo.Text = "Subir archivo";
            this.btnSubirArchivo.UseVisualStyleBackColor = false;
            // 
            // pctAdmin
            // 
            this.pctAdmin.BackColor = System.Drawing.Color.Transparent;
            this.pctAdmin.ErrorImage = null;
            this.pctAdmin.Image = global::TP1practicas.Properties.Resources.admin;
            this.pctAdmin.Location = new System.Drawing.Point(15, 49);
            this.pctAdmin.Name = "pctAdmin";
            this.pctAdmin.Size = new System.Drawing.Size(250, 250);
            this.pctAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctAdmin.TabIndex = 63;
            this.pctAdmin.TabStop = false;
            // 
            // btnMinizar2
            // 
            this.btnMinizar2.BackColor = System.Drawing.Color.LightCyan;
            this.btnMinizar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinizar2.Image = ((System.Drawing.Image)(resources.GetObject("btnMinizar2.Image")));
            this.btnMinizar2.Location = new System.Drawing.Point(613, 4);
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
            this.btnCerrar2.Location = new System.Drawing.Point(708, 4);
            this.btnCerrar2.Name = "btnCerrar2";
            this.btnCerrar2.Size = new System.Drawing.Size(89, 36);
            this.btnCerrar2.TabIndex = 51;
            this.btnCerrar2.TabStop = false;
            this.btnCerrar2.UseVisualStyleBackColor = false;
            this.btnCerrar2.Click += new System.EventHandler(this.btnCerrar2_Click);
            // 
            // WelcomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.ControlBox = false;
            this.Controls.Add(this.pctAdmin);
            this.Controls.Add(this.btnSubirArchivo);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblTipoUser);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.dtgCambios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCambios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinizar2;
        private System.Windows.Forms.Button btnCerrar2;
        private System.Windows.Forms.DataGridView dtgCambios;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblTipoUser;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnSubirArchivo;
        private System.Windows.Forms.PictureBox pctAdmin;
    }
}