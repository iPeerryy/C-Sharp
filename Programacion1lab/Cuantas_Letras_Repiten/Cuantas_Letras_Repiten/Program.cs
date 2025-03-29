// Contar la frecuencia de apariciones de cada letra en una cadena
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una cadena: ");
        string input = Console.ReadLine();

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                int count = 0;
                foreach (char x in input)
                {
                    if (char.ToLower(x) == char.ToLower(c))
                        count++;
                }
                Console.WriteLine(c + " : " + count);
            }
        }
    }
}