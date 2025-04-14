using System;
using System.Collections.Generic;


/* En un mercado de frutas en la zona rural, cada vendedor vende diferentes tipos de frutas. Crea un programa que permita ingresar el nombre de la fruta, la cantidad vendida y el precio por libra. Luego, el programa debe calcular el total de dinero recibido por cada vendedor.*/

class MercadoFrutas
{
    
    class Fruta
    {
        public string Nombre;
        public double CantidadLibras;
        public double PrecioPorLibra;

        public double CalcularTotal()
        {
            return CantidadLibras * PrecioPorLibra;
        }
    }

    static void Main()
    {
        Console.WriteLine("=== Registro de Ventas de Frutas ===");

        
        string continuarVendedor;
        do
        {
            Console.Write("Nombre del vendedor: ");
            string nombreVendedor = Console.ReadLine();

            double totalVendedor = RegistrarVentasVendedor(nombreVendedor);

            Console.WriteLine($"=> Total vendido por {nombreVendedor}: ${totalVendedor:F2}\n");

            Console.Write("¿Deseas ingresar otro vendedor? (s/n): ");
            continuarVendedor = Console.ReadLine().ToLower();
            Console.WriteLine();

        } while (continuarVendedor == "s");
    }

    
    static double RegistrarVentasVendedor(string nombre)
    {
        List<Fruta> frutasVendidas = new List<Fruta>();
        string continuarFruta;

        do
        {
            Console.Write("Nombre de la fruta: ");
            string nombreFruta = Console.ReadLine();

            Console.Write("Cantidad vendida (en libras): ");
            double cantidad = Convert.ToDouble(Console.ReadLine());

            Console.Write("Precio por libra: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            frutasVendidas.Add(new Fruta
            {
                Nombre = nombreFruta,
                CantidadLibras = cantidad,
                PrecioPorLibra = precio
            });

            Console.Write("¿Deseas ingresar otra fruta? (s/n): ");
            continuarFruta = Console.ReadLine().ToLower();
            Console.WriteLine();

        } while (continuarFruta == "s");

        double total = 0;
        foreach (var fruta in frutasVendidas)
        {
            total += fruta.CalcularTotal();
        }

        return total;
    }
}
