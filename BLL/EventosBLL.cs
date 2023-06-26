using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class EventosBLL

{
    private Contexto _contexto;
    public EventosBLL(Contexto contexto)

    {
        _contexto = contexto;

    }
    public bool Existe(int Id)

    {

        return _contexto.Eventos.Any(c => c.eventoId == Id);

    }

       public bool Guardar(Eventos eventos)

    {
        if (!Existe(eventos.eventoId))
         return Insertar(eventos);

        else
         return Modificar(eventos);
    }

    private bool Insertar(Eventos eventos)

    {

        _contexto.Eventos.Add(eventos);
        bool insertar = _contexto.SaveChanges() > 0;

        _contexto.Entry(eventos).State = EntityState.Detached;

        return insertar;

    }
     public bool Modificar(Eventos eventos)
        {
            _contexto.Database.ExecuteSqlRaw($"DELETE FROM EventosDetalle WHERE EventoId={eventos.eventoId};");

			foreach (var item in eventos.Detalle)
			{
                _contexto.Entry(item).State = EntityState.Added;
			}

            _contexto.Entry(eventos).State = EntityState.Modified;

            var guardo = _contexto.SaveChanges() > 0;
            _contexto.Entry(eventos).State = EntityState.Detached;
            return guardo;
        }
    public bool Eliminar(Eventos eventos)

    {

      _contexto.Eventos.Add(eventos);
        
        _contexto.Entry(eventos).State = EntityState.Deleted;
     
        bool elimino = _contexto.SaveChanges() > 0;

        _contexto.Entry(eventos).State = EntityState.Detached;
        return elimino;

    }
      public Eventos? Buscar(int eventos)

    {

        return _contexto.Eventos
        .Include(c => c.Detalle)
        .Where(c => c.eventoId == eventos)
        .AsNoTracking()
        .SingleOrDefault();

    }
    

    public List<Eventos> GetList(Expression<Func<Eventos, bool>> critero)
        {
            List<Eventos> lista = new List<Eventos>();

            try
            {
                lista = _contexto.Eventos
                    .Include(x => x.Detalle)
                    .Where(critero)
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
   
}