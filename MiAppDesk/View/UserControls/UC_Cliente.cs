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
    public partial class UC_Cliente : UserControl
    {
        //Invocando a las clases claves
        C_Cliente obj = new C_Cliente();

        public UC_Cliente()
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
            //dgvItems.Columns[0].Visible = false;
            dgvCli.Columns[0].Width = 60;
            //dgvItems.Columns[2].Width = 60;
            dgvCli.ClearSelection();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            C_Cliente.IdCli = 0;
            Cliente_Dialog m = new Cliente_Dialog();
            m.ShowDialog();
            datostabla("");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCli.SelectedRows.Count > 0)
            {
                C_Cliente.IdCli = Int32.Parse(dgvCli.CurrentRow.Cells[0].Value.ToString());
                C_Cliente.nom = dgvCli.CurrentRow.Cells[1].Value.ToString();
                C_Cliente.tel = dgvCli.CurrentRow.Cells[2].Value.ToString();
                C_Cliente.dir = dgvCli.CurrentRow.Cells[3].Value.ToString();
                //MessageBox.Show(objC.Nombre);
                using (Cliente_Dialog m = new Cliente_Dialog())
                {
                    m.ShowDialog();
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
            C_Cliente.nom = dgvCli.CurrentRow.Cells[1].Value.ToString();
            if (dgvCli.SelectedRows.Count > 0)
            {
                obj.ID = Convert.ToInt32(dgvCli.CurrentRow.Cells[0].Value.ToString());
                obj.Eliminar(obj);
                datostabla("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desee eliminar ");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            datostabla(txtBuscar.Text);
        }
    }
}
