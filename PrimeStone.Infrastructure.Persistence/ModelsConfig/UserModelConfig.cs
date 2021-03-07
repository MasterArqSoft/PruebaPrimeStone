using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeStone.Core.Models;

namespace PrimeStone.Infrastructure.Persistence.ModelsConfig
{
    public class UserModelConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.ToTable("Usuario");

            entityBuilder.HasKey(e => e.Id);

            entityBuilder.Property(e => e.Id)
                .HasColumnName("IdUsuario");

            entityBuilder.Property(e => e.FirstName)
                .HasColumnName("Nombres")
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entityBuilder.Property(e => e.LastName)
                .HasColumnName("Apellidos")
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entityBuilder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            entityBuilder.Property(e => e.DateOfBirth)
                .HasColumnName("FechaNacimiento")
                .HasColumnType("date");

            entityBuilder.Property(e => e.Telephone)
                .HasColumnName("Telefono")
                .HasMaxLength(10)
                .IsUnicode(false);

            entityBuilder.Property(e => e.IsActive)
                .HasColumnName("Activo");

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
        }
    }
}
