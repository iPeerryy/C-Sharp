using System;
using System.Collections.Generic;
/*Supón que un hogar tiene diferentes electrodomésticos y sistemas de riego. Crea un programa que calcule cuántos litros de agua se utilizan en un hogar a lo largo de un mes, dado que el usuario ingresará los litros utilizados por cada electrodoméstico (como lavadora, ducha, etc.) y las horas de riego por día.*/
class ProgramaAgua
{
    

    static void Main()
    {
        Console.WriteLine("=== Cálculo de Consumo de Agua Mensual ===");

       
        double consumoElectrodomesticos = ObtenerConsumoElectrodomesticos();

       
        double consumoRiego = CalcularConsumoRiego();

        
        double consumoTotal = consumoElectrodomesticos + consumoRiego;

        Console.WriteLine($" Consumo total mensual de agua: {consumoTotal} litros.");
    }

  
    static double ObtenerConsumoElectrodomesticos()
    {
        double total = 0;
        string continuar;

        do
        {
            Console.Write("Nombre del electrodoméstico: ");
            string nombre = Console.ReadLine();

            Console.Write($"Litros usados por '{nombre}' en el mes: ");
            double litros = Convert.ToDouble(Console.ReadLine());

            total += litros;

            Console.Write("¿Deseas ingresar otro electrodoméstico? (s/n): ");
            continuar = Console.ReadLine().ToLower();

        } while (continuar == "s");

        return total;
    }

    static double CalcularConsumoRiego()
    {
        Console.Write("Horas de riego por día: ");
        double horasPorDia = Convert.ToDouble(Console.ReadLine());

        double consumoMensual = horasPorDia * 30; 

        Console.WriteLine($"Consumo mensual por riego: {consumoMensual} litros");

        return consumoMensual;
    }
}
