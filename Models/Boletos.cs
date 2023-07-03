using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Boletos
{
    [Key]
    public long boletoId {get; set;}
    public double cantidadBoletos { get; set; }
    public long eventoId{get; set;}
    public long seccionId {get; set;}
    
    [ForeignKey("boletoId")]
    public List<BoletosDetalle> Detalle { get; set; } = new List<BoletosDetalle>();
    
}
