using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class CarritoRepository : GenericRepository<Carrito>, ICarrito
{
    private readonly ApiContext _context;

    public CarritoRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Carrito>> GetAllAsync()
    {
        return await _context.Carritos
            .ToListAsync();
    }

    public override async Task<Carrito> GetByIdAsync(int id)
    {
        return await _context.Carritos
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}