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
    public partial class fr_gestión_artículos : MetroFramework.Forms.MetroForm
    {
        public fr_gestión_artículos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void verArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verCelularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fr_celulares().Visible = true;
        }

        private void verAccesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fr_ver_accesorios().Visible = true;
        }

        private void registroDeCelularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fr_registro_celular().Visible = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
