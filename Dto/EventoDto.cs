namespace BoletosWeb.Models
{

    public class EventoDto
    {
        public long eventoId { get; set; }
        public string? nombreEvento { get; set; }
        public string? tipoEvento{get; set;}    
        public string? descripcion { get; set; }    
        public string? fecha {get; set;}
        public string? hora { get; set; }
        public string? ubicacion { get; set; }
    }

   
}