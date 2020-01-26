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
    public class M_Ciudad
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
        public List<C_Ciudad> ListarI(String lista)
        {

            List<C_Ciudad> Listar = new List<C_Ciudad>();
            using (MySqlCommand command = new MySqlCommand())
            {
                StringBuilder Query = new StringBuilder();
                abrirConexion();
                Query.Append("SELECT c.ciudad_id,c.nombre,d.nombre FROM ciudades c, departamentos d WHERE c.depto_id = d.depto_id AND c.nombre LIKE '" + lista + "' '%';");

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = Query.ToString();

                MySqlDataReader reader = null;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new C_Ciudad
                    {
                        ID = reader.GetInt32(0),
                        Ciudad = reader.GetString(1),
                        Departamento = reader.GetString(2),

                    });
                }
                conn.Close();
                reader.Close();
            }
            return Listar;
        }
        public void Insertar(C_Ciudad Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM ciudades", conn);
                string id = (cmd1.ExecuteScalar()).ToString();
                if (Convert.ToInt32(id) > 0)
                {
                    MySqlCommand idmax = new MySqlCommand("SELECT MAX(ciudad_id) FROM ciudades", conn);
                    string _id = (idmax.ExecuteScalar()).ToString();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO ciudades (ciudad_id,nombre,depto_id) VALUES ('" + (Convert.ToInt32(_id) + 1) + "', '" + Dato.Ciudad + "', '" + C_Ciudad.IdDepto + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd3 = new MySqlCommand("INSERT INTO ciudades (ciudad_id,nombre,depto_id) VALUES ('" + 1 + "', '" + Dato.Ciudad + "', '" + C_Ciudad.IdDepto + "')", conn);
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
        public void Editar(C_Ciudad Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE ciudades SET nombre = '" + Dato.Ciudad + "',depto_id = '" + C_Ciudad.IdDepto + "'WHERE ciudad_id = '" + C_Ciudad.IdCiudad + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar" + ex);
                throw new Exception("Error !!!");
            }
        }
        public void Eliminar(C_Ciudad Dato)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM ciudades WHERE ciudad_id = '" + Dato.ID + "'", conn);
                if (MessageBox.Show("¿Está seguro que que desea eliminar '" + Dato.Ciudad + "'?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
        //Listar para combobox
        public List<C_CiudadCombo> ListarC(string id)
        {

            List<C_CiudadCombo> Listar = new List<C_CiudadCombo>();
            using (MySqlCommand command = new MySqlCommand())
            {
                StringBuilder Query = new StringBuilder();
                abrirConexion();
                Query.Append("SELECT * FROM ciudades WHERE depto_id = '" + Int32.Parse(id) + "'");

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = Query.ToString();

                MySqlDataReader reader = null;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Listar.Add(new C_CiudadCombo
                    {
                        IdCi = reader.GetInt32(0),
                        NombreCi = reader.GetString(1)
                    });
                }
                conn.Close();
                reader.Close();
            }
            return Listar;
        }

    }
}
