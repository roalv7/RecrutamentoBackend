using Microsoft.EntityFrameworkCore;
using RecrutamentoBackend.Database.Entities;

namespace RecrutamentoBackend.Database.Configs
{
    public class RecrutamentoDBContext : DbContext
    {
        public DbSet<User> UserList { get; set; }
        public DbSet<Interest> InterestList { get; set; }

        public RecrutamentoDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}
