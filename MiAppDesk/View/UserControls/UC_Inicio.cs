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
        C_Inicio obj3 = new C_Inicio();
        public UC_Inicio()
        {
            InitializeComponent();
            comboSuc1("");
            AccionesTabla();
        }
        private void datostabla(string buscar)
        {
            dgvStock.DataSource = obj1.Listado(buscar);
        }
        private void datostabla1(string buscar)
        {
            dgvCart.DataSource = obj3.Listado(buscar);
        }
        public void AccionesTabla()
        {
            dgvStock.Columns[0].Visible = false;
            dgvStock.Columns[1].Visible = false;
            dgvStock.Columns[4].Visible = false;

            dgvCart.Columns[0].Visible = false;
            dgvCart.Columns[1].Visible = false;
            dgvCart.Columns[2].Visible = false;
            dgvCart.Columns[3].Visible = false;
            //dgvItems.Columns[2].Width = 60;
            dgvStock.ClearSelection();
        }
        private void btnNuevoOrden_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count > 0)
            {
                C_Inicio.idit = Convert.ToInt32(dgvStock.CurrentRow.Cells[1].Value.ToString());
                C_Inicio.prod = dgvStock.CurrentRow.Cells[2].Value.ToString();
                C_Inicio.tipo = 1;
                //C_Inicio.cant = Convert.ToInt32(dgvStock.CurrentRow.Cells[3].Value.ToString());
                C_Stock.can = Convert.ToInt32(dgvStock.CurrentRow.Cells[3].Value.ToString());
                using (AddToCart m = new AddToCart())
                {
                    m.ShowDialog();
                    datostabla("");
                    datostabla1("");
                }
            }
            else
            {
                MessageBox.Show("Seleccione la tabla que desea editar");
            }
        }

        private void btnQuitarorden_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                C_Inicio.idit = Convert.ToInt32(dgvCart.CurrentRow.Cells[0].Value.ToString());
                C_Inicio.cant = Convert.ToInt32(dgvCart.CurrentRow.Cells[5].Value.ToString());
                C_Inicio.prod = dgvCart.CurrentRow.Cells[4].Value.ToString();
                obj.Eliminar();
                datostabla("");
                datostabla1("");
            }
            else
            {
                MessageBox.Show("Seleccione la tabla que desea editar");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            datostabla(txtBuscar.Text);
        }
        public void comboSuc1(string dato)
        {
            C_Sucursal obj2 = new C_Sucursal();
            comboSuc.DataSource = obj2.Listado(dato);
            comboSuc.DisplayMember = "Nombre";
            comboSuc.ValueMember = "ID";
            C_Stock.suc = Convert.ToInt32(comboSuc.SelectedValue.ToString());
            datostabla("");
            comboCliente("");
        }

        private void comboSuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSuc.SelectedValue != null)
            {
                C_Stock.suc = Convert.ToInt32(comboSuc.SelectedValue.ToString());
                datostabla("");
                comboCliente("");
                //MessageBox.Show(cmbSucursal.SelectedValue.ToString());
            }
        }

        private void txtBuscarO_TextChanged(object sender, EventArgs e)
        {
            datostabla1(txtBuscarO.Text);
        }

        private void UC_Inicio_Load(object sender, EventArgs e)
        {
            
            //datostabla1("");
        }
        private void comboCliente(string dato)
        {
            C_Cliente obj4 = new C_Cliente();
            comboBoxCliente.DataSource = obj4.Listado(dato);
            comboBoxCliente.DisplayMember = "Nombre";
            comboBoxCliente.ValueMember = "ID";
            C_Inicio.idcl = comboBoxCliente.SelectedValue.ToString();
            datostabla1("");
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCliente.SelectedValue != null)
            {
                C_Inicio.idcl = "10";
                C_Inicio.idcl = comboBoxCliente.SelectedValue.ToString();
                //MessageBox.Show("jajaja Un error "+comboBoxCliente.SelectedValue.ToString());
                datostabla1("");
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            C_Cliente.IdCli = 0;
            Cliente_Dialog m = new Cliente_Dialog();
            m.ShowDialog();
            comboCliente("");
        }
    }
}
