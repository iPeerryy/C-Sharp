//Escribir un programa que muestre el eco de todo lo que el usuario introduzca hasta que el usuario escriba “salir” que terminará.

class Program
{
    static void Main()
    {
        string entrada;

        do
        {
            Console.Write("Ingrese algo (escriba 'salir' para terminar): ");
            entrada = Console.ReadLine();

            if (entrada.ToLower() != "salir")
            {
                Console.WriteLine("Echo: " + entrada);
            }

        } while (entrada.ToLower() != "salir");

        Console.WriteLine("Programa terminado.");
    }
}