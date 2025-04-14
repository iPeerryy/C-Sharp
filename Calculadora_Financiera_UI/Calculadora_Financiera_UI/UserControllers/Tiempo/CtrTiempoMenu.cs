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
    public partial class CtrTiempoMenu : UserControl
    {
        public CtrTiempoMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelTiempoMenu.Controls.Clear();
            CtrTiempoAproximadoFormula tiempoAproximadoFormula = new CtrTiempoAproximadoFormula();
            PanelTiempoMenu.Controls.Add(tiempoAproximadoFormula);
            PanelTiempoMenu.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelTiempoMenu.Controls.Clear();
            CtrTiempoExactoFormula tiempoExactoFormula = new CtrTiempoExactoFormula();
            PanelTiempoMenu.Controls.Add(tiempoExactoFormula);
            PanelTiempoMenu.Visible = true;


        }
    }
}
