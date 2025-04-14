class AritmeticaCl
{
    public float valor1;
    public float valor2;
    public float resultado;
    public void capturaValores()
    {
        Console.Write("Ingrese el primer valor: ");
        valor1 = float.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo valor: ");
        valor2 = float.Parse(Console.ReadLine());
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

class SumaCL : AritmeticaCl
{
   
    public void sumar(float num1, float num2)
    {
        
        resultado = num1 + num2;
       
        Console.WriteLine("El Resultado de la suma: " + resultado);
    }
}
class RestaCL : SumaCL
{
    
    public void restar(float num1,  float num2)
    {
        resultado = num1 - num2;
        Console.WriteLine("El Resultado de la resta: " + resultado);
    }
}

class MultiplicaCL : RestaCL
{
   
    public void multiplicar(float num1, float num2)
    {
        resultado = num1 * num2;
        Console.WriteLine("El Resultado de la multiplicacion: " + resultado);
    }
}

class DivideCL : MultiplicaCL
{
    public void dividir(float num1, float num2)
    {
        resultado = num1 / num2;
        Console.WriteLine("El Resultado de la division: " + resultado);
    }
}
