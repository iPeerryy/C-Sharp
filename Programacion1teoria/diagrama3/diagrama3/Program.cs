class AritmeticaCl
{
    public float valor1 = 30.5f;
    public float valor2 = 10.8f;
    public float resultado = 0.0f;
   
    public static void Main(string[] args)
    {
        
        SumaCL suma = new SumaCL();
        suma.sumar();

        RestaCL resta = new RestaCL();
        resta.restar();

        MultiplicaCL multiplica = new MultiplicaCL();
        multiplica.multiplicar();

        DivideCL divide = new DivideCL();
        divide.dividir();



    }
}

class SumaCL : AritmeticaCl
{

    public void sumar()
    {

        resultado = valor1 + valor2;

        Console.WriteLine("El Resultado de la suma: " + resultado);
    }
}
class RestaCL : AritmeticaCl
{

    public void restar()
    {
        resultado = valor1 - valor2;
        Console.WriteLine("El Resultado de la resta: " + resultado);
    }
}

class MultiplicaCL : AritmeticaCl
{

    public void multiplicar()
    {
        resultado = valor1 * valor2;
        Console.WriteLine("El Resultado de la multiplicacion: " + resultado);
    }
}

class DivideCL : AritmeticaCl
{
    public void dividir()
    {
        resultado = valor1 / valor2;
        Console.WriteLine("El Resultado de la division: " + resultado);
    }
}

