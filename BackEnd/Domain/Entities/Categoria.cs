namespace Domain.Entities;

public partial class Categoria : BaseEntity
{
    //public int Id { get; set; }
    public string Nombre { get; set; }
    public virtual ICollection<Producto> Productos { get; set; }
}
