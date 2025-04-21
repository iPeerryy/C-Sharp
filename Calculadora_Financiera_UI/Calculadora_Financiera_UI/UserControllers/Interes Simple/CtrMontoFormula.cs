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

namespace Calculadora_Financiera_UI.UserControllers.Interes_Simple
{
    public partial class CtrMontoFormula : CtrTiempoFormula
    {
        public CtrMontoFormula()
        {
            InitializeComponent();
        }

        private void CtrControlFormula_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtInteres.Text, out double capital) &&
                    double.TryParse(txtTasaInteres.Text, out double tasa) &&
                    DateTime.TryParse(txtFechaInicial.Text, out DateTime fechaInicial) &&
                    DateTime.TryParse(txtFechaFinal.Text, out DateTime fechaFinal))
                {
                    double tiempo = TiempoAproximado(fechaInicial, fechaFinal) / 360;
                    double monto = capital * (1 + (tasa / 100) * tiempo);
                    txtResultado.Text = ("El monto calculado es: " + monto);
                }
                else
                {
                    MessageBox.Show("Por favor ingrese valores numéricos válidos en todos los campos.",
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

