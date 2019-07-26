using BLL;
using Entity;
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
    public partial class fr_principal : MetroFramework.Forms.MetroForm
    {
        public fr_principal()
        {
            InitializeComponent();
        }

        private void gestiónClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fr_gestión_clientes().Visible = true;
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fr_celulares().Visible = true;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fr_gestión_usuarios().Visible = true;
        }

        private void verVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fr_ver_ventas().Visible = true;
        }

        private void AgregarArtículo(Artículo a, int cantidad)
        {
            dataGridView1.Rows.Add(a.Referencia, a.Nombre, a.Precio, cantidad, cantidad * a.Precio);
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            CelularLógica cl = new CelularLógica();
            AccesorioLógica al = new AccesorioLógica();

            Artículo a = null;

            try
            {
                if ((a = cl.GetBy("Referencia", RefArtículoTextBox.Text)) != null)
                {
                    AgregarArtículo(a, int.Parse(tb_cantidad.Text));
                }
                else if ((a = al.GetBy("Referencia", RefArtículoTextBox.Text)) != null)
                {
                    AgregarArtículo(a, int.Parse(tb_cantidad.Text));
                }
                else
                {
                    MessageBox.Show("Este artículo no está registrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un valor correcto");
            }
            
        }

        private void accesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fr_gestión_artículos().Visible = true;
        }
    }
}
