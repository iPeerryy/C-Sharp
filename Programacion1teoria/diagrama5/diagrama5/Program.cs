class AritmeticaCl
{
    public float valor1;
    public float valor2;
    public float resultado;


    public void capturarValores()
    {
        Console.WriteLine("Ingrese el primer valor: ");
        valor1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo valor: ");
        valor2 = float.Parse(Console.ReadLine());
    }

    public virtual void operacion()
    {

    }

    public static void Main(string[] args)
    {
        
       
    }
        
    

}

class SumaCL : AritmeticaCl
{

    public override void operacion()
    {

        resultado = valor1 + valor2;
    }
}
class RestaCL : AritmeticaCl
{

    public override void operacion()
    {
        resultado = valor1 - valor2;
        
    }
}

class MultiplicaCL : AritmeticaCl
{

    public override void operacion()
    {
        resultado = valor1 * valor2;
       
    }
}

class DivideCL : AritmeticaCl
{
    public override void operacion()
    {
        resultado = valor1 / valor2;
        
    }
}

