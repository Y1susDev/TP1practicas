using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1practicas
{
    public partial class RecuperoContraseña : Form
    {
        public RecuperoContraseña()
        {
            InitializeComponent();
        }

        private void txtCodigoIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string fechanac = mskFechaNacimiento.Text;
            string dni = mskDNI.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(fechanac) || string.IsNullOrEmpty(dni))
            {
                lblLeyenda.Text = ("Debe completar todos los campos");
            }
            else
            {
                lblLeyenda.Text = ("Revise su correo electrónico e ingrese a continuación el código que se le envió");
            }


            lblLeyenda.Visible = true;
        }

        private void btnIngresarCodigo_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoIngreso.Text;

            if (string.IsNullOrEmpty(codigo))
            {
                lblLeyenda2.Text = ("ingrese un codigo");
            }
            else
            {
                lblLeyenda2.Text = ("se ha reestablecido su usuario y contraseña, vuelva al menu de inicio de sesion e ingrese nuevamente");
            }
            lblLeyenda2.Visible = true;
        }

        private void lblRecContraseña_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioSesion v4 = new InicioSesion();
            v4.ShowDialog();

        }

        private void RecuperoContraseña_Load(object sender, EventArgs e)
        {

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaNac_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaNac_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtApellidoKey(object sender, KeyPressEventArgs ApellidoKey)
        {
            if (Char.IsLetter(ApellidoKey.KeyChar))
            {
                ApellidoKey.Handled = false;
            }
            else if (Char.IsSeparator(ApellidoKey.KeyChar))
            {
                ApellidoKey.Handled = false;
            }
            else if (Char.IsControl(ApellidoKey.KeyChar))
            {
                ApellidoKey.Handled = false;
            }
            else
            {
                ApellidoKey.Handled = true;
            }
        }

        private void txtNombreKey(object sender, KeyPressEventArgs e)
        {

        }
    }
}            
        
