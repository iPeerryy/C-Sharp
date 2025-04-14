using Calculadora_Financiera_UI.Tiempo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Financiera_UI.Interes_Simple
{
    public partial class CtrIeTeFormula : CtrTiempoFormula
    {
        public CtrIeTeFormula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtCapital.Text, out double capital) &&
                    double.TryParse(txtInteres.Text, out double tasa) &&
                    DateTime.TryParse(txtFechaInicial.Text, out DateTime fechaInicial) &&
                    DateTime.TryParse(txtFechaFinal.Text, out DateTime fechaFinal))
                {
                    double interes = capital * (tasa / 100) * (TiempoExacto(fechaInicial, fechaFinal) / 365);
                    double montoTotal = capital + interes;

                    txtResultado.Text = ("Interes Generado= " + interes);
                }
                else
                {
                    MessageBox.Show("Por favor ingrese valores numéricos válidos en todos los campor.",
                        "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
