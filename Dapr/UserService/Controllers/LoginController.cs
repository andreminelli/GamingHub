using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UserService.Contracts;

namespace UserService.Controllers
{
    [Route(nameof(UserService) + "/Login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<LoginResponse>> LoginAsync(LoginRequest request)
        {
            return Ok(new LoginResponse
            {
                IsSuccess = true,
                Message = $"Welcome, {request.Name}"
            });
        }
    }
}
