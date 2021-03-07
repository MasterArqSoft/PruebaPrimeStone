using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeStone.Core.Enumerations;
using PrimeStone.Core.Models;
using System;

namespace PrimeStone.Infrastructure.Persistence.ModelsConfig
{
    public class DireccionModelConfig : IEntityTypeConfiguration<Direccion>
    {
        public void Configure(EntityTypeBuilder<Direccion> entityBuilder)
        {
            entityBuilder.ToTable("Direccion");

            #region Campos

            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id)
                         .HasColumnType("int")
                         .HasColumnName("Id")
                         .HasComment("Direction Identifier")
                         .IsRequired();

            entityBuilder.Property(x => x.StringDireccion)
                         .HasColumnName("Direccion")
                         .HasComment("Direction")
                         .HasColumnType("nvarchar(100)")
                         .HasMaxLength(100)
                         .HasConversion(_ => _.ToUpper(),
                                       dbValue => dbValue)
                         .IsRequired();

            entityBuilder.Property(x => x.TipoDireccion)
                         .HasColumnName("TipoDireccion")
                         .HasMaxLength(1)
                         .IsRequired()
                         .HasConversion<int>();

            entityBuilder.Property(x => x.EstudianteId)
                         .HasColumnType("int")
                         .HasColumnName("EstudianteId")
                         .HasComment("Student Identifier Foreign Key")
                         .IsRequired();

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

            entityBuilder.HasOne(x => x.Estudiante)
                         .WithMany(x => x.Direcciones)
                         .HasForeignKey(x => x.EstudianteId)
                         .HasConstraintName("Fk_Direction_Student")
                         .IsRequired();
        }
    }
}
