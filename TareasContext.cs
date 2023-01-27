using Microsoft.EntityFrameworkCore;
using projectef.Models;

namespace projectef;


public class TareasContext: DbContext{

    public DbSet<Categoria> categorias {get;set;}
    public DbSet<Tarea> tareas {get;set;}

    public TareasContext(DbContextOptions<TareasContext> options) : base (options) {}
}