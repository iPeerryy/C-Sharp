//Escribir un programa que pregunte al usuario su edad y muestre por pantalla todos los años que ha cumplido (desde 1 hasta su edad).

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Has cumplido los siguientes años:");
        for (int i = 1; i <= edad; i++)
        {
            Console.WriteLine(i);
        }
    }
}