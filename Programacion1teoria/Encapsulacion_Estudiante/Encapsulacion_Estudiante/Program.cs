using System;

class Estudiante
{
    // Campos privados (encapsulacion)
    private string nombre;
    private string matricula;

    // Propiedades para acceder a los datos encapsulados
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Matricula
    {
        get { return matricula; }
        set { matricula = value; }
        
    }

    private double primerParcial, segundoParcial, examenFinal;

    
    public Estudiante()
    {
       
        primerParcial = 100;
        segundoParcial = 80;
        examenFinal = 75;
    }

    
    public double CalcularPromedio()
    {
        
        return (primerParcial + segundoParcial + examenFinal) / 3;
    }

    
    public void MostrarResultados()
    {

        double NotaFinal = CalcularPromedio();
        Console.WriteLine("----- Resultado del Estudiante -----");
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Matrícula: " + Matricula);
        if (NotaFinal >= 70)
        {
            Console.WriteLine("Promovido con: " + NotaFinal + " Puntos");
        }
        else Console.WriteLine("Reporbado con: " + NotaFinal + " Puntos"); 
    }
}

class Program
{
    static void Main()
    {
        // Capturar datos del estudiante
        Console.Write("Ingrese el nombre del estudiante: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese la matrícula del estudiante: ");
        string matricula = Console.ReadLine();

        
        
        Estudiante estudiante = new Estudiante();
        estudiante.Nombre = nombre;
        estudiante.Matricula = matricula;
        Console.Clear();
        
        

        
        estudiante.MostrarResultados();
    }
}
