using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeStone.Core.Enumerations;
using PrimeStone.Core.Models;
using System;

namespace PrimeStone.Infrastructure.Persistence.ModelsConfig
{
    public class EstudianteModelConfig : IEntityTypeConfiguration<Estudiante>
    {
        public void Configure(EntityTypeBuilder<Estudiante> entityBuilder)
        {
            entityBuilder.ToTable("Estudiante");

            #region Campos

            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id)
                         .HasColumnType("int")
                         .HasColumnName("Id")
                         .HasComment("Student Identifier")
                         .IsRequired();

            entityBuilder.Property(x => x.Nombres)
                         .HasColumnName("Nombres")
                         .HasComment("Names")
                         .HasColumnType("nvarchar(50)")
                         .HasMaxLength(50)
                         .HasConversion(_ => _.ToUpper(),
                                       dbValue => dbValue)
                         .IsRequired();

            entityBuilder.Property(x => x.Apellidos)
                         .HasColumnName("Apellidos")
                         .HasComment("Last names")
                         .HasColumnType("nvarchar(50)")
                         .HasMaxLength(50)
                         .HasConversion(_ => _.ToUpper(),
                                       dbValue => dbValue)
                         .IsRequired();

            entityBuilder.Property(x => x.FechaNacimento)
                         .HasColumnName("FechaNacimento")
                         .HasColumnType("datetime")
                         .HasComment("Date of Birth")
                         .HasDefaultValueSql("getdate()")
                         .ValueGeneratedOnAdd();

            entityBuilder.Property(x => x.Genero)
                         .HasColumnName("Genero")
                         .HasColumnType("int")
                         .HasMaxLength(1)
                         .IsRequired()
                         .HasConversion<int>();

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
