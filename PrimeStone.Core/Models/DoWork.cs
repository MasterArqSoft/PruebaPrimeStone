using System;

namespace PrimeStone.Core.Models
{
    public class DoWork
    {
        public int Id { get; set; }
        public bool EstaBorrado { get; set; }
        public string Evento { get; set; }
        public DateTime Fecha { get; set; }
    }
}
