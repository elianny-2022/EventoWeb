namespace BoletosWeb.Models
{
public class ReservaDto
    {
        public long eventoId { get; set; }
        public double precio { get; set; }
        public double cantidadBoletos {get; set;}
        public string? fecha {get; set;}
    }
}