using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Models.Entities
{
    public class Reserva
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan hora { get; set; }
        public double total { get; set; }
        public Cliente cliente { get; set; }
        public List<ProductoPedido> productos { get; set; } = new List<ProductoPedido>();
        public bool estado { get; set; } = true;
    }
}
