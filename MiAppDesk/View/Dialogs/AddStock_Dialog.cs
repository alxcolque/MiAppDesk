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
    public partial class AddStock_Dialog : Form
    {
        C_Stock obj = new C_Stock();
        
        
        public AddStock_Dialog()
        {
            InitializeComponent();
            comboSuc("");
            comboProd("");
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
        public void comboSuc(string dato)
        {
            C_Sucursal obj1 = new C_Sucursal();
            cmbSucursal.DataSource = obj1.Listado(dato);
            cmbSucursal.DisplayMember = "Nombre";
            cmbSucursal.ValueMember = "ID";
            C_Stock.suc = Convert.ToInt32(cmbSucursal.SelectedValue.ToString());
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSucursal.SelectedValue != null)
            {
                C_Stock.suc = Convert.ToInt32(cmbSucursal.SelectedValue.ToString());
                //MessageBox.Show(cmbSucursal.SelectedValue.ToString());
            }
        }
        public void comboProd(string dato)
        {
            C_Item obj2 = new C_Item();
            cmbProd.DataSource = obj2.Listado(dato);
            cmbProd.DisplayMember = "Nombre";
            cmbProd.ValueMember = "ID";
            C_Stock.pro = Convert.ToInt32(cmbProd.SelectedValue.ToString());
        }

        private void cmbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProd.SelectedValue != null)
            {
                C_Stock.pro = Convert.ToInt32(cmbProd.SelectedValue.ToString());
                //MessageBox.Show(cmbProd.SelectedValue.ToString());
            }
        }

        private void cmbProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (numDownCantidad.Text != "" && cmbProd.Text != "" && cmbSucursal.Text != "")
            {
                try
                {
                    obj.Cantidad = Convert.ToInt32(numDownCantidad.Text);
                    obj.Insertar(obj);
                    //MessageBox.Show("Se guardó el registro ");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro " + ex);
                }
            }
            else
            {
                MessageBox.Show("Llene los campos por favor");
            }
        }

        private void AddStock_Dialog_Load(object sender, EventArgs e)
        {
            lblTitleItem.Text = "NUEVO CLIENTE";
        }
    }
}
