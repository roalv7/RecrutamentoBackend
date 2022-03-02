using Microsoft.AspNetCore.Mvc;
using RecrutamentoWebAPI.Models;
using System.Linq;

namespace RecrutamentoWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        
        [HttpPost()]
        public IActionResult CreateUser(Users users)
        {
            return Ok(users);
        }
    }
}
