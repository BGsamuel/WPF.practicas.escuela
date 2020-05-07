using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.practicas.escuela.Models
{
    class Escuela
    {
        public int idEscuela { get; set; }
        public string Nombre { get; set; }
        public Persona Director { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public List<Profesor>Profesores { get; set; }
    }
}
