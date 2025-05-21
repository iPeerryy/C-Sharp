namespace Calculadora_Financiera_UI.UserControllers.DecuentoPorProntoPago
{
    partial class CtrDescuentoPorProntoPago
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoOriginal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarDescuento = new System.Windows.Forms.Button();
            this.txtPorcentajeDescuento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcionDescuento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridDescuentos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDescuentoEquivalente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalDescontado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontoFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcularDescuentos = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnReglasDescuentos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDescuentos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMontoOriginal);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Iniciales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto Original:";
            // 
            // txtMontoOriginal
            // 
            this.txtMontoOriginal.Location = new System.Drawing.Point(142, 27);
            this.txtMontoOriginal.Name = "txtMontoOriginal";
            this.txtMontoOriginal.Size = new System.Drawing.Size(130, 22);
            this.txtMontoOriginal.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarDescuento);
            this.groupBox2.Controls.Add(this.txtPorcentajeDescuento);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDescripcionDescuento);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dataGridDescuentos);
            this.groupBox2.Location = new System.Drawing.Point(16, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descuentos";
            // 
            // btnAgregarDescuento
            // 
            this.btnAgregarDescuento.Location = new System.Drawing.Point(396, 55);
            this.btnAgregarDescuento.Name = "btnAgregarDescuento";
            this.btnAgregarDescuento.Size = new System.Drawing.Size(130, 28);
            this.btnAgregarDescuento.TabIndex = 5;
            this.btnAgregarDescuento.Text = "Agregar";
            this.btnAgregarDescuento.UseVisualStyleBackColor = true;
            this.btnAgregarDescuento.Click += new System.EventHandler(this.btnAgregarDescuento_Click);
            // 
            // txtPorcentajeDescuento
            // 
            this.txtPorcentajeDescuento.Location = new System.Drawing.Point(142, 55);
            this.txtPorcentajeDescuento.Name = "txtPorcentajeDescuento";
            this.txtPorcentajeDescuento.Size = new System.Drawing.Size(130, 22);
            this.txtPorcentajeDescuento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Porcentaje (%):";
            // 
            // txtDescripcionDescuento
            // 
            this.txtDescripcionDescuento.Location = new System.Drawing.Point(142, 27);
            this.txtDescripcionDescuento.Name = "txtDescripcionDescuento";
            this.txtDescripcionDescuento.Size = new System.Drawing.Size(384, 22);
            this.txtDescripcionDescuento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // dataGridDescuentos
            // 
            this.dataGridDescuentos.AllowUserToResizeColumns = false;
            this.dataGridDescuentos.AllowUserToResizeRows = false;
            this.dataGridDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDescuentos.Location = new System.Drawing.Point(25, 89);
            this.dataGridDescuentos.Name = "dataGridDescuentos";
            this.dataGridDescuentos.RowHeadersWidth = 51;
            this.dataGridDescuentos.RowTemplate.Height = 24;
            this.dataGridDescuentos.Size = new System.Drawing.Size(501, 141);
            this.dataGridDescuentos.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescuentoEquivalente);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTotalDescontado);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtMontoFinal);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(16, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(552, 124);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // txtDescuentoEquivalente
            // 
            this.txtDescuentoEquivalente.Location = new System.Drawing.Point(200, 87);
            this.txtDescuentoEquivalente.Name = "txtDescuentoEquivalente";
            this.txtDescuentoEquivalente.ReadOnly = true;
            this.txtDescuentoEquivalente.Size = new System.Drawing.Size(159, 22);
            this.txtDescuentoEquivalente.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Descuento Equivalente:";
            // 
            // txtTotalDescontado
            // 
            this.txtTotalDescontado.Location = new System.Drawing.Point(200, 59);
            this.txtTotalDescontado.Name = "txtTotalDescontado";
            this.txtTotalDescontado.ReadOnly = true;
            this.txtTotalDescontado.Size = new System.Drawing.Size(159, 22);
            this.txtTotalDescontado.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Descontado:";
            // 
            // txtMontoFinal
            // 
            this.txtMontoFinal.Location = new System.Drawing.Point(200, 31);
            this.txtMontoFinal.Name = "txtMontoFinal";
            this.txtMontoFinal.ReadOnly = true;
            this.txtMontoFinal.Size = new System.Drawing.Size(159, 22);
            this.txtMontoFinal.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Monto Final (a pagar):";
            // 
            // btnCalcularDescuentos
            // 
            this.btnCalcularDescuentos.Location = new System.Drawing.Point(16, 342);
            this.btnCalcularDescuentos.Name = "btnCalcularDescuentos";
            this.btnCalcularDescuentos.Size = new System.Drawing.Size(178, 47);
            this.btnCalcularDescuentos.TabIndex = 3;
            this.btnCalcularDescuentos.Text = "Calcular Descuentos";
            this.btnCalcularDescuentos.UseVisualStyleBackColor = true;
            this.btnCalcularDescuentos.Click += new System.EventHandler(this.btnCalcularDescuentos_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(200, 342);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(178, 47);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnReglasDescuentos
            // 
            this.btnReglasDescuentos.Location = new System.Drawing.Point(390, 342);
            this.btnReglasDescuentos.Name = "btnReglasDescuentos";
            this.btnReglasDescuentos.Size = new System.Drawing.Size(178, 47);
            this.btnReglasDescuentos.TabIndex = 5;
            this.btnReglasDescuentos.Text = "Reglas de Descuentos";
            this.btnReglasDescuentos.UseVisualStyleBackColor = true;
            this.btnReglasDescuentos.Click += new System.EventHandler(this.btnReglasDescuentos_Click);
            // 
            // CtrDescuentosComerciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReglasDescuentos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcularDescuentos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CtrDescuentosComerciales";
            this.Size = new System.Drawing.Size(587, 547);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDescuentos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontoOriginal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarDescuento;
        private System.Windows.Forms.TextBox txtPorcentajeDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcionDescuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridDescuentos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDescuentoEquivalente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalDescontado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMontoFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcularDescuentos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnReglasDescuentos;
    }
}
