using System;

class CelsiusAFahrenheit
{
	static void Main()
	{
		Console.Write("Ingrese la temperatura en grados Celsius: ");
		double celsius = double.Parse(Console.ReadLine());

		
		double fahrenheit = (celsius * 9 / 5) + 32;

		Console.WriteLine((celsius) + "°C equivalen a "+ (fahrenheit)+"°F");

		
		Console.ReadKey();
	}
}
