namespace Calculadora_Financiera_UI.UserControllers.InteresCompuesto
{
    partial class CtrInteresCompuesto
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoCalculo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAnualidad = new System.Windows.Forms.Label();
            this.txtAnualidad = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTasaInteres = new System.Windows.Forms.Label();
            this.lblMontoFinal = new System.Windows.Forms.Label();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.txtMontoFinal = new System.Windows.Forms.TextBox();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPeriodoCapitalizacion = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDetallesCalculo = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Cálculo:";
            // 
            // cboTipoCalculo
            // 
            this.cboTipoCalculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCalculo.FormattingEnabled = true;
            this.cboTipoCalculo.Items.AddRange(new object[] {
            "Monto Final (F)",
            "Principal (P)",
            "Tasa de Interés (i)",
            "Tiempo (n)",
            "Interés Compuesto (I)",
            "Anualidad (A)",
            "Valor Futuro de una Anualidad",
            "Valor Presente de una Anualidad",
            "Anualidad de Pago Único",
            "Amortización"});
            this.cboTipoCalculo.Location = new System.Drawing.Point(104, 12);
            this.cboTipoCalculo.Name = "cboTipoCalculo";
            this.cboTipoCalculo.Size = new System.Drawing.Size(250, 21);
            this.cboTipoCalculo.TabIndex = 0;
            this.cboTipoCalculo.SelectedIndexChanged += new System.EventHandler(this.cboTipoCalculo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAnualidad);
            this.groupBox1.Controls.Add(this.txtAnualidad);
            this.groupBox1.Controls.Add(this.lblTiempo);
            this.groupBox1.Controls.Add(this.lblTasaInteres);
            this.groupBox1.Controls.Add(this.lblMontoFinal);
            this.groupBox1.Controls.Add(this.lblPrincipal);
            this.groupBox1.Controls.Add(this.txtTiempo);
            this.groupBox1.Controls.Add(this.txtTasaInteres);
            this.groupBox1.Controls.Add(this.txtMontoFinal);
            this.groupBox1.Controls.Add(this.txtPrincipal);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 183);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // lblAnualidad
            // 
            this.lblAnualidad.AutoSize = true;
            this.lblAnualidad.Enabled = false;
            this.lblAnualidad.Location = new System.Drawing.Point(6, 148);
            this.lblAnualidad.Name = "lblAnualidad";
            this.lblAnualidad.Size = new System.Drawing.Size(57, 13);
            this.lblAnualidad.TabIndex = 9;
            this.lblAnualidad.Text = "Anualidad:";
            // 
            // txtAnualidad
            // 
            this.txtAnualidad.Enabled = false;
            this.txtAnualidad.Location = new System.Drawing.Point(142, 145);
            this.txtAnualidad.Name = "txtAnualidad";
            this.txtAnualidad.Size = new System.Drawing.Size(183, 20);
            this.txtAnualidad.TabIndex = 4;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Enabled = false;
            this.lblTiempo.Location = new System.Drawing.Point(6, 122);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(79, 13);
            this.lblTiempo.TabIndex = 7;
            this.lblTiempo.Text = "Tiempo (años):";
            // 
            // lblTasaInteres
            // 
            this.lblTasaInteres.AutoSize = true;
            this.lblTasaInteres.Enabled = false;
            this.lblTasaInteres.Location = new System.Drawing.Point(6, 96);
            this.lblTasaInteres.Name = "lblTasaInteres";
            this.lblTasaInteres.Size = new System.Drawing.Size(100, 13);
            this.lblTasaInteres.TabIndex = 6;
            this.lblTasaInteres.Text = "Tasa de Interés (%):";
            // 
            // lblMontoFinal
            // 
            this.lblMontoFinal.AutoSize = true;
            this.lblMontoFinal.Enabled = false;
            this.lblMontoFinal.Location = new System.Drawing.Point(6, 70);
            this.lblMontoFinal.Name = "lblMontoFinal";
            this.lblMontoFinal.Size = new System.Drawing.Size(65, 13);
            this.lblMontoFinal.TabIndex = 5;
            this.lblMontoFinal.Text = "Monto Final:";
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Enabled = false;
            this.lblPrincipal.Location = new System.Drawing.Point(6, 44);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(51, 13);
            this.lblPrincipal.TabIndex = 4;
            this.lblPrincipal.Text = "Principal:";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Enabled = false;
            this.txtTiempo.Location = new System.Drawing.Point(142, 119);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(183, 20);
            this.txtTiempo.TabIndex = 3;
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Enabled = false;
            this.txtTasaInteres.Location = new System.Drawing.Point(142, 93);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(183, 20);
            this.txtTasaInteres.TabIndex = 2;
            // 
            // txtMontoFinal
            // 
            this.txtMontoFinal.Enabled = false;
            this.txtMontoFinal.Location = new System.Drawing.Point(142, 67);
            this.txtMontoFinal.Name = "txtMontoFinal";
            this.txtMontoFinal.Size = new System.Drawing.Size(183, 20);
            this.txtMontoFinal.TabIndex = 1;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Enabled = false;
            this.txtPrincipal.Location = new System.Drawing.Point(142, 41);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(183, 20);
            this.txtPrincipal.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Periodo de Capitalización:";
            // 
            // cboPeriodoCapitalizacion
            // 
            this.cboPeriodoCapitalizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodoCapitalizacion.FormattingEnabled = true;
            this.cboPeriodoCapitalizacion.Items.AddRange(new object[] {
            "Anual",
            "Semestral",
            "Trimestral",
            "Bimestral",
            "Mensual",
            "Quincenal",
            "Semanal",
            "Diario"});
            this.cboPeriodoCapitalizacion.Location = new System.Drawing.Point(151, 42);
            this.cboPeriodoCapitalizacion.Name = "cboPeriodoCapitalizacion";
            this.cboPeriodoCapitalizacion.Size = new System.Drawing.Size(203, 21);
            this.cboPeriodoCapitalizacion.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(136, 264);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 28);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDetallesCalculo);
            this.groupBox2.Controls.Add(this.lblResultado);
            this.groupBox2.Location = new System.Drawing.Point(12, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 180);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // txtDetallesCalculo
            // 
            this.txtDetallesCalculo.Location = new System.Drawing.Point(9, 52);
            this.txtDetallesCalculo.Multiline = true;
            this.txtDetallesCalculo.Name = "txtDetallesCalculo";
            this.txtDetallesCalculo.ReadOnly = true;
            this.txtDetallesCalculo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetallesCalculo.Size = new System.Drawing.Size(327, 122);
            this.txtDetallesCalculo.TabIndex = 0;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(6, 25);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 16);
            this.lblResultado.TabIndex = 0;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 490);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cboPeriodoCapitalizacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboTipoCalculo);
            this.Controls.Add(this.label1);
            
            this.Name = "FormCalculadora";
            
            this.Text = "Calculadora de Interés Compuesto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoCalculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPeriodoCapitalizacion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTasaInteres;
        private System.Windows.Forms.Label lblMontoFinal;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.TextBox txtMontoFinal;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDetallesCalculo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblAnualidad;
        private System.Windows.Forms.TextBox txtAnualidad;
    }
}
