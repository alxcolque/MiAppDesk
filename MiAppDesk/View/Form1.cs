using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Libs
/// </summary>
using MiAppDesk.Controller;

namespace MiAppDesk
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnAcceder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //MessageBox.Show("Enter Key Pressed");
                login();

            }
        }
        public void login()
        {
            C_Sesion.Usuario = txtUsuario.Text;
            C_Sesion.Clave = txtPassword.Text;
            C_Sesion obj = new C_Sesion();
            obj.resp();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();

            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();

            }
        }
    }
}
