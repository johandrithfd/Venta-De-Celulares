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
    public partial class fr_registro_celular : MetroFramework.Forms.MetroForm
    {
        CelularLógica cl = new CelularLógica();

        public fr_registro_celular()
        {
            InitializeComponent();
            CargarMarcas();
            CargarColores();
            CargarTipos();
        }

        private void bt_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CargarMarcas()
        {
            MarcaLógica mc = new MarcaLógica();
            IList<Marca> marcas = mc.GetAll();

            MarcaComboBox.DataSource = marcas;
            MarcaComboBox.DisplayMember = "Nombre";
            MarcaComboBox.ValueMember = "Id";
        }

        private void CargarColores()
        {
            ColorLógica cl = new ColorLógica();
            IList<Entity.Color> colores = cl.GetAll();

            ColoresComboBox.DataSource = colores;
            ColoresComboBox.DisplayMember = "Nombre";
            ColoresComboBox.ValueMember = "Id";
        }

        private void CargarTipos()
        {
            IList<string> tipos = new List<string>
            {
                "Inteligente",
                "Regular"
            };
            TipoComboBox.DataSource = tipos;
        }

        private void Bt_registrar_Click(object sender, EventArgs e)
        {
            cl.Insert(GetCelular());
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            NombreTextBox.Text = "";
            DescripciónTextBox.Text = "";
            PrecioTextBox.Text = "";
            CantidadTextBox.Text = "";
            AlmacenamientoTextBox.Text = "";
            RamTextBox.Text = "";
            ResoluciónTextBox.Text = "";
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Celular c = cl.GetBy("Referencia", ReferenciaTextBox.Text);

            if (c == null) MessageBox.Show("El celular con esta referencia no existe");
            else
            {
                if (cl.Delete(c.Id) == 0) MessageBox.Show("La eliminación falló");
                else {
                    MessageBox.Show("Eliminación correcta");
                    LimpiarCampos();
                }
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            Celular c = cl.GetBy("Referencia", ReferenciaTextBox.Text);
            if (c == null) MessageBox.Show("Este celular no existe");
            else
            {
                NombreTextBox.Text = c.Nombre;
                DescripciónTextBox.Text = c.Descripción;
                PrecioTextBox.Text = c.Precio.ToString();
                CantidadTextBox.Text = c.Cantidad.ToString();
                MarcaComboBox.SelectedValue = c.Marca.Id;
                ColoresComboBox.SelectedValue = c.Color.Id;
                TipoComboBox.SelectedText = c.Tipo == TipoDeCelular.INTELIGENTE ? "Inteligente" : "Regular";
                AlmacenamientoTextBox.Text = c.Almacenamiento.ToString();
                RamTextBox.Text = c.RAM.ToString();
                ResoluciónTextBox.Text = c.MegapixelesEnLaCámara.ToString();
            }
        }

        private Celular GetCelular()
        {
            Celular c = new Celular();

            MarcaLógica mc = new MarcaLógica();
            ColorLógica lc = new ColorLógica();

            c.Referencia = ReferenciaTextBox.Text;
            c.Almacenamiento = int.Parse(AlmacenamientoTextBox.Text);
            c.MegapixelesEnLaCámara = int.Parse(ResoluciónTextBox.Text);
            c.RAM = int.Parse(RamTextBox.Text);
            c.Nombre = NombreTextBox.Text;
            c.Precio = float.Parse(PrecioTextBox.Text);
            c.Descripción = DescripciónTextBox.Text;
            c.Cantidad = int.Parse(CantidadTextBox.Text);
            c.Tipo = TipoComboBox.SelectedText == "Inteligente" ? TipoDeCelular.INTELIGENTE : TipoDeCelular.REGULAR;
            c.Precio = int.Parse(PrecioTextBox.Text);
            c.Marca = mc.Get(int.Parse(MarcaComboBox.SelectedValue.ToString()));
            c.Color = lc.Get(int.Parse(ColoresComboBox.SelectedValue.ToString()));

            return c;
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            var c = cl.GetBy("Referencia", ReferenciaTextBox.Text);
            if (c == null)
            {
                MessageBox.Show("Este celular no existe");
            } else
            {
                cl.Update(GetCelular(), c.Id);
            }
        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
            new fr_celulares().Visible = true;
        }
    }
}
