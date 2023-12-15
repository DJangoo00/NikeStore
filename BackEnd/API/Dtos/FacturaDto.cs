using Domain.Entities;

namespace API.Dtos;
public class FacturaDto
{
    public int Id { get; set; }
    public decimal PrecioTotal { get; set; }
    public int IdClienteFk { get; set; }
    public Cliente Cliente { get; set; }
}