using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libs
using MiAppDesk.Controller;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace MiAppDesk.View.Dialogs
{
    public partial class Tipos : Form
    {
        internal static MySqlConnection conn = null;
        public Tipos()
        {
            InitializeComponent();
            datostabla();
        }
        private void abrirConexion()
        {
            string conexionstring = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            conn = new MySqlConnection(conexionstring);
            try
            {
                conn.Open();
                MessageBox.Show("Conexion establecida");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion");
                Application.Exit();
                throw new Exception("Error !!!");
            }
        }

        private void btnNewT_Click(object sender, EventArgs e)
        {

        }
        private void datostabla()
        {
            abrirConexion();
            List<C_Tipo> Lista = new List<C_Tipo>();
            using (MySqlCommand command = new MySqlCommand())
            {
                StringBuilder Query = new StringBuilder();

                Query.Append("SELECT tipo_id, nombre FROM tipos;");

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = Query.ToString();

                MySqlDataReader reader = null;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    C_Tipo obj = new C_Tipo();
                    obj.Id = Convert.ToInt32(reader["tipo_id"]);
                    obj.Tipo = reader["nombre"].ToString();
                    Lista.Add(obj);
                }
            }
            dgvTi.DataSource = Lista.OrderBy(b => b.Id).ToList();
            conn.Close();
        }

    }
}
