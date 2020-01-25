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
using MiAppDesk.View.Dialogs;
using MiAppDesk.Controller;
using System.Configuration;


namespace MiAppDesk.View
{
    public partial class Ciudad : Form
    {
        private bool editarse = false;
        C_Ciudad obj = new C_Ciudad();
        public Ciudad()
        {
            InitializeComponent();
            datostabla("");
            AccionesTabla();
            llenarCombo("");

        }
        private void datostabla(string buscar)
        {
            C_Ciudad obj = new C_Ciudad();
            dgvCiudad.DataSource = obj.Listado(buscar);

        }
        public void AccionesTabla()
        {
            //dgvItems.Columns[0].Visible = false;
            dgvCiudad.Columns[0].Width = 60;
            //dgvItems.Columns[2].Width = 60;
            dgvCiudad.ClearSelection();
        }

        //LLenar Combo box
        public void llenarCombo(string data)
        {
            C_Depto obj1 = new C_Depto();
            cmbxDepto.DataSource = obj1.ListCombo(data);
            cmbxDepto.DisplayMember = "NombreD";
            cmbxDepto.ValueMember = "IdD";
            //C_Ciudad.IdDepto = Convert.ToInt32(cmbxDepto.SelectedValue.ToString());

        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            datostabla(txtBuscar.Text);
        }

        private void cmbxDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxDepto.SelectedValue != null)
            {
                C_Ciudad.IdDepto = Convert.ToInt32(cmbxDepto.SelectedValue.ToString());
                //MessageBox.Show(C_Ciudad.IdDepto+"");
            }

        }
        private void limpiar()
        {
            editarse = false;
            txtNombre.Text = "";
            txtNombre.Focus();// 
        }

        //Nuevo

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCiudad.SelectedRows.Count > 0)
            {
                editarse = true;
                C_Ciudad.IdCiudad = Convert.ToInt32(dgvCiudad.CurrentRow.Cells[0].Value.ToString());
                txtNombre.Text = dgvCiudad.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la tabla que desea editar");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCiudad.SelectedRows.Count > 0)
            {
                obj.ID = Convert.ToInt32(dgvCiudad.CurrentRow.Cells[0].Value.ToString());
                obj.Eliminar(obj);
                datostabla("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desee eliminar ");
            }

        }
        //Método guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                if (editarse == false)
                {
                    try
                    {
                        obj.Ciudad = txtNombre.Text;

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
                        obj.Ciudad = txtNombre.Text;

                        obj.Editar(obj);
                        MessageBox.Show("Se guardó el registro ");
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


    }
}
