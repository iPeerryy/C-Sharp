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
    }
}
