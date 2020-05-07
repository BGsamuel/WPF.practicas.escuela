using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.practicas.escuela.Models
{
    class Materia
    {
        public int IdMateria { get; set; }
        public string Nombre { get; set; }
        public Profesor Profesor { get; set; }
    }
}
