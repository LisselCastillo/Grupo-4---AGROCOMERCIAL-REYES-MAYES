using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pantalla_1
{
    public partial class frmLogin : Form
    {
        clsEmpleado empleado = new clsEmpleado();
        clsConexionBD conex = new clsConexionBD();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conex.AbrirConexion();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            clsValidaciones validacion = new clsValidaciones();

            if (validacion.Espacio_Blanco(errorProvider1, txtContraseña) || validacion.Espacio_Blanco(errorProvider1, txtUsuario))
            {
                if (validacion.Espacio_Blanco(errorProvider1, txtContraseña))
                {
                    if (!validacion.Espacio_Blanco(errorProvider1, txtUsuario))
                    {
                        errorProvider1.SetError(txtUsuario, "");
                    }
                    errorProvider1.SetError(txtContraseña, "No se ingreso una contraseña.");
                }
                if (validacion.Espacio_Blanco(errorProvider1, txtUsuario))
                {
                    if (!validacion.Espacio_Blanco(errorProvider1, txtContraseña))
                    {
                        errorProvider1.SetError(txtContraseña, "");
                    }
                    errorProvider1.SetError(txtUsuario, "No se ingreso un usuario.");
                }
            }
            else
            {
                empleado.Nombre_Usuario = txtUsuario.Text;
                empleado.Codigo_Usuario = txtContraseña.Text;

                //--------------------sql-----------------------------------
                //se usa la funcion verificacion de usuario y contraseña para pasar a la siguiente ventana
                if (empleado.autentificacion() == true)
                {
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                    txtUsuario.Focus();

                    try
                    {
                        this.Hide();                     
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else
                {
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                    txtUsuario.Focus();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Consulte al administrador o encargado de gestionar contraseñas", "AGROCOMERCIAL REYES MAYES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtContraseña.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();

        }
    }
}

