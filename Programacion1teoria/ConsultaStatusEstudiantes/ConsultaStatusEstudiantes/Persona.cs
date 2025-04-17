using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaStatusEstudiantes
{
    public class Persona
    {
        protected string matricula;
        protected string nombre;
        protected string apellido;


        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string NombreCompleto()
        {
            return (nombre + apellido);
        }
        public virtual string ObtenerInformacion()
        {
            return null;
        }
       
    }
}
