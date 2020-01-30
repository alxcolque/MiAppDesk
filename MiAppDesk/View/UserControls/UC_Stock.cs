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
    public partial class UC_Stock : UserControl
    {
        //Invocando a las clases claves
        C_Stock obj = new C_Stock();
        public UC_Stock()
        {
            InitializeComponent();
            datostabla("");
            AccionesTabla();
        }
        private void datostabla(string buscar)
        {
            dgvCli.DataSource = obj.Listado(buscar);

        }
        public void AccionesTabla()
        {
            dgvCli.Columns[0].Visible = false;
            dgvCli.Columns[1].Visible = false;
            dgvCli.Columns[4].Width = 200;
            //dgvItems.Columns[2].Width = 60;
            dgvCli.ClearSelection();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            datostabla(txtBuscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AddStock_Dialog m = new AddStock_Dialog();
            m.ShowDialog();
            datostabla("");
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            C_Stock.suc = Convert.ToInt32(dgvCli.CurrentRow.Cells[0].Value.ToString());
            C_Stock.pro = Convert.ToInt32(dgvCli.CurrentRow.Cells[1].Value.ToString());
            if (dgvCli.SelectedRows.Count > 0)
            {
                obj.Eliminar();
                datostabla("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desee eliminar ");
            }
        }
    }
}
