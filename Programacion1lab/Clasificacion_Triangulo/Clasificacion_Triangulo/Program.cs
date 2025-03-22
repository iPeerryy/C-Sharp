using System;

class TipoDeTriangulo
{
	static void Main()
	{
		Console.WriteLine("Ingrese la longitud del lado 1:");
		double lado1 = double.Parse(Console.ReadLine());

		Console.WriteLine("Ingrese la longitud del lado 2:");
		double lado2 = double.Parse(Console.ReadLine());

		Console.WriteLine("Ingrese la longitud del lado 3:");
		double lado3 = double.Parse(Console.ReadLine());


		if (lado1 == lado2 && lado2 == lado3)
		{
			Console.WriteLine("El triángulo es equilátero.");
		}
		else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
		{
			Console.WriteLine("El triángulo es isósceles.");
		}
		else
		{
			Console.WriteLine("El triángulo es escaleno.");
		}

		
		 Console.ReadKey();
	}
}