using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsultaStatusEstudiantes.Estudiante;

namespace ConsultaStatusEstudiantes
{
    public class AlmacenamientoSQLServer : IAlmacenamiento<Estudiante>
    {
        private readonly DataBaseContext _context;

        public AlmacenamientoSQLServer(DataBaseContext context)
        {
            _context = context;
        }

        public void InicializarBaseDatos()
        {
            _context.Database.EnsureCreated();
        }
        public void Eliminar(string matricula)
        {
            var estudiante = Obtener(matricula);
            if (estudiante != null)
            {
                _context.Estudiantes.Remove(estudiante);
                _context.SaveChanges();
            }
        }

        public void Actualizar(Estudiante estudiante)
        {
            _context.Estudiantes.Update(estudiante);
            _context.SaveChanges();

        }

        public void Guardar(Estudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);
            _context.SaveChanges();
        }

        public Estudiante Obtener(string matricula)
        {
            return _context.Estudiantes.FirstOrDefault(e => e.Matricula == matricula);
        }

        public List<Estudiante> ObtenerTodos()
        {
            return _context.Estudiantes.ToList();
        }
    }
}
