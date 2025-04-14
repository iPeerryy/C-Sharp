public class AritmeticaCL
{
   
    public float valor1;
    public float valor2;
    public float resultado;

    
    public void capturaValores()
    {
        Console.WriteLine("Ingrese el primer valor:");
        valor1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo valor:");
        valor2 = float.Parse(Console.ReadLine());
    }

    
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculadora Básica");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                SumaCL suma = new SumaCL();
                suma.capturaValores();
                suma.sumar();
                break;
            case 2:
                RestaCL resta = new RestaCL();
                resta.capturaValores();
                resta.restar();
                break;
            case 3:
                MultiplicaCL multiplica = new MultiplicaCL();
                multiplica.capturaValores();
                multiplica.multiplicar();
                break;
            case 4:
                DivideCL divide = new DivideCL();
                divide.capturaValores();
                divide.dividir();
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
}


public class SumaCL : AritmeticaCL
{
    public void sumar()
    {
        resultado = valor1 + valor2;
        Console.WriteLine("Resultado: " + resultado);
    }
}

public class RestaCL : AritmeticaCL
{
    public void restar()
    {
        resultado = valor1 - valor2;
        Console.WriteLine($"Resultado: {valor1} - {valor2} = {resultado}");
    }
}


public class MultiplicaCL : AritmeticaCL
{
    public void multiplicar()
    {
        resultado = valor1 * valor2;
        Console.WriteLine("Resultado: " + resultado );
    }
}


public class DivideCL : AritmeticaCL
{
    public void dividir()
    {
        if (valor2 != 0)
        {
            resultado = valor1 / valor2;
            Console.WriteLine("Resultado: " + resultado);
        }
       
    }
}