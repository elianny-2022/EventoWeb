using System.ComponentModel.DataAnnotations;

public class Usuarios
{
    [Key]
    public int UsuarioId { get; set; }
    public string? Nombre { get; set; }
    public string? Correo { get; set; }
    public string? Contraseña { get; set; }
    public string? Direccion { get; set; }
    public string? Historial {get; set;}
  
}