using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//REF-------------------------bY COLQUE EKIS
using System.Runtime.InteropServices;
using MiAppDesk.Controller;

namespace MiAppDesk.View.Dialogs
{
    public partial class Usuario_Dialog : Form
    {
        C_Usuario obj = new C_Usuario();
        C_Rol obj1 = new C_Rol();
        private bool editarse = false;
        public Usuario_Dialog()
        {
            InitializeComponent();
            controlForm();
            comboRol("");
            comboSuc("");
        }

        private void Usuario_Dialog_Load(object sender, EventArgs e)
        {

        }
        /// <summary> Alekis Colque
        /// Mover la ventana con el raton
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitleItem_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Combo select roles
        public void comboRol(string dato)
        {
            cmboRol.DataSource = obj1.Listado(dato);
            cmboRol.DisplayMember = "Nombre";
            cmboRol.ValueMember = "ID";
            C_Usuario.IdRol = Convert.ToInt32(cmboRol.SelectedValue.ToString());
        }
        public void comboSuc(string dato)
        {
            C_Sucursal obj1 = new C_Sucursal();
            comboBoxS.DataSource = obj1.Listado(dato);
            comboBoxS.DisplayMember = "Nombre";
            comboBoxS.ValueMember = "ID";
            C_Usuario.IdSuc = Convert.ToInt32(comboBoxS.SelectedValue.ToString());
        }
        //Controlar el boton guardar
        public void controlForm()
        {
            if (C_Usuario.IdUsuario == 0)
            {
                lblTitleItem.Text = "NUEVO USUARIO";
            }
            else
            {
                lblTitleItem.Text = "MODIFICAR USUARIO";
                editarse = true;
                txtNombre.Text = C_Usuario.nom;
                txtUsuario.Text = C_Usuario.usu;
                txtClave.Text = C_Usuario.cla;

            }
        }

        private void linkRoles_Click(object sender, EventArgs e)
        {
            using (Rol_Dialog uf = new Rol_Dialog())
            {
                uf.ShowDialog();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtUsuario.Text != "" && txtClave.Text != "" && cmboRol.Text != "")
            {
                if (editarse == false)
                {
                    try
                    {
                        //Para tabla suc
                        obj.Nombre = txtNombre.Text;
                        obj.Usuario = txtUsuario.Text;
                        obj.Clave = txtClave.Text;

                        obj.Insertar(obj);
                        MessageBox.Show("Se guardó el registro ");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo guardar el registro " + ex);
                    }
                }
                if (editarse == true)
                {
                    try
                    {
                        obj.Nombre = txtNombre.Text;
                        obj.Usuario = txtUsuario.Text;
                        obj.Clave = txtClave.Text;

                        obj.Editar(obj);
                        MessageBox.Show("Se editó el registro ");
                        editarse = false;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar el registro " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Llene los campos por favor");
            }
        }

        private void cmboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboRol.SelectedValue != null)
            {
                C_Usuario.IdRol = Convert.ToInt32(cmboRol.SelectedValue.ToString());
            }
        }

        private void comboBoxS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxS.SelectedValue != null)
            {
                C_Usuario.IdSuc = Convert.ToInt32(comboBoxS.SelectedValue.ToString());
                //MessageBox.Show(cmbSucursal.SelectedValue.ToString());
            }
        }
    }
}
