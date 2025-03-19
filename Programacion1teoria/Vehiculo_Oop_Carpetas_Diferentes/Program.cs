using Vehiculo_Oop_Carpetas_Diferentes.Models;
using Vehiculo_Oop_Carpetas_Diferentes.Services;

namespace VehiculosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Vehiculo vehiculo = VehiculoService.CapturarDatos();

            if (vehiculo != null)
            {
                vehiculo.CalcularImpuesto();
                VehiculoService.MostrarResultados(vehiculo);
            }

            Console.ReadKey();
        }
    }
}