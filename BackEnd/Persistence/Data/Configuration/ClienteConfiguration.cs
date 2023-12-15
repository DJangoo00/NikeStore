using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("cliente");

        builder.HasIndex(e => e.Dni, "dni")
            .IsUnique();

        builder.HasIndex(e => e.IdUserFk, "idUserFk")
            .IsUnique();

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.Dni)
            .IsRequired()
            .HasMaxLength(12)
            .HasColumnName("dni");

        builder.Property(e => e.IdUserFk)
            .HasColumnName("idUserFk");

        builder.Property(e => e.PrimerApellido)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnName("primerApellido");

        builder.Property(e => e.PrimerNombre)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnName("primerNombre");

        builder.Property(e => e.SegundoApellido)
            .HasMaxLength(50)
            .HasColumnName("segundoApellido");

        builder.Property(e => e.SegundoNombre)
            .HasMaxLength(50)
            .HasColumnName("segundoNombre");

        builder.Property(e => e.Telefono)
            .IsRequired()
            .HasMaxLength(10)
            .HasColumnName("telefono");

        builder.HasOne(d => d.User)
            .WithOne(p => p.Cliente)
            .HasForeignKey<Cliente>(d => d.IdUserFk)
            .HasConstraintName("cliente_ibfk_1");
    }
}