using Domain.Entities;

namespace API.Dtos;
public class ClienteDto
{
    public int Id { get; set; }
    public string Dni { get; set; }
    public string PrimerNombre { get; set; }
    public string SegundoNombre { get; set; }
    public string PrimerApellido { get; set; }
    public string SegundoApellido { get; set; }
    public string Telefono { get; set; }
    public int IdUserFk { get; set; }
    public User User { get; set; }
}