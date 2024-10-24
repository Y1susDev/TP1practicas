using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
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

            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtEmail.Text) || !mskDNI.MaskFull)
            {
                lblLeyenda.Text = ("Debe completar todos los campos");
            }
            else
            {
                lblLeyenda.Text = ("Un código ha sido enviado a su correo electrónico");
                txtCodigo.Enabled = true;
                btnIngresarCodigo.Enabled = true;
            }

            lblLeyenda.Visible = true;
        }

        private void btnIngresarCodigo_Click(object sender, EventArgs e)
        {
            int codigo;

            if (int.TryParse(txtCodigo.Text, out codigo))
            {
                if (codigo == 01234)
                {
                    lblLeyenda.Visible = false;
                    txtUsuario.Clear(); txtEmail.Clear(); mskDNI.Clear();
                    ReestablecerContraseña reestablecer = new ReestablecerContraseña();
                    reestablecer.Show();
                    this.Close();
                }
                else MessageBox.Show("El código es incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("El campo no puede contener letras", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void lblRecContraseña_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void txtUsuarioKey(object sender, KeyPressEventArgs UserKey)
        {
            if (Char.IsLetter(UserKey.KeyChar))
            {
                UserKey.Handled = false;
            }
            else if (Char.IsSeparator(UserKey.KeyChar))
            {
                UserKey.Handled = true;
            }
            else if (Char.IsControl(UserKey.KeyChar))
            {
                UserKey.Handled = false;
            }
            else if (Char.IsNumber(UserKey.KeyChar))
            {
                UserKey.Handled = false;
            }
            else
            {
                UserKey.Handled = true;
            }
        }

        private void mskFechaNacimiento_MaskInputRejected(object sender, MaskInputRejectedEventArgs FechaNacKey)
        {
            
        }

        private void mskDNI_MaskInputRejected(object sender, MaskInputRejectedEventArgs DniKey)
        {
            
        }

        private void lblLeyenda2_Click(object sender, EventArgs e)
        {

        }

        private void lblLeyenda_Click(object sender, EventArgs e)
        {

        }

        private void mskCodigoEnviado_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
        
        private void lblInicieSesion_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            InicioSesion iniciosesion = new InicioSesion();
            iniciosesion.Show();
            this.Close();
        }

        private void btnMinizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblIngreseCodigo_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}            
        
