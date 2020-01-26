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
    public class M_Rol
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
        public List<C_Rol> ListarI(String lista)
        {

            List<C_Rol> Listar = new List<C_Rol>();
            using (MySqlCommand command = new MySqlCommand())
            {
                StringBuilder Query = new StringBuilder();
                abrirConexion();
                Query.Append("SELECT * FROM roles WHERE nombre LIKE '" + lista + "' '%';");

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = Query.ToString();

                MySqlDataReader reader = null;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new C_Rol
                    {
                        ID = reader.GetInt32(0),
                        Nombre = reader.GetString(1)

                    });
                }
                conn.Close();
                reader.Close();
            }
            return Listar;
        }
        public void Insertar(C_Rol Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM roles", conn);
                string id = (cmd1.ExecuteScalar()).ToString();
                if (Convert.ToInt32(id) > 0)
                {
                    MySqlCommand idmax = new MySqlCommand("SELECT MAX(rol_id) FROM roles", conn);
                    string _id = (idmax.ExecuteScalar()).ToString();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO roles (rol_id,nombre) VALUES ('" + (Convert.ToInt32(_id) + 1) + "', '" + Dato.Nombre +"')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd3 = new MySqlCommand("INSERT INTO roles (rol_id,nombre) VALUES ('" + 1 + "', '" + Dato.Nombre + "')", conn);
                    cmd3.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar" + ex);
                throw new Exception("Error !!!");
            }
        }
        public void Editar(C_Rol Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE roles SET nombre = '" + Dato.Nombre + "'WHERE rol_id = '" + Dato.ID + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar" + ex);
                throw new Exception("Error !!!");
            }
        }
        public void Eliminar(C_Rol Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM roles WHERE rol_id = '" + Dato.ID + "'", conn);
                if (MessageBox.Show("¿Está seguro que que desea eliminar '" + Dato.Nombre + "'?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar" + ex);
                throw new Exception("Error !!!");
            }
        }
    }
}
