namespace ProyectoAvicola.Windows.Formularios.FrmMenus
{
    partial class ProveedoresMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedoresMenu));
            toolStrip1 = new ToolStrip();
            TsbButtonAgregar = new ToolStripButton();
            TsbButtonBorrar = new ToolStripButton();
            TsbButtonEditar = new ToolStripButton();
            TsbButtonAsignarGranja = new ToolStripButton();
            TsbButtonActualizar = new ToolStripButton();
            panel1 = new Panel();
            DgvDatos = new DataGridView();
            ColumnPersona = new DataGridViewTextBoxColumn();
            ColumnTelefono = new DataGridViewTextBoxColumn();
            ColumnLocalidad = new DataGridViewTextBoxColumn();
            ColumnGranjas = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsbButtonAgregar, TsbButtonBorrar, TsbButtonEditar, TsbButtonAsignarGranja, TsbButtonActualizar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(551, 70);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // TsbButtonAgregar
            // 
            TsbButtonAgregar.Image = (Image)resources.GetObject("TsbButtonAgregar.Image");
            TsbButtonAgregar.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonAgregar.ImageTransparentColor = Color.Magenta;
            TsbButtonAgregar.Name = "TsbButtonAgregar";
            TsbButtonAgregar.Size = new Size(52, 67);
            TsbButtonAgregar.Text = "Nuevo";
            TsbButtonAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonAgregar.Click += TsbButtonAgregar_Click;
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
            // TsbButtonAsignarGranja
            // 
            TsbButtonAsignarGranja.Image = (Image)resources.GetObject("TsbButtonAsignarGranja.Image");
            TsbButtonAsignarGranja.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonAsignarGranja.ImageTransparentColor = Color.Magenta;
            TsbButtonAsignarGranja.Name = "TsbButtonAsignarGranja";
            TsbButtonAsignarGranja.Size = new Size(67, 67);
            TsbButtonAsignarGranja.Text = "A/E Granja";
            TsbButtonAsignarGranja.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonAsignarGranja.Click += TsbButtonAsignarGranja_Click;
            // 
            // TsbButtonActualizar
            // 
            TsbButtonActualizar.Image = (Image)resources.GetObject("TsbButtonActualizar.Image");
            TsbButtonActualizar.ImageScaling = ToolStripItemImageScaling.None;
            TsbButtonActualizar.ImageTransparentColor = Color.Magenta;
            TsbButtonActualizar.Name = "TsbButtonActualizar";
            TsbButtonActualizar.Size = new Size(63, 67);
            TsbButtonActualizar.Text = "Actualizar";
            TsbButtonActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbButtonActualizar.Click += TsbButtonActualizar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(DgvDatos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 264);
            panel1.TabIndex = 2;
            // 
            // DgvDatos
            // 
            DgvDatos.AllowUserToAddRows = false;
            DgvDatos.AllowUserToDeleteRows = false;
            DgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnPersona, ColumnTelefono, ColumnLocalidad, ColumnGranjas });
            DgvDatos.Dock = DockStyle.Fill;
            DgvDatos.Location = new Point(0, 0);
            DgvDatos.Name = "DgvDatos";
            DgvDatos.ReadOnly = true;
            DgvDatos.RowTemplate.Height = 25;
            DgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDatos.Size = new Size(551, 264);
            DgvDatos.TabIndex = 0;
            // 
            // ColumnPersona
            // 
            ColumnPersona.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnPersona.HeaderText = "Persona";
            ColumnPersona.Name = "ColumnPersona";
            ColumnPersona.ReadOnly = true;
            // 
            // ColumnTelefono
            // 
            ColumnTelefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnTelefono.HeaderText = "Telefono";
            ColumnTelefono.Name = "ColumnTelefono";
            ColumnTelefono.ReadOnly = true;
            // 
            // ColumnLocalidad
            // 
            ColumnLocalidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnLocalidad.HeaderText = "Localidad";
            ColumnLocalidad.Name = "ColumnLocalidad";
            ColumnLocalidad.ReadOnly = true;
            // 
            // ColumnGranjas
            // 
            ColumnGranjas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnGranjas.HeaderText = "Granjas Asociadas";
            ColumnGranjas.Name = "ColumnGranjas";
            ColumnGranjas.ReadOnly = true;
            // 
            // ProveedoresMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 334);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "ProveedoresMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProveedoresMenu";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton TsbButtonAgregar;
        private ToolStripButton TsbButtonBorrar;
        private ToolStripButton TsbButtonEditar;
        private Panel panel1;
        private DataGridView DgvDatos;
        private DataGridViewTextBoxColumn ColumnPersona;
        private DataGridViewTextBoxColumn ColumnTelefono;
        private DataGridViewTextBoxColumn ColumnLocalidad;
        private DataGridViewTextBoxColumn ColumnGranjas;
        private ToolStripButton TsbButtonAsignarGranja;
        private ToolStripButton TsbButtonActualizar;
    }
}