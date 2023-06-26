using System.ComponentModel.DataAnnotations;

public class EventosDetalle
{
    [Key]
    public int DetalleId { get; set; }
    public int BoletoId { get; set; }
    public int MesaId { get; set; }
    public int SeccionId { get; set; }
}