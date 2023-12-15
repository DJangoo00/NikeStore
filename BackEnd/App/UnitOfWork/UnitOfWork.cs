using Aplicacion.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistencia;

namespace Aplicacion.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApiContext _context;
    //main
    private CarritoRepository _carritos;
    private CarritoProductoRepository _carritoProductos;
    private CategoriaRepository _categorias;
    private ClienteRepository _clientes;
    private DetalleFacturaRepository _detalleFacturas;
    private FacturaRepository _facturas;
    private ProductoRepository _productos;
    //jwt
    private RoleRepository _roles;
    private UserRepository _users;

    public UnitOfWork(ApiContext context)
    {
        _context = context;
    }
    //main

    public ICarrito Carritos
    {
        get
        {
            if (_carritos == null)
            {
                _carritos = new CarritoRepository(_context);
            }
            return _carritos;
        }
    }
    public ICarritoProducto CarritoProductos
    {
        get
        {
            if (_carritoProductos == null)
            {
                _carritoProductos = new CarritoProductoRepository(_context);
            }
            return _carritoProductos;
        }
    }
    public ICategoria Categorias
    {
        get
        {
            if (_categorias == null)
            {
                _categorias = new CategoriaRepository(_context);
            }
            return _categorias;
        }
    }
    public ICliente Clientes
    {
        get
        {
            if (_clientes == null)
            {
                _clientes = new ClienteRepository(_context);
            }
            return _clientes;
        }
    }
    public IDetalleFactura DetalleFacturas
    {
        get
        {
            if (_detalleFacturas == null)
            {
                _detalleFacturas = new DetalleFacturaRepository(_context);
            }
            return _detalleFacturas;
        }
    }
    public IFactura Facturas
    {
        get
        {
            if (_facturas == null)
            {
                _facturas = new FacturaRepository(_context);
            }
            return _facturas;
        }
    }
    public IProducto Productos
    {
        get
        {
            if (_productos == null)
            {
                _productos = new ProductoRepository(_context);
            }
            return _productos;
        }
    }
    //jwt
    public IRole Roles
    {
        get
        {
            if (_roles == null)
            {
                _roles = new RoleRepository(_context);
            }
            return _roles;
        }
    }

    public IUser Users
    {
        get
        {
            if (_users == null)
            {
                _users = new UserRepository(_context);
            }
            return _users;
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }
    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}