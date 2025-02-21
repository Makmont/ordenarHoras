namespace ordenarHoras
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxHora1 = new TextBox();
            textBoxHora3 = new TextBox();
            textBoxHora2 = new TextBox();
            button1 = new Button();
            textBoxTransferenciaMayor3 = new TextBox();
            textBoxTransferenciaMayor2 = new TextBox();
            textBoxTransferenciaMayor1 = new TextBox();
            textBoxTransferencia3 = new TextBox();
            textBoxTransferencia2 = new TextBox();
            textBoxTransferencia1 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonLimpiar = new Button();
            Horas = new Label();
            Minutos = new Label();
            SuspendLayout();
            // 
            // textBoxHora1
            // 
            textBoxHora1.Location = new Point(102, 89);
            textBoxHora1.Name = "textBoxHora1";
            textBoxHora1.Size = new Size(44, 27);
            textBoxHora1.TabIndex = 0;
            // 
            // textBoxHora3
            // 
            textBoxHora3.Location = new Point(102, 181);
            textBoxHora3.Name = "textBoxHora3";
            textBoxHora3.Size = new Size(44, 27);
            textBoxHora3.TabIndex = 1;
            // 
            // textBoxHora2
            // 
            textBoxHora2.Location = new Point(102, 133);
            textBoxHora2.Name = "textBoxHora2";
            textBoxHora2.Size = new Size(44, 27);
            textBoxHora2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(301, 252);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Ordenar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxTransferenciaMayor3
            // 
            textBoxTransferenciaMayor3.Location = new Point(445, 187);
            textBoxTransferenciaMayor3.Name = "textBoxTransferenciaMayor3";
            textBoxTransferenciaMayor3.Size = new Size(125, 27);
            textBoxTransferenciaMayor3.TabIndex = 4;
            // 
            // textBoxTransferenciaMayor2
            // 
            textBoxTransferenciaMayor2.Location = new Point(445, 133);
            textBoxTransferenciaMayor2.Name = "textBoxTransferenciaMayor2";
            textBoxTransferenciaMayor2.Size = new Size(125, 27);
            textBoxTransferenciaMayor2.TabIndex = 5;
            // 
            // textBoxTransferenciaMayor1
            // 
            textBoxTransferenciaMayor1.Location = new Point(445, 89);
            textBoxTransferenciaMayor1.Name = "textBoxTransferenciaMayor1";
            textBoxTransferenciaMayor1.Size = new Size(125, 27);
            textBoxTransferenciaMayor1.TabIndex = 6;
            // 
            // textBoxTransferencia3
            // 
            textBoxTransferencia3.Location = new Point(284, 187);
            textBoxTransferencia3.Name = "textBoxTransferencia3";
            textBoxTransferencia3.Size = new Size(125, 27);
            textBoxTransferencia3.TabIndex = 7;
            // 
            // textBoxTransferencia2
            // 
            textBoxTransferencia2.Location = new Point(284, 133);
            textBoxTransferencia2.Name = "textBoxTransferencia2";
            textBoxTransferencia2.Size = new Size(125, 27);
            textBoxTransferencia2.TabIndex = 8;
            // 
            // textBoxTransferencia1
            // 
            textBoxTransferencia1.Location = new Point(284, 89);
            textBoxTransferencia1.Name = "textBoxTransferencia1";
            textBoxTransferencia1.Size = new Size(125, 27);
            textBoxTransferencia1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(44, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(44, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(167, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(44, 27);
            textBox3.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 62);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 13;
            label1.Text = "Menor a Mayor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 60);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 14;
            label2.Text = "Mayor a Menor";
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(421, 252);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(94, 29);
            buttonLimpiar.TabIndex = 15;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click_1;
            // 
            // Horas
            // 
            Horas.AutoSize = true;
            Horas.Location = new Point(96, 45);
            Horas.Name = "Horas";
            Horas.Size = new Size(48, 20);
            Horas.TabIndex = 16;
            Horas.Text = "Horas";
            // 
            // Minutos
            // 
            Minutos.AutoSize = true;
            Minutos.Location = new Point(167, 45);
            Minutos.Name = "Minutos";
            Minutos.Size = new Size(62, 20);
            Minutos.TabIndex = 17;
            Minutos.Text = "Minutos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Minutos);
            Controls.Add(Horas);
            Controls.Add(buttonLimpiar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBoxTransferencia1);
            Controls.Add(textBoxTransferencia2);
            Controls.Add(textBoxTransferencia3);
            Controls.Add(textBoxTransferenciaMayor1);
            Controls.Add(textBoxTransferenciaMayor2);
            Controls.Add(textBoxTransferenciaMayor3);
            Controls.Add(button1);
            Controls.Add(textBoxHora2);
            Controls.Add(textBoxHora3);
            Controls.Add(textBoxHora1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHora1;
        private TextBox textBoxHora3;
        private TextBox textBoxHora2;
        private Button button1;
        private TextBox textBoxTransferenciaMayor3;
        private TextBox textBoxTransferenciaMayor2;
        private TextBox textBoxTransferenciaMayor1;
        private TextBox textBoxTransferencia3;
        private TextBox textBoxTransferencia2;
        private TextBox textBoxTransferencia1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Button buttonLimpiar;
        private Label Horas;
        private Label Minutos;
    }
}
