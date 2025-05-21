namespace Calculadora_Financiera_UI.UserControllers.Tasa_Equivalente
{
    partial class CtrTasaEquivalente
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCompoundRate = new System.Windows.Forms.TextBox();
            this.txtSimpleRate = new System.Windows.Forms.TextBox();
            this.txtPeriods = new System.Windows.Forms.TextBox();
            this.txtNominalRate = new System.Windows.Forms.TextBox();
            this.txtBondRate = new System.Windows.Forms.TextBox();
            this.txtCertificateRate = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCompoundToSimple = new System.Windows.Forms.Button();
            this.btnSimpleToCompound = new System.Windows.Forms.Button();
            this.btnNominalToEffective = new System.Windows.Forms.Button();
            this.btnCompareInvestments = new System.Windows.Forms.Button();
            this.btnSolveExample = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbPeriodType = new System.Windows.Forms.ComboBox();
            this.cmbNominalPeriodType = new System.Windows.Forms.ComboBox();
            this.lblCompoundRate = new System.Windows.Forms.Label();
            this.lblSimpleRate = new System.Windows.Forms.Label();
            this.lblPeriods = new System.Windows.Forms.Label();
            this.lblNominalRate = new System.Windows.Forms.Label();
            this.lblBondRate = new System.Windows.Forms.Label();
            this.lblCertificateRate = new System.Windows.Forms.Label();
            this.lblPeriodType = new System.Windows.Forms.Label();
            this.lblNominalPeriodType = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpConversionSimpleCompound = new System.Windows.Forms.GroupBox();
            this.grpNominalToEffective = new System.Windows.Forms.GroupBox();
            this.grpCompareInvestments = new System.Windows.Forms.GroupBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.grpConversionSimpleCompound.SuspendLayout();
            this.grpNominalToEffective.SuspendLayout();
            this.grpCompareInvestments.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();

            // grpConversionSimpleCompound
            this.grpConversionSimpleCompound.Location = new System.Drawing.Point(10, 10);
            this.grpConversionSimpleCompound.Name = "grpConversionSimpleCompound";
            this.grpConversionSimpleCompound.Size = new System.Drawing.Size(350, 150);
            this.grpConversionSimpleCompound.TabIndex = 0;
            this.grpConversionSimpleCompound.TabStop = false;
            this.grpConversionSimpleCompound.Text = "Conversión entre tasas simple y compuesta";

            // lblCompoundRate
            this.lblCompoundRate.AutoSize = true;
            this.lblCompoundRate.Location = new System.Drawing.Point(15, 25);
            this.lblCompoundRate.Name = "lblCompoundRate";
            this.lblCompoundRate.Size = new System.Drawing.Size(110, 13);
            this.lblCompoundRate.TabIndex = 0;
            this.lblCompoundRate.Text = "Tasa compuesta (%):";
            this.grpConversionSimpleCompound.Controls.Add(this.lblCompoundRate);

            // txtCompoundRate
            this.txtCompoundRate.Location = new System.Drawing.Point(135, 22);
            this.txtCompoundRate.Name = "txtCompoundRate";
            this.txtCompoundRate.Size = new System.Drawing.Size(80, 20);
            this.txtCompoundRate.TabIndex = 1;
            this.grpConversionSimpleCompound.Controls.Add(this.txtCompoundRate);

            // lblSimpleRate
            this.lblSimpleRate.AutoSize = true;
            this.lblSimpleRate.Location = new System.Drawing.Point(15, 55);
            this.lblSimpleRate.Name = "lblSimpleRate";
            this.lblSimpleRate.Size = new System.Drawing.Size(87, 13);
            this.lblSimpleRate.TabIndex = 2;
            this.lblSimpleRate.Text = "Tasa simple (%):";
            this.grpConversionSimpleCompound.Controls.Add(this.lblSimpleRate);

            // txtSimpleRate
            this.txtSimpleRate.Location = new System.Drawing.Point(135, 52);
            this.txtSimpleRate.Name = "txtSimpleRate";
            this.txtSimpleRate.Size = new System.Drawing.Size(80, 20);
            this.txtSimpleRate.TabIndex = 3;
            this.grpConversionSimpleCompound.Controls.Add(this.txtSimpleRate);

            // lblPeriods
            this.lblPeriods.AutoSize = true;
            this.lblPeriods.Location = new System.Drawing.Point(15, 85);
            this.lblPeriods.Name = "lblPeriods";
            this.lblPeriods.Size = new System.Drawing.Size(108, 13);
            this.lblPeriods.TabIndex = 4;
            this.lblPeriods.Text = "Número de períodos:";
            this.grpConversionSimpleCompound.Controls.Add(this.lblPeriods);

            // txtPeriods
            this.txtPeriods.Location = new System.Drawing.Point(135, 82);
            this.txtPeriods.Name = "txtPeriods";
            this.txtPeriods.Size = new System.Drawing.Size(80, 20);
            this.txtPeriods.TabIndex = 5;
            this.grpConversionSimpleCompound.Controls.Add(this.txtPeriods);

            // btnCompoundToSimple
            this.btnCompoundToSimple.Location = new System.Drawing.Point(15, 115);
            this.btnCompoundToSimple.Name = "btnCompoundToSimple";
            this.btnCompoundToSimple.Size = new System.Drawing.Size(150, 23);
            this.btnCompoundToSimple.TabIndex = 6;
            this.btnCompoundToSimple.Text = "Compuesta a Simple";
            this.btnCompoundToSimple.UseVisualStyleBackColor = true;
            this.btnCompoundToSimple.Click += new System.EventHandler(this.btnCompoundToSimple_Click);
            this.grpConversionSimpleCompound.Controls.Add(this.btnCompoundToSimple);

            // btnSimpleToCompound
            this.btnSimpleToCompound.Location = new System.Drawing.Point(175, 115);
            this.btnSimpleToCompound.Name = "btnSimpleToCompound";
            this.btnSimpleToCompound.Size = new System.Drawing.Size(150, 23);
            this.btnSimpleToCompound.TabIndex = 7;
            this.btnSimpleToCompound.Text = "Simple a Compuesta";
            this.btnSimpleToCompound.UseVisualStyleBackColor = true;
            this.btnSimpleToCompound.Click += new System.EventHandler(this.btnSimpleToCompound_Click);
            this.grpConversionSimpleCompound.Controls.Add(this.btnSimpleToCompound);

            // grpNominalToEffective
            this.grpNominalToEffective.Location = new System.Drawing.Point(10, 170);
            this.grpNominalToEffective.Name = "grpNominalToEffective";
            this.grpNominalToEffective.Size = new System.Drawing.Size(350, 120);
            this.grpNominalToEffective.TabIndex = 8;
            this.grpNominalToEffective.TabStop = false;
            this.grpNominalToEffective.Text = "Conversión de tasa nominal a efectiva";

            // lblNominalRate
            this.lblNominalRate.AutoSize = true;
            this.lblNominalRate.Location = new System.Drawing.Point(15, 25);
            this.lblNominalRate.Name = "lblNominalRate";
            this.lblNominalRate.Size = new System.Drawing.Size(90, 13);
            this.lblNominalRate.TabIndex = 0;
            this.lblNominalRate.Text = "Tasa nominal (%):";
            this.grpNominalToEffective.Controls.Add(this.lblNominalRate);

            // txtNominalRate
            this.txtNominalRate.Location = new System.Drawing.Point(135, 22);
            this.txtNominalRate.Name = "txtNominalRate";
            this.txtNominalRate.Size = new System.Drawing.Size(80, 20);
            this.txtNominalRate.TabIndex = 1;
            this.grpNominalToEffective.Controls.Add(this.txtNominalRate);

            // lblNominalPeriodType
            this.lblNominalPeriodType.AutoSize = true;
            this.lblNominalPeriodType.Location = new System.Drawing.Point(15, 55);
            this.lblNominalPeriodType.Name = "lblNominalPeriodType";
            this.lblNominalPeriodType.Size = new System.Drawing.Size(92, 13);
            this.lblNominalPeriodType.TabIndex = 2;
            this.lblNominalPeriodType.Text = "Tipo de período:";
            this.grpNominalToEffective.Controls.Add(this.lblNominalPeriodType);

            // cmbNominalPeriodType
            this.cmbNominalPeriodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNominalPeriodType.FormattingEnabled = true;
            this.cmbNominalPeriodType.Location = new System.Drawing.Point(135, 52);
            this.cmbNominalPeriodType.Name = "cmbNominalPeriodType";
            this.cmbNominalPeriodType.Size = new System.Drawing.Size(120, 21);
            this.cmbNominalPeriodType.TabIndex = 3;
            this.grpNominalToEffective.Controls.Add(this.cmbNominalPeriodType);

            // btnNominalToEffective
            this.btnNominalToEffective.Location = new System.Drawing.Point(105, 85);
            this.btnNominalToEffective.Name = "btnNominalToEffective";
            this.btnNominalToEffective.Size = new System.Drawing.Size(150, 23);
            this.btnNominalToEffective.TabIndex = 4;
            this.btnNominalToEffective.Text = "Calcular Tasa Efectiva";
            this.btnNominalToEffective.UseVisualStyleBackColor = true;
            this.btnNominalToEffective.Click += new System.EventHandler(this.btnNominalToEffective_Click);
            this.grpNominalToEffective.Controls.Add(this.btnNominalToEffective);

            // grpCompareInvestments
            this.grpCompareInvestments.Location = new System.Drawing.Point(10, 300);
            this.grpCompareInvestments.Name = "grpCompareInvestments";
            this.grpCompareInvestments.Size = new System.Drawing.Size(350, 160);
            this.grpCompareInvestments.TabIndex = 9;
            this.grpCompareInvestments.TabStop = false;
            this.grpCompareInvestments.Text = "Comparación de inversiones";

            // lblBondRate
            this.lblBondRate.AutoSize = true;
            this.lblBondRate.Location = new System.Drawing.Point(15, 25);
            this.lblBondRate.Name = "lblBondRate";
            this.lblBondRate.Size = new System.Drawing.Size(131, 13);
            this.lblBondRate.TabIndex = 0;
            this.lblBondRate.Text = "Tasa de bonos (% anual):";
            this.grpCompareInvestments.Controls.Add(this.lblBondRate);

            // txtBondRate
            this.txtBondRate.Location = new System.Drawing.Point(195, 22);
            this.txtBondRate.Name = "txtBondRate";
            this.txtBondRate.Size = new System.Drawing.Size(80, 20);
            this.txtBondRate.TabIndex = 1;
            this.grpCompareInvestments.Controls.Add(this.txtBondRate);

            // lblCertificateRate
            this.lblCertificateRate.AutoSize = true;
            this.lblCertificateRate.Location = new System.Drawing.Point(15, 55);
            this.lblCertificateRate.Name = "lblCertificateRate";
            this.lblCertificateRate.Size = new System.Drawing.Size(174, 13);
            this.lblCertificateRate.TabIndex = 2;
            this.lblCertificateRate.Text = "Tasa de cédulas hipotecarias (%):";
            this.grpCompareInvestments.Controls.Add(this.lblCertificateRate);

            // txtCertificateRate
            this.txtCertificateRate.Location = new System.Drawing.Point(195, 52);
            this.txtCertificateRate.Name = "txtCertificateRate";
            this.txtCertificateRate.Size = new System.Drawing.Size(80, 20);
            this.txtCertificateRate.TabIndex = 3;
            this.grpCompareInvestments.Controls.Add(this.txtCertificateRate);

            // lblPeriodType
            this.lblPeriodType.AutoSize = true;
            this.lblPeriodType.Location = new System.Drawing.Point(15, 85);
            this.lblPeriodType.Name = "lblPeriodType";
            this.lblPeriodType.Size = new System.Drawing.Size(144, 13);
            this.lblPeriodType.TabIndex = 4;
            this.lblPeriodType.Text = "Tipo período de las cédulas:";
            this.grpCompareInvestments.Controls.Add(this.lblPeriodType);

            // cmbPeriodType
            this.cmbPeriodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodType.FormattingEnabled = true;
            this.cmbPeriodType.Location = new System.Drawing.Point(195, 82);
            this.cmbPeriodType.Name = "cmbPeriodType";
            this.cmbPeriodType.Size = new System.Drawing.Size(120, 21);
            this.cmbPeriodType.TabIndex = 5;
            this.grpCompareInvestments.Controls.Add(this.cmbPeriodType);

            // btnCompareInvestments
            this.btnCompareInvestments.Location = new System.Drawing.Point(65, 115);
            this.btnCompareInvestments.Name = "btnCompareInvestments";
            this.btnCompareInvestments.Size = new System.Drawing.Size(100, 23);
            this.btnCompareInvestments.TabIndex = 6;
            this.btnCompareInvestments.Text = "Comparar";
            this.btnCompareInvestments.UseVisualStyleBackColor = true;
            this.btnCompareInvestments.Click += new System.EventHandler(this.btnCompareInvestments_Click);
            this.grpCompareInvestments.Controls.Add(this.btnCompareInvestments);

            // btnSolveExample
            this.btnSolveExample.Location = new System.Drawing.Point(175, 115);
            this.btnSolveExample.Name = "btnSolveExample";
            this.btnSolveExample.Size = new System.Drawing.Size(100, 23);
            this.btnSolveExample.TabIndex = 7;
            this.btnSolveExample.Text = "Usar Ejemplo";
            this.btnSolveExample.UseVisualStyleBackColor = true;
            this.btnSolveExample.Click += new System.EventHandler(this.btnSolveExample_Click);
            this.grpCompareInvestments.Controls.Add(this.btnSolveExample);

            // grpResults
            this.grpResults.Location = new System.Drawing.Point(10, 470);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(350, 120);
            this.grpResults.TabIndex = 10;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Resultados";

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(15, 25);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(61, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Resultado:";
            this.grpResults.Controls.Add(this.lblResult);

            // txtResult
            this.txtResult.Location = new System.Drawing.Point(15, 45);
            this.txtResult.Name = "txtResult";
            this.txtResult.Multiline = true;
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(320, 65);
            this.txtResult.TabIndex = 1;
            this.grpResults.Controls.Add(this.txtResult);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(135, 600);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // CtrTasaEquivalente
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpConversionSimpleCompound);
            this.Controls.Add(this.grpNominalToEffective);
            this.Controls.Add(this.grpCompareInvestments);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.btnClear);
            this.Name = "CtrTasaEquivalente";
            this.Size = new System.Drawing.Size(370, 630);
            this.grpConversionSimpleCompound.ResumeLayout(false);
            this.grpConversionSimpleCompound.PerformLayout();
            this.grpNominalToEffective.ResumeLayout(false);
            this.grpNominalToEffective.PerformLayout();
            this.grpCompareInvestments.ResumeLayout(false);
            this.grpCompareInvestments.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtCompoundRate;
        private System.Windows.Forms.TextBox txtSimpleRate;
        private System.Windows.Forms.TextBox txtPeriods;
        private System.Windows.Forms.TextBox txtNominalRate;
        private System.Windows.Forms.TextBox txtBondRate;
        private System.Windows.Forms.TextBox txtCertificateRate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCompoundToSimple;
        private System.Windows.Forms.Button btnSimpleToCompound;
        private System.Windows.Forms.Button btnNominalToEffective;
        private System.Windows.Forms.Button btnCompareInvestments;
        private System.Windows.Forms.Button btnSolveExample;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbPeriodType;
        private System.Windows.Forms.ComboBox cmbNominalPeriodType;
        private System.Windows.Forms.Label lblCompoundRate;
        private System.Windows.Forms.Label lblSimpleRate;
        private System.Windows.Forms.Label lblPeriods;
        private System.Windows.Forms.Label lblNominalRate;
        private System.Windows.Forms.Label lblBondRate;
        private System.Windows.Forms.Label lblCertificateRate;
        private System.Windows.Forms.Label lblPeriodType;
        private System.Windows.Forms.Label lblNominalPeriodType;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grpConversionSimpleCompound;
        private System.Windows.Forms.GroupBox grpNominalToEffective;
        private System.Windows.Forms.GroupBox grpCompareInvestments;
        private System.Windows.Forms.GroupBox grpResults;
    }
}
    


