using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class CarritoProductoRepository : GenericRepository<CarritoProducto>, ICarritoProducto
{
    private readonly ApiContext _context;

    public CarritoProductoRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<CarritoProducto>> GetAllAsync()
    {
        return await _context.CarritoProductos
            .ToListAsync();
    }

    public override async Task<CarritoProducto> GetByIdAsync(int id)
    {
        return await _context.CarritoProductos
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}