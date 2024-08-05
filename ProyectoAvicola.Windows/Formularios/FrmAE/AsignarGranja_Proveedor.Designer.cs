namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    partial class AsignarGranja_Proveedor
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
            ComboBoxGranjas = new ComboBox();
            TexBoxProveedor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ButtonAceptar = new Button();
            ButtonCancelar = new Button();
            ListBoxGranjasAsociadas = new ListBox();
            label3 = new Label();
            ButtonSacarGranja = new Button();
            SuspendLayout();
            // 
            // ComboBoxGranjas
            // 
            ComboBoxGranjas.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxGranjas.FormattingEnabled = true;
            ComboBoxGranjas.Location = new Point(107, 82);
            ComboBoxGranjas.Name = "ComboBoxGranjas";
            ComboBoxGranjas.Size = new Size(208, 23);
            ComboBoxGranjas.TabIndex = 0;
            // 
            // TexBoxProveedor
            // 
            TexBoxProveedor.Enabled = false;
            TexBoxProveedor.Location = new Point(107, 35);
            TexBoxProveedor.Name = "TexBoxProveedor";
            TexBoxProveedor.Size = new Size(208, 23);
            TexBoxProveedor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 34);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "Proveedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 85);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "Granja:";
            // 
            // ButtonAceptar
            // 
            ButtonAceptar.Location = new Point(21, 134);
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new Size(72, 39);
            ButtonAceptar.TabIndex = 4;
            ButtonAceptar.Text = "Aceptar";
            ButtonAceptar.UseVisualStyleBackColor = true;
            ButtonAceptar.Click += ButtonAceptar_Click;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Location = new Point(243, 134);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(72, 39);
            ButtonCancelar.TabIndex = 4;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ListBoxGranjasAsociadas
            // 
            ListBoxGranjasAsociadas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListBoxGranjasAsociadas.FormattingEnabled = true;
            ListBoxGranjasAsociadas.ItemHeight = 20;
            ListBoxGranjasAsociadas.Location = new Point(365, 34);
            ListBoxGranjasAsociadas.Name = "ListBoxGranjasAsociadas";
            ListBoxGranjasAsociadas.Size = new Size(189, 104);
            ListBoxGranjasAsociadas.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(393, 9);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 6;
            label3.Text = "Granjas Asociadas";
            // 
            // ButtonSacarGranja
            // 
            ButtonSacarGranja.Location = new Point(418, 150);
            ButtonSacarGranja.Name = "ButtonSacarGranja";
            ButtonSacarGranja.Size = new Size(75, 23);
            ButtonSacarGranja.TabIndex = 7;
            ButtonSacarGranja.Text = "Quitar";
            ButtonSacarGranja.UseVisualStyleBackColor = true;
            ButtonSacarGranja.Click += ButtonSacarGranja_Click;
            // 
            // AsignarGranja_Proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 187);
            Controls.Add(ButtonSacarGranja);
            Controls.Add(label3);
            Controls.Add(ListBoxGranjasAsociadas);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonAceptar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TexBoxProveedor);
            Controls.Add(ComboBoxGranjas);
            MaximumSize = new Size(603, 226);
            MinimumSize = new Size(603, 226);
            Name = "AsignarGranja_Proveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AsignarGranja_Proveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBoxGranjas;
        private TextBox TexBoxProveedor;
        private Label label1;
        private Label label2;
        private Button ButtonAceptar;
        private Button ButtonCancelar;
        private ListBox ListBoxGranjasAsociadas;
        private Label label3;
        private Button ButtonSacarGranja;
    }
}