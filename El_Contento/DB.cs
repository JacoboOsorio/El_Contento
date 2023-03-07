using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace El_Contento
{
    internal class DB
    {
        public static SqlConnection conectar(string nomBD)
        {
            //DESKTOP-POO2OVO\\SQLEXPRESS
            //localhost
            SqlConnection objConectar = new SqlConnection("Data Source = localhost; Initial Catalog = " + nomBD + "; Integrated Security = SSPI;");
            try
            {
                objConectar.Open();
                //MessageBox.Show("Se realizo la conexion...");
                return objConectar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la conexión " + ex.ToString());
                return null;
            }
        }
        public static SqlDataReader consulta(string conSQL, SqlConnection conector)
        {
            try
            {
                SqlCommand objComando = new SqlCommand(conSQL, conector);
                SqlDataReader tabla = objComando.ExecuteReader();
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la consulta " + ex.ToString());
                return null;
            }
        }
        public static int operar(string conSQL, SqlConnection conector)
        {
            int num = 0;
            try
            {
                SqlCommand objComando = new SqlCommand(conSQL, conector);
                num = objComando.ExecuteNonQuery();
                return num;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Fallo la consulta" + e.ToString());
                return num;
            }
        }
        public static void cerrar(SqlConnection conector)
        {
            try
            {
                conector.Close();
                //MessageBox.Show("Se cerró correctamente la base de datos.");
            }
            catch (SqlException eq)
            {
                MessageBox.Show("Error " + eq.ToString());
            }
        }
    }
}
