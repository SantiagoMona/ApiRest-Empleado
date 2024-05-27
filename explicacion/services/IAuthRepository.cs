
using explicacion.Models;

namespace explicacion.Services
{
    public interface IAuthRepository
    {
        Task Login(Empleado user, string password);
        Task Register(Empleado user);
    }
}