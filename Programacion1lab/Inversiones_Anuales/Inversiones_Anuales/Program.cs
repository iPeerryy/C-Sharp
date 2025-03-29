//Escribir un programa que pregunte al usuario una cantidad a invertir, el interés anual y el número de años, y muestre por pantalla el capital obtenido en la inversión cada año que dura la inversión.
class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad a invertir: ");
        double capital = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el interés anual (en porcentaje): ");
        double interes = double.Parse(Console.ReadLine()) / 100;

        Console.Write("Ingrese el número de años: ");
        int años = int.Parse(Console.ReadLine());

        Console.WriteLine("Año : Capital");
        for (int i = 1; i <= años; i++)
        {
            capital += capital * interes; 
            Console.WriteLine(i + " : " + capital);
        }
    }
}