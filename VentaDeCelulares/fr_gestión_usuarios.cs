using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaDeCelulares
{
    public partial class fr_gestión_usuarios : MetroFramework.Forms.MetroForm
    {
        public fr_gestión_usuarios()
        {
            InitializeComponent();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fr_ver_usuarios().Visible = true;
        }

       

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
