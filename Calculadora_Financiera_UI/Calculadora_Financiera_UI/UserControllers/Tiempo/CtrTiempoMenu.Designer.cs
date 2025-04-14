namespace Calculadora_Financiera_UI.UserControllers.Tiempo
{
    partial class CtrTiempoMenu
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
            button1 = new Button();
            button2 = new Button();
            PanelTiempoMenu = new Panel();
            PanelTiempoMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 0);
            label1.Name = "label1";
            label1.Size = new Size(504, 40);
            label1.TabIndex = 0;
            label1.Text = "Que Tipo de tiempo desea calcular?";
            // 
            // button1
            // 
            button1.Location = new Point(135, 164);
            button1.Name = "button1";
            button1.Size = new Size(170, 44);
            button1.TabIndex = 1;
            button1.Text = "Tiempo Aproximado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(469, 164);
            button2.Name = "button2";
            button2.Size = new Size(170, 44);
            button2.TabIndex = 2;
            button2.Text = "Tiempo Exacto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PanelTiempoMenu
            // 
            PanelTiempoMenu.Controls.Add(button2);
            PanelTiempoMenu.Controls.Add(label1);
            PanelTiempoMenu.Controls.Add(button1);
            PanelTiempoMenu.Location = new Point(0, 3);
            PanelTiempoMenu.Name = "PanelTiempoMenu";
            PanelTiempoMenu.Size = new Size(825, 464);
            PanelTiempoMenu.TabIndex = 3;
            // 
            // CtrTiempoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelTiempoMenu);
            Name = "CtrTiempoMenu";
            Size = new Size(825, 467);
            PanelTiempoMenu.ResumeLayout(false);
            PanelTiempoMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Panel PanelTiempoMenu;
    }
}
