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
            IeTaButton = new Button();
            button1 = new Button();
            IoTaButton = new Button();
            InteresSimpleLabel = new Label();
            button2 = new Button();
            panelInteresSimple.SuspendLayout();
            SuspendLayout();
            // 
            // IoTeButton
            // 
            IoTeButton.Location = new Point(20, 106);
            IoTeButton.Name = "IoTeButton";
            IoTeButton.Size = new Size(188, 36);
            IoTeButton.TabIndex = 2;
            IoTeButton.Text = "Interes Ordinario, Tiempo Exacto";
            IoTeButton.UseVisualStyleBackColor = true;
            IoTeButton.Click += interesSimpleFormulaButton_Click;
            // 
            // panelInteresSimple
            // 
            panelInteresSimple.Controls.Add(button2);
            panelInteresSimple.Controls.Add(IeTaButton);
            panelInteresSimple.Controls.Add(button1);
            panelInteresSimple.Controls.Add(IoTaButton);
            panelInteresSimple.Controls.Add(InteresSimpleLabel);
            panelInteresSimple.Controls.Add(IoTeButton);
            panelInteresSimple.Location = new Point(0, 0);
            panelInteresSimple.Name = "panelInteresSimple";
            panelInteresSimple.Size = new Size(1100, 659);
            panelInteresSimple.TabIndex = 3;
            panelInteresSimple.Paint += panelInteresSimple_Paint;
            // 
            // IeTaButton
            // 
            IeTaButton.Location = new Point(579, 106);
            IeTaButton.Name = "IeTaButton";
            IeTaButton.Size = new Size(225, 36);
            IeTaButton.TabIndex = 6;
            IeTaButton.Text = "Interes Exacto, Tiempo Exacto";
            IeTaButton.UseVisualStyleBackColor = true;
            IeTaButton.Click += IeTaButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(296, 230);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // IoTaButton
            // 
            IoTaButton.Location = new Point(287, 106);
            IoTaButton.Name = "IoTaButton";
            IoTaButton.Size = new Size(225, 36);
            IoTaButton.TabIndex = 4;
            IoTaButton.Text = "Interes Ordinario, Tiempo Aproximado";
            IoTaButton.UseVisualStyleBackColor = true;
            IoTaButton.Click += button1_Click;
            // 
            // InteresSimpleLabel
            // 
            InteresSimpleLabel.AutoSize = true;
            InteresSimpleLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InteresSimpleLabel.Location = new Point(399, 14);
            InteresSimpleLabel.Name = "InteresSimpleLabel";
            InteresSimpleLabel.Size = new Size(213, 40);
            InteresSimpleLabel.TabIndex = 3;
            InteresSimpleLabel.Text = "Interés Simple";
            // 
            // button2
            // 
            button2.Location = new Point(850, 106);
            button2.Name = "button2";
            button2.Size = new Size(225, 36);
            button2.TabIndex = 7;
            button2.Text = "Interes Exacto, Tiempo Aproximado";
            button2.UseVisualStyleBackColor = true;
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
        private Button IeTaButton;
        private Button button1;
        private Button button2;
    }
}
