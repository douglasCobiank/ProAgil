using Microsoft.EntityFrameworkCore;
using NovoProjeto.API.Model;

namespace NovoProjeto.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}
        public DbSet<Evento> Eventos { get; set; }
    }
}