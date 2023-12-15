namespace Domain.Entities;

public class RoleUser
{
    public int IdRolFk { get; set; }
    public Role Role { get; set; }
    public int IdUsuarioFk { get; set; }
    public User User { get; set; }
}