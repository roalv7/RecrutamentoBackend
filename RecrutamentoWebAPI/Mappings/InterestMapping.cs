using RecrutamentoBackend.Database.Entities;

namespace RecrutamentoWebAPI.Mappings
{
    public class InterestMapping
    {
        public static Interest ToEntity(Models.Interest interestModel)
        {
            var interestEntity = new Interest
            {
                Description = interestModel.Description,
            };

            return interestEntity;
        }
    }
}
