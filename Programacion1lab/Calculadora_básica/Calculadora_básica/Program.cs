using System;

class Calculadora
{
	static void Main()
	{
		Console.WriteLine("Ingrese el primer número:");
		double numero1 = double.Parse(Console.ReadLine());

		Console.WriteLine("Ingrese el segundo número:");
		double numero2 = double.Parse(Console.ReadLine());

		Console.WriteLine("Ingrese la operación a realizar (+, -, *, /):");
		string operacion = Console.ReadLine();

		double resultado = 0;
		bool operacionValida = true;

		switch (operacion)
		{
			case "+":
				resultado = numero1 + numero2;
				break;
			case "-":
				resultado = numero1 - numero2;
				break;
			case "*":
				resultado = numero1 * numero2;
				break;
			case "/":
				if (numero2 != 0)
				{
					resultado = numero1 / numero2;
				}
				else
				{
					Console.WriteLine("Error: División entre cero no permitida.");
					operacionValida = false;
				}
				break;
			default:
				Console.WriteLine("Operación no válida.");
				operacionValida = false;
				break;
		}

		if (operacionValida)
		{
			Console.WriteLine($"El resultado de " + (numero1) + " " + (operacion)+ " " + (numero2)+ " " + "es:" + (resultado));
		}

		
		Console.ReadKey();
	}
}
