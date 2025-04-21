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

namespace Calculadora_Financiera_UI.UserControllers.Descuento
{
    public partial class CtrTasaDescuentoFormula : CtrTiempoFormula
    {
        public CtrTasaDescuentoFormula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtTasaDescuento.Text, out double tasaDescuento) &&
                    DateTime.TryParse(txtFechaInicial.Text, out DateTime fechaInicial) &&
                    DateTime.TryParse(txtFechaFinal.Text, out DateTime fechaFinal))
                {
                    double tiempo = TiempoAproximado(fechaInicial, fechaFinal) / 360;
                    double tasaInteres = tasaDescuento/ (1 - (tasaDescuento / 100) * tiempo);
                    txtResultado.Text = ("La tasa de interes calculada es: " + tasaInteres);
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
