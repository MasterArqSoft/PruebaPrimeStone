using PrimeStone.Core.Common;
using PrimeStone.Core.Enumerations;
using System;
using System.Collections.Generic;

namespace PrimeStone.Core.Models
{
    public class Estudiante : Entidad
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimento { get; set; }
        public Genero Genero { get; set; }
        public IEnumerable<Direccion> Direcciones { get; set; }
        public IEnumerable<EstudianteCurso> EstudiantesCursos { get; set; }
    }
}
