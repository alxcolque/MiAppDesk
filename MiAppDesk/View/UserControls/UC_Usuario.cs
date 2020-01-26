using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Referencia
using MiAppDesk.View.Dialogs;
using MiAppDesk.Controller;
using System.Configuration;

namespace MiAppDesk.View.UserControls
{
    public partial class UC_Usuario : UserControl
    {
        //Invocando a las clases claves
        C_Usuario obj = new C_Usuario();

        public UC_Usuario()
        {
            InitializeComponent();
            datostabla("");
            AccionesTabla();

        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            using (Rol_Dialog uf = new Rol_Dialog())
            {
                uf.ShowDialog();
            }
        }
        private void datostabla(string buscar)
        {
            dgvUser.DataSource = obj.Listado(buscar);

        }
        public void AccionesTabla()
        {
            //dgvItems.Columns[0].Visible = false;
            dgvUser.Columns[0].Width = 60;
            //dgvItems.Columns[2].Width = 60;
            dgvUser.ClearSelection();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            C_Usuario.IdUsuario = 0;
            Usuario_Dialog m = new Usuario_Dialog();
            m.ShowDialog();
            datostabla("");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                C_Usuario.IdUsuario = Int32.Parse(dgvUser.CurrentRow.Cells[0].Value.ToString());
                C_Usuario.nom = dgvUser.CurrentRow.Cells[1].Value.ToString();
                C_Usuario.usu = dgvUser.CurrentRow.Cells[2].Value.ToString();
                C_Usuario.cla = dgvUser.CurrentRow.Cells[3].Value.ToString();
                //MessageBox.Show(objC.Nombre);
                using (Usuario_Dialog m = new Usuario_Dialog())
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
            if (dgvUser.SelectedRows.Count > 0)
            {
                obj.ID = Convert.ToInt32(dgvUser.CurrentRow.Cells[0].Value.ToString());
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
