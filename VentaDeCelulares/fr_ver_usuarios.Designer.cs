namespace VentaDeCelulares
{
    partial class fr_ver_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_ver_usuarios));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmn_identificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_volver = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_identificación,
            this.clmn_nombre,
            this.clmn_rol});
            this.dataGridView1.Location = new System.Drawing.Point(5, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // clmn_identificación
            // 
            this.clmn_identificación.Frozen = true;
            this.clmn_identificación.HeaderText = "Identificación";
            this.clmn_identificación.Name = "clmn_identificación";
            this.clmn_identificación.ReadOnly = true;
            // 
            // clmn_nombre
            // 
            this.clmn_nombre.Frozen = true;
            this.clmn_nombre.HeaderText = "Nombre";
            this.clmn_nombre.Name = "clmn_nombre";
            this.clmn_nombre.ReadOnly = true;
            // 
            // clmn_rol
            // 
            this.clmn_rol.Frozen = true;
            this.clmn_rol.HeaderText = "Rol";
            this.clmn_rol.Name = "clmn_rol";
            this.clmn_rol.ReadOnly = true;
            // 
            // b_volver
            // 
            this.b_volver.Location = new System.Drawing.Point(274, 231);
            this.b_volver.Name = "b_volver";
            this.b_volver.Size = new System.Drawing.Size(75, 23);
            this.b_volver.TabIndex = 2;
            this.b_volver.Text = "Volver";
            this.b_volver.UseSelectable = true;
            this.b_volver.Click += new System.EventHandler(this.b_volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ver Usuarios";
            // 
            // fr_ver_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(670, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_volver);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fr_ver_usuarios";
            this.Text = "Ver usuarios";
            this.Load += new System.EventHandler(this.fr_ver_usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_identificación;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_rol;
        private MetroFramework.Controls.MetroButton b_volver;
        private System.Windows.Forms.Label label1;
    }
}