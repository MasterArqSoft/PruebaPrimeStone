using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeStone.Core.Models;

namespace PrimeStone.Infrastructure.Persistence.ModelsConfig
{
    public class DoWrokModelConfig : IEntityTypeConfiguration<DoWork>
    {
        public void Configure(EntityTypeBuilder<DoWork> entityBuilder)
        {
            entityBuilder.ToTable("DoWork");

            #region Campos

            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id)
                         .HasColumnType("int")
                         .HasColumnName("Id")
                         .HasComment("DoWork Identifier")
                         .IsRequired();

            entityBuilder.Property(x => x.EstaBorrado)
                         .HasColumnName("EstaBorrado")
                         .HasColumnType("bit")
                         .HasComment("is deleted state  0:Active  1:deleted")
                         .HasMaxLength(1)
                         .HasDefaultValue(true)
                         .ValueGeneratedNever();

            entityBuilder.Property(x => x.Evento)
                         .HasColumnName("Evento")
                         .HasComment("Event name")
                         .HasColumnType("nvarchar(200)")
                         .HasMaxLength(200)
                         .HasConversion(_ => _.ToUpper(),
                                       dbValue => dbValue)
                         .IsRequired();

            entityBuilder.Property(x => x.Fecha)
                         .HasColumnName("FechaCreacion")
                         .HasColumnType("datetime")
                         .HasComment("Creation date")
                         .HasDefaultValueSql("getdate()")
                         .ValueGeneratedOnAdd();

            #endregion Campos
        }
    }
}
