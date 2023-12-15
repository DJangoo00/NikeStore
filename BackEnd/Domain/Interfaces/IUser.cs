using Domain.Entities;

namespace Domain.Interfaces;

public interface IUser : IGenericRepository<User>
{
    Task<User> GetByUsernameAsync(string nombre);
    Task<User> GetByRefreshTokenAsync(string nombre);
}