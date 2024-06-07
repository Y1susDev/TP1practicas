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
            string fechanac = txtFechaNac.Text;
            string dni = txtDni.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(fechanac) || string.IsNullOrEmpty(dni))
            { 
                lblLeyenda.Text = ("debe completar todos los campos, revise si no quedaron campos incompletos o vacios y completelos");
            }
            else 
            {
                lblLeyenda.Text = ("revise su correo electronico e ingrese a continuacion el codigo que se le envio"); 
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
}
}            
        
