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

namespace MiAppDesk.View.UserControls
{
    public partial class UC_Productos : UserControl
    {
        public UC_Productos()
        {
            InitializeComponent();
        }

        private void btnTipos_Click(object sender, EventArgs e)
        {
            using (Tipos uf = new Tipos())
            {
                uf.ShowDialog();
            }
        }
    }
}
