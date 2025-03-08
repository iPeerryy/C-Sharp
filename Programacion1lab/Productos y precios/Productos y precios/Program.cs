//Crea un programa que solicite al usuario ingresar nombres de productos y sus precios, luego almacena esta información en un diccionario donde el nombre del producto es la clave y el precio es el valor. Después, permite al usuario buscar el precio de un producto ingresando su nombre.



class Program
{
	static void Main()
	{
		
		Dictionary<string, decimal> productos = new Dictionary<string, decimal>();

		
		Console.WriteLine("Ingrese los nombres de los productos y sus precios. Escriba 'fin' para terminar.");

		while (true)
		{
			Console.Write("Nombre del producto: ");
			string nombre = Console.ReadLine();

			
			if (nombre.ToLower() == "fin")
			{
				break;
			}

			Console.Write("Precio del producto: ");
			if (decimal.TryParse(Console.ReadLine(), out decimal precio))
			{
				
				productos[nombre] = precio;
			}
			else
			{
				Console.WriteLine("Precio no válido. Intente nuevamente.");
			}
		}

		
		Console.WriteLine("Buscar el precio de un producto. Escriba 'fin' para salir.");

		while (true)
		{
			Console.Write("Nombre del producto a buscar: ");
			string nombreBusqueda = Console.ReadLine();

			
			if (nombreBusqueda.ToLower() == "fin")
			{
				break;
			}

			
			if (productos.TryGetValue(nombreBusqueda, out decimal precioEncontrado))
			{
				Console.WriteLine($"El precio de {nombreBusqueda} es: {precioEncontrado:C}");
			}
			else
			{
				Console.WriteLine($"El producto '{nombreBusqueda}' no se encuentra en la lista.");
			}
		}

		Console.WriteLine("Programa terminado.");
	}
}