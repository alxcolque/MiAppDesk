using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//referencias
using System.Data;
using System.Windows.Forms;
using MiAppDesk.Controller;
using MySql.Data.MySqlClient;
using System.Configuration;
using MiAppDesk.View.UserControls;


namespace MiAppDesk.Model
{
    class M_Depto
    {
        internal static MySqlConnection conn = null;
        private void abrirConexion()
        {
            string conexionstring = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            conn = new MySqlConnection(conexionstring);
            try
            {
                conn.Open();
                //MessageBox.Show("Conexion establecida");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion"+ex);
                Application.Exit();
                throw new Exception("Error !!!");
            }
        }
        //Llenar Combo
        public List<C_Depto> ListarCombo(String lista)
        {

            List<C_Depto> Listar = new List<C_Depto>();
            using (MySqlCommand command = new MySqlCommand())
            {
                StringBuilder Query = new StringBuilder();
                abrirConexion();
                Query.Append("SELECT * FROM departamentos WHERE nombre LIKE '" + lista + "' '%';");

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = Query.ToString();

                MySqlDataReader reader = null;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new C_Depto
                    {
                        IdD = reader.GetInt32(0),
                        NombreD = reader.GetString(1)

                    });
                }
                conn.Close();
                reader.Close();
            }
            return Listar;
        }
    }
}
