using Microsoft.AspNetCore.Mvc;
using RecrutamentoBackend.Database.Configs;
using RecrutamentoBackend.Database.Entities;

namespace RecrutamentoWebAPI.Database
{
    
    public class EmailCheck
    {
        public static User Check(string email, RecrutamentoDBContext _dbContext)
        {
            var userEmail = _dbContext.UserList.FirstOrDefault(userDb => userDb.Email == email);
            if (userEmail != null)
                return userEmail;
            return null;


        }
    }
}
