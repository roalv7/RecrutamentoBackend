using RecrutamentoBackend.Database.Configs;
using RecrutamentoBackend.Database.Entities;

namespace RecrutamentoWebAPI.Database
{
    public class InterestCheck
    {
        public static Interest Check(string description, RecrutamentoDBContext _dbContext)
        {
            var InterestDescription = _dbContext.InterestList.FirstOrDefault(interestDB => interestDB.Description == description);
            if (InterestDescription != null)
                return InterestDescription;
            return null;


        }
    }
}
