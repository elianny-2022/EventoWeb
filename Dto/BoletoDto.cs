namespace BoletosWeb.Models
{
    public class BoletoDto
    {
        public long boletoId { get; set; }
        public double precio { get; set; }
        public double cantidadBoletos {get; set;}
        public string? fecha {get; set;}
    }

   
}