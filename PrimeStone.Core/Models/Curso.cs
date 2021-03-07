using PrimeStone.Core.Common;
using System;
using System.Collections.Generic;

namespace PrimeStone.Core.Models
{
    public class Curso : Entidad
    {
        public string CodigoCurso { get; set; }
        public string NombreCurso { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public IEnumerable<EstudianteCurso> EstudiantesCursos { get; set; }
    }
}
