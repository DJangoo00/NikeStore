namespace Domain.Entities;

public partial class Carrito : BaseEntity
{
    //public int Id { get; set; }
    public int IdClienteFk { get; set; }
    public virtual Cliente Cliente { get; set; }
    public bool Vendido { get; set; }
    public virtual ICollection<CarritoProducto> CarritoProductos { get; set; }
}
