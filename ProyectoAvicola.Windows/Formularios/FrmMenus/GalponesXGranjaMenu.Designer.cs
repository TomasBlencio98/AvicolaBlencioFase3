namespace ProyectoAvicola.Windows.Formularios.FrmMenus
{
    partial class GalponesXGranjaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalponesXGranjaMenu));
            toolStrip1 = new ToolStrip();
            TsbButtonDetalleGalpon = new ToolStripButton();
            panel1 = new Panel();
            DgvDatos = new DataGridView();
            ColumnGalpon = new DataGridViewTextBoxColumn();
            ColumnCapacidad = new DataGridViewTextBoxColumn();
            ColumnaGranja = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsbButtonDetalleGalpon });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(489, 54);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // TsbButtonDetalleGalpon
            // 
            TsbButtonDetalleGalpon.Image = (Image)resources.GetObject("TsbButtonDetalleGalpon.Image");
            TsbButtonDetalleGalpon.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonDetalleGalpon.ImageTransparentColor = Color.Magenta;
            TsbButtonDetalleGalpon.Name = "TsbButtonDetalleGalpon";
            TsbButtonDetalleGalpon.Size = new Size(85, 51);
            TsbButtonDetalleGalpon.Text = "DetalleGalpon";
            TsbButtonDetalleGalpon.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonDetalleGalpon.Click += TsbButtonDetalleGalpon_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(DgvDatos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 209);
            panel1.TabIndex = 1;
            // 
            // DgvDatos
            // 
            DgvDatos.AllowUserToAddRows = false;
            DgvDatos.AllowUserToDeleteRows = false;
            DgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnGalpon, ColumnCapacidad, ColumnaGranja });
            DgvDatos.Dock = DockStyle.Fill;
            DgvDatos.Location = new Point(0, 0);
            DgvDatos.Name = "DgvDatos";
            DgvDatos.ReadOnly = true;
            DgvDatos.RowTemplate.Height = 25;
            DgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDatos.Size = new Size(489, 209);
            DgvDatos.TabIndex = 0;
            // 
            // ColumnGalpon
            // 
            ColumnGalpon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnGalpon.HeaderText = "Galpon";
            ColumnGalpon.Name = "ColumnGalpon";
            ColumnGalpon.ReadOnly = true;
            // 
            // ColumnCapacidad
            // 
            ColumnCapacidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCapacidad.HeaderText = "Capacidad";
            ColumnCapacidad.Name = "ColumnCapacidad";
            ColumnCapacidad.ReadOnly = true;
            // 
            // ColumnaGranja
            // 
            ColumnaGranja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaGranja.HeaderText = "Granja";
            ColumnaGranja.Name = "ColumnaGranja";
            ColumnaGranja.ReadOnly = true;
            // 
            // GalponesXGranjaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 263);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "GalponesXGranjaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GalponesXGranjaMenu";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private Panel panel1;
        private DataGridView DgvDatos;
        private DataGridViewTextBoxColumn ColumnGalpon;
        private DataGridViewTextBoxColumn ColumnCapacidad;
        private DataGridViewTextBoxColumn ColumnaGranja;
        private ToolStripButton TsbButtonDetalleGalpon;
    }
}