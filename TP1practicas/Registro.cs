using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1practicas
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string fechanacimiento = txtFechaNac.Text;
            string dni = txtDni.Text;
            string email = txtEmail.Text;
            string contraseña1 = txtContraseña1.Text;
            string contraseña2 = txtContraseña2.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(fechanacimiento) || string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contraseña1) || string.IsNullOrEmpty(contraseña2))
            {
                lblLeyenda.Text = ("debe completar todos los campos, revise si hay algun campo incompleto");
            }
            else
            {
                lblLeyenda.Text = ("Carga exitosa");
            }
            lblLeyenda.Visible = true;

        }

        
private void btnInicioSesion_Click(object sender, EventArgs e)
        {

        }
    }
    }

