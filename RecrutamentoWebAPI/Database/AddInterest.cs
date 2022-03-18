using RecrutamentoBackend.Database.Configs;
using RecrutamentoBackend.Database.Entities;

namespace RecrutamentoWebAPI.Database
{
    public class AddInterest
    {
        public static void Add(Interest interestEntity, RecrutamentoDBContext _dbContext)
        {
            _dbContext.Add(interestEntity);
            _dbContext.SaveChanges();
        }
    }
}
