namespace Calculadora_Financiera_UI.UserControllers.Tiempo
{
    partial class CtrTiempoExactoFormula
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtFechaInicial = new TextBox();
            button1 = new Button();
            label4 = new Label();
            TxtFechaFinal = new TextBox();
            TxtResultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(370, 24);
            label1.Name = "label1";
            label1.Size = new Size(331, 40);
            label1.TabIndex = 0;
            label1.Text = "Calcular tiempo Exacto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(312, 64);
            label2.Name = "label2";
            label2.Size = new Size(451, 30);
            label2.TabIndex = 1;
            label2.Text = "Recuerda seguir estos criterios: Año-Mes-Dia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 223);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha Inicial";
            // 
            // TxtFechaInicial
            // 
            TxtFechaInicial.Location = new Point(335, 241);
            TxtFechaInicial.Name = "TxtFechaInicial";
            TxtFechaInicial.Size = new Size(100, 23);
            TxtFechaInicial.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(522, 308);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(672, 223);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 5;
            label4.Text = "Fecha Final";
            // 
            // TxtFechaFinal
            // 
            TxtFechaFinal.Location = new Point(653, 241);
            TxtFechaFinal.Name = "TxtFechaFinal";
            TxtFechaFinal.Size = new Size(100, 23);
            TxtFechaFinal.TabIndex = 6;
            // 
            // TxtResultado
            // 
            TxtResultado.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtResultado.Location = new Point(263, 107);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.ReadOnly = true;
            TxtResultado.Size = new Size(599, 99);
            TxtResultado.TabIndex = 7;
            // 
            // CtrTiempoExactoFormula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TxtResultado);
            Controls.Add(TxtFechaFinal);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(TxtFechaInicial);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CtrTiempoExactoFormula";
            Size = new Size(1212, 680);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtFechaInicial;
        private Button button1;
        private Label label4;
        private TextBox TxtFechaFinal;
        private TextBox TxtResultado;
    }
}
