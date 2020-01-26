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
    public partial class Sucursal_Dialog : Form
    {
        C_Sucursal obj = new C_Sucursal();
        C_Depto obj1 = new C_Depto();
        C_Ciudad obj2 = new C_Ciudad();
        C_CiudadCombo obj3 = new C_CiudadCombo();

        public Sucursal_Dialog()
        {
            InitializeComponent();
            controlform();
            comboDepto("");
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

        private void lblCiudades_Click(object sender, EventArgs e)
        {
            using (Ciudad uf = new Ciudad())
            {
                uf.ShowDialog();
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
        }//Llenar Form
        public void controlform()
        {
            if (C_Sucursal.IdUbi == 0)
            {
                lblTitleItem.Text = "NUEVO SUCURSAL";
            }
            else
            {
                lblTitleItem.Text = "MODIFICAR SUCURSAL";

                /*txtItem.Text = C_Item.nom;
                txtPrecio.Text = C_Item.pre.ToString().Replace(',', '.');
                txtFabricante.Text = C_Item.fab;
                txtUnidad.Text = C_Item.uni;
                cmbxTipo.Text = C_Item.uni;
                editarse = true;*/
            }
        }
        public void comboDepto(string data)
        {
            
            cmbxDepto.DataSource = obj1.ListCombo(data);
            cmbxDepto.DisplayMember = "NombreD";
            cmbxDepto.ValueMember = "IdD";
            //C_Sucursal.IdDepto = Convert.ToInt32(cmbxDepto.SelectedValue.ToString());
            comboCiudad(C_Sucursal.IdDepto.ToString());
        }
        public void comboCiudad(string idDep)
        {
            cmboCiudad.DataSource = obj3.ListC(idDep);
            cmboCiudad.DisplayMember = "NombreCi";
            cmboCiudad.ValueMember = "IdCi";
    }

        private void cmbxDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxDepto.SelectedValue != null)
            {
                cmboCiudad.Text = "";
                C_Sucursal.IdDepto = Convert.ToInt32(cmbxDepto.SelectedValue.ToString());
                comboCiudad(C_Sucursal.IdDepto.ToString());
            }
        }

        private void cmboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboCiudad.SelectedValue != null)
            {
                C_Sucursal.IdCiudad = Convert.ToInt32(cmboCiudad.SelectedValue.ToString());
                //MessageBox.Show(C_Sucursal.IdCiudad + "");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNit.Text != "" && txtDireccion.Text != "" && cmboCiudad.Text != "")
            {
                try
                {
                    //Para tabla ubicacion----------------Alekis COL
                    obj.Direccion = txtDireccion.Text;
                    //Para tabla suc
                    obj.Nombre = txtNombre.Text;
                    obj.NIT = txtNit.Text;
                    
                    obj.Insertar(obj);
                    MessageBox.Show("Se guardó el registro ");
                    /*datostabla("");
                    limpiar();*/
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
    }
}
