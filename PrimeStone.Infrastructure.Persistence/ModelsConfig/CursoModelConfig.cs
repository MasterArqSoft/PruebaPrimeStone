using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeStone.Core.Models;

namespace PrimeStone.Infrastructure.Persistence.ModelsConfig
{
    public class CursoModelConfig : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> entityBuilder)
        {
            entityBuilder.ToTable("Curso");

            #region Campos

            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id)
                         .HasColumnType("int")
                         .HasColumnName("Id")
                         .HasComment("Course Identifier")
                         .IsRequired();

            entityBuilder.Property(x => x.CodigoCurso)
                         .HasColumnName("CodigoCurso")
                         .HasComment("Course code")
                         .HasColumnType("nvarchar(50)")
                         .HasMaxLength(50)
                         .HasConversion(_ => _.ToUpper(),
                                       dbValue => dbValue)
                         .IsRequired();

            entityBuilder.HasIndex(x => x.NombreCurso).IsUnique();
            entityBuilder.Property(x => x.NombreCurso)
                         .HasColumnName("NombreCurso")
                         .HasComment("Course name")
                         .HasColumnType("nvarchar(50)")
                         .HasMaxLength(50)
                         .HasConversion(_ => _.ToUpper(),
                                       dbValue => dbValue)
                         .IsRequired();

            entityBuilder.Property(x => x.FechaInicio)
                         .HasColumnName("FechaInicio")
                         .HasColumnType("datetime")
                         .HasComment("Creation date")
                         .HasDefaultValueSql("getdate()")
                         .ValueGeneratedOnAdd();

            entityBuilder.Property(x => x.FechaFin)
                         .HasColumnName("FechaFin")
                         .HasColumnType("datetime")
                         .HasComment("Fin date");

            entityBuilder.Property(x => x.EstaBorrado)
                         .HasColumnName("EstaBorrado")
                         .HasColumnType("bit")
                         .HasComment("is deleted state  0:Active  1:deleted")
                         .HasMaxLength(1)
                         .HasDefaultValue(true)
                         .ValueGeneratedNever();

            entityBuilder.Property(x => x.FechaCreacion)
                         .HasColumnName("FechaCreacion")
                         .HasColumnType("datetime")
                         .HasComment("Creation date")
                         .HasDefaultValueSql("getdate()")
                         .ValueGeneratedOnAdd();

            entityBuilder.Property(x => x.FechaBorrado)
                         .HasColumnName("FechaBorrado")
                         .HasColumnType("datetime")
                         .HasComment("Deletion Date");

            entityBuilder.Property(x => x.FechaActualizacion)
                         .HasColumnName("FechaActualizacion")
                         .HasColumnType("datetime")
                         .HasComment("Update date")
                         .HasDefaultValueSql("getdate()")
                         .ValueGeneratedOnAdd();

            #endregion Campos

        }
    }
}
