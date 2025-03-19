using System;
using System.Runtime;

namespace VehiculosApp
{
	//clase base
	public class Vehiculo
	{

		public string Marca;
		public string Modelo;
		public int Anio;
		public double PrecioBase;
		public double Impuesto;

		// Para sobreescribir el impuesto calculado
		public virtual void CalcularImpuesto()
		{

			
		}
	}

	//Clases hijas sobreescribiendo sus respectivos impuestos
	public class Carro : Vehiculo
	{

		public int NumeroDePuertas;


		public override void CalcularImpuesto()
		{
			Impuesto = PrecioBase * 0.20;
		}
	}


	public class Camion : Vehiculo
	{

		public double CapacidadCarga;


		public override void CalcularImpuesto()
		{
			Impuesto = PrecioBase * 0.30;
		}
	}


	public class Motor : Vehiculo
	{

		public double Potencia;


		public override void CalcularImpuesto()
		{
			Impuesto = PrecioBase * 0.15;
		}
	}

	public class Camioneta : Vehiculo
	{
		public int NumeroDeRuedas;

		public override void CalcularImpuesto()
		{
			Impuesto = PrecioBase * 0.25;
		}


		class Program
		{
			static void Main(string[] args)
			{

				Console.Clear();


				Vehiculo vehiculo = CapturarDatos();

				if( vehiculo != null )
				{
					vehiculo.CalcularImpuesto();
				}

				MostrarResultados(vehiculo);


				Console.ReadKey();
			}

			//metodo para capturar datos del vehiculo
			static Vehiculo CapturarDatos()
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
						{

							Carro carro = new Carro();
							carro.Marca = marca;
							carro.Modelo = modelo;
							carro.Anio = anio;
							carro.PrecioBase = precioBase;

							Console.Write("Número de Puertas: ");
							carro.NumeroDePuertas = int.Parse(Console.ReadLine());

							vehiculo = carro;
							
						}
						break;



					case 2:
						
						{
							Camion camion = new Camion();
							camion.Marca = marca;
							camion.Modelo = modelo;
							camion.Anio = anio;
							camion.PrecioBase = precioBase;

							Console.Write("Capacidad de Carga (kg): ");
							camion.CapacidadCarga = int.Parse(Console.ReadLine());
							
						}
						break;



					case 3:
						{
							Motor motor = new Motor();
							motor.Marca = marca;
							motor.Modelo = modelo;
							motor.Anio = anio;
							motor.PrecioBase = precioBase;

							Console.Write("Potencia del Motor (HP): ");
							motor.Potencia = double.Parse(Console.ReadLine());
						}
						break;

					case 4:
						{
							Camioneta camioneta = new Camioneta();
							camioneta.Marca = marca;
							camioneta.Modelo = modelo;
							camioneta.Anio = anio;
							camioneta.PrecioBase = precioBase;

							Console.Write("Numero de ruedas: ");
							camioneta.NumeroDeRuedas = int.Parse(Console.ReadLine());
						}
						break;

					case 5:
						break;

					default:
						Console.WriteLine("Opción no válida.");
						break;
				}


				

				return vehiculo;
			}

			

			static void MostrarResultados(Vehiculo vehiculo)
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
						Console.WriteLine("Numero de Puertas: " + carro.NumeroDePuertas);
					}


					if (vehiculo is Camion camion)
					{
						Console.WriteLine("Capacidad de Carga: " + camion.CapacidadCarga + " Kg");
					}


					if (vehiculo is Motor motor)
					{
						Console.WriteLine("Potencia del motor: " + motor.Potencia +  " HP");
					}
				}
				else
				{
					Console.WriteLine("No se capturaron datos válidos.");
				}
			}
		}
	}
}
