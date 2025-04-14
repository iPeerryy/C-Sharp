namespace Calculadora_Financiera_UI.Interes_Simple
{
    partial class CtrIeTaFormula
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
            label5 = new Label();
            label4 = new Label();
            txtFechaFinal = new TextBox();
            txtResultado = new TextBox();
            button1 = new Button();
            txtFechaInicial = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtInteres = new TextBox();
            label1 = new Label();
            txtCapital = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(304, 16);
            label5.Name = "label5";
            label5.Size = new Size(508, 40);
            label5.TabIndex = 31;
            label5.Text = "Interes Exacto, Tiempo Aproximado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(727, 214);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 30;
            label4.Text = "Fecha Final";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(712, 232);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(100, 23);
            txtFechaFinal.TabIndex = 29;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(233, 98);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(671, 81);
            txtResultado.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(497, 289);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtFechaInicial
            // 
            txtFechaInicial.Location = new Point(558, 232);
            txtFechaInicial.Name = "txtFechaInicial";
            txtFechaInicial.Size = new Size(100, 23);
            txtFechaInicial.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(573, 214);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 25;
            label3.Text = "Fecha Inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 214);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 24;
            label2.Text = "Tasa de interes";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtInteres
            // 
            txtInteres.Location = new Point(404, 232);
            txtInteres.Name = "txtInteres";
            txtInteres.Size = new Size(100, 23);
            txtInteres.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 214);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 22;
            label1.Text = "Capital";
            // 
            // txtCapital
            // 
            txtCapital.Location = new Point(233, 232);
            txtCapital.Name = "txtCapital";
            txtCapital.Size = new Size(100, 23);
            txtCapital.TabIndex = 21;
            // 
            // CtrIeTaFormula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtFechaFinal);
            Controls.Add(txtResultado);
            Controls.Add(button1);
            Controls.Add(txtFechaInicial);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtInteres);
            Controls.Add(label1);
            Controls.Add(txtCapital);
            Name = "CtrIeTaFormula";
            Size = new Size(1209, 674);
            Load += CtrIeTaFormula_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private TextBox txtFechaFinal;
        private TextBox txtResultado;
        private Button button1;
        private TextBox txtFechaInicial;
        private Label label3;
        private Label label2;
        private TextBox txtInteres;
        private Label label1;
        private TextBox txtCapital;
    }
}
