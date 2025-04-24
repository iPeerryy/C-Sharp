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


            // Guardar el control actual en el historial si existe
            if (contenedor.Controls.Count > 0)
            {
                foreach (Control control in contenedor.Controls)
                {
                    if (control is UserControl existingUserControl)
                    {
                        historial.Push(existingUserControl);
                        break;
                    }
                }
            }

            contenedor.Controls.Clear();
            nuevo.Dock = DockStyle.Fill;
            contenedor.Controls.Add(nuevo);
        }

        public void Volver()
        {
            
            if (historial.Count > 0)
            {
                contenedor.Controls.Clear();
                var anterior = historial.Pop();
                contenedor.Controls.Add(anterior);
                anterior.Dock = DockStyle.Fill;
            }
        }
    }
}
