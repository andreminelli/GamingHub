using Microsoft.Extensions.Logging;
using ProtoBuf.Grpc;
using System.Threading.Tasks;
using UserService.Contracts;

namespace UserService
{
    public class LoginService : ILoginService
    {
        private readonly ILogger<LoginService> _logger;
        public LoginService(ILogger<LoginService> logger)
        {
            _logger = logger;
        }

        public Task<LoginResponse> LoginAsync(LoginRequest request, CallContext context = default)
        {
            return Task.FromResult(new LoginResponse
            {
                IsSuccess = true,
                Message = $"Welcome, {request.Name}"
            });
        }
    }
}
