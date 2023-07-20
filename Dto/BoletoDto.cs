namespace BoletosWeb.Models
{
    public class BoletoDto
    {
         public long boletoId { get; set; }
         public double cantidadBoletos {get; set;}
         public double precio { get; set; }
         public string? asiento { get; set; }
         public EventoDto? evento {get; set; }
    }
    
   
}