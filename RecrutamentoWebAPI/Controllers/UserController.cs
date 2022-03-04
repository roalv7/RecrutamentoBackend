using Microsoft.AspNetCore.Mvc;
using RecrutamentoBackend.Database.Configs;
using RecrutamentoWebAPI.Models;
using System.Linq;

namespace RecrutamentoWebAPI.Controllers
{
   
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly RecrutamentoDBContext _dbContext;
        public UserController(RecrutamentoDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        [HttpGet("specific/{id}")]
        public IActionResult GetUserData(int id)
        {
            var user = _dbContext.UserList.FirstOrDefault(user => user.Id == id);
            if(user == null)
                return NotFound($"Não existe um utilizador com o id: {id}");
            return Ok(user);
        }
        [HttpGet]
        public IActionResult GetUserData()
        {
            var users = _dbContext.UserList.ToList();
            return Ok(users);
        }
        [HttpPost()]
        public IActionResult CreateUser(User user)
        {
            var userEntity = new RecrutamentoBackend.Database.Entities.User
            {
                Name = user.Name,
                Email = user.Email,
                Number = user.Number,
                Interests = user.Interests,
                Message = user.Message
            };

            _dbContext.Add(userEntity);
            _dbContext.SaveChanges();
            return Ok(user);
        }
    }
}
