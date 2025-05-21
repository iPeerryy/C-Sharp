using Calculadora_Financiera_UI.UserControllers.DecuentoPorProntoPago;
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
    public partial class CtrDescuentoPorProntoPagoMenu : UserControl
    {
        public CtrDescuentoPorProntoPagoMenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CtrDescuentoPorProntoPago ctrDescuentoPorProntoPago = new CtrDescuentoPorProntoPago();
            panelDescuentoPorProntoPago.Controls.Clear();
            panelDescuentoPorProntoPago.Controls.Add(ctrDescuentoPorProntoPago);
            panelDescuentoPorProntoPago.Visible = true;
        }
    }
}
