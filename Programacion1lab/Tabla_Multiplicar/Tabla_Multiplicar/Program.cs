//Escribir un programa que muestre por pantalla la tabla de multiplicar del 1 al 10.
class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Tabla del " + i + ": ");
            
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(i + " × " + j + " = " +  i * j);
            }
        }
    }
}