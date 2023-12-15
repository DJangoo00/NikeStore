namespace Domain.Entities;

public partial class Cliente : BaseEntity
{
    //public int Id { get; set; }
    public string Dni { get; set; }
    public string PrimerNombre { get; set; }
    public string SegundoNombre { get; set; }
    public string PrimerApellido { get; set; }
    public string SegundoApellido { get; set; }
    public string Telefono { get; set; }
    public int IdUserFk { get; set; }
    public virtual User User { get; set; }
    public virtual ICollection<Carrito> Carritos { get; set; }
    public virtual ICollection<Factura> Facturas { get; set; }
}
