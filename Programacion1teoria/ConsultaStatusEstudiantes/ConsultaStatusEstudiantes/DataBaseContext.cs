using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaStatusEstudiantes
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; } 
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>()
                .HasKey(e => e.Matricula);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Matricula)
                .HasMaxLength(20);

            modelBuilder.Entity<Estudiante>()
                .Property(e=> e.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Apellido)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.PrimerParcial)
                .HasColumnType("float");

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.SegundoParcial)
                .HasColumnType("float");

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.ExamenFinal)
                .HasColumnType("float");

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Practica1)
                .HasColumnType("float");

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Practica2)
                .HasColumnType("float");

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Practica3)
                .HasColumnType("float");
        }   


    }

}

