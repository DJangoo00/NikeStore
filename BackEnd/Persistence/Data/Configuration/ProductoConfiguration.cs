using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("producto");

        builder.HasIndex(e => e.IdCategoriaFk, "idCategoriaFk");

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.IdCategoriaFk)
            .HasColumnName("idCategoriaFk");

        builder.Property(e => e.Imagen)
            .IsRequired()
            .HasMaxLength(255)
            .HasColumnName("imagen");

        builder.Property(e => e.Precio)
            .HasPrecision(10, 2)
            .HasColumnName("precio");

        builder.Property(e => e.Stock)
            .HasColumnName("stock");

        builder.Property(e => e.Titulo)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("titulo");

        builder.HasOne(d => d.Categoria)
            .WithMany(p => p.Productos)
            .HasForeignKey(d => d.IdCategoriaFk)
            .HasConstraintName("producto_ibfk_1");
    }
}