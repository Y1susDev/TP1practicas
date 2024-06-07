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
            RecuperoContraseña v2 = new RecuperoContraseña();
            v2.Show();
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
                lblLeyenda.Text = ("debe completar todos los campos");
            }
            else 
            {
                lblLeyenda.Text = ("inicio de sesion exitoso");
            }
            lblLeyenda.Visible = true;        
        }

        private void lnkOlvidoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperoContraseña v3 = new RecuperoContraseña();
            v3.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lnkCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro v1 = new FrmRegistro();
            v1.ShowDialog();
        }
        
    }
    
}
