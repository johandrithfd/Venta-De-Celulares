namespace VentaDeCelulares
{
    partial class fr_principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.CédulaTextBox = new MetroFramework.Controls.MetroTextBox();
            this.RefArtículoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.tb_cantidad = new MetroFramework.Controls.MetroTextBox();
            this.tb_vueltas = new MetroFramework.Controls.MetroTextBox();
            this.tb_pago = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.accesoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónClientesToolStripMenuItem,
            this.artículosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.verVentasToolStripMenuItem,
            this.accesoriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestiónClientesToolStripMenuItem
            // 
            this.gestiónClientesToolStripMenuItem.Name = "gestiónClientesToolStripMenuItem";
            this.gestiónClientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.gestiónClientesToolStripMenuItem.Text = "Clientes";
            this.gestiónClientesToolStripMenuItem.Click += new System.EventHandler(this.gestiónClientesToolStripMenuItem_Click);
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.artículosToolStripMenuItem.Text = "Celulares";
            this.artículosToolStripMenuItem.Click += new System.EventHandler(this.artículosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // verVentasToolStripMenuItem
            // 
            this.verVentasToolStripMenuItem.Name = "verVentasToolStripMenuItem";
            this.verVentasToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.verVentasToolStripMenuItem.Text = "Ver ventas";
            this.verVentasToolStripMenuItem.Click += new System.EventHandler(this.verVentasToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Referencia,
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.Subtotal});
            this.dataGridView1.Location = new System.Drawing.Point(347, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 146);
            this.dataGridView1.TabIndex = 10;
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(163, 315);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 21;
            this.metroButton1.Text = "Aceptar";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(81, 315);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 22;
            this.metroButton2.Text = "Cancelar";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(298, 201);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(27, 23);
            this.metroButton3.TabIndex = 23;
            this.metroButton3.Text = ">>";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.MetroButton3_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(704, 259);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Total";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(704, 288);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Pago";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(704, 317);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Vueltas";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 234);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 27;
            this.metroLabel4.Text = "Nombre";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 205);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(142, 19);
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "Referencia del Articulo";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(14, 176);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(126, 19);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Nombre Del Cliente";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(14, 143);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(156, 19);
            this.metroLabel7.TabIndex = 30;
            this.metroLabel7.Text = "Identificacion Del Cliente ";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(14, 101);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(30, 19);
            this.metroLabel8.TabIndex = 31;
            this.metroLabel8.Text = "000";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(123, 101);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(69, 38);
            this.metroLabel9.TabIndex = 32;
            this.metroLabel9.Text = "17/10/2017\r\n";
            // 
            // CédulaTextBox
            // 
            // 
            // 
            // 
            this.CédulaTextBox.CustomButton.Image = null;
            this.CédulaTextBox.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.CédulaTextBox.CustomButton.Name = "";
            this.CédulaTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CédulaTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CédulaTextBox.CustomButton.TabIndex = 1;
            this.CédulaTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CédulaTextBox.CustomButton.UseSelectable = true;
            this.CédulaTextBox.CustomButton.Visible = false;
            this.CédulaTextBox.Lines = new string[0];
            this.CédulaTextBox.Location = new System.Drawing.Point(176, 143);
            this.CédulaTextBox.MaxLength = 32767;
            this.CédulaTextBox.Name = "CédulaTextBox";
            this.CédulaTextBox.PasswordChar = '\0';
            this.CédulaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CédulaTextBox.SelectedText = "";
            this.CédulaTextBox.SelectionLength = 0;
            this.CédulaTextBox.SelectionStart = 0;
            this.CédulaTextBox.ShortcutsEnabled = true;
            this.CédulaTextBox.Size = new System.Drawing.Size(149, 23);
            this.CédulaTextBox.TabIndex = 33;
            this.CédulaTextBox.UseSelectable = true;
            this.CédulaTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CédulaTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RefArtículoTextBox
            // 
            // 
            // 
            // 
            this.RefArtículoTextBox.CustomButton.Image = null;
            this.RefArtículoTextBox.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.RefArtículoTextBox.CustomButton.Name = "";
            this.RefArtículoTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RefArtículoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RefArtículoTextBox.CustomButton.TabIndex = 1;
            this.RefArtículoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RefArtículoTextBox.CustomButton.UseSelectable = true;
            this.RefArtículoTextBox.CustomButton.Visible = false;
            this.RefArtículoTextBox.Lines = new string[0];
            this.RefArtículoTextBox.Location = new System.Drawing.Point(176, 201);
            this.RefArtículoTextBox.MaxLength = 32767;
            this.RefArtículoTextBox.Name = "RefArtículoTextBox";
            this.RefArtículoTextBox.PasswordChar = '\0';
            this.RefArtículoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RefArtículoTextBox.SelectedText = "";
            this.RefArtículoTextBox.SelectionLength = 0;
            this.RefArtículoTextBox.SelectionStart = 0;
            this.RefArtículoTextBox.ShortcutsEnabled = true;
            this.RefArtículoTextBox.Size = new System.Drawing.Size(116, 23);
            this.RefArtículoTextBox.TabIndex = 34;
            this.RefArtículoTextBox.UseSelectable = true;
            this.RefArtículoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RefArtículoTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_cantidad
            // 
            // 
            // 
            // 
            this.tb_cantidad.CustomButton.Image = null;
            this.tb_cantidad.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.tb_cantidad.CustomButton.Name = "";
            this.tb_cantidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_cantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_cantidad.CustomButton.TabIndex = 1;
            this.tb_cantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_cantidad.CustomButton.UseSelectable = true;
            this.tb_cantidad.CustomButton.Visible = false;
            this.tb_cantidad.Lines = new string[0];
            this.tb_cantidad.Location = new System.Drawing.Point(176, 259);
            this.tb_cantidad.MaxLength = 32767;
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.PasswordChar = '\0';
            this.tb_cantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_cantidad.SelectedText = "";
            this.tb_cantidad.SelectionLength = 0;
            this.tb_cantidad.SelectionStart = 0;
            this.tb_cantidad.ShortcutsEnabled = true;
            this.tb_cantidad.Size = new System.Drawing.Size(149, 23);
            this.tb_cantidad.TabIndex = 35;
            this.tb_cantidad.UseSelectable = true;
            this.tb_cantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_cantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_vueltas
            // 
            // 
            // 
            // 
            this.tb_vueltas.CustomButton.Image = null;
            this.tb_vueltas.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.tb_vueltas.CustomButton.Name = "";
            this.tb_vueltas.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_vueltas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_vueltas.CustomButton.TabIndex = 1;
            this.tb_vueltas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_vueltas.CustomButton.UseSelectable = true;
            this.tb_vueltas.CustomButton.Visible = false;
            this.tb_vueltas.Lines = new string[0];
            this.tb_vueltas.Location = new System.Drawing.Point(780, 313);
            this.tb_vueltas.MaxLength = 32767;
            this.tb_vueltas.Name = "tb_vueltas";
            this.tb_vueltas.PasswordChar = '\0';
            this.tb_vueltas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_vueltas.SelectedText = "";
            this.tb_vueltas.SelectionLength = 0;
            this.tb_vueltas.SelectionStart = 0;
            this.tb_vueltas.ShortcutsEnabled = true;
            this.tb_vueltas.Size = new System.Drawing.Size(119, 23);
            this.tb_vueltas.TabIndex = 36;
            this.tb_vueltas.UseSelectable = true;
            this.tb_vueltas.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_vueltas.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_pago
            // 
            // 
            // 
            // 
            this.tb_pago.CustomButton.Image = null;
            this.tb_pago.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.tb_pago.CustomButton.Name = "";
            this.tb_pago.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_pago.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_pago.CustomButton.TabIndex = 1;
            this.tb_pago.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_pago.CustomButton.UseSelectable = true;
            this.tb_pago.CustomButton.Visible = false;
            this.tb_pago.Lines = new string[0];
            this.tb_pago.Location = new System.Drawing.Point(780, 284);
            this.tb_pago.MaxLength = 32767;
            this.tb_pago.Name = "tb_pago";
            this.tb_pago.PasswordChar = '\0';
            this.tb_pago.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_pago.SelectedText = "";
            this.tb_pago.SelectionLength = 0;
            this.tb_pago.SelectionStart = 0;
            this.tb_pago.ShortcutsEnabled = true;
            this.tb_pago.Size = new System.Drawing.Size(119, 23);
            this.tb_pago.TabIndex = 37;
            this.tb_pago.UseSelectable = true;
            this.tb_pago.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_pago.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(780, 255);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ReadOnly = true;
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(119, 23);
            this.metroTextBox1.TabIndex = 38;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(176, 172);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(149, 23);
            this.metroTextBox2.TabIndex = 39;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(176, 230);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ReadOnly = true;
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(149, 23);
            this.metroTextBox3.TabIndex = 40;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(14, 263);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(62, 19);
            this.metroLabel10.TabIndex = 41;
            this.metroLabel10.Text = "Cantidad";
            // 
            // accesoriosToolStripMenuItem
            // 
            this.accesoriosToolStripMenuItem.Name = "accesoriosToolStripMenuItem";
            this.accesoriosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.accesoriosToolStripMenuItem.Text = "Accesorios";
            this.accesoriosToolStripMenuItem.Click += new System.EventHandler(this.accesoriosToolStripMenuItem_Click);
            // 
            // fr_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 349);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.tb_pago);
            this.Controls.Add(this.tb_vueltas);
            this.Controls.Add(this.tb_cantidad);
            this.Controls.Add(this.RefArtículoTextBox);
            this.Controls.Add(this.CédulaTextBox);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fr_principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem verVentasToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox CédulaTextBox;
        private MetroFramework.Controls.MetroTextBox RefArtículoTextBox;
        private MetroFramework.Controls.MetroTextBox tb_cantidad;
        private MetroFramework.Controls.MetroTextBox tb_vueltas;
        private MetroFramework.Controls.MetroTextBox tb_pago;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.ToolStripMenuItem accesoriosToolStripMenuItem;
    }
}