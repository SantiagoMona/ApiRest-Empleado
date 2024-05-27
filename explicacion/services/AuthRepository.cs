using explicacion.Data;
using explicacion.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace explicacion.Services
{   
    public class AuthRepository : IAuthRepository
    {
        private readonly BaseContext _context;
        public AuthRepository(BaseContext context)
        {
            _context = context;
        }
        public Task Register(Empleado user)
        {
            _context.Empleados.Add(user);
            return Ok();
        }
    }
}