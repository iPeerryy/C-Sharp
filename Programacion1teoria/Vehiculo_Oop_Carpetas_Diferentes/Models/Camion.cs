using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_Oop_Carpetas_Diferentes.Models
{
    public class Camion : Vehiculo
    {
        public double CapacidadCarga;

        public override void CalcularImpuesto()
        {
            Impuesto = PrecioBase * 0.30;
        }
    }
}
