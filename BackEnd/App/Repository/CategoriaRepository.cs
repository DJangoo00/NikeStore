using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class CategoriaRepository : GenericRepository<Categoria>, ICategoria
{
    private readonly ApiContext _context;

    public CategoriaRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Categoria>> GetAllAsync()
    {
        return await _context.Categorias
            .ToListAsync();
    }

    public override async Task<Categoria> GetByIdAsync(int id)
    {
        return await _context.Categorias
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}