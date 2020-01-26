using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//referencias -------------------By: Colque Alekis
using System.Data;
using System.Windows.Forms;
using MiAppDesk.Controller;
using MySql.Data.MySqlClient;
using System.Configuration;
using MiAppDesk.View.UserControls;


namespace MiAppDesk.Model
{
    public class M_Usuario
    {
        //
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
                MessageBox.Show("Error de conexion" + ex);
                Application.Exit();
                throw new Exception("Error !!!");
            }
        }
        public List<C_Usuario> ListarI(String lista)
        {

            List<C_Usuario> Listar = new List<C_Usuario>();
            using (MySqlCommand command = new MySqlCommand())
            {
                StringBuilder Query = new StringBuilder();
                abrirConexion();
                Query.Append("SELECT u.usuario_id, u.nombre, u.nombre_usuario,u.clave,r.nombre FROM usuarios u, roles r WHERE u.rol_id = r.rol_id AND u.nombre LIKE '" + lista + "' '%';");

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = Query.ToString();

                MySqlDataReader reader = null;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new C_Usuario
                    {
                        ID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Usuario = reader.GetString(2),
                        Clave = reader.GetString(3),
                        Cargo = reader.GetString(4),

                    });
                }
                conn.Close();
                reader.Close();
            }
            return Listar;
        }
        public void Insertar(C_Usuario Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM usuarios", conn);
                string id = (cmd1.ExecuteScalar()).ToString();
                if (Convert.ToInt32(id) > 0)
                {
                    MySqlCommand idmax = new MySqlCommand("SELECT MAX(usuario_id) FROM usuarios", conn);
                    string _id = (idmax.ExecuteScalar()).ToString();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO usuarios (usuario_id,nombre,nombre_usuario,clave,rol_id) VALUES ('" + (Convert.ToInt32(_id) + 1) + "', '" + Dato.Nombre + "', '" + Dato.Usuario + "', '" + Dato.Clave + "', '" + C_Usuario.IdRol + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd3 = new MySqlCommand("INSERT INTO usuarios (usuario_id,nombre,nombre_usuario,clave,rol_id) VALUES ('" + 1 + "', '" + Dato.Nombre + "', '" + Dato.Usuario + "', '" + Dato.Clave + "', '" + C_Usuario.IdRol + "')", conn);
                    cmd3.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar Ciudad " + ex);
                throw new Exception("Error !!!");
            }
        }
        public void Editar(C_Usuario Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE usuarios SET nombre = '" + Dato.Nombre + "',nombre_usuario = '" + Dato.Usuario + "',clave = '" + Dato.Clave + "',rol_id = '" + C_Usuario.IdRol + "'WHERE usuario_id = '" + C_Usuario.IdUsuario + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar" + ex);
                throw new Exception("Error !!!");
            }
        }
        public void Eliminar(C_Usuario Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM usuarios WHERE usuario_id = '" + Dato.ID + "'", conn);
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
