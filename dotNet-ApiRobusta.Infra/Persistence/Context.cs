using dotNet_ApiRobusta.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotNet_ApiRobusta.Infra.Persistence
{
    public class Context : DbContext
    {
        public Context(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }



        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Plataforma> Plataformas { get; set; }
    }
}
