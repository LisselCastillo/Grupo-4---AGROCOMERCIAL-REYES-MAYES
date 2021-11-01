using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pantalla_1
{
    public class clsEmpleado : clsConexionBD
    {
        private static int id_Usuario;
        private static int id_Ingreso;
        private static string nombre_Usuario;
        private static string apellido_Usuario;
        private static string codigo_Usuario;
        private static string id_TipoUsuario;
        private static int telefono_Usuario;
        private static string email_Usuario;
        private static string direccion_Usuario;

        public int Id_Usuario { get => id_Usuario; set => id_Usuario = value; }
        public int Id_Ingreso { get => id_Ingreso; set => id_Ingreso = value; }
        public string Nombre_Usuario { get => nombre_Usuario; set => nombre_Usuario = value; }
        public string Apellido_Usuario { get => apellido_Usuario; set => apellido_Usuario = value; }
        public string Codigo_Usuario { get => codigo_Usuario; set => codigo_Usuario = value; }
        public string Id_TipoUsuario { get => id_TipoUsuario; set => id_TipoUsuario = value; }
        public int Telefono_Usuario { get => telefono_Usuario; set => telefono_Usuario = value; }
        public string Email_Usuario { get => email_Usuario; set => email_Usuario = value; }
        public string Direccion_Usuario { get => direccion_Usuario; set => direccion_Usuario = value; }

        //--------------------sql-----------------------------------
        //se utiliza para verificar el usuario y contraseña con la Base de datos
        public bool autentificacion()
        {
            bool result = false;
            //--------------------sql-----------------------------------
            //string que se usa para verificar el usuario 
            sql = string.Format("Select I.Usuario, I.Contraseña, I.Id_TipoUsuario from Ingreso as I inner join Usuario as U on I.Usuario = U.Codigo_Usuario where I.Usuario='{0}'and I.Contraseña='{1}'",nombre_Usuario, codigo_Usuario);

            cmd = new SqlCommand(sql, sc);
            sc.Open();

            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                nombre_Usuario = lector["Usuario"].ToString();
                codigo_Usuario = lector["Contraseña"].ToString();
                id_TipoUsuario = lector["Id_TipoUsuario"].ToString();

                result = true;
                MessageBox.Show("Bienvenido:  " + Nombre_Usuario + "! ", "Login AgroComercial Reyes Mayes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (id_TipoUsuario == "1")
                {
                    frmAdmin admin = new frmAdmin();
                    admin.ShowDialog();
                }
                else if (id_TipoUsuario == "2")
                {
                    frmEmpleado empleado = new frmEmpleado();
                    empleado.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña incorrectos", "Login AgroComercial Reyes Mayes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sc.Close();
            return result;


        }
    }
}
