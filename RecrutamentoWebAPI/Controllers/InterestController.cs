using Microsoft.AspNetCore.Mvc;
using RecrutamentoBackend.Database.Configs;
using RecrutamentoWebAPI.Database;
using RecrutamentoWebAPI.Mappings;
using RecrutamentoWebAPI.Models;

namespace RecrutamentoWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InterestController: ControllerBase 
    {
        private readonly RecrutamentoDBContext _dbContext;
        public InterestController(RecrutamentoDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        [HttpGet]
        public IActionResult GetInterestData()
        {
            var interests = _dbContext.InterestList.ToList();
            return Ok(interests);
        }
        [HttpPost()]
        public IActionResult CreateInterest(Interest interest)
        {
            var intDescription = InterestCheck.Check(interest.Description, _dbContext);
            if (intDescription != null)
                return BadRequest("Interesse já registado, Insira outro.");

            var intEntity = InterestMapping.ToEntity(interest);

            AddInterest.Add(intEntity, _dbContext);

            return Ok(interest);

        }

    }
}
