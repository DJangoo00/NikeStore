using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class CarritoProductoConfiguration : IEntityTypeConfiguration<CarritoProducto>
{
    public void Configure(EntityTypeBuilder<CarritoProducto> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("carritoproducto");

        builder.HasIndex(e => e.IdCarritoFk, "idCarritoFk");

        builder.HasIndex(e => e.IdProductoFk, "idProductoFk");

        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.Cantidad)
            .HasColumnName("cantidad");

        builder.Property(e => e.IdCarritoFk)
            .HasColumnName("idCarritoFk");

        builder.Property(e => e.IdProductoFk)
            .HasColumnName("idProductoFk");

        builder.HasOne(d => d.Carrito)
            .WithMany(p => p.CarritoProductos)
            .HasForeignKey(d => d.IdCarritoFk)
            .HasConstraintName("carritoproducto_ibfk_1");

        builder.HasOne(d => d.Producto)
            .WithMany(p => p.CarritoProductos)
            .HasForeignKey(d => d.IdProductoFk)
            .HasConstraintName("carritoproducto_ibfk_2");
    }
}