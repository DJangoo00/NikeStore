using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("user");

        builder.HasKey(x => x.Id);

        builder.Property(p => p.Id)
            .IsRequired();

        builder.Property(p => p.Nombre)
            .HasColumnName("nombre")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(p => p.Email)
            .HasColumnName("correo")
            .HasColumnType("varchar")
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(p => p.Password)
            .HasColumnName("password")
            .HasColumnType("varchar")
            .HasMaxLength(255)
            .IsRequired();

        builder
            .HasMany(p => p.Roles)
            .WithMany(r => r.Users)
            .UsingEntity<RoleUser>(

                j => j
                .HasOne(pt => pt.Role)
                .WithMany(t => t.RoleUsers)
                .HasForeignKey(ut => ut.IdRolFk),

                j => j
                .HasOne(et => et.User)
                .WithMany(et => et.RoleUsers)
                .HasForeignKey(el => el.IdUsuarioFk),

                j =>
                {
                    j.ToTable("roleuser");
                    j.HasKey(t => new { t.IdUsuarioFk, t.IdRolFk });
                });

        builder
            .HasMany(p => p.RefreshTokens)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.IdUserFk);
    }
}
