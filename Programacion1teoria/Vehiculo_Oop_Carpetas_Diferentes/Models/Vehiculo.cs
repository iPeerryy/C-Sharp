using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_Oop_Carpetas_Diferentes.Models
{
    public class Vehiculo
    {
        public string Marca;
        public string Modelo;
        public int Anio;
        public double PrecioBase;
        public double Impuesto;

        public virtual void CalcularImpuesto() { }
    }
}
