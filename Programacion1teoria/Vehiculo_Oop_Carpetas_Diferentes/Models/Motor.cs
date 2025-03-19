using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_Oop_Carpetas_Diferentes.Models
{
    public class Motor : Vehiculo
    {
        public double Potencia;

        public override void CalcularImpuesto()
        {
            Impuesto = PrecioBase * 0.15;
        }
    }
}
