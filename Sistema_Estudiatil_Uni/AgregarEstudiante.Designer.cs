namespace Sistema_Estudiatil_Uni
{
    partial class AgregarEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEstudiante));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 95);
            label1.Name = "label1";
            label1.Size = new Size(93, 27);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 145);
            label2.Name = "label2";
            label2.Size = new Size(61, 27);
            label2.TabIndex = 1;
            label2.Text = "Edad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 195);
            label3.Name = "label3";
            label3.Size = new Size(73, 27);
            label3.TabIndex = 2;
            label3.Text = "Grado:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(133, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(168, 34);
            txtNombre.TabIndex = 4;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(54, 250);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(222, 31);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Estado de Estudiante";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 195);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 35);
            comboBox1.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(142, 138);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(159, 34);
            numericUpDown1.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(142, 302);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 36);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // AgregarEstudiante
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(389, 376);
            Controls.Add(btnGuardar);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(radioButton1);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AgregarEstudiante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Estudiante";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Button btnGuardar;
    }
}