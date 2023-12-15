namespace Domain.Entities;

public class User : BaseEntity
{
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public Cliente Cliente {get; set;}
    public ICollection<RoleUser> RoleUsers { get; set; } 
    public ICollection<Role> Roles { get; set; }  = new HashSet<Role>();
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();
}