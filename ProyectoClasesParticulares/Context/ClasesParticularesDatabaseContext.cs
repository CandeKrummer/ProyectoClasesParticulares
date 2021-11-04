using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoClasesParticulares.Models;


namespace ProyectoClasesParticulares.Context
{
    public class ClasesParticularesDatabaseContext : DbContext
    {
        public ClasesParticularesDatabaseContext(DbContextOptions<ClasesParticularesDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Docente> Docente { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Clase> Clases { get; set; }
    }
}
