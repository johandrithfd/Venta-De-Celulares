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
    public partial class fr_iniciar_sesión : MetroFramework.Forms.MetroForm
    {
        public fr_iniciar_sesión()
        {
            InitializeComponent();
        }

        private void bb_iniciar_sesión_Click(object sender, EventArgs e)
        {
            new fr_principal().Visible = true;
        }
    }
}
