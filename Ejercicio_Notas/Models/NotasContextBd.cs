  
using Microsoft.EntityFrameworkCore;

namespace Ejercicio_Notas.Models
{
    public class NotasContextBd : DbContext
    {
        public NotasContextBd(DbContextOptions<NotasContextBd> options)
            :base(options){

        }

        public DbSet<Nota> Nota { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}