using Calculadora_Financiera_UI.Interes_Simple;
using Calculadora_Financiera_UI.UserControllers.Interes_Simple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Financiera_UI
{

    public partial class CtrInteresSimple : UserControl
    {

        public CtrInteresSimple()
        {
            InitializeComponent();

        }

        private void interesSimpleFormulaButton_Click(object sender, EventArgs e)
        {
            panelInteresSimple.Controls.Clear();
            CtrIoTeFormula intresSimpleFormula = new CtrIoTeFormula();
            panelInteresSimple.Controls.Add(intresSimpleFormula);
            panelInteresSimple.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelInteresSimple.Controls.Clear();
            CtrIoTaFormula intresSimpleFormula = new CtrIoTaFormula();
            panelInteresSimple.Controls.Add(intresSimpleFormula);
            panelInteresSimple.Visible = true;
        }

        private void panelInteresSimple_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IeTaButton_Click(object sender, EventArgs e)
        {
            panelInteresSimple.Controls.Clear();
            CtrIeTeFormula intresSimpleFormula = new CtrIeTeFormula();
            panelInteresSimple.Controls.Add(intresSimpleFormula);
            panelInteresSimple.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelInteresSimple.Controls.Clear();
            CtrIeTaFormula intresSimpleFormula = new CtrIeTaFormula();
            panelInteresSimple.Controls.Add(intresSimpleFormula);
            panelInteresSimple.Visible = true;
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelInteresSimple.Controls.Clear();
            CtrCapitalFormula intresSimpleFormula = new CtrCapitalFormula();
            panelInteresSimple.Controls.Add(intresSimpleFormula);
            panelInteresSimple.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panelInteresSimple.Controls.Clear();
            CtrMontoFormula intresSimpleFormula = new CtrMontoFormula();
            panelInteresSimple.Controls.Add(intresSimpleFormula);
            panelInteresSimple.Visible = true;
        }
    }
}
