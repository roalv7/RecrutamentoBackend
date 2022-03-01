using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RecrutamentoWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public class User
        {
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Number { get; set; }
            public string Interests { get; set; }
            public User(string nome, string email, string number, string interests)
            {
                Nome = nome;
                Email = email;
                Number = number;
                Interests = interests;
            }
        }
        [HttpPost()]
        public IActionResult CreateUser(string name,string email, string number,string interests)
        {
            Console.WriteLine(name+email+number+interests);
            User user = new User(name, email, number, interests);

            return Ok(user);
        }
    }
}
