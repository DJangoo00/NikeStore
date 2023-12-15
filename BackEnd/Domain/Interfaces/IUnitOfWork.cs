namespace Domain.Interfaces;

public interface IUnitOfWork
{
    //main
    ICarrito Carritos { get; }
    ICarritoProducto CarritoProductos { get; }
    ICategoria Categorias { get; }
    ICliente Clientes { get; }
    IDetalleFactura DetalleFacturas { get; }
    IFactura Facturas { get; }
    IProducto Productos { get; }
    //jwt
    IRole Roles { get; }
    IUser Users { get; }
    Task<int> SaveAsync();
}