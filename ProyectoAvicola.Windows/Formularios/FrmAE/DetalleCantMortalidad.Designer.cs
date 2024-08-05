
namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    partial class DetalleCantMortalidad
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
            TextBoxMortalidad = new TextBox();
            label1 = new Label();
            ButtonCancelar = new Button();
            ButtonAceptar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // TextBoxMortalidad
            // 
            TextBoxMortalidad.Location = new Point(113, 28);
            TextBoxMortalidad.Name = "TextBoxMortalidad";
            TextBoxMortalidad.PlaceholderText = "Ingrese bajas..";
            TextBoxMortalidad.Size = new Size(136, 23);
            TextBoxMortalidad.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Cantidad:";
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCancelar.Location = new Point(165, 75);
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
            ButtonAceptar.Location = new Point(31, 75);
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new Size(84, 48);
            ButtonAceptar.TabIndex = 4;
            ButtonAceptar.Text = "Aceptar";
            ButtonAceptar.UseVisualStyleBackColor = true;
            ButtonAceptar.Click += ButtonAceptar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // DetalleCantMortalidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 146);
            Controls.Add(TextBoxMortalidad);
            Controls.Add(label1);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonAceptar);
            Name = "DetalleCantMortalidad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalleCantMMA";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxMortalidad;
        private Label label1;
        private Button ButtonCancelar;
        private Button ButtonAceptar;
        private ErrorProvider errorProvider1;
    }
}