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
            interesSimpleFormulaButton = new Button();
            panelInteresSimple = new Panel();
            InteresSimpleLabel = new Label();
            panelInteresSimple.SuspendLayout();
            SuspendLayout();
            // 
            // interesSimpleFormulaButton
            // 
            interesSimpleFormulaButton.Location = new Point(20, 106);
            interesSimpleFormulaButton.Name = "interesSimpleFormulaButton";
            interesSimpleFormulaButton.Size = new Size(188, 36);
            interesSimpleFormulaButton.TabIndex = 2;
            interesSimpleFormulaButton.Text = "Interes Ordinario, Tiempo Exacto";
            interesSimpleFormulaButton.UseVisualStyleBackColor = true;
            interesSimpleFormulaButton.Click += interesSimpleFormulaButton_Click;
            // 
            // panelInteresSimple
            // 
            panelInteresSimple.Controls.Add(InteresSimpleLabel);
            panelInteresSimple.Controls.Add(interesSimpleFormulaButton);
            panelInteresSimple.Location = new Point(0, 0);
            panelInteresSimple.Name = "panelInteresSimple";
            panelInteresSimple.Size = new Size(1100, 659);
            panelInteresSimple.TabIndex = 3;
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

        private Button interesSimpleFormulaButton;
        private Panel panelInteresSimple;
        private Label InteresSimpleLabel;
    }
}
