namespace Domain.Entities;

public partial class Factura : BaseEntity
{
    //public int Id { get; set; }
    public decimal PrecioTotal { get; set; }
    public int IdClienteFk { get; set; }
    public virtual Cliente Cliente { get; set; }
    public virtual ICollection<DetalleFactura> Detallefacturas { get; set; }
}
