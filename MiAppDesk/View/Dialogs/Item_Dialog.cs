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
using System.Globalization;

namespace MiAppDesk.View.Dialogs
{
    public partial class Item_Dialog : Form
    {
        C_Item obj = new C_Item();
        C_Tipo objT = new C_Tipo();
        private bool editarse = false;
        
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
                
                txtItem.Text = C_Item.nom;
                txtPrecio.Text = C_Item.pre.ToString().Replace(',', '.');
                 txtFabricante.Text = C_Item.fab;
                txtUnidad.Text = C_Item.uni;
                cmbxTipo.Text = C_Item.uni;
                editarse = true;
            }
        }
        //Colque Alekis
        private void limpiar()
        {
            editarse = false;
            txtItem.Text = "";
            txtPrecio.Text = "";
            txtFabricante.Text = "";
            txtUnidad.Text = "";
            txtItem.Focus();// 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CultureInfo.CreateSpecificCulture("en-US");
            if (txtItem.Text != "" && txtPrecio.Text != "" && txtFabricante.Text != "" && txtUnidad.Text != "")
            {
                
                if (editarse == false)
                {
                    try
                    {
                        obj.Nombre = txtItem.Text;
                        obj.Precio = Double.Parse(txtPrecio.Text.Trim(),CultureInfo.InvariantCulture.NumberFormat);
                        obj.Fabricante = txtFabricante.Text;
                        obj.Unidad = txtUnidad.Text;
                        C_Item.IdTipo = Convert.ToInt32(cmbxTipo.SelectedValue.ToString());
                        obj.Insertar(obj);
                        //MessageBox.Show(obj.Precio+"");
                        limpiar();
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
                        obj.Nombre = txtItem.Text;
                        obj.Precio = Double.Parse(txtPrecio.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);
                        obj.Fabricante = txtFabricante.Text;
                        obj.Unidad = txtUnidad.Text;
                        C_Item.IdTipo = Convert.ToInt32(cmbxTipo.SelectedValue.ToString());
                        obj.Editar(obj);
                        //MessageBox.Show(C_Item.IdItem + "-" + obj.Nombre + "-" + obj.Precio + "-" + obj.Fabricante+"-"+ obj.Unidad+"-"+ C_Item.IdTipo);
                        limpiar();
                        editarse = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar el registro " + ex);
                    }
                }
                Close();
            }
            else
            {
                MessageBox.Show("Llene los campos por favor");
            }

        }
        //
        public void llenarCombo(string data)
        {
            C_Tipo obj1 = new C_Tipo();
            cmbxTipo.DataSource = obj1.Listado(data);
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
