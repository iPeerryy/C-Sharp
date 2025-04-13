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
            panelCalculadoraFinanciera = new Panel();
            panelCalculadoraFinanciera.SuspendLayout();
            SuspendLayout();
            // 
            // interesSimpleMenuButton
            // 
            interesSimpleMenuButton.Location = new Point(22, 85);
            interesSimpleMenuButton.Name = "interesSimpleMenuButton";
            interesSimpleMenuButton.Size = new Size(124, 39);
            interesSimpleMenuButton.TabIndex = 1;
            interesSimpleMenuButton.Text = "Interes Simple";
            interesSimpleMenuButton.UseVisualStyleBackColor = true;
            interesSimpleMenuButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 0);
            label1.Name = "label1";
            label1.Size = new Size(288, 42);
            label1.TabIndex = 2;
            label1.Text = "Calculadora Financiera";
            // 
            // panelCalculadoraFinanciera
            // 
            panelCalculadoraFinanciera.Controls.Add(interesSimpleMenuButton);
            panelCalculadoraFinanciera.Controls.Add(label1);
            panelCalculadoraFinanciera.Location = new Point(2, 1);
            panelCalculadoraFinanciera.Name = "panelCalculadoraFinanciera";
            panelCalculadoraFinanciera.Size = new Size(800, 451);
            panelCalculadoraFinanciera.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelCalculadoraFinanciera);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            panelCalculadoraFinanciera.ResumeLayout(false);
            panelCalculadoraFinanciera.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button interesSimpleMenuButton;
        private Label label1;
        private Panel panelCalculadoraFinanciera;
    }
}
