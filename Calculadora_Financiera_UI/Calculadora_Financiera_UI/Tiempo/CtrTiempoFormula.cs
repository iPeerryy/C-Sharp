using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Financiera_UI.Tiempo
{
    public partial class CtrTiempoFormula : UserControl
    {
        public CtrTiempoFormula()
        {
            InitializeComponent();



        }
        public double TiempoAproximado(DateTime fechaInicial, DateTime fechaFinal)
        {
            int años = fechaFinal.Year - fechaInicial.Year;
            int meses = fechaFinal.Month - fechaInicial.Month;
            int dias = fechaFinal.Day - fechaInicial.Day;

            // Ajustar si los días o meses son negativos
            if (dias < 0)
            {
                meses--;
                dias += 30;
            }

            if (meses < 0)
            {
                años--;
                meses += 12;
            }

            return (años*360) + (meses * 30) + dias;
        }

        public double TiempoExacto(DateTime fechaInicial, DateTime fechaFinal)
        {
            // TimeSpan representa un intervalo de tiempo
            TimeSpan diferencia = fechaFinal - fechaInicial;

            // Convertir el total de días a años
            return diferencia.TotalDays;
        }

        private void CtrTiempoFormula_Load(object sender, EventArgs e)
        {

        }
    }
}
