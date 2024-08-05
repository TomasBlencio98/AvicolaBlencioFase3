
namespace ProyectoAvicola.Windows.Formularios.FrmMenus
{
    partial class TransaccionHistorialMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransaccionHistorialMenu));
            toolStrip1 = new ToolStrip();
            TsbButtonDetalles = new ToolStripButton();
            TsbButtonActualizar = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            DgvDatosTransacciones = new DataGridView();
            ColumnTransaccion = new DataGridViewTextBoxColumn();
            ColumnProveedor = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            DgvDatosDetalles = new DataGridView();
            ColumnTipo = new DataGridViewTextBoxColumn();
            ColumnDescripcion = new DataGridViewTextBoxColumn();
            ColumnCantidad = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDatosTransacciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvDatosDetalles).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsbButtonDetalles, TsbButtonActualizar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(746, 69);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // TsbButtonDetalles
            // 
            TsbButtonDetalles.Image = (Image)resources.GetObject("TsbButtonDetalles.Image");
            TsbButtonDetalles.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonDetalles.ImageTransparentColor = Color.Magenta;
            TsbButtonDetalles.Name = "TsbButtonDetalles";
            TsbButtonDetalles.Size = new Size(117, 66);
            TsbButtonDetalles.Text = "Detalles Transaccion";
            TsbButtonDetalles.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonDetalles.Click += TsbButtonDetalles_Click;
            // 
            // TsbButtonActualizar
            // 
            TsbButtonActualizar.Image = (Image)resources.GetObject("TsbButtonActualizar.Image");
            TsbButtonActualizar.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonActualizar.ImageTransparentColor = Color.Magenta;
            TsbButtonActualizar.Name = "TsbButtonActualizar";
            TsbButtonActualizar.Size = new Size(63, 66);
            TsbButtonActualizar.Text = "Actualizar";
            TsbButtonActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonActualizar.Click += TsbButtonActualizar_Click_2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 69);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(DgvDatosTransacciones);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DgvDatosDetalles);
            splitContainer1.Size = new Size(746, 275);
            splitContainer1.SplitterDistance = 401;
            splitContainer1.TabIndex = 1;
            // 
            // DgvDatosTransacciones
            // 
            DgvDatosTransacciones.AllowUserToAddRows = false;
            DgvDatosTransacciones.AllowUserToDeleteRows = false;
            DgvDatosTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDatosTransacciones.Columns.AddRange(new DataGridViewColumn[] { ColumnTransaccion, ColumnProveedor, ColumnFecha });
            DgvDatosTransacciones.Dock = DockStyle.Fill;
            DgvDatosTransacciones.Location = new Point(0, 0);
            DgvDatosTransacciones.Name = "DgvDatosTransacciones";
            DgvDatosTransacciones.ReadOnly = true;
            DgvDatosTransacciones.RowTemplate.Height = 25;
            DgvDatosTransacciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDatosTransacciones.Size = new Size(401, 275);
            DgvDatosTransacciones.TabIndex = 0;
            // 
            // ColumnTransaccion
            // 
            ColumnTransaccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumnTransaccion.HeaderText = "N° Transaccion";
            ColumnTransaccion.Name = "ColumnTransaccion";
            ColumnTransaccion.ReadOnly = true;
            ColumnTransaccion.Width = 111;
            // 
            // ColumnProveedor
            // 
            ColumnProveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnProveedor.HeaderText = "Proveedor";
            ColumnProveedor.Name = "ColumnProveedor";
            ColumnProveedor.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            ColumnFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnFecha.HeaderText = "Fecha";
            ColumnFecha.Name = "ColumnFecha";
            ColumnFecha.ReadOnly = true;
            // 
            // DgvDatosDetalles
            // 
            DgvDatosDetalles.AllowUserToAddRows = false;
            DgvDatosDetalles.AllowUserToDeleteRows = false;
            DgvDatosDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDatosDetalles.Columns.AddRange(new DataGridViewColumn[] { ColumnTipo, ColumnDescripcion, ColumnCantidad });
            DgvDatosDetalles.Dock = DockStyle.Fill;
            DgvDatosDetalles.Location = new Point(0, 0);
            DgvDatosDetalles.Name = "DgvDatosDetalles";
            DgvDatosDetalles.ReadOnly = true;
            DgvDatosDetalles.RowTemplate.Height = 25;
            DgvDatosDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDatosDetalles.Size = new Size(341, 275);
            DgvDatosDetalles.TabIndex = 0;
            // 
            // ColumnTipo
            // 
            ColumnTipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnTipo.HeaderText = "Tipo";
            ColumnTipo.Name = "ColumnTipo";
            ColumnTipo.ReadOnly = true;
            // 
            // ColumnDescripcion
            // 
            ColumnDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnDescripcion.HeaderText = "Descripcion";
            ColumnDescripcion.Name = "ColumnDescripcion";
            ColumnDescripcion.ReadOnly = true;
            // 
            // ColumnCantidad
            // 
            ColumnCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCantidad.HeaderText = "Cantidad";
            ColumnCantidad.Name = "ColumnCantidad";
            ColumnCantidad.ReadOnly = true;
            // 
            // TransaccionHistorialMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 344);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "TransaccionHistorialMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransaccionHistorialMenu";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDatosTransacciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvDatosDetalles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton TsbButtonDetalles;
        private SplitContainer splitContainer1;
        private DataGridView DgvDatosTransacciones;
        private DataGridView DgvDatosDetalles;
        private DataGridViewTextBoxColumn ColumnTransaccion;
        private DataGridViewTextBoxColumn ColumnProveedor;
        private DataGridViewTextBoxColumn ColumnFecha;
        private DataGridViewTextBoxColumn ColumnTipo;
        private DataGridViewTextBoxColumn ColumnDescripcion;
        private DataGridViewTextBoxColumn ColumnCantidad;
        private ToolStripButton TsbButtonActualizar;
    }
}