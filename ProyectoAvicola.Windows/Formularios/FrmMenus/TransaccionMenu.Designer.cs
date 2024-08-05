namespace ProyectoAvicola.Windows.Formularios.FrmMenus
{
    partial class TransaccionMenu
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
            label1 = new Label();
            ComboBoxProveedores = new ComboBox();
            dateTimePickerFecha = new DateTimePicker();
            label2 = new Label();
            groupBox1 = new GroupBox();
            buttonAceptarAlimentos = new Button();
            label4 = new Label();
            numericUpDownCantidadAlimentos = new NumericUpDown();
            label3 = new Label();
            comboBoxAlimento = new ComboBox();
            groupBox2 = new GroupBox();
            buttonAceptarMedicamentos = new Button();
            label5 = new Label();
            numericUpDownCantidadMedicamentos = new NumericUpDown();
            label6 = new Label();
            comboBoxMedicamentos = new ComboBox();
            label7 = new Label();
            panel1 = new Panel();
            DgvDatos = new DataGridView();
            ColumnTipo = new DataGridViewTextBoxColumn();
            ColumnDescripcion = new DataGridViewTextBoxColumn();
            ColumnCantidad = new DataGridViewTextBoxColumn();
            buttonQuitar = new Button();
            buttonFinalizar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidadAlimentos).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidadMedicamentos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Proveedores:";
            // 
            // ComboBoxProveedores
            // 
            ComboBoxProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxProveedores.FormattingEnabled = true;
            ComboBoxProveedores.Location = new Point(112, 30);
            ComboBoxProveedores.Name = "ComboBoxProveedores";
            ComboBoxProveedores.Size = new Size(156, 23);
            ComboBoxProveedores.TabIndex = 1;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Format = DateTimePickerFormat.Short;
            dateTimePickerFecha.Location = new Point(112, 76);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(156, 23);
            dateTimePickerFecha.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "Fecha:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAceptarAlimentos);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDownCantidadAlimentos);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBoxAlimento);
            groupBox1.Location = new Point(12, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 139);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alimentos";
            // 
            // buttonAceptarAlimentos
            // 
            buttonAceptarAlimentos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAceptarAlimentos.Location = new Point(73, 104);
            buttonAceptarAlimentos.Name = "buttonAceptarAlimentos";
            buttonAceptarAlimentos.Size = new Size(75, 29);
            buttonAceptarAlimentos.TabIndex = 4;
            buttonAceptarAlimentos.Text = "Aceptar";
            buttonAceptarAlimentos.UseVisualStyleBackColor = true;
            buttonAceptarAlimentos.Click += buttonAceptarAlimentos_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 63);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Cantidad:";
            // 
            // numericUpDownCantidadAlimentos
            // 
            numericUpDownCantidadAlimentos.Location = new Point(122, 60);
            numericUpDownCantidadAlimentos.Name = "numericUpDownCantidadAlimentos";
            numericUpDownCantidadAlimentos.Size = new Size(134, 23);
            numericUpDownCantidadAlimentos.TabIndex = 2;
            numericUpDownCantidadAlimentos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 25);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 1;
            label3.Text = "Alimentos:";
            // 
            // comboBoxAlimento
            // 
            comboBoxAlimento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAlimento.FormattingEnabled = true;
            comboBoxAlimento.Location = new Point(122, 22);
            comboBoxAlimento.Name = "comboBoxAlimento";
            comboBoxAlimento.Size = new Size(134, 23);
            comboBoxAlimento.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonAceptarMedicamentos);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numericUpDownCantidadMedicamentos);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(comboBoxMedicamentos);
            groupBox2.Location = new Point(12, 307);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(274, 139);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Medicamentos";
            // 
            // buttonAceptarMedicamentos
            // 
            buttonAceptarMedicamentos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAceptarMedicamentos.Location = new Point(73, 104);
            buttonAceptarMedicamentos.Name = "buttonAceptarMedicamentos";
            buttonAceptarMedicamentos.Size = new Size(75, 29);
            buttonAceptarMedicamentos.TabIndex = 4;
            buttonAceptarMedicamentos.Text = "Aceptar";
            buttonAceptarMedicamentos.UseVisualStyleBackColor = true;
            buttonAceptarMedicamentos.Click += buttonAceptarMedicamentos_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 63);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 3;
            label5.Text = "Cantidad:";
            // 
            // numericUpDownCantidadMedicamentos
            // 
            numericUpDownCantidadMedicamentos.Location = new Point(122, 60);
            numericUpDownCantidadMedicamentos.Name = "numericUpDownCantidadMedicamentos";
            numericUpDownCantidadMedicamentos.Size = new Size(134, 23);
            numericUpDownCantidadMedicamentos.TabIndex = 2;
            numericUpDownCantidadMedicamentos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 25);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 1;
            label6.Text = "Medicamentos:";
            // 
            // comboBoxMedicamentos
            // 
            comboBoxMedicamentos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMedicamentos.FormattingEnabled = true;
            comboBoxMedicamentos.Location = new Point(122, 22);
            comboBoxMedicamentos.Name = "comboBoxMedicamentos";
            comboBoxMedicamentos.Size = new Size(134, 23);
            comboBoxMedicamentos.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(457, 29);
            label7.Name = "label7";
            label7.Size = new Size(105, 32);
            label7.TabIndex = 6;
            label7.Text = "REMITO";
            // 
            // panel1
            // 
            panel1.Controls.Add(DgvDatos);
            panel1.Location = new Point(345, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 311);
            panel1.TabIndex = 7;
            // 
            // DgvDatos
            // 
            DgvDatos.AllowUserToAddRows = false;
            DgvDatos.AllowUserToDeleteRows = false;
            DgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnTipo, ColumnDescripcion, ColumnCantidad });
            DgvDatos.Dock = DockStyle.Fill;
            DgvDatos.Location = new Point(0, 0);
            DgvDatos.Name = "DgvDatos";
            DgvDatos.ReadOnly = true;
            DgvDatos.RowTemplate.Height = 25;
            DgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDatos.Size = new Size(309, 311);
            DgvDatos.TabIndex = 0;
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
            // buttonQuitar
            // 
            buttonQuitar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonQuitar.Location = new Point(345, 420);
            buttonQuitar.Name = "buttonQuitar";
            buttonQuitar.Size = new Size(74, 42);
            buttonQuitar.TabIndex = 8;
            buttonQuitar.Text = "Quitar";
            buttonQuitar.UseVisualStyleBackColor = true;
            buttonQuitar.Click += buttonQuitar_Click;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFinalizar.Location = new Point(580, 420);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(74, 42);
            buttonFinalizar.TabIndex = 8;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = true;
            buttonFinalizar.Click += buttonFinalizar_Click;
            // 
            // TransaccionMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 474);
            Controls.Add(buttonFinalizar);
            Controls.Add(buttonQuitar);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(ComboBoxProveedores);
            Controls.Add(label1);
            Name = "TransaccionMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransaccionMenu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidadAlimentos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidadMedicamentos).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox ComboBoxProveedores;
        private DateTimePicker dateTimePickerFecha;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private NumericUpDown numericUpDownCantidadAlimentos;
        private Label label3;
        private ComboBox comboBoxAlimento;
        private Button buttonAceptarAlimentos;
        private GroupBox groupBox2;
        private Button buttonAceptarMedicamentos;
        private Label label5;
        private NumericUpDown numericUpDownCantidadMedicamentos;
        private Label label6;
        private ComboBox comboBoxMedicamentos;
        private Label label7;
        private Panel panel1;
        private DataGridView DgvDatos;
        private Button buttonQuitar;
        private Button buttonFinalizar;
        private DataGridViewTextBoxColumn ColumnTipo;
        private DataGridViewTextBoxColumn ColumnDescripcion;
        private DataGridViewTextBoxColumn ColumnCantidad;
    }
}