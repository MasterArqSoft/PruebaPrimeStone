using PrimeStone.Core.Enumerations;
using PrimeStone.Core.Models;

namespace PrimeStone.Core.Dtos
{
    public class DireccionDto
    {
        public string StringDireccion { get; set; }
        public TipoDireccion TipoDireccion { get; set; }
        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }
    }
}
