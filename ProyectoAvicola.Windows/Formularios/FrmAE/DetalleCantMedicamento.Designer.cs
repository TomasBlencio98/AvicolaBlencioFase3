namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    partial class DetalleCantMedicamento
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
            components = new System.ComponentModel.Container();
            ComboBoxMedicamento = new ComboBox();
            TextBoxCantidadMedi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ButtonCancelar = new Button();
            ButtonAceptar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ComboBoxMedicamento
            // 
            ComboBoxMedicamento.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxMedicamento.FormattingEnabled = true;
            ComboBoxMedicamento.Location = new Point(141, 30);
            ComboBoxMedicamento.Name = "ComboBoxMedicamento";
            ComboBoxMedicamento.Size = new Size(139, 23);
            ComboBoxMedicamento.TabIndex = 13;
            // 
            // TextBoxCantidadMedi
            // 
            TextBoxCantidadMedi.Location = new Point(108, 85);
            TextBoxCantidadMedi.Name = "TextBoxCantidadMedi";
            TextBoxCantidadMedi.PlaceholderText = "Ingrese cantidad";
            TextBoxCantidadMedi.Size = new Size(172, 23);
            TextBoxCantidadMedi.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 29);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 10;
            label2.Text = "Medicamento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 84);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 11;
            label1.Text = "Cantidad:";
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCancelar.Location = new Point(196, 137);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(84, 48);
            ButtonCancelar.TabIndex = 8;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonAceptar
            // 
            ButtonAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonAceptar.Location = new Point(26, 137);
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new Size(84, 48);
            ButtonAceptar.TabIndex = 9;
            ButtonAceptar.Text = "Aceptar";
            ButtonAceptar.UseVisualStyleBackColor = true;
            ButtonAceptar.Click += ButtonAceptar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // DetalleCantMedicamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 216);
            Controls.Add(ComboBoxMedicamento);
            Controls.Add(TextBoxCantidadMedi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonAceptar);
            Name = "DetalleCantMedicamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalleCantMedicamento";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBoxMedicamento;
        private TextBox TextBoxCantidadMedi;
        private Label label2;
        private Label label1;
        private Button ButtonCancelar;
        private Button ButtonAceptar;
        private ErrorProvider errorProvider1;
    }
}