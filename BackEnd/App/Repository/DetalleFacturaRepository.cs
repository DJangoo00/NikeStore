using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class DetalleFacturaRepository : GenericRepository<DetalleFactura>, IDetalleFactura
{
    private readonly ApiContext _context;

    public DetalleFacturaRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<DetalleFactura>> GetAllAsync()
    {
        return await _context.DetalleFacturas
            .ToListAsync();
    }

    public override async Task<DetalleFactura> GetByIdAsync(int id)
    {
        return await _context.DetalleFacturas
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}