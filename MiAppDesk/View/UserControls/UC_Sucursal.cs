using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//REFERENCIAS
using MiAppDesk.View.Dialogs;
using MiAppDesk.Controller;
using System.Configuration;


namespace MiAppDesk.View.UserControls
{
    public partial class UC_Sucursal : UserControl
    {
        C_Sucursal obj = new C_Sucursal();
        public UC_Sucursal()
        {
            InitializeComponent();
            datostabla("");
            AccionesTabla();

        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {
            using (Ciudad uf = new Ciudad())
            {
                uf.ShowDialog();
            }
        }
        private void datostabla(string buscar)
        {
            dgvSucursal.DataSource = obj.Listado(buscar);

        }
        public void AccionesTabla()
        {
            //dgvItems.Columns[0].Visible = false;
            dgvSucursal.Columns[0].Width = 60;
            //dgvItems.Columns[2].Width = 60;
            dgvSucursal.ClearSelection();
        }


        //Botones CRUD
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            C_Sucursal.IdUbi = 0;
            Sucursal_Dialog m = new Sucursal_Dialog();
            m.ShowDialog();
            datostabla("");

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            datostabla(txtBuscar.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSucursal.SelectedRows.Count > 0)
            {
                obj.ID = Convert.ToInt32(dgvSucursal.CurrentRow.Cells[0].Value.ToString());
                obj.Eliminar(obj);
                datostabla("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desee eliminar ");
            }

        }
    }
}
