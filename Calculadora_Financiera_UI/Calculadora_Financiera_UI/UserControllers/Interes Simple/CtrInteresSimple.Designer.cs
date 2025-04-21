namespace Calculadora_Financiera_UI
{
    partial class CtrInteresSimple
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IoTeButton = new Button();
            panelInteresSimple = new Panel();
            button2 = new Button();
            button1 = new Button();
            IeTaButton = new Button();
            IeTeButton = new Button();
            IoTaButton = new Button();
            InteresSimpleLabel = new Label();
            panelInteresSimple.SuspendLayout();
            SuspendLayout();
            // 
            // IoTeButton
            // 
            IoTeButton.Location = new Point(20, 106);
            IoTeButton.Name = "IoTeButton";
            IoTeButton.Size = new Size(257, 36);
            IoTeButton.TabIndex = 2;
            IoTeButton.Text = "Interes Ordinario, Tiempo Exacto PiT/360";
            IoTeButton.UseVisualStyleBackColor = true;
            IoTeButton.Click += interesSimpleFormulaButton_Click;
            // 
            // panelInteresSimple
            // 
            panelInteresSimple.Controls.Add(button2);
            panelInteresSimple.Controls.Add(button1);
            panelInteresSimple.Controls.Add(IeTaButton);
            panelInteresSimple.Controls.Add(IeTeButton);
            panelInteresSimple.Controls.Add(IoTaButton);
            panelInteresSimple.Controls.Add(InteresSimpleLabel);
            panelInteresSimple.Controls.Add(IoTeButton);
            panelInteresSimple.Location = new Point(0, 0);
            panelInteresSimple.Name = "panelInteresSimple";
            panelInteresSimple.Size = new Size(1100, 656);
            panelInteresSimple.TabIndex = 3;
            panelInteresSimple.Paint += panelInteresSimple_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(716, 190);
            button2.Name = "button2";
            button2.Size = new Size(295, 36);
            button2.TabIndex = 9;
            button2.Text = "Monto P(1+it/360)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(359, 190);
            button1.Name = "button1";
            button1.Size = new Size(295, 36);
            button1.TabIndex = 8;
            button1.Text = "Capital S/1+it/360";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // IeTaButton
            // 
            IeTaButton.Location = new Point(20, 190);
            IeTaButton.Name = "IeTaButton";
            IeTaButton.Size = new Size(257, 36);
            IeTaButton.TabIndex = 7;
            IeTaButton.Text = "Interes Exacto, Tiempo Aproximado PiT/365";
            IeTaButton.UseVisualStyleBackColor = true;
            IeTaButton.Click += button2_Click;
            // 
            // IeTeButton
            // 
            IeTeButton.Location = new Point(716, 106);
            IeTeButton.Name = "IeTeButton";
            IeTeButton.Size = new Size(295, 36);
            IeTeButton.TabIndex = 6;
            IeTeButton.Text = "Interes Exacto, Tiempo Exacto PiT/365";
            IeTeButton.UseVisualStyleBackColor = true;
            IeTeButton.Click += IeTaButton_Click;
            // 
            // IoTaButton
            // 
            IoTaButton.Location = new Point(359, 106);
            IoTaButton.Name = "IoTaButton";
            IoTaButton.Size = new Size(295, 36);
            IoTaButton.TabIndex = 4;
            IoTaButton.Text = "Interes Ordinario, Tiempo Aproximado PiT/360";
            IoTaButton.UseVisualStyleBackColor = true;
            IoTaButton.Click += button1_Click;
            // 
            // InteresSimpleLabel
            // 
            InteresSimpleLabel.AutoSize = true;
            InteresSimpleLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InteresSimpleLabel.Location = new Point(427, 13);
            InteresSimpleLabel.Name = "InteresSimpleLabel";
            InteresSimpleLabel.Size = new Size(213, 40);
            InteresSimpleLabel.TabIndex = 3;
            InteresSimpleLabel.Text = "Interés Simple";
            // 
            // CtrInteresSimple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelInteresSimple);
            Name = "CtrInteresSimple";
            Size = new Size(1100, 659);
            panelInteresSimple.ResumeLayout(false);
            panelInteresSimple.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button IoTeButton;
        private Panel panelInteresSimple;
        private Label InteresSimpleLabel;
        private Button IoTaButton;
        private Button IeTeButton;
        private Button IeTaButton;
        private Button button1;
        private Button button2;
    }
}
