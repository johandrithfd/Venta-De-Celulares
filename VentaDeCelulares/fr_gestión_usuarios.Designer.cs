namespace VentaDeCelulares
{
    partial class fr_gestión_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_gestión_usuarios));
            this.tb_identificación = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_contraseña = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.b_modificar = new MetroFramework.Controls.MetroButton();
            this.b_eliminar = new MetroFramework.Controls.MetroButton();
            this.b_registrar = new MetroFramework.Controls.MetroButton();
            this.b_cancelar = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_identificación
            // 
            this.tb_identificación.Location = new System.Drawing.Point(108, 117);
            this.tb_identificación.Name = "tb_identificación";
            this.tb_identificación.Size = new System.Drawing.Size(150, 20);
            this.tb_identificación.TabIndex = 4;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(108, 172);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(150, 20);
            this.tb_nombre.TabIndex = 5;
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.Location = new System.Drawing.Point(108, 223);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.Size = new System.Drawing.Size(150, 20);
            this.tb_contraseña.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verUsuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.verUsuariosToolStripMenuItem.Text = "Ver usuarios";
            this.verUsuariosToolStripMenuItem.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 118);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Identificacion";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(5, 173);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Nombre";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(5, 224);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Contraseña";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(5, 284);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(28, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Rol";
            // 
            // b_modificar
            // 
            this.b_modificar.Location = new System.Drawing.Point(5, 368);
            this.b_modificar.Name = "b_modificar";
            this.b_modificar.Size = new System.Drawing.Size(75, 23);
            this.b_modificar.TabIndex = 17;
            this.b_modificar.Text = "Modificar";
            this.b_modificar.UseSelectable = true;
            // 
            // b_eliminar
            // 
            this.b_eliminar.Location = new System.Drawing.Point(108, 368);
            this.b_eliminar.Name = "b_eliminar";
            this.b_eliminar.Size = new System.Drawing.Size(75, 23);
            this.b_eliminar.TabIndex = 18;
            this.b_eliminar.Text = "Eliminar";
            this.b_eliminar.UseSelectable = true;
            // 
            // b_registrar
            // 
            this.b_registrar.Location = new System.Drawing.Point(209, 368);
            this.b_registrar.Name = "b_registrar";
            this.b_registrar.Size = new System.Drawing.Size(75, 23);
            this.b_registrar.TabIndex = 19;
            this.b_registrar.Text = "Registrar";
            this.b_registrar.UseSelectable = true;
            // 
            // b_cancelar
            // 
            this.b_cancelar.Location = new System.Drawing.Point(311, 368);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(75, 23);
            this.b_cancelar.TabIndex = 20;
            this.b_cancelar.Text = "Cancelar";
            this.b_cancelar.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Cajero"});
            this.metroComboBox1.Location = new System.Drawing.Point(108, 274);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(150, 29);
            this.metroComboBox1.TabIndex = 21;
            this.metroComboBox1.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(343, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 261);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(579, 368);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 23;
            this.metroButton1.Text = "Volver";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // fr_gestión_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 414);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_registrar);
            this.Controls.Add(this.b_eliminar);
            this.Controls.Add(this.b_modificar);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tb_contraseña);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tb_identificación);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fr_gestión_usuarios";
            this.Text = "Gestión de usuarios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_identificación;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_contraseña;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton b_modificar;
        private MetroFramework.Controls.MetroButton b_eliminar;
        private MetroFramework.Controls.MetroButton b_registrar;
        private MetroFramework.Controls.MetroButton b_cancelar;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}