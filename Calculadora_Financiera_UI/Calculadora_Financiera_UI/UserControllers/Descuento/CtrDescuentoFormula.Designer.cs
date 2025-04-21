namespace Calculadora_Financiera_UI.UserControllers.Descuento
{
    partial class CtrDescuentoFormula
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
            label1 = new Label();
            txtValorPagar = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(444, 18);
            label5.Name = "label5";
            label5.Size = new Size(280, 40);
            label5.TabIndex = 53;
            label5.Text = "Calcular Descuento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(724, 213);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 52;
            label4.Text = "Fecha Final";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(709, 231);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(100, 23);
            txtFechaFinal.TabIndex = 51;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(230, 97);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(671, 81);
            txtResultado.TabIndex = 50;
            // 
            // button1
            // 
            button1.Location = new Point(494, 288);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 49;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtFechaInicial
            // 
            txtFechaInicial.Location = new Point(555, 231);
            txtFechaInicial.Name = "txtFechaInicial";
            txtFechaInicial.Size = new Size(100, 23);
            txtFechaInicial.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(570, 213);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 47;
            label3.Text = "Fecha Inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 213);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 46;
            label2.Text = "Tasa de descuento";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtTasaDescuento
            // 
            txtTasaDescuento.Location = new Point(401, 231);
            txtTasaDescuento.Name = "txtTasaDescuento";
            txtTasaDescuento.Size = new Size(100, 23);
            txtTasaDescuento.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 213);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 44;
            label1.Text = "Valor a pagar";
            // 
            // txtValorPagar
            // 
            txtValorPagar.Location = new Point(230, 231);
            txtValorPagar.Name = "txtValorPagar";
            txtValorPagar.Size = new Size(100, 23);
            txtValorPagar.TabIndex = 43;
            // 
            // CtrDescuentoFormula
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
            Controls.Add(label1);
            Controls.Add(txtValorPagar);
            Name = "CtrDescuentoFormula";
            Size = new Size(1190, 675);
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
        private Label label1;
        private TextBox txtValorPagar;
    }
}
