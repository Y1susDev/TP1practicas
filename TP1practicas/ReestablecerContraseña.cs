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
    public partial class ReestablecerContraseña : Form
    {
        public ReestablecerContraseña()
        {
            InitializeComponent();
        }

        private void ReestablecerContraseña_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            string password1 = txtConfirm.Text;
            string password2 = txtConfirm2.Text;

            if (string.IsNullOrEmpty(txtConfirm.Text) || string.IsNullOrEmpty(txtConfirm2.Text))
            {
                MessageBox.Show("¡Debe completar todos los campos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtConfirm.Text != txtConfirm2.Text)
            {
                MessageBox.Show("¡Las contraseñas deben ser iguales!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password1.Length < 6 || password2.Length < 6)
            {
                MessageBox.Show("La contraseña no puede ser menor a 6 caracteres", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtConfirm.Text == txtConfirm2.Text)
            {
                MessageBox.Show("¡Se ha restablecido su contraseña exitosamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RecuperoContraseña recupero = new RecuperoContraseña();
            recupero.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pcbMostrar_Click(object sender, EventArgs e)
        {
            pcbOcultar.BringToFront();
            txtConfirm.PasswordChar = '\0';
        }
        private void pcbOcultar_Click_1(object sender, EventArgs e)
        {
            pcbMostrar.BringToFront();
            txtConfirm.PasswordChar = '*';
        }

        private void pcbMostrar1_Click_1(object sender, EventArgs e)
        {
            pcbOcultar1.BringToFront();
            txtConfirm2.PasswordChar = '\0';
        }

        private void pcbOcultar1_Click_1(object sender, EventArgs e)
        {
            pcbMostrar1.BringToFront();
            txtConfirm2.PasswordChar = '*';
        }
        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirm2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
