using PrimeStone.Core.Enumerations;
using PrimeStone.Core.Models;
using System;
using System.Collections.Generic;

namespace PrimeStone.Core.Dtos
{
    public class EstudianteDto
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimento { get; set; }
        public Genero Genero { get; set; }
        public IEnumerable<Direccion> Direcciones { get; set; }
        public IEnumerable<EstudianteCurso> EstudiantesCursos { get; set; }
    }
}
