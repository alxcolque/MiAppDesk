using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libs
using MiAppDesk.Controller;
using System.Configuration;

namespace MiAppDesk.View.Dialogs
{
    public partial class Tipos : Form
    {
        private string id;//Ayuda Editar y eliminar
        private bool editarse = false;
        //Invocando a las clases claves
        C_Tipo objC = new C_Tipo();
        public Tipos()
        {
            InitializeComponent(); 
            datostabla("");
            
        }
        
        public void AccionesTabla()
        {
            dgvTi.Columns[0].Visible = false;
            dgvTi.Columns[1].Width = 60;
            dgvTi.Columns[2].Width = 150;
            dgvTi.ClearSelection();
        }
        private void btnNewT_Click(object sender, EventArgs e)
        {

        }
        private void limpiar()
        {
            editarse = false;
            txtTipo.Text = "";
            txtTipo.Focus();// 
        }
        private void datostabla(string buscar)
        {            
            C_Tipo obj = new C_Tipo();
            dgvTi.DataSource = obj.Listado(buscar);

        }
        //buscar datos en tiempo real
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            datostabla(txtBuscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvTi.SelectedRows.Count > 0)
            {
                editarse = true;
                id = dgvTi.CurrentRow.Cells[0].Value.ToString();
                txtTipo.Text = dgvTi.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la tabla que desea editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTi.SelectedRows.Count > 0)
            {
                objC.Idtipo = Convert.ToInt32(dgvTi.CurrentRow.Cells[0].Value.ToString());
                objC.Eliminar(objC);
                datostabla("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desee eliminar ");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtTipo.Text != "")
            {
                if (editarse == false)
                {
                    try
                    {
                        objC.Nombre = txtTipo.Text;

                        objC.Insertar(objC);
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
                        objC.Idtipo = Convert.ToInt32(id);
                        objC.Nombre = txtTipo.Text;

                        objC.Editar(objC);
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