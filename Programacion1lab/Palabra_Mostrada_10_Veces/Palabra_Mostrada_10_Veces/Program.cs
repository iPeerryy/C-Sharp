//Escribir un programa que pida al usuario una palabra y la muestre por pantalla 10 veces.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(palabra);
        }
    }
}