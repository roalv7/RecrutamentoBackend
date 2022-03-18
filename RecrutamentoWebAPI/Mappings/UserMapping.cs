using RecrutamentoBackend.Database.Entities;

namespace RecrutamentoWebAPI.Mappings
{
    public class UserMapping
    {
        public static User ToEntity(Models.User userModel)
        {
            var userEntity = new User
            {
                Name = userModel.Name,
                Email = userModel.Email,
                Number = userModel.Number,
                Interests = userModel.Interests,
                Message = userModel.Message
            };

            return userEntity;
        }
    }
}
