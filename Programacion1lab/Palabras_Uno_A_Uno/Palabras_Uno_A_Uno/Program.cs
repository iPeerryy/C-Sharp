//Escribir un programa que pida al usuario una palabra y luego muestre por pantalla una a una las letras de la palabra introducida empezando por la última.
class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        Console.WriteLine("Letras de la palabra desde la última:");
        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(palabra[i]);
        }
    }
}
