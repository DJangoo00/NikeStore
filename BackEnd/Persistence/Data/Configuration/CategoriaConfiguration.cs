using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("categoria");

        builder.Property(e => e.Id)
        .HasColumnName("id");
        
        builder.Property(e => e.Nombre)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnName("nombre");
    }
}