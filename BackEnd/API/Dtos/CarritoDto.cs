using Domain.Entities;

namespace API.Dtos;
public class CarritoDto
{
    public int Id { get; set; }
    public int IdClienteFk { get; set; }
    public Cliente Cliente { get; set; }
    public bool Vendido { get; set; }
}