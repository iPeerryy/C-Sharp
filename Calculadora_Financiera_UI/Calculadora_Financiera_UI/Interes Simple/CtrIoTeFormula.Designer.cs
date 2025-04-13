namespace Calculadora_Financiera_UI
{
    partial class CtrIoTeFormula
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
            txtCapital = new TextBox();
            label1 = new Label();
            txtInteres = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtFechaInicial = new TextBox();
            button1 = new Button();
            txtResultado = new TextBox();
            txtFechaFinal = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtCapital
            // 
            txtCapital.Location = new Point(20, 153);
            txtCapital.Name = "txtCapital";
            txtCapital.Size = new Size(100, 23);
            txtCapital.TabIndex = 0;
            txtCapital.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 135);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Capital";
            // 
            // txtInteres
            // 
            txtInteres.Location = new Point(183, 153);
            txtInteres.Name = "txtInteres";
            txtInteres.Size = new Size(100, 23);
            txtInteres.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 135);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 3;
            label2.Text = "Tasa de interes";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 135);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha Inicial";
            label3.Click += label3_Click;
            // 
            // txtFechaInicial
            // 
            txtFechaInicial.Location = new Point(347, 153);
            txtFechaInicial.Name = "txtFechaInicial";
            txtFechaInicial.Size = new Size(100, 23);
            txtFechaInicial.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(285, 275);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(59, 12);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(671, 81);
            txtResultado.TabIndex = 7;
            txtResultado.TextChanged += textBox1_TextChanged_1;
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(504, 153);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(100, 23);
            txtFechaFinal.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 135);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 9;
            label4.Text = "Fecha Final";
            // 
            // CtrIntresSimpleFormula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "CtrIntresSimpleFormula";
            Size = new Size(859, 612);
            Load += CtrIntresSimpleFormula_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCapital;
        private Label label1;
        private TextBox txtInteres;
        private Label label2;
        private Label label3;
        private TextBox txtFechaInicial;
        private Button button1;
        private TextBox txtResultado;
        private TextBox txtFechaFinal;
        private Label label4;
    }
}
