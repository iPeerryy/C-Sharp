namespace Calculadora_Financiera_UI.UserControllers.Tiempo
{
    partial class CtrTiempoAproximadoFormula
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
            TxtResultado = new TextBox();
            TxtFechaFinal = new TextBox();
            label4 = new Label();
            button1 = new Button();
            TxtFechaInicial = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // TxtResultado
            // 
            TxtResultado.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtResultado.Location = new Point(262, 85);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.ReadOnly = true;
            TxtResultado.Size = new Size(599, 99);
            TxtResultado.TabIndex = 15;
            // 
            // TxtFechaFinal
            // 
            TxtFechaFinal.Location = new Point(652, 219);
            TxtFechaFinal.Name = "TxtFechaFinal";
            TxtFechaFinal.Size = new Size(100, 23);
            TxtFechaFinal.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(671, 201);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 13;
            label4.Text = "Fecha Final";
            // 
            // button1
            // 
            button1.Location = new Point(521, 286);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TxtFechaInicial
            // 
            TxtFechaInicial.Location = new Point(334, 219);
            TxtFechaInicial.Name = "TxtFechaInicial";
            TxtFechaInicial.Size = new Size(100, 23);
            TxtFechaInicial.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 201);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 10;
            label3.Text = "Fecha Inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(334, 40);
            label2.Name = "label2";
            label2.Size = new Size(451, 30);
            label2.TabIndex = 9;
            label2.Text = "Recuerda seguir estos criterios: Año-Mes-Dia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 0);
            label1.Name = "label1";
            label1.Size = new Size(411, 40);
            label1.TabIndex = 8;
            label1.Text = "Calcular tiempo Aproximado";
            // 
            // CtrTiempoAproximadoFormula
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
            Name = "CtrTiempoAproximadoFormula";
            Size = new Size(1213, 667);
            Load += CtrTiempoAproximadoFormula_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtResultado;
        private TextBox TxtFechaFinal;
        private Label label4;
        private Button button1;
        private TextBox TxtFechaInicial;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
