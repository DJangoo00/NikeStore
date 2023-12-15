using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class RoleRepository : GenericRepository<Role>, IRole
{
    private readonly ApiContext _context;

    public RoleRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Role>> GetAllAsync()
    {
        return await _context.Roles
            .ToListAsync();
    }

    public override async Task<Role> GetByIdAsync(int id)
    {
        return await _context.Roles
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}