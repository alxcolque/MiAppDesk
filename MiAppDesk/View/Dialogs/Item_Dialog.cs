using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//REF
using System.Runtime.InteropServices;
using MiAppDesk.Controller;

namespace MiAppDesk.View.Dialogs
{
    public partial class Item_Dialog : Form
    {
        C_Item objC = new C_Item();
        C_Tipo objT = new C_Tipo();
        public Item_Dialog()
        {
            InitializeComponent();
            llenarCombo("");
            llenarform();
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
            this.Dispose();
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
        //Llenar Form
        public void llenarform()
        {
            if (C_Item.IdItem == 0)
            {
                lblTitleItem.Text = "NUEVO ARTICULO";
            }
            else
            {
                lblTitleItem.Text = "MODIFICAR ARTICULO";
                txtItem.Text = objC.Nombre;
                txtPrecio.Text = (objC.Precio).ToString();
                txtFabricante.Text = objC.Fabricante;
                txtUnidad.Text = objC.Unidad;
                //cmbxTipo.Text = CC_Item.Gramos;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
        //
        public void llenarCombo(string data)
        {
            C_Tipo obj = new C_Tipo();
            cmbxTipo.DataSource = obj.Listado(data);
            cmbxTipo.DisplayMember = "Nombre";
            cmbxTipo.ValueMember = "Idtipo";
            //C_Item.IdTipo = cmbxTipo.SelectedValue.ToString();

        }

        private void cmbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxTipo.SelectedValue != null)
            {
                C_Item.IdTipo = Convert.ToInt32(cmbxTipo.SelectedValue.ToString());
                //MessageBox.Show(C_Item.IdTipo+"");
            }
        }

        private void cmbxTipo_TextChanged(object sender, EventArgs e)
        {
            /*C_Tipo obj = new C_Tipo();
            cmbxTipo.DataSource = obj.Listado(cmbxTipo.Text);
            cmbxTipo.DisplayMember = "Nombre";
            cmbxTipo.ValueMember = "Idtipo";*/
        }
    }
}
