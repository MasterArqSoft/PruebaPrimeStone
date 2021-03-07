using PrimeStone.Core.Common;
using PrimeStone.Core.Enumerations;

namespace PrimeStone.Core.Models
{
    public class Direccion : Entidad
    {
        public string StringDireccion { get; set; }
        public TipoDireccion TipoDireccion { get; set; }
        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }
    }
}
