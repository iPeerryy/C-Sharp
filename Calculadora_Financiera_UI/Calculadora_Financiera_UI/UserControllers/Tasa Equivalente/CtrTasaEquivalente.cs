using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Financiera_UI.UserControllers.Tasa_Equivalente
{
    public partial class CtrTasaEquivalente : UserControl
    {
        public CtrTasaEquivalente()
        {
            InitializeComponent();
            // Inicializar ComboBox de periodos
            cmbPeriodType.Items.AddRange(new string[] { "Anual", "Semestral", "Trimestral", "Mensual" });
            cmbPeriodType.SelectedIndex = 0; // Seleccionar Anual por defecto

            cmbNominalPeriodType.Items.AddRange(new string[] { "Anual", "Semestral", "Trimestral", "Mensual" });
            cmbNominalPeriodType.SelectedIndex = 0; // Seleccionar Anual por defecto
        }

        private void btnCompoundToSimple_Click(object sender, EventArgs e)
        {
            try
            {
                double compoundRate = Convert.ToDouble(txtCompoundRate.Text) / 100;
                int periods = Convert.ToInt32(txtPeriods.Text);

                // Fórmula para convertir tasa compuesta a simple
                // i = (1+j)^n - 1
                // Donde:
                // i = tasa simple equivalente
                // j = tasa compuesta
                // n = número de períodos

                double simpleRate = (Math.Pow(1 + compoundRate, periods) - 1) * 100;

                txtResult.Text = $"Tasa de interés simple equivalente: {simpleRate.ToString("F4")}%";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos ingresados: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpleToCompound_Click(object sender, EventArgs e)
        {
            try
            {
                double simpleRate = Convert.ToDouble(txtSimpleRate.Text) / 100;
                int periods = Convert.ToInt32(txtPeriods.Text);

                // Fórmula para convertir tasa simple a compuesta
                // j = (1+i)^(1/n) - 1
                // Donde:
                // j = tasa compuesta equivalente
                // i = tasa simple
                // n = número de períodos

                double compoundRate = (Math.Pow(1 + simpleRate, 1.0 / periods) - 1) * 100;

                txtResult.Text = $"Tasa de interés compuesta equivalente: {compoundRate.ToString("F4")}%";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos ingresados: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNominalToEffective_Click(object sender, EventArgs e)
        {
            try
            {
                double nominalRate = Convert.ToDouble(txtNominalRate.Text) / 100;
                int periodsPerYear = GetPeriodsPerYear(cmbNominalPeriodType.SelectedIndex);

                // Calcular tasa periódica
                double periodicRate = nominalRate / periodsPerYear;

                // Fórmula para convertir tasa nominal a efectiva
                // Efectiva = (1 + j/m)^m - 1
                // Donde:
                // j = tasa nominal
                // m = número de períodos por año

                double effectiveRate = (Math.Pow(1 + periodicRate, periodsPerYear) - 1) * 100;

                txtResult.Text = $"Tasa efectiva anual: {effectiveRate.ToString("F4")}%";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos ingresados: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompareInvestments_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener tasas de bonos y cédulas
                double bondRate = Convert.ToDouble(txtBondRate.Text) / 100;
                double certificateRate = Convert.ToDouble(txtCertificateRate.Text) / 100;

                // Obtener tipo de período para cédulas
                int periodsPerYear = GetPeriodsPerYear(cmbPeriodType.SelectedIndex);

                // Calcular tasa periódica de las cédulas
                double periodicRate = certificateRate / periodsPerYear;

                // Convertir a tasa efectiva anual
                double effectiveCertificateRate = (Math.Pow(1 + periodicRate, periodsPerYear) - 1) * 100;

                string result = $"Bonos: {(bondRate * 100).ToString("F4")}% efectivo anual\r\n" +
                               $"Cédulas: {effectiveCertificateRate.ToString("F4")}% efectivo anual\r\n\r\n";

                if (bondRate * 100 > effectiveCertificateRate)
                {
                    result += "Es más conveniente invertir en BONOS.";
                }
                else if (bondRate * 100 < effectiveCertificateRate)
                {
                    result += "Es más conveniente invertir en CÉDULAS HIPOTECARIAS.";
                }
                else
                {
                    result += "Ambas inversiones ofrecen el mismo rendimiento.";
                }

                txtResult.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos ingresados: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetPeriodsPerYear(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0: return 1;  // Anual
                case 1: return 2;  // Semestral
                case 2: return 4;  // Trimestral
                case 3: return 12; // Mensual
                default: return 1;
            }
        }

        private void btnSolveExample_Click(object sender, EventArgs e)
        {
            // Ingresar los datos del ejemplo automáticamente
            txtBondRate.Text = "8";
            txtCertificateRate.Text = "7.75";
            cmbPeriodType.SelectedIndex = 2; // Trimestral

            // Ejecutar comparación
            btnCompareInvestments_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCompoundRate.Text = "";
            txtSimpleRate.Text = "";
            txtPeriods.Text = "";
            txtNominalRate.Text = "";
            txtBondRate.Text = "";
            txtCertificateRate.Text = "";
            txtResult.Text = "";
        }
    }
}

