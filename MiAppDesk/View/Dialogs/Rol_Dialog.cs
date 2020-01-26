using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Referencia
using MiAppDesk.Controller;
using System.Configuration;


namespace MiAppDesk.View.Dialogs
{
    public partial class Rol_Dialog : Form
    {
        private bool editarse = false;
        C_Rol obj = new C_Rol();

        public Rol_Dialog()
        {
            InitializeComponent();
            datostabla("");
            AccionesTabla();

        }
        private void datostabla(string buscar)
        {
            C_Rol obj = new C_Rol();
            dgvR.DataSource = obj.Listado(buscar);

        }
        public void AccionesTabla()
        {
            //dgvItems.Columns[0].Visible = false;
            dgvR.Columns[0].Width = 60;
            //dgvItems.Columns[2].Width = 60;
            dgvR.ClearSelection();
        }
        private void limpiar()
        {
            editarse = false;
            txtNombre.Text = "";
            txtNombre.Focus();// 
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvR.SelectedRows.Count > 0)
            {
                editarse = true;
                obj.ID = Convert.ToInt32(dgvR.CurrentRow.Cells[0].Value.ToString());
                txtNombre.Text = dgvR.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la tabla que desea editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvR.SelectedRows.Count > 0)
            {
                obj.ID = Convert.ToInt32(dgvR.CurrentRow.Cells[0].Value.ToString());
                obj.Eliminar(obj);
                datostabla("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desee eliminar ");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                if (editarse == false)
                {
                    try
                    {
                        obj.Nombre = txtNombre.Text;
                        obj.Insertar(obj);
                        MessageBox.Show("Se guardó el registro ");
                        datostabla("");
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
                        obj.Nombre = txtNombre.Text;

                        obj.Editar(obj);
                        MessageBox.Show("Se editó el registro ");
                        datostabla("");
                        limpiar();
                        editarse = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar el registro " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Llene los campos por favor");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            datostabla(txtBuscar.Text);
        }
    }
}
