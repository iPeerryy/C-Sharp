using System;

class AhorrosFamilia
{
    static void Main()
    {
        Console.WriteLine("=== Seguimiento de Ahorros Anuales ===");

        double[] ahorrosMensuales = RegistrarAhorros();

        double totalAhorros = CalcularTotalAhorros(ahorrosMensuales);

        Console.WriteLine($" Total ahorrado al final del año: RD${totalAhorros}");
    }

   
    static double[] RegistrarAhorros()
    {
        double[] ahorros = new double[12];

        for (int mes = 0; mes < 12; mes++)
        {
            Console.Write($"Ingrese el ahorro del mes {mes + 1}: RD$");
            ahorros[mes] = Convert.ToDouble(Console.ReadLine());
        }

        return ahorros;
    }

    
    static double CalcularTotalAhorros(double[] ahorros)
    {
        double total = 0;

        foreach (double monto in ahorros)
        {
            total += monto;
        }

        return total;
    }
}
