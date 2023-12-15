namespace Domain.Entities;

public class Role : BaseEntity
{
    public string roleName { get; set; }
    public ICollection<RoleUser> RoleUsers { get; set; }
    public ICollection<User> Users { get; set; }  = new HashSet<User>();
}