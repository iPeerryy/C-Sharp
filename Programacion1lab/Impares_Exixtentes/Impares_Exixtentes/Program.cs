//Escribir un programa que pida al usuario un número entero positivo y muestre por pantalla todos los números impares desde 1 hasta ese número separados por comas.

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero positivo: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Números impares: ");
        for (int i = 1; i <= numero; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(" ");
                Console.Write(i);
                
            }
        }

        Console.WriteLine(); 
    }
}