

namespace Calculadora_Financiera_UI
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
            interesSimpleMenuButton = new Button();
            label1 = new Label();
            button1 = new Button();
            TiempoMenuButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel3 = new Panel();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            EcuacionValor = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panelReemplazable = new Panel();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // interesSimpleMenuButton
            // 
            interesSimpleMenuButton.FlatAppearance.BorderSize = 0;
            interesSimpleMenuButton.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            interesSimpleMenuButton.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            interesSimpleMenuButton.FlatStyle = FlatStyle.Flat;
            interesSimpleMenuButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            interesSimpleMenuButton.Location = new Point(3, 3);
            interesSimpleMenuButton.Name = "interesSimpleMenuButton";
            interesSimpleMenuButton.Padding = new Padding(5, 0, 0, 0);
            interesSimpleMenuButton.Size = new Size(284, 38);
            interesSimpleMenuButton.TabIndex = 0;
            interesSimpleMenuButton.Text = "Interes Simple";
            interesSimpleMenuButton.TextAlign = ContentAlignment.MiddleLeft;
            interesSimpleMenuButton.TextImageRelation = TextImageRelation.ImageAboveText;
            interesSimpleMenuButton.UseVisualStyleBackColor = false;
            interesSimpleMenuButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(591, 29);
            label1.Name = "label1";
            label1.Size = new Size(230, 23);
            label1.TabIndex = 2;
            label1.Text = "Calculadora Financiera";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 88);
            button1.Name = "button1";
            button1.Size = new Size(284, 36);
            button1.TabIndex = 5;
            button1.Text = "Descuento interes simple";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // TiempoMenuButton
            // 
            TiempoMenuButton.FlatAppearance.BorderSize = 0;
            TiempoMenuButton.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            TiempoMenuButton.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            TiempoMenuButton.FlatStyle = FlatStyle.Flat;
            TiempoMenuButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TiempoMenuButton.Location = new Point(3, 47);
            TiempoMenuButton.Name = "TiempoMenuButton";
            TiempoMenuButton.Size = new Size(284, 35);
            TiempoMenuButton.TabIndex = 3;
            TiempoMenuButton.Text = "Tiempo";
            TiempoMenuButton.TextAlign = ContentAlignment.MiddleLeft;
            TiempoMenuButton.UseVisualStyleBackColor = true;
            TiempoMenuButton.Click += TiempoMenuButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1165, 78);
            panel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 29);
            label2.Name = "label2";
            label2.Size = new Size(205, 23);
            label2.TabIndex = 4;
            label2.Text = "Qué desea calcular?";
            label2.Click += label2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(interesSimpleMenuButton);
            flowLayoutPanel1.Controls.Add(TiempoMenuButton);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(EcuacionValor);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 78);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(287, 413);
            flowLayoutPanel1.TabIndex = 8;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // EcuacionValor
            // 
            EcuacionValor.FlatAppearance.BorderSize = 0;
            EcuacionValor.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            EcuacionValor.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            EcuacionValor.FlatStyle = FlatStyle.Flat;
            EcuacionValor.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            EcuacionValor.Location = new Point(3, 130);
            EcuacionValor.Name = "EcuacionValor";
            EcuacionValor.Size = new Size(284, 36);
            EcuacionValor.TabIndex = 6;
            EcuacionValor.Text = "Ecuacion de Valor ";
            EcuacionValor.TextAlign = ContentAlignment.MiddleLeft;
            EcuacionValor.UseVisualStyleBackColor = true;
            EcuacionValor.Click += EcuacionValor_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(3, 172);
            button2.Name = "button2";
            button2.Size = new Size(284, 36);
            button2.TabIndex = 7;
            button2.Text = "Descuento por pronto pago";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            button3.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(3, 214);
            button3.Name = "button3";
            button3.Size = new Size(284, 36);
            button3.TabIndex = 8;
            button3.Text = "Interes Compuesto";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            button4.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.Location = new Point(3, 256);
            button4.Name = "button4";
            button4.Size = new Size(284, 36);
            button4.TabIndex = 9;
            button4.Text = "Tasas Equivalente";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            button5.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.Location = new Point(3, 298);
            button5.Name = "button5";
            button5.Size = new Size(284, 36);
            button5.TabIndex = 10;
            button5.Text = "Formulas";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panelReemplazable
            // 
            panelReemplazable.Dock = DockStyle.Fill;
            panelReemplazable.Location = new Point(287, 78);
            panelReemplazable.Name = "panelReemplazable";
            panelReemplazable.Size = new Size(878, 413);
            panelReemplazable.TabIndex = 9;
            panelReemplazable.Paint += panelReemplazable_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 491);
            Controls.Add(panelReemplazable);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void panelCalculadoraFinanciera_Paint(object sender, PaintEventArgs e)
        {
            
        }



        #endregion
        private Button interesSimpleMenuButton;
        private Label label1;
        private Button TiempoMenuButton;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelReemplazable;
        private Button EcuacionValor;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
