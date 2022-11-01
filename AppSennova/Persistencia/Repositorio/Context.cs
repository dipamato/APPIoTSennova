using Microsoft.EntityFrameworkCore;
using AppSennova.Dominio;

namespace AppSennova.Persistencia
{
    public class Context: DbContext
    {
        public DbSet<Corriente> Corrientes {get;set;}
        public DbSet<Voltaje> Voltajes {get;set;}
        public DbSet<Usuario> Usuarios {get;set;}
        
         protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
           
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=Fotoceldas");
            }
        }
    }
}