using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Boletos
{
    [Key]
    public long boletoId {get; set;}
    public double cantidadBoletos { get; set; }
    public double precio{get; set;}
    public string? fecha {get; set;}
    
    [ForeignKey("boletoId")]
    public List<BoletosDetalle> Detalle { get; set; } = new List<BoletosDetalle>();
    
}
