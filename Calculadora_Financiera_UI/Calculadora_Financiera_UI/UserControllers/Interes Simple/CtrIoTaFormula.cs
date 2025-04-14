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
    public partial class CtrIoTaFormula : CtrTiempoFormula
    {

        private CtrIoTaFormula controlBase;
        public CtrIoTaFormula()
        {
            InitializeComponent();
            CtrIoTeFormula ctrIoTeFormula = new CtrIoTeFormula();

        }

        private void CtrIoTaFormula_Load(object sender, EventArgs e)
        {

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
                    double interes = capital * (tasa / 100) * (TiempoAproximado(fechaInicial, fechaFinal) / 360);
                    double montoTotal = capital + interes;

                    txtResultado.Text = ("Interes Generado= " + interes);
                     double juan = TiempoAproximado(fechaInicial, fechaFinal);
                    MessageBox.Show("El tiempo es: " + juan);
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
