using System;

class AreaFiguras
{
	static void Main()
	{
		Console.WriteLine("Seleccione la figura para calcular el área:");
		Console.WriteLine("1 - Triángulo");
		Console.WriteLine("2 - Cuadrado");
		Console.WriteLine("3 - Círculo");
		string opcion = Console.ReadLine();

		switch (opcion)
		{
			case "1":
				Console.WriteLine("Ingrese la base del triángulo:");
				double baseT = double.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese la altura del triángulo:");
				double alturaT = double.Parse(Console.ReadLine());
				double areaT = (baseT * alturaT) / 2;
				Console.WriteLine($"El área del triángulo es: " +(areaT));
				break;

			case "2":
				Console.WriteLine("Ingrese el lado del cuadrado:");
				double lado = double.Parse(Console.ReadLine());
				double areaC = lado * lado;
				Console.WriteLine($"El área del cuadrado es:" + (areaC));
				break;

			case "3":
				Console.WriteLine("Ingrese el radio del círculo:");
				double radio = double.Parse(Console.ReadLine());
				double areaCirculo = Math.PI * (radio * radio);
				Console.WriteLine($"El área del círculo es: " + (areaCirculo));
				break;

			default:
				Console.WriteLine("Opción no válida.");
				break;
		}

		 Console.ReadKey();
	}
}