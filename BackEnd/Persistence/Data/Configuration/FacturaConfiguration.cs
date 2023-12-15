using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class FacturaConfiguration : IEntityTypeConfiguration<Factura>
{
    public void Configure(EntityTypeBuilder<Factura> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("factura");

        builder.HasIndex(e => e.IdClienteFk, "idClienteFk");

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.IdClienteFk)
            .HasColumnName("idClienteFk");
            
        builder.Property(e => e.PrecioTotal)
            .HasPrecision(10, 2)
            .HasColumnName("precioTotal");

        builder.HasOne(d => d.Cliente).WithMany(p => p.Facturas)
            .HasForeignKey(d => d.IdClienteFk)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("factura_ibfk_1");
    }
}