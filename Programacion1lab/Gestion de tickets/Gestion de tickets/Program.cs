//Implementa un sistema simple de gestión de tickets de soporte. Los usuarios pueden agregar tickets a una cola y el sistema debe mostrar el ticket más antiguo cuando un agente de soporte está disponible para manejarlo.


class Program
{
	static void Main(string[] args)
	{
		Queue<string> ticketQueue = new Queue<string>();
		

		while (true)
		{
			Console.WriteLine("1. Agregar ticket");
			Console.WriteLine("2. Atender ticket");
			Console.WriteLine("3. Salir");
			Console.Write("Seleccione una opción: ");
			int option = int.Parse(Console.ReadLine());


			if (option == 3)
			{
				break;
			}
			switch (option)
			{
			
				case 1:
					Console.Write("Ingrese la descripción del ticket: ");
					string ticketDescription = Console.ReadLine();
					ticketQueue.Enqueue(ticketDescription);
					Console.WriteLine("Ticket agregado a la cola.");
					break;

				case 2:
					if (ticketQueue.Count > 0)
					{
						string nextTicket = ticketQueue.Dequeue();
						Console.WriteLine("Ticket atendido: " + nextTicket);
					}
					else
					{
						Console.WriteLine("No hay tickets en la cola.");
					}
					break;

			
				default:
					Console.WriteLine("Opción no válida. Intente de nuevo.");
					break;
			}

			Console.WriteLine();
		}
	}
}