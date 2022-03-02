using Microsoft.EntityFrameworkCore;


namespace RecrutamentoBackend.Database.Configs
{
    public class RecrutamentoDBContext : DbContext
    {
        public RecrutamentoDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}
