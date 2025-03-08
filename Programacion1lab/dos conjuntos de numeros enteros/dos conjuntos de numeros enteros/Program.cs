//Escribe un programa que tome dos conjuntos de números enteros y encuentre la intersección de ambos conjuntos, es decir, los números que están presentes en ambos conjuntos.


HashSet<int> conjunto1 = new HashSet<int> { 1, 2, 3, 4, 5 };
HashSet<int> conjunto2 = new HashSet<int> { 4, 5, 6, 7, 8 };


HashSet<int> interseccion = new HashSet<int>(conjunto1);
interseccion.IntersectWith(conjunto2);


Console.WriteLine("Intersección de los conjuntos:");
foreach (int numero in interseccion)
{
	Console.WriteLine(numero);
}