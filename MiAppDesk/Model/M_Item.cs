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
    public class M_Item
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
                MessageBox.Show("Error de conexion");
                Application.Exit();
                throw new Exception("Error !!!");
            }
        }

        public List<C_Item> ListarI(String lista)
        {

            List<C_Item> Listar = new List<C_Item>();
            using (MySqlCommand command = new MySqlCommand())
            {
                StringBuilder Query = new StringBuilder();
                abrirConexion();
                Query.Append("SELECT i.item_id,i.nombre,i.precio,i.fabricante,i.unidad,t.nombre FROM items i, tipos t WHERE i.tipo_id = t.tipo_id AND i.nombre LIKE '" + lista + "'  '%';");

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = Query.ToString();
                
                MySqlDataReader reader = null;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new C_Item
                    {
                        ID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Precio = reader.GetDouble(2),
                        Fabricante = reader.GetString(3),
                        Unidad = reader.GetString(4),
                        Tipo = reader.GetString(5),

                    });
                }
                conn.Close();
                reader.Close();
            }
            return Listar;
        }
        public void Insertar(C_Item Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM items", conn);
                string id = (cmd1.ExecuteScalar()).ToString();
                if (Convert.ToInt32(id) > 0)
                {
                    MySqlCommand idmax = new MySqlCommand("SELECT MAX(item_id) FROM items", conn);
                    string _id = (idmax.ExecuteScalar()).ToString();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO items (item_id,nombre,precio,fabricante,unidad,tipo_id) VALUES ('" + (Convert.ToInt32(id) + 1) + "', '" + Dato.Nombre + "', '" + (Dato.Precio).ToString().Replace(',','.') + "', '" + Dato.Fabricante + "', '" + Dato.Unidad + "', '" + C_Item.IdTipo + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd3 = new MySqlCommand("INSERT INTO items (item_id,nombre,precio,fabricante,unidad,tipo_id) VALUES ('" + 1 + "', '" + Dato.Nombre + "', '" + (Dato.Precio).ToString().Replace(',', '.') + "', '" + Dato.Fabricante + "', '" + Dato.Unidad + "', '" + C_Item.IdTipo + "')", conn);
                    cmd3.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar Producto " + ex);
                throw new Exception("Error !!!");
            }
        }
        public void Editar(C_Item Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE items SET nombre = '" + Dato.Nombre + "',precio = '" + (Dato.Precio).ToString().Replace(',', '.') + "',fabricante = '" + Dato.Fabricante + "',unidad = '" + Dato.Unidad + "',tipo_id = '" + C_Item.IdTipo + "'WHERE item_id = '" + C_Item.IdItem + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar Items" + ex);
                throw new Exception("Error !!!");
            }
        }
        public void Eliminar(C_Item Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM items WHERE item_id = '" + Dato.ID + "'", conn);
                if (MessageBox.Show("¿Está seguro que que desea eliminar '" + Dato.Nombre + "'?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar Items" + ex);
                throw new Exception("Error !!!");
            }
        }

    }
}
