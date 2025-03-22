using System;

class MayorDeTres
{
	static void Main()
	{
		Console.WriteLine("Ingrese el primer número:");
		double num1 = double.Parse(Console.ReadLine());

		Console.WriteLine("Ingrese el segundo número:");
		double num2 = double.Parse(Console.ReadLine());

		Console.WriteLine("Ingrese el tercer número:");
		double num3 = double.Parse(Console.ReadLine());

		double mayor;

		if (num1 >= num2 && num1 >= num3)
		{
			mayor = num1;
		}
		else if (num2 >= num1 && num2 >= num3)
		{
			mayor = num2;
		}
		else
		{
			mayor = num3;
		}

		Console.WriteLine("El número mayor es: " + (mayor));

	  Console.ReadKey();
	}
}
