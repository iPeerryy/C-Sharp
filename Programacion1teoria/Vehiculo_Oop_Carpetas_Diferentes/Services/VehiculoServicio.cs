using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculo_Oop_Carpetas_Diferentes.Models;

namespace Vehiculo_Oop_Carpetas_Diferentes.Services
{
    public class VehiculoService
    {
        public static Vehiculo CapturarDatos()
        {
            Console.WriteLine("Captura de Datos del Vehículo");
            Console.WriteLine("------------------------------");

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Año: ");
            int anio = int.Parse(Console.ReadLine());

            Console.Write("Precio Base: ");
            double precioBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Selecciona el tipo de vehículo:");
            Console.WriteLine("1. Carro");
            Console.WriteLine("2. Camión");
            Console.WriteLine("3. Motor");
            Console.WriteLine("4. Camioneta");
            int tipo = int.Parse(Console.ReadLine());

            Vehiculo vehiculo = null;
            switch (tipo)
            {
                case 1:
                    var carro = new Carro
                    {
                        Marca = marca,
                        Modelo = modelo,
                        Anio = anio,
                        PrecioBase = precioBase
                    };
                    Console.Write("Número de Puertas: ");
                    carro.NumeroDePuertas = int.Parse(Console.ReadLine());
                    vehiculo = carro;
                    break;

                case 2:
                    var camion = new Camion
                    {
                        Marca = marca,
                        Modelo = modelo,
                        Anio = anio,
                        PrecioBase = precioBase
                    };
                    Console.Write("Capacidad de Carga (kg): ");
                    camion.CapacidadCarga = double.Parse(Console.ReadLine());
                    vehiculo = camion;
                    break;

                case 3:
                    var motor = new Motor
                    {
                        Marca = marca,
                        Modelo = modelo,
                        Anio = anio,
                        PrecioBase = precioBase
                    };
                    Console.Write("Potencia del Motor (HP): ");
                    motor.Potencia = double.Parse(Console.ReadLine());
                    vehiculo = motor;
                    break;

                case 4:
                    var camioneta = new Camioneta
                    {
                        Marca = marca,
                        Modelo = modelo,
                        Anio = anio,
                        PrecioBase = precioBase
                    };
                    Console.Write("Número de Ruedas: ");
                    camioneta.NumeroDeRuedas = int.Parse(Console.ReadLine());
                    vehiculo = camioneta;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            return vehiculo;
        }

        public static void MostrarResultados(Vehiculo vehiculo)
        {
            if (vehiculo != null)
            {
                Console.Clear();
                Console.WriteLine("Datos del Vehículo:");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Marca: " + vehiculo.Marca);
                Console.WriteLine("Modelo: " + vehiculo.Modelo);
                Console.WriteLine("Año: " + vehiculo.Anio);
                Console.WriteLine("Precio Base: " + vehiculo.PrecioBase);
                Console.WriteLine("Impuesto Calculado: " + vehiculo.Impuesto);

                if (vehiculo is Carro carro)
                {
                    Console.WriteLine("Número de Puertas: " + carro.NumeroDePuertas);
                }
                else if (vehiculo is Camion camion)
                {
                    Console.WriteLine("Capacidad de Carga: " + camion.CapacidadCarga + " Kg");
                }
                else if (vehiculo is Motor motor)
                {
                    Console.WriteLine("Potencia del Motor: " + motor.Potencia + " HP");
                }
                else if (vehiculo is Camioneta camioneta)
                {
                    Console.WriteLine("Número de Ruedas: " + camioneta.NumeroDeRuedas);
                }
            }
            else
            {
                Console.WriteLine("No se capturaron datos válidos.");
            }
        }
    }
}

