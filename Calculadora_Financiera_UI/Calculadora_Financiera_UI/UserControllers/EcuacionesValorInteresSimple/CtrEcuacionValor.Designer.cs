namespace Calculadora_Financiera_UI.UserControllers.EcuacionesValorInteresSimple
{
    partial class CtrEcuacionValor
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            comboMetodoInteres = new ComboBox();
            calcularTasaButton = new Button();
            label2 = new Label();
            dateTimePickerFechaFocal = new DateTimePicker();
            CalcularButton = new Button();
            textBoxTasa = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboMetodoInteres);
            panel1.Controls.Add(calcularTasaButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePickerFechaFocal);
            panel1.Controls.Add(CalcularButton);
            panel1.Controls.Add(textBoxTasa);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1136, 608);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(892, 455);
            button2.Name = "button2";
            button2.Size = new Size(196, 84);
            button2.TabIndex = 9;
            button2.Text = "Calcular con regla de los saldos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(171, 455);
            button1.Name = "button1";
            button1.Size = new Size(196, 84);
            button1.TabIndex = 8;
            button1.Text = "Buscar Tiempo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboMetodoInteres
            // 
            comboMetodoInteres.FormattingEnabled = true;
            comboMetodoInteres.Location = new Point(120, 212);
            comboMetodoInteres.Name = "comboMetodoInteres";
            comboMetodoInteres.Size = new Size(274, 23);
            comboMetodoInteres.TabIndex = 7;
            // 
            // calcularTasaButton
            // 
            calcularTasaButton.Location = new Point(673, 455);
            calcularTasaButton.Name = "calcularTasaButton";
            calcularTasaButton.Size = new Size(162, 84);
            calcularTasaButton.TabIndex = 6;
            calcularTasaButton.Text = "Calcular Tasa";
            calcularTasaButton.UseVisualStyleBackColor = true;
            calcularTasaButton.Click += calcularTasaButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(507, 319);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 5;
            label2.Text = "Fecha Focal";
            // 
            // dateTimePickerFechaFocal
            // 
            dateTimePickerFechaFocal.Location = new Point(432, 344);
            dateTimePickerFechaFocal.Name = "dateTimePickerFechaFocal";
            dateTimePickerFechaFocal.Size = new Size(200, 23);
            dateTimePickerFechaFocal.TabIndex = 4;
            // 
            // CalcularButton
            // 
            CalcularButton.Location = new Point(432, 455);
            CalcularButton.Name = "CalcularButton";
            CalcularButton.Size = new Size(196, 84);
            CalcularButton.TabIndex = 3;
            CalcularButton.Text = "Calcular o buscar X";
            CalcularButton.UseVisualStyleBackColor = true;
            CalcularButton.Click += CalcularButton_Click;
            // 
            // textBoxTasa
            // 
            textBoxTasa.Location = new Point(74, 52);
            textBoxTasa.Name = "textBoxTasa";
            textBoxTasa.Size = new Size(100, 23);
            textBoxTasa.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 23);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Tasa";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(525, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(419, 150);
            dataGridView1.TabIndex = 0;
            // 
            // CtrEcuacionValor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "CtrEcuacionValor";
            Size = new Size(1136, 608);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private DateTimePicker dateTimePickerFechaFocal;
        private Button CalcularButton;
        private TextBox textBoxTasa;
        private Label label1;
        private DataGridView dataGridView1;
        private Button calcularTasaButton;
        private ComboBox comboMetodoInteres;
        private Button button2;
        private Button button1;
    }
}
