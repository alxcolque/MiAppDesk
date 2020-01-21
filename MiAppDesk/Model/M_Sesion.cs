using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using MiAppDesk.Controller;
using MiAppDesk.View;

namespace MiAppDesk.Model
{
    class M_Sesion
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
        //Validacion de cuenta
        private bool validate_login(string user, string pass)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Select * from usuarios where nombre_usuario=@user and clave=@pass";
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Connection = conn;
                MySqlDataReader login = cmd.ExecuteReader();
                if (login.Read())
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Validar usuario");
                throw new Exception("Error !!!");
            }

        }
        public void login()
        {
            try
            {
                string user = C_Sesion.Usuario;
                string pass = C_Sesion.Clave;
                string id_rol = C_Sesion.rol;
                if (user == "" || pass == "")
                {
                    MessageBox.Show("Llene los campos vacios por favor..!!");
                    return;
                }
                bool r = validate_login(user, pass);
                if (r)
                {
                    /*abrirConexion();
                    MySqlCommand cmd = new MySqlCommand("Select rol_id from usuarios WHERE nombre_usuario = '"+C_Sesion.Usuario+ "'AND rol_id=1",conn);
                    id_rol = (cmd.ExecuteScalar()).ToString();
                    
                    if (id_rol == "1"){*/
                        Principal m = new Principal();
                        m.ShowDialog();
                    /*}
                    else {
                        Vendedor m = new Vendedor();
                        m.ShowDialog();
                    }
                    conn.Close();*/

                }
                else
                    MessageBox.Show("Datos incorrectos, Revise e intente nuevamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de metodo Login");
                throw new Exception("Error !!!");
            }

        }
    }
}
