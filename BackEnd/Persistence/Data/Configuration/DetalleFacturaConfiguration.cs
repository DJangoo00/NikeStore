using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class DetalleFacturaConfiguration : IEntityTypeConfiguration<DetalleFactura>
{
    public void Configure(EntityTypeBuilder<DetalleFactura> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("detallefactura");

        builder.HasIndex(e => e.IdCarritoProductoFk, "idCarritoProductoFk");

        builder.HasIndex(e => e.IdFacturaFk, "idFacturaFk");

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.Cantidad)
            .HasColumnName("cantidad");

        builder.Property(e => e.IdCarritoProductoFk)
            .HasColumnName("idCarritoProductoFk");

        builder.Property(e => e.IdFacturaFk)
            .HasColumnName("idFacturaFk");
            
        builder.Property(e => e.PrecioUnitario)
            .HasPrecision(10, 2)
            .HasColumnName("precioUnitario");

        builder.HasOne(d => d.CarritoProducto)
            .WithMany(p => p.DetalleFacturas)
            .HasForeignKey(d => d.IdCarritoProductoFk)
            .HasConstraintName("detallefactura_ibfk_1");

        builder.HasOne(d => d.Factura)
            .WithMany(p => p.Detallefacturas)
            .HasForeignKey(d => d.IdFacturaFk)
            .HasConstraintName("detallefactura_ibfk_2");
    }
}