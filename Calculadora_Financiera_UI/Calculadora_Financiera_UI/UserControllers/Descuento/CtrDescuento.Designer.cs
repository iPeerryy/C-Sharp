namespace Calculadora_Financiera_UI.UserControllers.Descuento
{
    partial class CtrDescuento
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
            button2 = new Button();
            button1 = new Button();
            IeTaButton = new Button();
            IeTeButton = new Button();
            IoTaButton = new Button();
            InteresSimpleLabel = new Label();
            IoTeButton = new Button();
            panelDescuento = new Panel();
            panelDescuento.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(682, 162);
            button2.Name = "button2";
            button2.Size = new Size(295, 36);
            button2.TabIndex = 16;
            button2.Text = "Monto P(1+it/360)";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(323, 162);
            button1.Name = "button1";
            button1.Size = new Size(295, 36);
            button1.TabIndex = 15;
            button1.Text = "Capital S/1+it/360";
            button1.UseVisualStyleBackColor = true;
            // 
            // IeTaButton
            // 
            IeTaButton.Location = new Point(3, 162);
            IeTaButton.Name = "IeTaButton";
            IeTaButton.Size = new Size(257, 36);
            IeTaButton.TabIndex = 14;
            IeTaButton.Text = "Interes Exacto, Tiempo Aproximado PiT/365";
            IeTaButton.UseVisualStyleBackColor = true;
            // 
            // IeTeButton
            // 
            IeTeButton.Location = new Point(682, 82);
            IeTeButton.Name = "IeTeButton";
            IeTeButton.Size = new Size(295, 36);
            IeTeButton.TabIndex = 13;
            IeTeButton.Text = "Valor Descontado S(1-dt)";
            IeTeButton.UseVisualStyleBackColor = true;
            IeTeButton.Click += IeTeButton_Click;
            // 
            // IoTaButton
            // 
            IoTaButton.Location = new Point(339, 58);
            IoTaButton.Name = "IoTaButton";
            IoTaButton.Size = new Size(295, 60);
            IoTaButton.TabIndex = 12;
            IoTaButton.Text = "Tasa de interes simple equivalente a una tasa de descuento dada  d/1-dt";
            IoTaButton.UseVisualStyleBackColor = true;
            IoTaButton.Click += IoTaButton_Click;
            // 
            // InteresSimpleLabel
            // 
            InteresSimpleLabel.AutoSize = true;
            InteresSimpleLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InteresSimpleLabel.Location = new Point(405, 0);
            InteresSimpleLabel.Name = "InteresSimpleLabel";
            InteresSimpleLabel.Size = new Size(162, 40);
            InteresSimpleLabel.TabIndex = 11;
            InteresSimpleLabel.Text = "Descuento";
            // 
            // IoTeButton
            // 
            IoTeButton.Location = new Point(3, 82);
            IoTeButton.Name = "IoTeButton";
            IoTeButton.Size = new Size(257, 36);
            IoTeButton.TabIndex = 10;
            IoTeButton.Text = "Descuento o interés anticipado SdT";
            IoTeButton.UseVisualStyleBackColor = true;
            IoTeButton.Click += IoTeButton_Click;
            // 
            // panelDescuento
            // 
            panelDescuento.Controls.Add(button2);
            panelDescuento.Controls.Add(InteresSimpleLabel);
            panelDescuento.Controls.Add(IoTaButton);
            panelDescuento.Controls.Add(IeTaButton);
            panelDescuento.Controls.Add(button1);
            panelDescuento.Controls.Add(IoTeButton);
            panelDescuento.Controls.Add(IeTeButton);
            panelDescuento.Location = new Point(0, 3);
            panelDescuento.Name = "panelDescuento";
            panelDescuento.Size = new Size(1123, 649);
            panelDescuento.TabIndex = 17;
            panelDescuento.Paint += PanelDescuento_Paint;
            // 
            // CtrDescuento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelDescuento);
            Name = "CtrDescuento";
            Size = new Size(1126, 655);
            Load += CtrDescuento_Load;
            panelDescuento.ResumeLayout(false);
            panelDescuento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button IeTaButton;
        private Button IeTeButton;
        private Button IoTaButton;
        private Label InteresSimpleLabel;
        private Button IoTeButton;
        private Panel panelDescuento;
    }
}
