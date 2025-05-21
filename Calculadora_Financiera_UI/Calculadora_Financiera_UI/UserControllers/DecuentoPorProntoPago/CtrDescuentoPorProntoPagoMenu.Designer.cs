namespace Calculadora_Financiera_UI
{
    partial class CtrDescuentoPorProntoPagoMenu
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
            panelDescuentoPorProntoPago = new Panel();
            button1 = new Button();
            panelDescuentoPorProntoPago.SuspendLayout();
            SuspendLayout();
            // 
            // panelDescuentoPorProntoPago
            // 
            panelDescuentoPorProntoPago.Controls.Add(button1);
            panelDescuentoPorProntoPago.Dock = DockStyle.Fill;
            panelDescuentoPorProntoPago.Location = new Point(0, 0);
            panelDescuentoPorProntoPago.Name = "panelDescuentoPorProntoPago";
            panelDescuentoPorProntoPago.Size = new Size(1110, 600);
            panelDescuentoPorProntoPago.TabIndex = 0;
            panelDescuentoPorProntoPago.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(98, 86);
            button1.Name = "button1";
            button1.Size = new Size(193, 57);
            button1.TabIndex = 0;
            button1.Text = "Descuento por pronto pago";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CtrDescuentoPorProntoPagoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelDescuentoPorProntoPago);
            Name = "CtrDescuentoPorProntoPagoMenu";
            Size = new Size(1110, 600);
            panelDescuentoPorProntoPago.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDescuentoPorProntoPago;
        private Button button1;
    }
}
