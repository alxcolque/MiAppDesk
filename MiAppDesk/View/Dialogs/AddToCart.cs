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
    public partial class AddToCart : Form
    {
        C_Inicio obj = new C_Inicio();
        public AddToCart()
        {
            InitializeComponent();
        }
        /// <summary> Alekis Colque
        /// Mover la ventana con el raton
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnCancelarOrden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            C_Inicio.cant = Convert.ToInt32(txtCantidad.Text);
            obj.Insertar(obj);
            //MessageBox.Show("Se guardó el registro ");
            this.Close();
        }
    }
}
