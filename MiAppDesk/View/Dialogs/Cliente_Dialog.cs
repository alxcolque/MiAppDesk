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
    public partial class Cliente_Dialog : Form
    {
        C_Cliente obj = new C_Cliente();
        private bool editarse = false;
        public Cliente_Dialog()
        {
            InitializeComponent();
            controlForm();
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
        //Controlar el boton guardar
        public void controlForm()
        {
            if (C_Cliente.IdCli == 0)
            {
                lblTitleItem.Text = "NUEVO CLIENTE";
            }
            else
            {
                lblTitleItem.Text = "MODIFICAR CLIENTE";
                editarse = true;
                txtNombre.Text = C_Cliente.nom;
                txtTel.Text = C_Cliente.tel;
                txtDireccion.Text = C_Cliente.dir;

            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtTel.Text != "" && txtDireccion.Text != "")
            {
                if (editarse == false)//Guardar Nuevo
                {
                    try
                    {
                        //Para tabla suc
                        obj.Nombre = txtNombre.Text;
                        obj.Telefono = txtTel.Text;
                        obj.Direccion = txtDireccion.Text;

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
                        obj.Telefono = txtTel.Text;
                        obj.Direccion = txtDireccion.Text;

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
                //

            }
            else
            {
                MessageBox.Show("Llene los campos por favor");
            }
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
    }
}
