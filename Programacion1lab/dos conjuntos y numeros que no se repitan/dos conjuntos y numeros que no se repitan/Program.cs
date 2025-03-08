//Escribe un programa que tome dos listas de números enteros y encuentre los números únicos que están presentes en ambas listas, es decir, los números que no se repiten en ninguna de las dos listas.

class Program
{
	static void Main()
	{
		
		List<int> lista1 = new List<int> { 1, 2, 3, 4, 5, 2, 3 };
		List<int> lista2 = new List<int> { 4, 5, 6, 7, 8, 9, 10};

	
		List<int> unicosEnAmbas = new List<int>();

		
		foreach (int numero in lista1)
		{
			
			if (lista1.Count(x => x == numero) == 1 &&
				lista2.Contains(numero) &&
				lista2.Count(x => x == numero) == 1)
			{
				unicosEnAmbas.Add(numero);
			}
		}

		
		Console.WriteLine("Números únicos presentes en ambas listas:");
		foreach (int numero in unicosEnAmbas)
		{
			Console.WriteLine(numero);
		}
	}
}