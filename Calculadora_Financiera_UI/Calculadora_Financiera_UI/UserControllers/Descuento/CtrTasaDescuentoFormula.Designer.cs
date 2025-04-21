namespace Calculadora_Financiera_UI.UserControllers.Descuento
{
    partial class CtrTasaDescuentoFormula
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
            txtTasaDescuento = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 19);
            label5.Name = "label5";
            label5.Size = new Size(977, 40);
            label5.TabIndex = 64;
            label5.Text = "Calcular Tasa De interes simple equivalente a una tasa de interes dada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(631, 208);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 63;
            label4.Text = "Fecha Final";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(616, 226);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(100, 23);
            txtFechaFinal.TabIndex = 62;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(137, 92);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(671, 81);
            txtResultado.TabIndex = 61;
            // 
            // button1
            // 
            button1.Location = new Point(401, 283);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 60;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtFechaInicial
            // 
            txtFechaInicial.Location = new Point(462, 226);
            txtFechaInicial.Name = "txtFechaInicial";
            txtFechaInicial.Size = new Size(100, 23);
            txtFechaInicial.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 208);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 58;
            label3.Text = "Fecha Inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 208);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 57;
            label2.Text = "Tasa de descuento";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtTasaDescuento
            // 
            txtTasaDescuento.Location = new Point(308, 226);
            txtTasaDescuento.Name = "txtTasaDescuento";
            txtTasaDescuento.Size = new Size(100, 23);
            txtTasaDescuento.TabIndex = 56;
            // 
            // CtrTasaDescuentoFormula
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
            Controls.Add(txtTasaDescuento);
            Name = "CtrTasaDescuentoFormula";
            Size = new Size(1063, 640);
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
        private TextBox txtTasaDescuento;
    }
}
