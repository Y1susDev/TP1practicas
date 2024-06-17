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

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || !mskFechaNacimiento.MaskFull || !mskDNI.MaskFull)
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
            if (!mskCodigoEnviado.MaskFull)
            {
                MessageBox.Show("¡Se ha restablecido su usuario/contraseña exitosamente!",
                    "Reestablemiento usuario/contraseña",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

        private void txtNombreKey(object sender, KeyPressEventArgs NombreKey)
        {
            if (Char.IsLetter(NombreKey.KeyChar))
            {
                NombreKey.Handled = false;
            }
            else if (Char.IsSeparator(NombreKey.KeyChar))
            {
                NombreKey.Handled = false;
            }
            else if (Char.IsControl(NombreKey.KeyChar))
            {
                NombreKey.Handled = false;
            }
            else
            {
                NombreKey.Handled = true;
            }
        }

        private void mskFechaNacimiento_MaskInputRejected(object sender, MaskInputRejectedEventArgs FechaNacKey)
        {

        }

        private void mskDNI_MaskInputRejected(object sender, MaskInputRejectedEventArgs DniKey)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblLeyenda2_Click(object sender, EventArgs e)
        {

        }
    }
}            
        
