using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1practicas
{
    public partial class InicioSesion : Form
    {
       

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void lnkolvidocontraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkolvidocontraseña.TabStop = true;
            RecuperoContraseña recuperocontra = new RecuperoContraseña();
            recuperocontra.Show();
            this.Hide();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            string contraseña = txtContraseña.Text;
           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                lblLeyenda.Text = ("Debe completar todos los campos");
                lblLeyenda.Visible = true;
            }
            else 
            {
                MessageBox.Show("¡Inicio de sesión exitoso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblLeyenda.Visible = false;
                txtUsuario.Clear(); txtContraseña.Clear();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lnkCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro Registro = new FrmRegistro();
            Registro.Show();
            this.Hide();

        }

        private void lblTexto_Click(object sender, EventArgs e)
        {

        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void lnkOlvidoUsuario_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pcbMostrar_Click(object sender, EventArgs e)
        {
            pcbOcultar.BringToFront();
            txtContraseña.PasswordChar = '\0';
        }

        private void pcbOcultar_Click(object sender, EventArgs e)
        {
            pcbMostrar.BringToFront();
            txtContraseña.PasswordChar = '*';
        }

        private void lnkolvidocontraseña_TabStopChanged(object sender, EventArgs e)
        {

        }
    }
    
}
