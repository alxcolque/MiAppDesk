using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Referencia---------------Alekis COL
using MiAppDesk.View.Dialogs;
using MiAppDesk.Controller;
using System.Configuration;

namespace MiAppDesk.View.UserControls
{
    public partial class UC_Inicio : UserControl
    {
        //Invocando a las clases claves
        C_Inicio obj = new C_Inicio();
        C_Stock obj1 = new C_Stock();
        public UC_Inicio()
        {
            InitializeComponent();
            comboSuc1("");
            datostabla("");
            AccionesTabla();
        }
        private void datostabla(string buscar)
        {
            dgvStock.DataSource = obj1.Listado(buscar);

        }
        public void AccionesTabla()
        {
            dgvStock.Columns[0].Visible = false;
            dgvStock.Columns[1].Visible = false;
            dgvStock.Columns[4].Visible = false;
            //dgvItems.Columns[2].Width = 60;
            dgvStock.ClearSelection();
        }
        private void btnNuevoOrden_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitarorden_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
        public void comboSuc1(string dato)
        {
            C_Sucursal obj1 = new C_Sucursal();
            comboSuc.DataSource = obj1.Listado(dato);
            comboSuc.DisplayMember = "Nombre";
            comboSuc.ValueMember = "ID";
            C_Stock.suc = Convert.ToInt32(comboSuc.SelectedValue.ToString());
        }

        private void comboSuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSuc.SelectedValue != null)
            {
                C_Stock.suc = Convert.ToInt32(comboSuc.SelectedValue.ToString());
                //MessageBox.Show(cmbSucursal.SelectedValue.ToString());
            }
        }
    }
}
