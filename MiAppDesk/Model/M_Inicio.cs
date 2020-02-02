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
    public class M_Inicio
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
        public List<C_Inicio> ListarI(String lista)
        {
            List<C_Inicio> Listar = new List<C_Inicio>();
            try
            {
                using (MySqlCommand command = new MySqlCommand())
                {
                    StringBuilder Query = new StringBuilder();
                    abrirConexion();
                    Query.Append("SELECT o.item_id,o.cliente_id,o.sucursal_id,o.tipoorden,i.nombre,o.cantidad,o.cantidad*i.precio FROM ordenes o, items i ,clientes c, sucursales s WHERE o.item_id = i.item_id AND o.cliente_id = c.cliente_id AND o.sucursal_id = s.sucursal_id AND o.sucursal_id = '" + C_Stock.suc + "' AND o.cliente_id = '" + Convert.ToInt32(C_Inicio.idcl) + "' AND i.nombre LIKE '" + lista + "' '%';");

                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = Query.ToString();

                    MySqlDataReader reader = null;
                    command.Connection = conn;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Listar.Add(new C_Inicio
                        {
                            IDIT = reader.GetInt32(0),
                            IDCL = reader.GetInt32(1),
                            IDSU = reader.GetInt32(2),
                            TipoOrden = reader.GetInt32(3),
                            Producto = reader.GetString(4),
                            Cantidad = reader.GetInt32(5),
                            Precio = reader.GetDouble(6)
                        });
                    }
                    conn.Close();
                    reader.Close();
                }
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ha Ocurrido error" + ex);
            }
            return Listar;
        }
        private void descontarStock()
        {
            string query = "UPDATE stocks SET cantidad = ?can WHERE item_id = ?idi AND sucursal_id = ?ids ";
            MySqlCommand cm = new MySqlCommand(query, conn);
            cm.Parameters.AddWithValue("?can", (C_Stock.can) - (C_Inicio.cant));
            cm.Parameters.AddWithValue("?idi", C_Inicio.idit);
            cm.Parameters.AddWithValue("?ids", C_Stock.suc);
            cm.ExecuteNonQuery();
        }
        public void Insertar(C_Inicio Dato)
        {
            abrirConexion();
            //validacion
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(item_id) FROM ordenes WHERE item_id = '" + C_Inicio.idit + "' AND cliente_id = '" + C_Inicio.idcl + "';", conn);
            int existe = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (existe > 0)
            {
                MySqlCommand cmdc = new MySqlCommand("SELECT cantidad FROM ordenes WHERE item_id = '" + C_Inicio.idit + "' AND cliente_id = '" + C_Inicio.idcl + "';", conn);
                int canti = Convert.ToInt32(cmdc.ExecuteScalar().ToString());
                if (C_Stock.can >= C_Inicio.cant)
                {
                    try
                    {
                        string query = "UPDATE ordenes SET cantidad = ?can WHERE item_id = ?idi AND cliente_id = ?idc ";
                        MySqlCommand cm = new MySqlCommand(query, conn);
                        cm.Parameters.AddWithValue("?can", (C_Inicio.cant + canti));
                        cm.Parameters.AddWithValue("?idi", C_Inicio.idit);
                        cm.Parameters.AddWithValue("?idc", C_Inicio.idcl);
                        cm.ExecuteNonQuery();
                        descontarStock();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar" + ex);
                        throw new Exception("Error !!!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("La cantidad ordenada es mayor al stock!");
                }
            }
            else
            {
                try
                {
                    if (C_Stock.can >= C_Inicio.cant)
                    {
                        string query = "INSERT INTO ordenes (item_id,cliente_id,cantidad,tipoorden,sucursal_id) VALUES (?idi,?idc,?can,?tip,?ids)";
                        MySqlCommand cm = new MySqlCommand(query, conn);

                        cm.Parameters.AddWithValue("?idi", C_Inicio.idit);
                        cm.Parameters.AddWithValue("?idc", C_Inicio.idcl);
                        cm.Parameters.AddWithValue("?can", C_Inicio.cant);
                        cm.Parameters.AddWithValue("?tip", C_Inicio.tipo);
                        cm.Parameters.AddWithValue("?ids", C_Stock.suc);
                        //MessageBox.Show(C_Stock.suc + "', '" + C_Inicio.tipo + "', '" + C_Inicio.cant);
                        cm.ExecuteNonQuery();
                        descontarStock();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad ordenada es mayor al stock!"+ C_Stock.can+ " - "+ C_Inicio.cant);
                    }

                    
                }
                catch(Exception)
                {
                    MessageBox.Show("Error al registrar");
                }
            }
            conn.Close();
            
        }
        public void Eliminar()
        {
            try
            {
                abrirConexion();
                if (MessageBox.Show("¿Está seguro que que desea quitar '"+ C_Inicio.prod + "' del orden?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //Actualizar registro en la tabla stocks
                    MySqlCommand cmds = new MySqlCommand("SELECT cantidad FROM stocks WHERE item_id = '" + C_Inicio.idit + "' AND sucursal_id = '" + C_Stock.suc + "';", conn);
                    int canti = Convert.ToInt32(cmds.ExecuteScalar().ToString());

                    string query = "UPDATE stocks SET cantidad = ?can WHERE item_id = ?idi AND sucursal_id = ?ids ";
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    cm.Parameters.AddWithValue("?can", canti + (C_Inicio.cant));
                    cm.Parameters.AddWithValue("?idi", C_Inicio.idit);
                    cm.Parameters.AddWithValue("?ids", C_Stock.suc);
                    cm.ExecuteNonQuery();

                    //Eliminar registro de ordenes
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM ordenes WHERE item_id = '" + C_Inicio.idit + "' AND cliente_id = '" + C_Inicio.idcl + "'", conn);
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
