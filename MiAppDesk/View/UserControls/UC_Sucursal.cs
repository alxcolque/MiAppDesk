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

namespace MiAppDesk.View.UserControls
{
    public partial class UC_Sucursal : UserControl
    {
        public UC_Sucursal()
        {
            InitializeComponent();
        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {
            using (Ciudad uf = new Ciudad())
            {
                uf.ShowDialog();
            }
        }
    }
}
