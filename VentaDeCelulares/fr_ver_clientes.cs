using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace VentaDeCelulares
{
    public partial class fr_ver_clientes : Form
    {
        private void CargarTabla()
        {
            ClienteLógica cl = new ClienteLógica();

            DataTable dt = new DataTable();
            dt.Columns.Add("Cédula");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("Correo electrónico");
            dt.Columns.Add("Dirección");
            dt.Columns.Add("Teléfono");
            dt.Columns.Add("Género");
            dt.Columns.Add("Edad");
            foreach (var oItem in cl.GetAll())
            {
                dt.Rows.Add(new object[] { oItem.Cédula, oItem.Nombres,
                oItem.PrimerApellido , oItem.CorreoElectrónico, oItem.Dirección, oItem.Teléfono, oItem.Género,
                oItem.Edad });
            }
            dataGridView1.DataSource = dt;
        }

        public fr_ver_clientes()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void b_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
