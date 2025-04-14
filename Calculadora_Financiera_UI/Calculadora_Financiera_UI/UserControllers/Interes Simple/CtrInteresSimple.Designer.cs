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
            IoTeButton.Size = new Size(188, 36);
            IoTeButton.TabIndex = 2;
            IoTeButton.Text = "Interes Ordinario, Tiempo Exacto";
            IoTeButton.UseVisualStyleBackColor = true;
            IoTeButton.Click += interesSimpleFormulaButton_Click;
            // 
            // panelInteresSimple
            // 
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
            // IeTaButton
            // 
            IeTaButton.Location = new Point(20, 190);
            IeTaButton.Name = "IeTaButton";
            IeTaButton.Size = new Size(205, 36);
            IeTaButton.TabIndex = 7;
            IeTaButton.Text = "Interes Exacto, Tiempo Aproximado";
            IeTaButton.UseVisualStyleBackColor = true;
            IeTaButton.Click += button2_Click;
            // 
            // IeTeButton
            // 
            IeTeButton.Location = new Point(579, 106);
            IeTeButton.Name = "IeTeButton";
            IeTeButton.Size = new Size(225, 36);
            IeTeButton.TabIndex = 6;
            IeTeButton.Text = "Interes Exacto, Tiempo Exacto";
            IeTeButton.UseVisualStyleBackColor = true;
            IeTeButton.Click += IeTaButton_Click;
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
    }
}
