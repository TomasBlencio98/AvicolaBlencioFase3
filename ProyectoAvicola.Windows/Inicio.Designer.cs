namespace ProyectoAvicola.Windows
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            toolStrip1 = new ToolStrip();
            TsbButtonDetalleGranja = new ToolStripButton();
            TsbButtonGalpon = new ToolStripButton();
            TsbButtonEmpleados = new ToolStripButton();
            TsbButtonProveedores = new ToolStripButton();
            TsbButtonTransaccion = new ToolStripDropDownButton();
            nuevaTransaccionToolStripMenuItem = new ToolStripMenuItem();
            historialToolStripMenuItem = new ToolStripMenuItem();
            TsbButtonLocalidades = new ToolStripButton();
            TsbButtonAlimento = new ToolStripButton();
            TsbButtonMedicamento = new ToolStripButton();
            TsbButtonActualizar = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            DgvDatos = new DataGridView();
            ColumnaGranja = new DataGridViewTextBoxColumn();
            ColumnaLocalidad = new DataGridViewTextBoxColumn();
            ColumnaDireccion = new DataGridViewTextBoxColumn();
            ColumnaGalpones = new DataGridViewTextBoxColumn();
            ColumnaEmpleados = new DataGridViewTextBoxColumn();
            ColumnaProveedores = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsbButtonDetalleGranja, TsbButtonGalpon, TsbButtonEmpleados, TsbButtonProveedores, TsbButtonTransaccion, TsbButtonLocalidades, TsbButtonAlimento, TsbButtonMedicamento, TsbButtonActualizar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(692, 62);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // TsbButtonDetalleGranja
            // 
            TsbButtonDetalleGranja.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TsbButtonDetalleGranja.Image = (Image)resources.GetObject("TsbButtonDetalleGranja.Image");
            TsbButtonDetalleGranja.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonDetalleGranja.ImageTransparentColor = Color.Magenta;
            TsbButtonDetalleGranja.Name = "TsbButtonDetalleGranja";
            TsbButtonDetalleGranja.Size = new Size(81, 59);
            TsbButtonDetalleGranja.Text = "DetalleGranja";
            TsbButtonDetalleGranja.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonDetalleGranja.Click += TsbButtonDetalleGranja_Click;
            // 
            // TsbButtonGalpon
            // 
            TsbButtonGalpon.Image = (Image)resources.GetObject("TsbButtonGalpon.Image");
            TsbButtonGalpon.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonGalpon.ImageTransparentColor = Color.Magenta;
            TsbButtonGalpon.Name = "TsbButtonGalpon";
            TsbButtonGalpon.Size = new Size(60, 59);
            TsbButtonGalpon.Text = "Galpones";
            TsbButtonGalpon.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonGalpon.Click += TsbButtonGalpon_Click;
            // 
            // TsbButtonEmpleados
            // 
            TsbButtonEmpleados.Image = (Image)resources.GetObject("TsbButtonEmpleados.Image");
            TsbButtonEmpleados.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonEmpleados.ImageTransparentColor = Color.Magenta;
            TsbButtonEmpleados.Name = "TsbButtonEmpleados";
            TsbButtonEmpleados.Size = new Size(69, 59);
            TsbButtonEmpleados.Text = "Empleados";
            TsbButtonEmpleados.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonEmpleados.Click += TsbButtonEmpleados_Click;
            // 
            // TsbButtonProveedores
            // 
            TsbButtonProveedores.Image = (Image)resources.GetObject("TsbButtonProveedores.Image");
            TsbButtonProveedores.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonProveedores.ImageTransparentColor = Color.Magenta;
            TsbButtonProveedores.Name = "TsbButtonProveedores";
            TsbButtonProveedores.Size = new Size(76, 59);
            TsbButtonProveedores.Text = "Proveedores";
            TsbButtonProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonProveedores.Click += TsbButtonProveedores_Click;
            // 
            // TsbButtonTransaccion
            // 
            TsbButtonTransaccion.DropDownItems.AddRange(new ToolStripItem[] { nuevaTransaccionToolStripMenuItem, historialToolStripMenuItem });
            TsbButtonTransaccion.Image = (Image)resources.GetObject("TsbButtonTransaccion.Image");
            TsbButtonTransaccion.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonTransaccion.ImageTransparentColor = Color.Magenta;
            TsbButtonTransaccion.Name = "TsbButtonTransaccion";
            TsbButtonTransaccion.Size = new Size(82, 59);
            TsbButtonTransaccion.Text = "Transaccion";
            TsbButtonTransaccion.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // nuevaTransaccionToolStripMenuItem
            // 
            nuevaTransaccionToolStripMenuItem.Name = "nuevaTransaccionToolStripMenuItem";
            nuevaTransaccionToolStripMenuItem.Size = new Size(173, 22);
            nuevaTransaccionToolStripMenuItem.Text = "Nueva Transaccion";
            nuevaTransaccionToolStripMenuItem.Click += nuevaTransaccionToolStripMenuItem_Click;
            // 
            // historialToolStripMenuItem
            // 
            historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            historialToolStripMenuItem.Size = new Size(173, 22);
            historialToolStripMenuItem.Text = "Historial";
            historialToolStripMenuItem.Click += historialToolStripMenuItem_Click;
            // 
            // TsbButtonLocalidades
            // 
            TsbButtonLocalidades.Image = (Image)resources.GetObject("TsbButtonLocalidades.Image");
            TsbButtonLocalidades.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonLocalidades.ImageTransparentColor = Color.Magenta;
            TsbButtonLocalidades.Name = "TsbButtonLocalidades";
            TsbButtonLocalidades.Size = new Size(73, 59);
            TsbButtonLocalidades.Text = "Localidades";
            TsbButtonLocalidades.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonLocalidades.Click += TsbButtonLocalidades_Click;
            // 
            // TsbButtonAlimento
            // 
            TsbButtonAlimento.Image = (Image)resources.GetObject("TsbButtonAlimento.Image");
            TsbButtonAlimento.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonAlimento.ImageTransparentColor = Color.Magenta;
            TsbButtonAlimento.Name = "TsbButtonAlimento";
            TsbButtonAlimento.Size = new Size(60, 59);
            TsbButtonAlimento.Text = "Alimento";
            TsbButtonAlimento.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonAlimento.Click += TsbButtonAlimento_Click;
            // 
            // TsbButtonMedicamento
            // 
            TsbButtonMedicamento.Image = (Image)resources.GetObject("TsbButtonMedicamento.Image");
            TsbButtonMedicamento.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonMedicamento.ImageTransparentColor = Color.Magenta;
            TsbButtonMedicamento.Name = "TsbButtonMedicamento";
            TsbButtonMedicamento.Size = new Size(85, 59);
            TsbButtonMedicamento.Text = "Medicamento";
            TsbButtonMedicamento.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonMedicamento.Click += TsbButtonMedicamento_Click;
            // 
            // TsbButtonActualizar
            // 
            TsbButtonActualizar.Image = (Image)resources.GetObject("TsbButtonActualizar.Image");
            TsbButtonActualizar.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonActualizar.ImageTransparentColor = Color.Magenta;
            TsbButtonActualizar.Name = "TsbButtonActualizar";
            TsbButtonActualizar.Size = new Size(63, 59);
            TsbButtonActualizar.Text = "Actualizar";
            TsbButtonActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonActualizar.Click += TsbButtonActualizar_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 62);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.Desktop;
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.ForeColor = SystemColors.ControlText;
            splitContainer1.Panel1.ImeMode = ImeMode.NoControl;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DgvDatos);
            splitContainer1.Size = new Size(692, 312);
            splitContainer1.SplitterDistance = 53;
            splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(202, 12);
            label1.Name = "label1";
            label1.Size = new Size(207, 32);
            label1.TabIndex = 0;
            label1.Text = "AVICOLA NUÑEZ";
            // 
            // DgvDatos
            // 
            DgvDatos.AllowUserToAddRows = false;
            DgvDatos.AllowUserToDeleteRows = false;
            DgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnaGranja, ColumnaLocalidad, ColumnaDireccion, ColumnaGalpones, ColumnaEmpleados, ColumnaProveedores });
            DgvDatos.Dock = DockStyle.Fill;
            DgvDatos.Location = new Point(0, 0);
            DgvDatos.Name = "DgvDatos";
            DgvDatos.ReadOnly = true;
            DgvDatos.RowTemplate.Height = 25;
            DgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDatos.Size = new Size(692, 255);
            DgvDatos.TabIndex = 0;
            // 
            // ColumnaGranja
            // 
            ColumnaGranja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaGranja.HeaderText = "Granja";
            ColumnaGranja.Name = "ColumnaGranja";
            ColumnaGranja.ReadOnly = true;
            // 
            // ColumnaLocalidad
            // 
            ColumnaLocalidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaLocalidad.HeaderText = "Localidad";
            ColumnaLocalidad.Name = "ColumnaLocalidad";
            ColumnaLocalidad.ReadOnly = true;
            // 
            // ColumnaDireccion
            // 
            ColumnaDireccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaDireccion.HeaderText = "Direccion";
            ColumnaDireccion.Name = "ColumnaDireccion";
            ColumnaDireccion.ReadOnly = true;
            // 
            // ColumnaGalpones
            // 
            ColumnaGalpones.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaGalpones.HeaderText = "Galpones";
            ColumnaGalpones.Name = "ColumnaGalpones";
            ColumnaGalpones.ReadOnly = true;
            // 
            // ColumnaEmpleados
            // 
            ColumnaEmpleados.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaEmpleados.HeaderText = "Empleados";
            ColumnaEmpleados.Name = "ColumnaEmpleados";
            ColumnaEmpleados.ReadOnly = true;
            // 
            // ColumnaProveedores
            // 
            ColumnaProveedores.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaProveedores.HeaderText = "Proveedores";
            ColumnaProveedores.Name = "ColumnaProveedores";
            ColumnaProveedores.ReadOnly = true;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 374);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private SplitContainer splitContainer1;
        private DataGridView DgvDatos;
        private Label label1;
        private ToolStripButton TsbButtonDetalleGranja;
        private ToolStripButton TsbButtonEmpleados;
        private ToolStripButton TsbButtonProveedores;
        private ToolStripButton TsbButtonLocalidades;
        private ToolStripButton TsbButtonAlimento;
        private ToolStripButton TsbButtonMedicamento;
        private DataGridViewTextBoxColumn ColumnaGranja;
        private DataGridViewTextBoxColumn ColumnaLocalidad;
        private DataGridViewTextBoxColumn ColumnaDireccion;
        private DataGridViewTextBoxColumn ColumnaGalpones;
        private DataGridViewTextBoxColumn ColumnaEmpleados;
        private DataGridViewTextBoxColumn ColumnaProveedores;
        private ToolStripButton TsbButtonActualizar;
        private ToolStripDropDownButton TsbButtonTransaccion;
        private ToolStripMenuItem nuevaTransaccionToolStripMenuItem;
        private ToolStripMenuItem historialToolStripMenuItem;
        private ToolStripButton TsbButtonGalpon;
    }
}