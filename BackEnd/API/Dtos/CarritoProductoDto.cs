using Domain.Entities;

namespace API.Dtos;
public class CarritoProductoDto
{
    public int Id { get; set; }
    public int IdCarritoFk { get; set; }
    public Carrito Carrito { get; set; }
    public int IdProductoFk { get; set; }
    public Producto Producto { get; set; }
    public int Cantidad { get; set; }
    
}