class Operacion
{
    public double valor1;
    public double valor2;
    public double resultado;
    public void capturaValores()
    {
        Console.Write("Ingrese el primer valor: ");
        valor1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo valor: ");
        valor2 = double.Parse(Console.ReadLine());
    }
    public static void Main(string[] args)
    {
        SumaCL suma = new SumaCL();
        suma.capturaValores();
        suma.sumar(suma.valor1, suma.valor2);

        RestaCL resta = new RestaCL();
        resta.capturaValores();
        resta.restar(resta.valor1, resta.valor2);

        MultiplicaCL multiplica = new MultiplicaCL();
        multiplica.capturaValores();
        multiplica.multiplicar(multiplica.valor1, multiplica.valor2);


        DivideCL divide = new DivideCL();
        divide.capturaValores();
        divide.dividir(divide.valor1, divide.valor2);




    }
}

class SumaCL : Operacion 
{

    public void sumar(double num1, double num2)
    {

        resultado = num1 + num2;

        Console.WriteLine("El Resultado de la suma: " + resultado);
    }
}
class RestaCL : SumaCL
{

    public void restar(double num1, double num2)
    {
        resultado = num1 - num2;
        Console.WriteLine("El Resultado de la resta: " + resultado);
    }
}

class MultiplicaCL : RestaCL
{

    public void multiplicar(double num1, double num2)
    {
        resultado = num1 * num2;
        Console.WriteLine("El Resultado de la multiplicacion: " + resultado);
    }
}

class DivideCL : MultiplicaCL
{
    public void dividir(double num1, double num2)
    {
        resultado = num1 / num2;
        Console.WriteLine("El Resultado de la division: " + resultado);
    }
}
