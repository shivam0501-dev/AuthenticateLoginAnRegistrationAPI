using AuthenticateLoginAnRegistration.Dtos;

namespace AuthenticateLoginAnRegistration
{
    public interface IAuthenticationService
    {
        Task<Status> Register(RegisterRequest request);
        Task<Status> Login(LoginRequest request);
    }
}
