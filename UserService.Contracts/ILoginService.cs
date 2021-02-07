using ProtoBuf.Grpc;
using System.ServiceModel;
using System.Threading.Tasks;

namespace UserService.Contracts
{
    [ServiceContract(Name = "UserService.Login")]
    public interface ILoginService
    {
        Task<LoginResponse> LoginAsync(LoginRequest request, CallContext context = default);
    }
}
