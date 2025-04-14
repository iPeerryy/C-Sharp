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

namespace Calculadora_Financiera_UI.UserControllers.Tiempo
{
    public partial class CtrTiempoAproximadoFormula : CtrTiempoFormula
    {
        public CtrTiempoAproximadoFormula()
        {
            InitializeComponent();
        }

        private void CtrTiempoAproximadoFormula_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.TryParse(TxtFechaInicial.Text, out DateTime fechaInicial) &&
                    DateTime.TryParse(TxtFechaFinal.Text, out DateTime fechaFinal))
                {
                    double Resultado = TiempoAproximado(fechaInicial, fechaFinal);

                    TxtResultado.Text = (Resultado + " Días");
                }
                else
                {
                    MessageBox.Show("Por favoor infrese valores numéricos válidos en todos los campos", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
