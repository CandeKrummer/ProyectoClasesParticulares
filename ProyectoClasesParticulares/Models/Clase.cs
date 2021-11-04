using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoClasesParticulares.Models
{
    public class Clase
    {
        //Poner los displays de los atributos
        //https://www.c-sharpcorner.com/blogs/validation-in-asp-net-mvc-using-dataannotations
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idClase { get; set; }
        public DateTime fechaYHora { get; set; }
        public string tema { get; set; }
        public int idMateria { get; set; }
        public Materia materia { get; set; }
        public int idAlumno { get; set; }
        public Alumno alumno { get; set; }

    }
}
