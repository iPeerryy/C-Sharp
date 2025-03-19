using calculadora2;
using System;
using System.Reflection;

OperacionesCalculadora calculadora = new OperacionesCalculadora();


<<<<<<< Updated upstream




while (true)
{
	Console.WriteLine("Con que operacion deseas hacer?");
	Console.WriteLine("1=> Suma");
	Console.WriteLine("2=> Resta");
	Console.WriteLine("3=> Multiplicacion");
	Console.WriteLine("4=> Division");
	Console.WriteLine("5=> Terminar el Programa");
	Console.Write("Opcion: ");
	int dato = int.Parse(Console.ReadLine());

	if (dato == 5)
	{
		break;
	}

	Console.Write("Ingrese el primer valor: ");
	double valor1 = double.Parse(Console.ReadLine());
	Console.Write("Ingrese el segundo valor: ");
	double valor2 = double.Parse(Console.ReadLine());


	double Resultado = 0;
	switch (dato)
	{
		case 1:
			Resultado = calculadora.OperacionSuma(valor1, valor2);
			Console.WriteLine("El resultado es: " + Resultado);
			break;

		case 2:
			Resultado = calculadora.OperacionResta(valor1, valor2);
			Console.WriteLine("El resultado es: " + Resultado);
			break;

		case 3:
			Resultado = calculadora.OperacionMultiplicacion(valor1, valor2);
			Console.WriteLine("El resultado es: " + Resultado);
			break;

		case 4:
			Resultado = calculadora.OperacionDivision(valor1, valor2);
			Console.WriteLine("El resultado es: " + Resultado);
			break;
		default:
			Console.WriteLine("Opcion no valida");
			break;

	}
=======
while (true) { 
	

	Console.WriteLine("Con que operacion deseas hacer?");
	Console.WriteLine("1=> Suma");
	Console.WriteLine("2=> Resta");
	Console.WriteLine("3=> Multiplicacion");
	Console.WriteLine("4=> Division");
	Console.WriteLine("5=> Terminar Programa");
    Console.Write("Opcion: ");
	int dato = int.Parse(Console.ReadLine());
>>>>>>> Stashed changes

	if (dato == 5) 
	{
		break;
	}

    Console.Write("Ingrese el primer valor: ");
    double valor1 = double.Parse(Console.ReadLine());
    Console.Write("Ingrese el segundo valor: ");
    double valor2 = double.Parse(Console.ReadLine());
    double Resultado = 0;
	switch (dato)
	{
		case 1:
			Resultado = calculadora.OperacionSuma(valor1, valor2);
			Console.WriteLine("El resultado es: " + Resultado);
			break;

		case 2:
			Resultado = calculadora.OperacionResta(valor1, valor2);
			Console.WriteLine("El resultado es: " + Resultado);
			break;

		case 3:
			Resultado = calculadora.OperacionMultiplicacion(valor1, valor2);
			Console.WriteLine("El resultado es: " + Resultado);
			break;

		case 4:
			Resultado = calculadora.OperacionDivision(valor1, valor2);
			Console.WriteLine("El resultado es: " + Resultado);
			break;

		default:
			Console.WriteLine("Opcion no valida");
			break;
	}
}
<<<<<<< Updated upstream
Console.WriteLine("Gracias por usar el programa.");

=======
Console.WriteLine("Gracias por usar la calculadora de Jose Daniel!!!");
>>>>>>> Stashed changes




