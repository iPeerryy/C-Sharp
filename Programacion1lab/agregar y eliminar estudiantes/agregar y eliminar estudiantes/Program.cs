//Crea una clase llamada Curso que tenga una lista de estudiantes. Implementa métodos para agregar estudiantes al curso, eliminar estudiantes y mostrar todos los estudiantes inscritos.

class Curso
{
	
	private List<string> estudiantes = new List<string>();

	
	public void AgregarEstudiante(string nombre)
	{
		estudiantes.Add(nombre);
		Console.WriteLine($"Estudiante '{nombre}' agregado al curso.");
	}

	
	public void EliminarEstudiante(string nombre)
	{
		if (estudiantes.Remove(nombre))
		{
			Console.WriteLine($"Estudiante '{nombre}' eliminado del curso.");
		}
		else
		{
			Console.WriteLine($"Estudiante '{nombre}' no encontrado en el curso.");
		}
	}

	
	public void MostrarEstudiantes()
	{
		if (estudiantes.Count == 0)
		{
			Console.WriteLine("No hay estudiantes inscritos en el curso.");
		}
		else
		{
			Console.WriteLine("Estudiantes inscritos en el curso:");
			foreach (string estudiante in estudiantes)
			{
				Console.WriteLine(estudiante);
			}
		}
	}
}

class Program
{
	static void Main()
	{
		
		Curso curso = new Curso();

		
		curso.AgregarEstudiante("Juan");
		curso.AgregarEstudiante("Maria");
		curso.AgregarEstudiante("Pedro");

		
		curso.MostrarEstudiantes();

		
		curso.EliminarEstudiante("Maria");


		curso.MostrarEstudiantes();
	}
}