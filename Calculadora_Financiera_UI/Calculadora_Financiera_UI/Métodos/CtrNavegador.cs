using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Financiera_UI.Métodos
{
    public class CtrNavegador
    {
        private Panel contenedor;
        private Stack<UserControl> historial = new Stack<UserControl>();

        public CtrNavegador(Panel panel)
        {
            contenedor = panel;
        }

        public void NavegarA(UserControl nuevo)
        {
            if (contenedor.Controls.Count > 0)
            {
                var actual = (UserControl)contenedor.Controls[0];
                actual.Visible = false;
                historial.Push(actual);
            }

            nuevo.Dock = DockStyle.Fill;
            contenedor.Controls.Add(nuevo);
            nuevo.Visible = true;
        }

        public void Volver()
        {
            if (historial.Count > 0)
            {
                var actual = (UserControl)contenedor.Controls[contenedor.Controls.Count - 1];
                contenedor.Controls.Remove(actual);

                var anterior = historial.Pop();
                anterior.Visible = true;
            }
        }
    }
}
