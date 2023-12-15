using Domain.Entities;

namespace API.Dtos;
public class ProductoDto
{
    public int Id { get; set; }
    public int IdCategoriaFk { get; set; }
    public Categoria Categoria { get; set; }
    public string Titulo { get; set; }
    public string Imagen { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
}