using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Eventos
{
    [Key]
    public int eventoId { get; set; }
    public DateTime fecha { get; set; }
    public string? ubicacion { get; set; }
    public string? nombreEvento { get; set; }
    public long tipoEventoId { get; set; }
    [ForeignKey("EventoId")]
    public List<EventosDetalle> Detalle { get; set; } = new List<EventosDetalle>();
}