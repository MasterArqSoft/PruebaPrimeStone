namespace PrimeStone.Core.Models
{
    public class EstudianteCurso
    {
        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }

        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
