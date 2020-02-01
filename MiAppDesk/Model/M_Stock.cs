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
    public class M_Stock
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
        public List<C_Stock> ListarI(String lista)
        {

            List<C_Stock> Listar = new List<C_Stock>();
            using (MySqlCommand command = new MySqlCommand())
            {
                StringBuilder Query = new StringBuilder();
                abrirConexion();
                Query.Append("SELECT s.sucursal_id,s.item_id,i.nombre,s.cantidad,s.fecha,su.nombre FROM stocks s,sucursales su,items i WHERE s.sucursal_id = su.sucursal_id AND s.item_id = i.item_id AND s.sucursal_id = '" + C_Stock.suc + "' AND i.nombre LIKE '" + lista + "' '%';");

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = Query.ToString();

                MySqlDataReader reader = null;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new C_Stock
                    {
                        IDSU = reader.GetInt32(0),
                        IDIT = reader.GetInt32(1),
                        Producto = reader.GetString(2),
                        Cantidad = reader.GetInt32(3),
                        Fecha = reader.GetString(4),
                        Sucursal = reader.GetString(5)
                    });
                }
                conn.Close();
                reader.Close();
            }
            return Listar;
        }
        public void Insertar(C_Stock Dato)
        {
            //var existe;
            try
            {
                abrirConexion();
                //validacion
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(sucursal_id) FROM stocks WHERE sucursal_id LIKE '" + C_Stock.suc + "' '%' AND item_id LIKE '" + C_Stock.pro + "' '%';", conn);
                int existe = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if(existe > 0)
                {
                    if (MessageBox.Show("Ya existe en el stock!,¿Desea Actualizar stock?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        MySqlCommand cmde = new MySqlCommand("DELETE FROM stocks WHERE sucursal_id = '" + C_Stock.suc + "' AND item_id = '" + C_Stock.pro + "'", conn);
                        cmde.ExecuteNonQuery();

                        string query = "INSERT INTO stocks (sucursal_id,item_id,cantidad,fecha) VALUES (?ids,?idi,?can,?fec)";
                        MySqlCommand cm = new MySqlCommand(query, conn);
                        cm.Parameters.AddWithValue("?ids", C_Stock.suc);
                        cm.Parameters.AddWithValue("?idi", C_Stock.pro);
                        cm.Parameters.AddWithValue("?can", Dato.Cantidad);
                        cm.Parameters.AddWithValue("?fec", DateTime.Now);
                        cm.ExecuteNonQuery();
                    }
                }
                else
                {
                    string query = "INSERT INTO stocks (sucursal_id,item_id,cantidad,fecha) VALUES (?ids,?idi,?can,?fec)";
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    cm.Parameters.AddWithValue("?ids", C_Stock.suc);
                    cm.Parameters.AddWithValue("?idi", C_Stock.pro);
                    cm.Parameters.AddWithValue("?can", Dato.Cantidad);
                    cm.Parameters.AddWithValue("?fec", DateTime.Now);
                    //MessageBox.Show(C_Stock.suc + "', '" + C_Stock.pro + "', '" + Dato.Cantidad + "', '" + nw);
                    cm.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar" + ex);
                throw new Exception("Error !!!");
            }
        }
        public void Eliminar()
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM stocks WHERE sucursal_id = '" + C_Stock.suc + "' AND item_id = '" + C_Stock.pro + "'", conn);
                if (MessageBox.Show("¿Está seguro que que desea eliminar?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //MessageBox.Show(C_Stock.suc +" - " + C_Stock.pro);
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
