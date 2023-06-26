using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Boletos> Boletos { get; set; } = null!;
    public DbSet<Eventos> Eventos { get; set; }=null!;
    public DbSet <Usuarios> Usuarios { get; set; }=null!;
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
    }
    
}