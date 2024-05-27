using explicacion.Controller.Auth;
using explicacion.Models;
using Microsoft.EntityFrameworkCore;

namespace explicacion.Data
{
    public class BaseContext: DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options){}
        public DbSet<Empleado> Empleados {get;set;}

        public static implicit operator BaseContext(AuthController v)
        {
            throw new NotImplementedException();
        }
    }
}