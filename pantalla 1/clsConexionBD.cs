using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace pantalla_1
{
    public class clsConexionBD
    {
        public SqlConnection sc = new SqlConnection();

        SqlDataAdapter da;
        DataTable dt;

        protected string sql;
        protected SqlCommand cmd;
        //--------------------sql-----------------------------------
        //Conexion con la base de datos ; en el dato sorce se pone un ."punto" para que funcione en cualquier computadora la conexion
        string conexion = "Data Source = .; Initial Catalog = AgroComOficial; " + "Integrated Security = true";

        //--------------------sql-----------------------------------
        //funcion para poder abrir la conexion con la base datos con el string de CONEXION
        public clsConexionBD()
        {
            sc.ConnectionString = conexion;
        }


        //--------------------sql-----------------------------------
        // funcion que se usara en cada parte del codigo para abrir una conexion con la Base de datos
        public void AbrirConexion()
        {
            try
            {
                sc.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR en la conexion" + ex, "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //--------------------sql-----------------------------------
        // funcion que se usara en cada parte del codigo para cerrar una conexion con la Base de datos
        public void CerrarConexion()
        {
            sc.Close();
        }



    }
}
