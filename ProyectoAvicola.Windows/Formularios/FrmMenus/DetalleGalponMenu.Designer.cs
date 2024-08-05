namespace ProyectoAvicola.Windows.Formularios.FrmMenus
{
    partial class DetalleGalponMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleGalponMenu));
            toolStrip1 = new ToolStrip();
            TsbButtonNuevoDetalleGalpon = new ToolStripButton();
            TsbButtonBorrar = new ToolStripButton();
            TsbButtonEditar = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            DgvDatos = new DataGridView();
            ColumnaDetalleGalponId = new DataGridViewTextBoxColumn();
            ColumnGalponId = new DataGridViewTextBoxColumn();
            ColumnaNombreGranja = new DataGridViewTextBoxColumn();
            ColumnNombreGalpon = new DataGridViewTextBoxColumn();
            ColumnaFechaIngreso = new DataGridViewTextBoxColumn();
            ColumnCapacidad = new DataGridViewTextBoxColumn();
            ColumnaIngreso = new DataGridViewTextBoxColumn();
            ColumnaFechaEgreso = new DataGridViewTextBoxColumn();
            ColumnaMortalidad = new DataGridViewButtonColumn();
            ColumnaMuerte = new DataGridViewTextBoxColumn();
            ColumnaVivos = new DataGridViewTextBoxColumn();
            ColumnaAlimento = new DataGridViewButtonColumn();
            ColumnaVerAlimentos = new DataGridViewButtonColumn();
            ColumnaMedicamento = new DataGridViewButtonColumn();
            ColumnaVerMedicamentos = new DataGridViewButtonColumn();
            ColumnaFinalizar = new DataGridViewButtonColumn();
            label1 = new Label();
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsbButtonNuevoDetalleGalpon, TsbButtonBorrar, TsbButtonEditar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1370, 70);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // TsbButtonNuevoDetalleGalpon
            // 
            TsbButtonNuevoDetalleGalpon.Image = (Image)resources.GetObject("TsbButtonNuevoDetalleGalpon.Image");
            TsbButtonNuevoDetalleGalpon.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonNuevoDetalleGalpon.ImageTransparentColor = Color.Magenta;
            TsbButtonNuevoDetalleGalpon.Name = "TsbButtonNuevoDetalleGalpon";
            TsbButtonNuevoDetalleGalpon.Size = new Size(126, 67);
            TsbButtonNuevoDetalleGalpon.Text = "Nuevo Detalle Galpon";
            TsbButtonNuevoDetalleGalpon.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonNuevoDetalleGalpon.Click += TsbButtonNuevoDetalleGalpon_Click;
            // 
            // TsbButtonBorrar
            // 
            TsbButtonBorrar.Image = (Image)resources.GetObject("TsbButtonBorrar.Image");
            TsbButtonBorrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonBorrar.ImageTransparentColor = Color.Magenta;
            TsbButtonBorrar.Name = "TsbButtonBorrar";
            TsbButtonBorrar.Size = new Size(52, 67);
            TsbButtonBorrar.Text = "Borrar";
            TsbButtonBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonBorrar.Click += TsbButtonBorrar_Click;
            // 
            // TsbButtonEditar
            // 
            TsbButtonEditar.Image = (Image)resources.GetObject("TsbButtonEditar.Image");
            TsbButtonEditar.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonEditar.ImageTransparentColor = Color.Magenta;
            TsbButtonEditar.Name = "TsbButtonEditar";
            TsbButtonEditar.Size = new Size(52, 67);
            TsbButtonEditar.Text = "Editar";
            TsbButtonEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonEditar.Click += TsbButtonEditar_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 70);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(DgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Desktop;
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(1370, 250);
            splitContainer1.SplitterDistance = 178;
            splitContainer1.TabIndex = 1;
            // 
            // DgvDatos
            // 
            DgvDatos.AllowUserToAddRows = false;
            DgvDatos.AllowUserToDeleteRows = false;
            DgvDatos.BackgroundColor = SystemColors.ButtonShadow;
            DgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnaDetalleGalponId, ColumnGalponId, ColumnaNombreGranja, ColumnNombreGalpon, ColumnaFechaIngreso, ColumnCapacidad, ColumnaIngreso, ColumnaFechaEgreso, ColumnaMortalidad, ColumnaMuerte, ColumnaVivos, ColumnaAlimento, ColumnaVerAlimentos, ColumnaMedicamento, ColumnaVerMedicamentos, ColumnaFinalizar });
            DgvDatos.Dock = DockStyle.Fill;
            DgvDatos.Location = new Point(0, 0);
            DgvDatos.Name = "DgvDatos";
            DgvDatos.ReadOnly = true;
            DgvDatos.RowTemplate.Height = 25;
            DgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDatos.Size = new Size(1370, 178);
            DgvDatos.TabIndex = 0;
            DgvDatos.CellContentClick += DgvDatos_CellContentClick;
            // 
            // ColumnaDetalleGalponId
            // 
            ColumnaDetalleGalponId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnaDetalleGalponId.HeaderText = "DetalleGalponId";
            ColumnaDetalleGalponId.Name = "ColumnaDetalleGalponId";
            ColumnaDetalleGalponId.ReadOnly = true;
            ColumnaDetalleGalponId.Visible = false;
            // 
            // ColumnGalponId
            // 
            ColumnGalponId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnGalponId.HeaderText = "GalponId";
            ColumnGalponId.Name = "ColumnGalponId";
            ColumnGalponId.ReadOnly = true;
            ColumnGalponId.Visible = false;
            // 
            // ColumnaNombreGranja
            // 
            ColumnaNombreGranja.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnaNombreGranja.HeaderText = "Granja";
            ColumnaNombreGranja.Name = "ColumnaNombreGranja";
            ColumnaNombreGranja.ReadOnly = true;
            ColumnaNombreGranja.Width = 66;
            // 
            // ColumnNombreGalpon
            // 
            ColumnNombreGalpon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnNombreGalpon.HeaderText = "Galpon";
            ColumnNombreGalpon.Name = "ColumnNombreGalpon";
            ColumnNombreGalpon.ReadOnly = true;
            ColumnNombreGalpon.Width = 70;
            // 
            // ColumnaFechaIngreso
            // 
            ColumnaFechaIngreso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaFechaIngreso.HeaderText = "F. Ingreso";
            ColumnaFechaIngreso.Name = "ColumnaFechaIngreso";
            ColumnaFechaIngreso.ReadOnly = true;
            // 
            // ColumnCapacidad
            // 
            ColumnCapacidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnCapacidad.HeaderText = "Capacidad";
            ColumnCapacidad.Name = "ColumnCapacidad";
            ColumnCapacidad.ReadOnly = true;
            ColumnCapacidad.Width = 88;
            // 
            // ColumnaIngreso
            // 
            ColumnaIngreso.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnaIngreso.HeaderText = "Ingreso";
            ColumnaIngreso.Name = "ColumnaIngreso";
            ColumnaIngreso.ReadOnly = true;
            ColumnaIngreso.Width = 71;
            // 
            // ColumnaFechaEgreso
            // 
            ColumnaFechaEgreso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaFechaEgreso.HeaderText = "F. Egreso";
            ColumnaFechaEgreso.Name = "ColumnaFechaEgreso";
            ColumnaFechaEgreso.ReadOnly = true;
            // 
            // ColumnaMortalidad
            // 
            ColumnaMortalidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaMortalidad.HeaderText = "New Mortalidad";
            ColumnaMortalidad.Name = "ColumnaMortalidad";
            ColumnaMortalidad.ReadOnly = true;
            // 
            // ColumnaMuerte
            // 
            ColumnaMuerte.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnaMuerte.HeaderText = "Muerte";
            ColumnaMuerte.Name = "ColumnaMuerte";
            ColumnaMuerte.ReadOnly = true;
            ColumnaMuerte.Width = 70;
            // 
            // ColumnaVivos
            // 
            ColumnaVivos.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnaVivos.HeaderText = "Vivos";
            ColumnaVivos.Name = "ColumnaVivos";
            ColumnaVivos.ReadOnly = true;
            ColumnaVivos.Width = 60;
            // 
            // ColumnaAlimento
            // 
            ColumnaAlimento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaAlimento.HeaderText = "New Alimento";
            ColumnaAlimento.Name = "ColumnaAlimento";
            ColumnaAlimento.ReadOnly = true;
            // 
            // ColumnaVerAlimentos
            // 
            ColumnaVerAlimentos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaVerAlimentos.HeaderText = "Ver Alimentos";
            ColumnaVerAlimentos.Name = "ColumnaVerAlimentos";
            ColumnaVerAlimentos.ReadOnly = true;
            // 
            // ColumnaMedicamento
            // 
            ColumnaMedicamento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaMedicamento.HeaderText = "New Medicamento";
            ColumnaMedicamento.Name = "ColumnaMedicamento";
            ColumnaMedicamento.ReadOnly = true;
            // 
            // ColumnaVerMedicamentos
            // 
            ColumnaVerMedicamentos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaVerMedicamentos.HeaderText = "Ver Medicamentos";
            ColumnaVerMedicamentos.Name = "ColumnaVerMedicamentos";
            ColumnaVerMedicamentos.ReadOnly = true;
            // 
            // ColumnaFinalizar
            // 
            ColumnaFinalizar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnaFinalizar.HeaderText = "Finalizar";
            ColumnaFinalizar.Name = "ColumnaFinalizar";
            ColumnaFinalizar.ReadOnly = true;
            ColumnaFinalizar.Width = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(677, 18);
            label1.Name = "label1";
            label1.Size = new Size(207, 32);
            label1.TabIndex = 0;
            label1.Text = "AVICOLA NUÑEZ";
            // 
            // DetalleGalponMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 320);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "DetalleGalponMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalleGalponMenu";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
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
        private ToolStripButton TsbButtonNuevoDetalleGalpon;
        private ToolStripButton TsbButtonBorrar;
        private ToolStripButton TsbButtonEditar;
        private DataGridViewTextBoxColumn ColumnaDetalleGalponId;
        private DataGridViewTextBoxColumn ColumnGalponId;
        private DataGridViewTextBoxColumn ColumnaNombreGranja;
        private DataGridViewTextBoxColumn ColumnNombreGalpon;
        private DataGridViewTextBoxColumn ColumnaFechaIngreso;
        private DataGridViewTextBoxColumn ColumnCapacidad;
        private DataGridViewTextBoxColumn ColumnaIngreso;
        private DataGridViewTextBoxColumn ColumnaFechaEgreso;
        private DataGridViewButtonColumn ColumnaMortalidad;
        private DataGridViewTextBoxColumn ColumnaMuerte;
        private DataGridViewTextBoxColumn ColumnaVivos;
        private DataGridViewButtonColumn ColumnaAlimento;
        private DataGridViewButtonColumn ColumnaVerAlimentos;
        private DataGridViewButtonColumn ColumnaMedicamento;
        private DataGridViewButtonColumn ColumnaVerMedicamentos;
        private DataGridViewButtonColumn ColumnaFinalizar;
        private Label label1;
    }
}