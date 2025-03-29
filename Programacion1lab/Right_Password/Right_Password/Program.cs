//Escribir un programa que almacene la cadena de caracteres contraseña en una variable, pregunte al usuario por la contraseña hasta que introduzca la contraseña correcta.

class Program
{
    static void Main()
    {
        string contraseña = "secreta"; 
        string intento;

        do
        {
            Console.Write("Ingrese la contraseña: ");
            intento = Console.ReadLine();
        } while (intento != contraseña);

        Console.WriteLine("Contraseña correcta!");
    }
}
