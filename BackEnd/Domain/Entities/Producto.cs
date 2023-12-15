namespace Domain.Entities;

public partial class Producto : BaseEntity
{
    //public int Id { get; set; }
    public int IdCategoriaFk { get; set; }
    public virtual Categoria Categoria { get; set; }
    public string Titulo { get; set; }
    public string Imagen { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public virtual ICollection<CarritoProducto> CarritoProductos { get; set; }
}
