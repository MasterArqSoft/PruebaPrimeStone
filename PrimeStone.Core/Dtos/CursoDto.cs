using PrimeStone.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeStone.Core.Dtos
{
    public class CursoDto
    {
        public string CodigoCurso { get; set; }
        public string NombreCurso { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public IEnumerable<EstudianteCurso> EstudiantesCursos { get; set; }
    }
}
