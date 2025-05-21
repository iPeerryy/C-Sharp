using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaStatusEstudiantes
{
    public class Estudiante : Persona
    {
        public string matricula { get; set; }
        public double PrimerParcial { get; set; }
        public double SegundoParcial { get; set; }
        public double ExamenFinal { get; set; }
        public double Practica1 { get; set; }
        public double Practica2 { get; set; }
        public double Practica3 { get; set; }
        public double PromedioPracticas { get; set; }
        public double PromedioExamenes { get; set; }
        public double PromedioTotal { get; set; }
        public bool estado { get; set; }

        public double CalificacionExamenes()
        {
            return (PrimerParcial + SegundoParcial + ExamenFinal) / 3;
        }
        public double CalificacionesPracticas()
        {
            return (Practica1 + Practica2 + Practica3) / 3;
        }

        public double PorcentajeExamenes()
        {
            double resultadoSumaExamenes = CalificacionExamenes();
            return resultadoSumaExamenes * 0.6;
        }
        public double PorcentajePracticas()
        {
            double resultadoSumaPracticas = CalificacionesPracticas();
            return resultadoSumaPracticas * 0.4;
        }
        public double CalificacionFinal()
        {
            double TotalPracticas = PorcentajePracticas();
            double TotalExamenes = PorcentajeExamenes();
            
            return  TotalPracticas + TotalExamenes;   
        }
        public string Estatus()
        {
            double final = CalificacionFinal();
            if (final >= 70)
            {
                return "Aprobado";
            }
            else return "Reprobado";
        }

        public bool ValidarCalificacion(double calificacion)
        {
            return calificacion >= 50 && calificacion <= 100;
        }

        public interface IAlmacenamiento<T>
        {
            void Guardar(T item);
            void Actualizar(T item);
            void Eliminar(string Matricula);
            T Obtener(string Matricula);
            List<T> ObtenerTodos();
        }
    }
}
