using PrimeStone.Core.Enumerations;
using System;

namespace PrimeStone.Core.Dtos
{
    public class EstudianteDto
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimento { get; set; }
        public Genero Genero { get; set; }
    }
}
