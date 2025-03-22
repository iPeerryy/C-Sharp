using System;

class SaludoSegunHora
{
	static void Main()
	{
		Console.WriteLine("Ingrese la hora actual (0 - 23):");
		int hora = int.Parse(Console.ReadLine());

		if (hora < 0 || hora > 23)
		{
			Console.WriteLine("Hora no válida. Debe ser un número entre 0 y 23.");
		}
		else if (hora >= 6 && hora <= 11)
		{
			Console.WriteLine("Buenos días");
		}
		else if (hora >= 12 && hora <= 17)
		{
			Console.WriteLine("Buenas tardes");
		}
		else
		{
			
			Console.WriteLine("Buenas noches");
		}

		
		Console.ReadKey();
	}
}
