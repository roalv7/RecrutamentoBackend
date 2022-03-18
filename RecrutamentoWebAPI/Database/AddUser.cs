using RecrutamentoBackend.Database.Configs;
using RecrutamentoBackend.Database.Entities;

namespace RecrutamentoWebAPI.Database
{
    public class AddUser
    {
        public static void Add(User userEntity, RecrutamentoDBContext _dbContext)
        {
            _dbContext.Add(userEntity);
            _dbContext.SaveChanges();
        }
    }
}
