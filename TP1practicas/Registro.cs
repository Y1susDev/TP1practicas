using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1practicas
{
    public partial class FrmRegistro : Form
    {

        // CREAMOS LISTA PERSONAS
        public FrmRegistro()
        {
            InitializeComponent();
            //INICIALIZAMOS LA LISTA
            Icon icono = new Icon(Application.StartupPath + @"\Iconos\herramienta.ico");
            this.Icon = icono;
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string fechanacimiento = mskFechaNac.Text;
            string dni = mskDni.Text;
            string email = txtEmail.Text;
            string contraseña1 = txtContraseña1.Text;
            string contraseña2 = txtContraseña2.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(fechanacimiento) || string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contraseña1) || string.IsNullOrEmpty(contraseña2))
            {
                lblLeyenda.Text = ("Complete todos los campos");
            }
            else
            {
                MessageBox.Show("¡Se cuenta se ha creado exitosamente!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblLeyenda.Visible = true;
            //CARGAMOS LA LISTA
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs nptNombre)
        {
            if (Char.IsLetter(nptNombre.KeyChar))
            {
                nptNombre.Handled = false;
            }
            else if (Char.IsSeparator(nptNombre.KeyChar))
            {
                nptNombre.Handled = false;
            }
            else if (Char.IsControl(nptNombre.KeyChar))
            {
                nptNombre.Handled = false;
            }
            else
            {
                nptNombre.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs nptApellido)
        {
            if (Char.IsLetter(nptApellido.KeyChar))
            {
                nptApellido.Handled = false;
            }
            else if (Char.IsSeparator(nptApellido.KeyChar))
            {
                nptApellido.Handled = false;
            }
            else if (Char.IsControl(nptApellido.KeyChar))
            {
                nptApellido.Handled = false;
            }
            else
            {
                nptApellido.Handled = true;
            }
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnCerrar3_Click(object sender, EventArgs e)
        {
            InicioSesion iniciosesion = new InicioSesion();
            iniciosesion.Show();
            this.Close();
        }

        private void btnMinizar3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblContraseña1_Click(object sender, EventArgs e)
        {

        }

        private void pcbMostrar_Click(object sender, EventArgs e)
        {
            pcbOcultar.BringToFront();
            txtContraseña1.PasswordChar = '\0';
        }

        private void pcbOcultar_Click(object sender, EventArgs e)
        {
            pcbMostrar.BringToFront();
            txtContraseña1.PasswordChar = '*';

        }

        private void pcbMostrar1_Click(object sender, EventArgs e)
        {
            pcbOcultar1.BringToFront();
            txtContraseña2.PasswordChar = '\0';
        }

        private void pcbOcultar1_Click(object sender, EventArgs e)
        {
            pcbMostrar1.BringToFront();
            txtContraseña2.PasswordChar = '*';
        }
    }
}
