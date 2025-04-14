class AritmeticaCl
{
    public float valor1;
    public float valor2;
    public float resultado;

    public static void Main(string[] args)
    {
        SumaCL suma = new SumaCL();
        suma.capturaValoresSuma();
        suma.sumar();


        DivideCL divide = new DivideCL();  
        divide.capturaValoresDivide();
        divide.dividir();

        RestaCL resta = new RestaCL();
        resta.capturaValoresResta();
        resta.restar();


        MultiplicaCL multiplica = new MultiplicaCL();
        multiplica.capturaValoresMultiplica();
        multiplica.multiplicar();

    }
}

class SumaCL : AritmeticaCl
{
    public void capturaValoresSuma()
    {
        Console.WriteLine("Ingrese el primer valor para sumar: ");
        valor1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo valor para sumar: ");
        valor2 = float.Parse(Console.ReadLine());
    }
    public void sumar()
    {
        resultado = valor1 + valor2;
        Console.WriteLine("El Resultado de la suma: " + resultado);
    }
}
class RestaCL : SumaCL
{
    public void capturaValoresResta()
    {
        Console.WriteLine("Ingrese el primer valor para restar: ");
        valor1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo valor para restar: ");
        valor2 = float.Parse(Console.ReadLine());
    }
    public void restar()
    {
        resultado = valor1 - valor2;
        Console.WriteLine("El Resultado de la resta: " + resultado);
    }
}

class MultiplicaCL : RestaCL
{
    public void capturaValoresMultiplica()
    {
        Console.WriteLine("Ingrese el primer valor para multiplicar: ");
        valor1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo valor para multiplicar: ");
        valor2 = float.Parse(Console.ReadLine());
    }
    public void multiplicar()
    {
        resultado = valor1 * valor2;
        Console.WriteLine("El Resultado de la multiplicacion: " + resultado);
    }
}

class DivideCL : MultiplicaCL
{
    public void capturaValoresDivide()
    {
        Console.WriteLine("Ingrese el primer valor para dividir: ");
        valor1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo valor para dividir: ");
        valor2 = float.Parse(Console.ReadLine());
    }
    public void dividir()
    {
        resultado = valor1 / valor2;
        Console.WriteLine("El Resultado de la division: " + resultado);
    }
}
