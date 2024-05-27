
using explicacion.Data;
using explicacion.Models;
using Microsoft.AspNetCore.Mvc;

namespace explicacion.Controller.Auth
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly BaseContext _context;
        public AuthController(BaseContext context)
        {
            _context = context;
        }
        [HttpPost("login")]
        public async Task<IActionResult> LoginAuth(string user, string password)
        {
            return Login()
        }
    }
}