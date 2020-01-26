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
    public class M_Sucursal
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
        public List<C_Sucursal> ListarI(String lista)
        {

            List<C_Sucursal> Listar = new List<C_Sucursal>();
            using (MySqlCommand command = new MySqlCommand())
            {
                StringBuilder Query = new StringBuilder();
                abrirConexion();
                Query.Append("SELECT s.sucursal_id,s.nombre,c.nombre,u.direccion,s.nit FROM sucursales s, ciudades c,ubicaciones u WHERE s.ubicacion_id = u.ubicacion_id AND u.ciudad_id = c.ciudad_id AND s.nombre LIKE '" + lista + "' '%';");

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = Query.ToString();

                MySqlDataReader reader = null;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new C_Sucursal
                    {
                        ID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Ciudad = reader.GetString(2),
                        Direccion = reader.GetString(3),
                        NIT = reader.GetString(4),

                    });
                }
                conn.Close();
                reader.Close();
            }
            return Listar;
        }
        public void Insertar(C_Sucursal Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM sucursales", conn);
                string id = (cmd1.ExecuteScalar()).ToString();
                if (Convert.ToInt32(id) > 0)
                {
                    MySqlCommand idmaxU = new MySqlCommand("SELECT MAX(ubicacion_id) FROM ubicaciones", conn);
                    string idUb = (idmaxU.ExecuteScalar()).ToString();
                    MySqlCommand cmdU = new MySqlCommand("INSERT INTO ubicaciones (ubicacion_id,direccion,ciudad_id) VALUES ('" + (Convert.ToInt32(idUb) + 1) + "', '" + Dato.Direccion + "', '" + C_Sucursal.IdCiudad + "')", conn);
                    cmdU.ExecuteNonQuery();
                    
                    MySqlCommand idmaxS = new MySqlCommand("SELECT MAX(sucursal_id) FROM sucursales", conn);
                    string idS = (idmaxS.ExecuteScalar()).ToString();
                    MySqlCommand cmdS = new MySqlCommand("INSERT INTO sucursales (sucursal_id,nombre,nit,ubicacion_id) VALUES ('" + (Convert.ToInt32(idS) + 1) + "', '" + Dato.Nombre + "', '" + Dato.NIT + "', '" + (Convert.ToInt32(idUb) + 1) + "')", conn);
                    cmdS.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand idmaxU = new MySqlCommand("SELECT MAX(ubicacion_id) FROM ubicaciones", conn);
                    string idUb = (idmaxU.ExecuteScalar()).ToString();
                    MySqlCommand cmdU = new MySqlCommand("INSERT INTO ubicaciones (ubicacion_id,direccion,ciudad_id) VALUES ('" + (Convert.ToInt32(idUb) + 1) + "', '" + Dato.Direccion + "', '" + C_Sucursal.IdCiudad + "')", conn);
                    cmdU.ExecuteNonQuery();

                    MySqlCommand cmdS = new MySqlCommand("INSERT INTO sucursales (sucursal_id,nombre,nit,ubicacion_id) VALUES ('" + 1 + "', '" + Dato.Nombre + "', '" + Dato.NIT + "', '" + (Convert.ToInt32(idUb) + 1) + "')", conn);
                    cmdS.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar Ciudad " + ex);
                throw new Exception("Error !!!");
            }
        }
        public void Editar(C_Sucursal Dato)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar" + ex);
                throw new Exception("Error !!!");
            }
        }
        public void Eliminar(C_Sucursal Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM sucursales WHERE sucursal_id = '" + Dato.ID + "'", conn);
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
