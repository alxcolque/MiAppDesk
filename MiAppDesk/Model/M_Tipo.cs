using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libs
using System.Data;
using System.Windows.Forms;
using MiAppDesk.Controller;
using MySql.Data.MySqlClient;
using System.Configuration;
using MiAppDesk.View.UserControls;

namespace MiAppDesk.Model
{
    public class M_Tipo
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
        public void datostabla()
        { }
        public List<C_Tipo> ListarTipo(String lista)
        {
            
            List<C_Tipo> Listar = new List<C_Tipo>();
            using (MySqlCommand command = new MySqlCommand())
            {
                StringBuilder Query = new StringBuilder();
                abrirConexion();
                Query.Append("SELECT tipo_id, nombre FROM tipos WHERE nombre LIKE '"+lista+"' '%';");

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = Query.ToString();


                MySqlDataReader reader = null;
                command.Connection = conn;
                reader = command.ExecuteReader();
                //List<C_Tipo> Listar = new List<C_Tipo>();
                while (reader.Read())
                {
                    Listar.Add(new C_Tipo
                    {
                        Idtipo = reader.GetInt32(0),
                        Nombre = reader.GetString(1)
                    });
                }
                conn.Close();
                reader.Close();
            }
            return Listar;
        }
        public void Insertar(C_Tipo Tipo)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM tipos", conn);
                string id = (cmd1.ExecuteScalar()).ToString();
                if (Convert.ToInt32(id) > 0)
                {
                    MySqlCommand idmax = new MySqlCommand("SELECT MAX(tipo_id) FROM tipos", conn);
                    string _id = (idmax.ExecuteScalar()).ToString();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO tipos (tipo_id,nombre) VALUES ('" + (Tipo.Idtipo + 1) + "', '" + Tipo.Nombre + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd3 = new MySqlCommand("INSERT INTO tipos (tipo_id,nombre) VALUES ('" + 1 + "', '" + Tipo.Nombre + "')", conn);
                    cmd3.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar Tipo " + ex);
                throw new Exception("Error !!!");
            }
        }
        public void Editar(C_Tipo Tipo)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE tipos SET nombre = '" + Tipo.Nombre + "'WHERE tipo_id = '" + Tipo.Idtipo + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar Tipo" + ex);
                throw new Exception("Error !!!");
            }
        }
        public void Eliminar(C_Tipo Tipo)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM tipos WHERE tipo_id = '" + Tipo.Idtipo + "'", conn);
                if (MessageBox.Show("¿Está seguro que que desea eliminar '" + Tipo.Nombre + "'?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar tipos" + ex);
                throw new Exception("Error !!!");
            }
        }
    }
}
