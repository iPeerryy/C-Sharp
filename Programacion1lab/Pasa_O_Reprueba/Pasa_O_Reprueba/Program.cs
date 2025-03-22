using System;

class AprobadoReprobado
{
	static void Main()
	{
		Console.WriteLine("Ingrese la nota del examen (0 - 100):");
		double nota = double.Parse(Console.ReadLine());

		if (nota >= 70)
		{
			Console.WriteLine("El estudiante APROBÓ.");
		}
		else
		{
			Console.WriteLine("El estudiante REPROBÓ.");
		}

		
		 Console.ReadKey();
	}
}