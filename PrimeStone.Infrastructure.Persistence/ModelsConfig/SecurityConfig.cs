using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeStone.Core.Enumerations;
using PrimeStone.Core.Models;
using System;

namespace PrimeStone.Infrastructure.Persistence.ModelsConfig
{
    public class SecurityConfig : IEntityTypeConfiguration<Security>
    {
        public void Configure(EntityTypeBuilder<Security> entityBuilder)
        {
            entityBuilder.ToTable("Seguridad");

            #region Campos

            entityBuilder.HasKey(e => e.Id);

            entityBuilder.Property(e => e.Id)
                         .HasColumnName("IdSeguridad");

            entityBuilder.Property(e => e.User)
                         .HasColumnName("Usuario")
                         .IsRequired()
                         .HasMaxLength(50)
                         .IsUnicode(false);

            entityBuilder.Property(e => e.UserName)
                         .HasColumnName("NombreUsuario")
                         .IsRequired()
                         .HasMaxLength(100)
                         .IsUnicode(false);

            entityBuilder.Property(e => e.UserName)
                        .HasColumnName("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

            entityBuilder.Property(e => e.Password)
                        .HasColumnName("Contrasena")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false);

            entityBuilder.Property(e => e.Role)
                           .HasColumnName("Rol")
                           .HasMaxLength(15)
                           .IsRequired()
                           .HasConversion(
                            x => x.ToString(),
                            x => (RoleType)Enum.Parse(typeof(RoleType), x)
                            );

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
