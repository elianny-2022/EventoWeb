namespace BoletosWeb.Models
{

    public class EventoDto
    {
        public long eventoId { get; set; }
        public string? nombreEvento { get; set; }
        public string? tipoEvento { get; set; }
        public DateTime fecha {get; set;}
        public string? ubicacion { get; set; }
        public double disponibilidad {get; set;}
        
    }

   
}