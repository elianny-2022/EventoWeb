using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Eventos
{
    [Key]
    public int eventoId { get; set; }
    public DateTime fecha { get; set; }
    public string? lugarEvento { get; set; }
    public string? nombreEvento { get; set; }
    public string? tipoEvento { get; set; }
    public double asientoDisponible { get; set; }
    [ForeignKey("EventoId")]
    public List<EventosDetalle> Detalle { get; set; } = new List<EventosDetalle>();
}