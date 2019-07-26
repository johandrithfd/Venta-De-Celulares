namespace VentaDeCelulares
{
    partial class fr_ver_accesorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_ver_accesorios));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmn_código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_volver = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_código,
            this.clmn_precio,
            this.clmn_color,
            this.clmn_marca,
            this.clmn_cantidad,
            this.clmn_tipo});
            this.dataGridView1.Location = new System.Drawing.Point(23, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // clmn_código
            // 
            this.clmn_código.Frozen = true;
            this.clmn_código.HeaderText = "Código";
            this.clmn_código.Name = "clmn_código";
            this.clmn_código.ReadOnly = true;
            // 
            // clmn_precio
            // 
            this.clmn_precio.Frozen = true;
            this.clmn_precio.HeaderText = "Precio";
            this.clmn_precio.Name = "clmn_precio";
            this.clmn_precio.ReadOnly = true;
            // 
            // clmn_color
            // 
            this.clmn_color.Frozen = true;
            this.clmn_color.HeaderText = "Color";
            this.clmn_color.Name = "clmn_color";
            this.clmn_color.ReadOnly = true;
            // 
            // clmn_marca
            // 
            this.clmn_marca.Frozen = true;
            this.clmn_marca.HeaderText = "Marca";
            this.clmn_marca.Name = "clmn_marca";
            this.clmn_marca.ReadOnly = true;
            // 
            // clmn_cantidad
            // 
            this.clmn_cantidad.Frozen = true;
            this.clmn_cantidad.HeaderText = "Cantidad";
            this.clmn_cantidad.Name = "clmn_cantidad";
            this.clmn_cantidad.ReadOnly = true;
            // 
            // clmn_tipo
            // 
            this.clmn_tipo.Frozen = true;
            this.clmn_tipo.HeaderText = "Tipo";
            this.clmn_tipo.Name = "clmn_tipo";
            this.clmn_tipo.ReadOnly = true;
            // 
            // bt_volver
            // 
            this.bt_volver.Location = new System.Drawing.Point(593, 258);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(75, 23);
            this.bt_volver.TabIndex = 2;
            this.bt_volver.Text = "Volver";
            this.bt_volver.UseSelectable = true;
            this.bt_volver.Click += new System.EventHandler(this.bt_volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ver Aceesorios";
            // 
            // fr_ver_accesorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_volver);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fr_ver_accesorios";
            this.Text = "Ver accesorios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_código;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_tipo;
        private MetroFramework.Controls.MetroButton bt_volver;
        private System.Windows.Forms.Label label1;
    }
}