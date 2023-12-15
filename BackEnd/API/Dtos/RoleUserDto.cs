namespace API.Dtos;

public class RolUsuarioDto
{
    public int IdRoleFk { get; set; }
    public RoleDto Role { get; set; }
    public int IdUserFk { get; set; }
    public UserDto User { get; set; }
}