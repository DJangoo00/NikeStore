using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;

public class ApiContext : DbContext
{
    public ApiContext(DbContextOptions<ApiContext> options) : base(options)
    {}
    //main entities
    public virtual DbSet<Carrito> Carritos { get; set; }
    public virtual DbSet<CarritoProducto> CarritoProductos { get; set; }
    public virtual DbSet<Categoria> Categorias { get; set; }
    public virtual DbSet<Cliente> Clientes { get; set; }
    public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }
    public virtual DbSet<Factura> Facturas { get; set; }
    public virtual DbSet<Producto> Productos { get; set; }

    //jwt
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<RoleUser> RoleUsers { get; set; }
    public DbSet<User> Users { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}