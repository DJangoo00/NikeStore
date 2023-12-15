namespace Domain.Entities;

public partial class CarritoProducto : BaseEntity
{
    //public int Id { get; set; }
    public int IdCarritoFk { get; set; }
    public virtual Carrito Carrito { get; set; }
    public int IdProductoFk { get; set; }
    public virtual Producto Producto { get; set; }
    public int Cantidad { get; set; }
    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
}
