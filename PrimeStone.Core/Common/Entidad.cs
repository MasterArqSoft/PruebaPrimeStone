using System;

namespace PrimeStone.Core.Common
{
    public abstract class Entidad
    {
        public int Id { get; set; }
        public bool EstaBorrado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBorrado { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
