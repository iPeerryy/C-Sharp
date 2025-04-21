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
    public partial class CtrValorDescontadoFormula : CtrTiempoFormula
    {
        public CtrValorDescontadoFormula()
        {
            InitializeComponent();
        }

        private void CtrValorDescontadoFormula_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtTasaDescuento.Text, out double tasaDescuento) &&
                    double.TryParse(txtSumaSolicitada.Text, out double sumaSolicitada) &&
                    DateTime.TryParse(txtFechaInicial.Text, out DateTime fechaInicial) &&
                    DateTime.TryParse(txtFechaFinal.Text, out DateTime fechaFinal))
                {
                    double tiempo = TiempoAproximado(fechaInicial, fechaFinal) / 360;
                    double valorDescontado = sumaSolicitada * (1-(tasaDescuento / 100) * tiempo);
                    txtResultado.Text = ("El valor descontado calculado es: " + valorDescontado);
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
