namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    partial class DetalleGalponAE
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
            label5 = new Label();
            TextBoxCapacidad = new TextBox();
            label1 = new Label();
            label4 = new Label();
            ButtonCancelar = new Button();
            ButtonAceptar = new Button();
            DtpFechaIngreso = new DateTimePicker();
            label2 = new Label();
            TexboxIngresoCant = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            TexBoxGalpon = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 134);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 49;
            label5.Text = "Fecha Ingreso:";
            // 
            // TextBoxCapacidad
            // 
            TextBoxCapacidad.Enabled = false;
            TextBoxCapacidad.Location = new Point(110, 62);
            TextBoxCapacidad.Name = "TextBoxCapacidad";
            TextBoxCapacidad.Size = new Size(245, 23);
            TextBoxCapacidad.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 45;
            label1.Text = "Galpon: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 61);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 46;
            label4.Text = "Capacidad: ";
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCancelar.Location = new Point(271, 183);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(84, 48);
            ButtonCancelar.TabIndex = 43;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonAceptar
            // 
            ButtonAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonAceptar.Location = new Point(25, 183);
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new Size(84, 48);
            ButtonAceptar.TabIndex = 44;
            ButtonAceptar.Text = "Aceptar";
            ButtonAceptar.UseVisualStyleBackColor = true;
            ButtonAceptar.Click += ButtonAceptar_Click;
            // 
            // DtpFechaIngreso
            // 
            DtpFechaIngreso.Format = DateTimePickerFormat.Short;
            DtpFechaIngreso.Location = new Point(141, 134);
            DtpFechaIngreso.Name = "DtpFechaIngreso";
            DtpFechaIngreso.Size = new Size(214, 23);
            DtpFechaIngreso.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 99);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 46;
            label2.Text = "Ingreso:";
            // 
            // TexboxIngresoCant
            // 
            TexboxIngresoCant.Location = new Point(110, 100);
            TexboxIngresoCant.Name = "TexboxIngresoCant";
            TexboxIngresoCant.Size = new Size(245, 23);
            TexboxIngresoCant.TabIndex = 48;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // TexBoxGalpon
            // 
            TexBoxGalpon.Enabled = false;
            TexBoxGalpon.Location = new Point(110, 19);
            TexBoxGalpon.Name = "TexBoxGalpon";
            TexBoxGalpon.Size = new Size(245, 23);
            TexBoxGalpon.TabIndex = 48;
            // 
            // DetalleGalponAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 261);
            Controls.Add(DtpFechaIngreso);
            Controls.Add(label5);
            Controls.Add(TexBoxGalpon);
            Controls.Add(TexboxIngresoCant);
            Controls.Add(TextBoxCapacidad);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonAceptar);
            Name = "DetalleGalponAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalleGalponAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox TextBoxCapacidad;
        private Label label1;
        private Label label4;
        private Button ButtonCancelar;
        private Button ButtonAceptar;
        private DateTimePicker DtpFechaIngreso;
        private Label label2;
        private TextBox TexboxIngresoCant;
        private ErrorProvider errorProvider1;
        private TextBox TexBoxGalpon;
    }
}