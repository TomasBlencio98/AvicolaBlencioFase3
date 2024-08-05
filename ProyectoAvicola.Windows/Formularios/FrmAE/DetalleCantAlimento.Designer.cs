namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    partial class DetalleCantAlimento
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
            TextBoxCantidadAlimento = new TextBox();
            label1 = new Label();
            ButtonCancelar = new Button();
            ButtonAceptar = new Button();
            label2 = new Label();
            ComboBoxAlimento = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // TextBoxCantidadAlimento
            // 
            TextBoxCantidadAlimento.Location = new Point(115, 88);
            TextBoxCantidadAlimento.Name = "TextBoxCantidadAlimento";
            TextBoxCantidadAlimento.PlaceholderText = "Ingrese cantidad";
            TextBoxCantidadAlimento.Size = new Size(136, 23);
            TextBoxCantidadAlimento.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 87);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Cantidad:";
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCancelar.Location = new Point(167, 140);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(84, 48);
            ButtonCancelar.TabIndex = 3;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonAceptar
            // 
            ButtonAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonAceptar.Location = new Point(33, 140);
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new Size(84, 48);
            ButtonAceptar.TabIndex = 4;
            ButtonAceptar.Text = "Aceptar";
            ButtonAceptar.UseVisualStyleBackColor = true;
            ButtonAceptar.Click += ButtonAceptar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 32);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 5;
            label2.Text = "Alimento:";
            // 
            // ComboBoxAlimento
            // 
            ComboBoxAlimento.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxAlimento.FormattingEnabled = true;
            ComboBoxAlimento.Location = new Point(115, 33);
            ComboBoxAlimento.Name = "ComboBoxAlimento";
            ComboBoxAlimento.Size = new Size(136, 23);
            ComboBoxAlimento.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // DetalleCantAlimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 214);
            Controls.Add(ComboBoxAlimento);
            Controls.Add(TextBoxCantidadAlimento);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonAceptar);
            Name = "DetalleCantAlimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalleCantAlimento";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxCantidadAlimento;
        private Label label1;
        private Button ButtonCancelar;
        private Button ButtonAceptar;
        private Label label2;
        private ComboBox ComboBoxAlimento;
        private ErrorProvider errorProvider1;
    }
}