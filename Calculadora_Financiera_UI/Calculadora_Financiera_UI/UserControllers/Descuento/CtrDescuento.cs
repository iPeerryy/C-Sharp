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
    public partial class CtrDescuento : UserControl
    {
        public CtrDescuento()
        {
            InitializeComponent();
        }

        private void IoTeButton_Click(object sender, EventArgs e)
        {
            panelDescuento.Controls.Clear();
            CtrDescuentoFormula intresSimpleFormula = new CtrDescuentoFormula();
            panelDescuento.Controls.Add(intresSimpleFormula);
            panelDescuento.Visible = true;
        }

        private void CtrDescuento_Load(object sender, EventArgs e)
        {

        }

        private void IoTaButton_Click(object sender, EventArgs e)
        {
            panelDescuento.Controls.Clear();
            CtrTasaDescuentoFormula intresSimpleFormula = new CtrTasaDescuentoFormula();
            panelDescuento.Controls.Add(intresSimpleFormula);
            panelDescuento.Visible = true;
        }

        private void PanelDescuento_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IeTeButton_Click(object sender, EventArgs e)
        {
            panelDescuento.Controls.Clear();
            CtrValorDescontadoFormula intresSimpleFormula = new CtrValorDescontadoFormula();
            panelDescuento.Controls.Add(intresSimpleFormula);
            panelDescuento.Visible = true;
        }
    }
}
