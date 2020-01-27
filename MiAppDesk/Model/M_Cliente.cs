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
    public class M_Cliente
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
                MessageBox.Show("Error de conexion" + ex);
                Application.Exit();
                throw new Exception("Error !!!");
            }
        }
        public List<C_Cliente> ListarI(String lista)
        {

            List<C_Cliente> Listar = new List<C_Cliente>();
            using (MySqlCommand command = new MySqlCommand())
            {
                StringBuilder Query = new StringBuilder();
                abrirConexion();
                Query.Append("SELECT * FROM clientes WHERE nombre LIKE '" + lista + "' '%';");

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = Query.ToString();

                MySqlDataReader reader = null;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new C_Cliente
                    {
                        ID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Telefono = reader.GetString(2),
                        Direccion = reader.GetString(3)

                    });
                }
                conn.Close();
                reader.Close();
            }
            return Listar;
        }
        public void Insertar(C_Cliente Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM clientes", conn);
                string id = (cmd1.ExecuteScalar()).ToString();
                if (Convert.ToInt32(id) > 0)
                {
                    MySqlCommand idmax = new MySqlCommand("SELECT MAX(cliente_id) FROM clientes", conn);
                    string _id = (idmax.ExecuteScalar()).ToString();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO clientes (cliente_id,nombre,telefono,direccion) VALUES ('" + (Convert.ToInt32(_id) + 1) + "', '" + Dato.Nombre + "', '" + Dato.Telefono + "', '" + Dato.Direccion + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd3 = new MySqlCommand("INSERT INTO clientes (cliente_id,nombre,telefono,direccion) VALUES ('" + 1 + "', '" + Dato.Nombre + "', '" + Dato.Telefono + "', '" + Dato.Direccion + "')", conn);
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
        public void Editar(C_Cliente Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE clientes SET nombre = '" + Dato.Nombre + "',telefono = '" + Dato.Telefono + "',direccion = '" + Dato.Direccion + "'WHERE cliente_id = '" + C_Cliente.IdCli + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar" + ex);
                throw new Exception("Error !!!");
            }
        }
        public void Eliminar(C_Cliente Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM clientes WHERE cliente_id = '" + Dato.ID + "'", conn);
                if (MessageBox.Show("¿Está seguro que que desea eliminar '" + C_Cliente.nom + "'?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
