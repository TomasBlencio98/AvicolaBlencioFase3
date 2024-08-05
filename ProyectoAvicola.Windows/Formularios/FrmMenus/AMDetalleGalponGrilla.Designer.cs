namespace ProyectoAvicola.Windows.Formularios.FrmMenus
{
    partial class AMDetalleGalponGrilla
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
            panel1 = new Panel();
            DgvDatos = new DataGridView();
            ColumnaAlimento = new DataGridViewTextBoxColumn();
            ColumnaCantidad = new DataGridViewTextBoxColumn();
            ColumnaFecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDatos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(DgvDatos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 198);
            panel1.TabIndex = 0;
            // 
            // DgvDatos
            // 
            DgvDatos.AllowUserToAddRows = false;
            DgvDatos.AllowUserToDeleteRows = false;
            DgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnaAlimento, ColumnaCantidad, ColumnaFecha });
            DgvDatos.Dock = DockStyle.Fill;
            DgvDatos.Location = new Point(0, 0);
            DgvDatos.Name = "DgvDatos";
            DgvDatos.ReadOnly = true;
            DgvDatos.RowTemplate.Height = 25;
            DgvDatos.Size = new Size(325, 198);
            DgvDatos.TabIndex = 0;
            // 
            // ColumnaAlimento
            // 
            ColumnaAlimento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaAlimento.HeaderText = "Descripcion";
            ColumnaAlimento.Name = "ColumnaAlimento";
            ColumnaAlimento.ReadOnly = true;
            // 
            // ColumnaCantidad
            // 
            ColumnaCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaCantidad.HeaderText = "Cantidad";
            ColumnaCantidad.Name = "ColumnaCantidad";
            ColumnaCantidad.ReadOnly = true;
            // 
            // ColumnaFecha
            // 
            ColumnaFecha.HeaderText = "Fecha";
            ColumnaFecha.Name = "ColumnaFecha";
            ColumnaFecha.ReadOnly = true;
            // 
            // AMDetalleGalponGrilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 198);
            Controls.Add(panel1);
            Name = "AMDetalleGalponGrilla";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AMDetalleGalponGrilla";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView DgvDatos;
        private DataGridViewTextBoxColumn ColumnaAlimento;
        private DataGridViewTextBoxColumn ColumnaCantidad;
        private DataGridViewTextBoxColumn ColumnaFecha;
    }
}