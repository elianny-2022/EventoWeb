using System.ComponentModel.DataAnnotations;

public class BoletosDetalle
{
    [Key]
    public int DetalleId { get; set; }
    public int EventoId { get; set; }
    public int SeccionId { get; set; }
    
}