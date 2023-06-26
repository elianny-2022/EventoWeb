using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class BoletosBLL

{
    private Contexto _contexto;
    public BoletosBLL(Contexto contexto)

    {
        _contexto = contexto;

    }
  
    public bool Existe(long Id)

    {

        return _contexto.Boletos.Any(c => c.boletoId == Id);

    }

       public bool Guardar(Boletos boletos)

    {
        if (!Existe(boletos.boletoId))
         return Insertar(boletos);

        else
         return Modificar(boletos);
    }

    private bool Insertar(Boletos boletos)

    {

        _contexto.Boletos.Add(boletos);
        bool insertar = _contexto.SaveChanges() > 0;

        _contexto.Entry(boletos).State = EntityState.Detached;

        return insertar;

    }
     public bool Modificar(Boletos boletos)
        {
            _contexto.Database.ExecuteSqlRaw($"DELETE FROM BoletosDetalle WHERE BoletoId={boletos.boletoId};");

			foreach (var item in boletos.Detalle)
			{
                _contexto.Entry(item).State = EntityState.Added;
			}

            _contexto.Entry(boletos).State = EntityState.Modified;

            var guardo = _contexto.SaveChanges() > 0;
            _contexto.Entry(boletos).State = EntityState.Detached;
            return guardo;
        }
    public bool Eliminar(Boletos boletos)

    {

      _contexto.Boletos.Add(boletos);
        
        _contexto.Entry(boletos).State = EntityState.Deleted;
     
        bool elimino = _contexto.SaveChanges() > 0;

        _contexto.Entry(boletos).State = EntityState.Detached;
        return elimino;

    }
      public Boletos? Buscar(long boletos)

    {

        return _contexto.Boletos
        .Include(c => c.Detalle)
        .Where(c => c.boletoId == boletos)
        .AsNoTracking()
        .SingleOrDefault();

    }


    public List<Boletos> GetList(Expression<Func<Boletos, bool>> critero)
        {
            List<Boletos> lista = new List<Boletos>();

            try
            {
                lista = _contexto.Boletos
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