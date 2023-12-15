namespace Domain.Entities;

public partial class DetalleFactura : BaseEntity
{
    //public int Id { get; set; }
    public int IdCarritoProductoFk { get; set; }
    public virtual CarritoProducto CarritoProducto { get; set; }
    public int IdFacturaFk { get; set; }
    public virtual Factura Factura { get; set; }
    public decimal PrecioUnitario { get; set; }
    public int Cantidad { get; set; }
}
