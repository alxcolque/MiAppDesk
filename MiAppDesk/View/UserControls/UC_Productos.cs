using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libs
using MiAppDesk.View.Dialogs;
using MiAppDesk.Controller;
using System.Configuration;


namespace MiAppDesk.View.UserControls
{
    public partial class UC_Productos : UserControl
    {

        //private string id;//Ayuda Editar y eliminar
        private bool editarse = false;
        //Invocando a las clases claves
        C_Item objC = new C_Item();

        public UC_Productos()
        {
            InitializeComponent();
            datostabla("");
            AccionesTabla();
        }
        private void datostabla(string buscar)
        {
            C_Item obj = new C_Item();
            dgvItems.DataSource = obj.Listado(buscar);

        }
        public void AccionesTabla()
        {
            //dgvItems.Columns[0].Visible = false;
            //sdgvItems.Columns[1].Width = 100;
            //dgvItems.Columns[2].Width = 60;
            dgvItems.ClearSelection();
        }


        private void btnTipos_Click(object sender, EventArgs e)
        {
            using (Tipos uf = new Tipos())
            {
                uf.ShowDialog();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            datostabla(txtBuscar.Text);
        }

        private void UC_Productos_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            C_Item.IdItem = 0;
            Item_Dialog m = new Item_Dialog();
            m.ShowDialog();
            datostabla("");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //C_Item.IdItem = 1;
            if (dgvItems.SelectedRows.Count > 0)
            {
                editarse = true;
                C_Item.IdItem = Int32.Parse(dgvItems.CurrentRow.Cells[0].Value.ToString());
                C_Item.nom = dgvItems.CurrentRow.Cells[1].Value.ToString();
                C_Item.pre = dgvItems.CurrentRow.Cells[2].Value.ToString();
                C_Item.fab = dgvItems.CurrentRow.Cells[3].Value.ToString();
                C_Item.uni = dgvItems.CurrentRow.Cells[4].Value.ToString();
                C_Item.tip = dgvItems.CurrentRow.Cells[5].Value.ToString();
                //MessageBox.Show(objC.Nombre);
                using (Item_Dialog uf = new Item_Dialog())
                {
                    uf.ShowDialog();
                    datostabla("");
                }
            }
            else
            {
                MessageBox.Show("Seleccione la tabla que desea editar");
            }

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                objC.ID = Convert.ToInt32(dgvItems.CurrentRow.Cells[0].Value.ToString());
                objC.Eliminar(objC);
                datostabla("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desee eliminar ");
            }

        }
    }
}
