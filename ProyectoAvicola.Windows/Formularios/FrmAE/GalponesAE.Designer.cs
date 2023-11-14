namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    partial class GalponesAE
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
            ComboBoxGranjas = new ComboBox();
            label5 = new Label();
            TextBoxCapacidad = new TextBox();
            label4 = new Label();
            ButtonCancelar = new Button();
            ButtonAceptar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ComboBoxGranjas
            // 
            ComboBoxGranjas.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxGranjas.FormattingEnabled = true;
            ComboBoxGranjas.Location = new Point(113, 77);
            ComboBoxGranjas.Name = "ComboBoxGranjas";
            ComboBoxGranjas.Size = new Size(245, 23);
            ComboBoxGranjas.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 77);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 41;
            label5.Text = "Granja: ";
            // 
            // TextBoxCapacidad
            // 
            TextBoxCapacidad.Location = new Point(113, 29);
            TextBoxCapacidad.Name = "TextBoxCapacidad";
            TextBoxCapacidad.PlaceholderText = "Ingrese la capacidad del galpon";
            TextBoxCapacidad.Size = new Size(245, 23);
            TextBoxCapacidad.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 28);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 37;
            label4.Text = "Capacidad: ";
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCancelar.Location = new Point(274, 113);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(84, 48);
            ButtonCancelar.TabIndex = 35;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonAceptar
            // 
            ButtonAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonAceptar.Location = new Point(28, 113);
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new Size(84, 48);
            ButtonAceptar.TabIndex = 36;
            ButtonAceptar.Text = "Aceptar";
            ButtonAceptar.UseVisualStyleBackColor = true;
            ButtonAceptar.Click += ButtonAceptar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // GalponesAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 202);
            Controls.Add(ComboBoxGranjas);
            Controls.Add(label5);
            Controls.Add(TextBoxCapacidad);
            Controls.Add(label4);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonAceptar);
            MaximumSize = new Size(420, 241);
            MinimumSize = new Size(420, 241);
            Name = "GalponesAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GalponesAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBoxGranjas;
        private Label label5;
        private TextBox TextBoxCapacidad;
        private Label label4;
        private Button ButtonCancelar;
        private Button ButtonAceptar;
        private ErrorProvider errorProvider1;
    }
}