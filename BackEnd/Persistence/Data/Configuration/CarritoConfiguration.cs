using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class CarritoConfiguration : IEntityTypeConfiguration<Carrito>
{
    public void Configure(EntityTypeBuilder<Carrito> builder)
    {
        builder.HasKey(e => e.Id)
            .HasName("PRIMARY");

        builder.ToTable("carrito");

        builder.HasIndex(e => e.IdClienteFk, "idClienteFk");

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.IdClienteFk)
            .HasColumnName("idClienteFk");

        builder.Property(e => e.Vendido)
            .HasColumnName("vendido");

        builder.HasOne(d => d.Cliente).WithMany(p => p.Carritos)
            .HasForeignKey(d => d.IdClienteFk)
            .HasConstraintName("carrito_ibfk_1");
    }
}