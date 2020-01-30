using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// </summary>
using System.Runtime.InteropServices;
using MiAppDesk.Controller;
using MiAppDesk.View.UserControls;

namespace MiAppDesk.View
{
    public partial class Principal : Form
    {

        int panelWidth;
        bool isCollapsed;
        public Principal()
        {
            InitializeComponent();
            lblAdmin.Text = C_Sesion.Usuario;
            tiempoReal.Start();
            panelWidth = pnlLeft.Width;
            isCollapsed = false;
            UC_Inicio uch = new UC_Inicio();
            AddControlsToPanel(uch);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            //btn.BackColor = Color.Red;
            //btnPrincipal.Normalcolor = Color.Red;
            panelAct.Top = btn.Top;
            panelAct.Height = btn.Height;
        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlCuerpo.Controls.Clear();
            pnlCuerpo.Controls.Add(c);
        }

        private void tiempoReal_Tick_1(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            //lblTimer.Text = dt.ToString("HH:MM:ss");
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPrincipal);
            UC_Inicio uch = new UC_Inicio();
            AddControlsToPanel(uch);
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnItems);
            UC_Productos uch = new UC_Productos();
            AddControlsToPanel(uch);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnlSidebar.Visible = false;
                pnlLeft.Width = pnlLeft.Width + 20;
                if (pnlLeft.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                    animacion1.Show(pnlSidebar);
                }
            }
            else
            {
                pnlSidebar.Visible = false;
                pnlLeft.Width = pnlLeft.Width - 20;
                if (pnlLeft.Width <= 80)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                    animacion1.Show(pnlSidebar);
                }
            }
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnStock);
            UC_Stock uch = new UC_Stock();
            AddControlsToPanel(uch);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnClientes);
            UC_Cliente uch = new UC_Cliente();
            AddControlsToPanel(uch);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsuarios);
            UC_Usuario uch = new UC_Usuario();
            AddControlsToPanel(uch);
        }

        private void btnSucursal_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSucursal);
            UC_Sucursal uch = new UC_Sucursal();
            AddControlsToPanel(uch);
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {

        }
    }
    
}
