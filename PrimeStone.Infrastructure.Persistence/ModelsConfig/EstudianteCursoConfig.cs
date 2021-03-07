using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeStone.Core.Models;

namespace PrimeStone.Infrastructure.Persistence.ModelsConfig
{
    public class EstudianteCursoModelConfig : IEntityTypeConfiguration<EstudianteCurso>
    {
        public void Configure(EntityTypeBuilder<EstudianteCurso> entityBuilder)
        {
            entityBuilder.ToTable("EstudianteCurso");

            #region Campos

            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id)
                         .HasColumnType("int")
                         .HasColumnName("Id")
                         .HasComment("Student Identifier")
                         .IsRequired();

            entityBuilder.Property(x => x.EstudianteId)
                         .HasColumnType("int")
                         .HasColumnName("EstudianteId")
                         .HasComment("Student Identifier Foreign Key")
                         .IsRequired();

            entityBuilder.Property(x => x.CursoId)
                         .HasColumnType("int")
                         .HasColumnName("CursoId")
                         .HasComment("Course Identifier Foreign Key")
                         .IsRequired();

            #endregion Campos

            entityBuilder.HasOne(x => x.Estudiante)
                         .WithMany(x => x.EstudiantesCursos)
                         .HasForeignKey(x => x.EstudianteId)
                         .HasConstraintName("Fk_StudentCourse_Student")
                         .IsRequired();

            entityBuilder.HasOne(x => x.Curso)
                         .WithMany(x => x.EstudiantesCursos)
                         .HasForeignKey(x => x.CursoId)
                         .HasConstraintName("Fk_StudentCourse_Course")
                         .IsRequired();
        }
    }
}
