using Orleans;
using System.Threading.Tasks;

namespace GrainInterfaces
{
    public interface ILoginWorker : IGrainWithGuidKey
    {
        Task<LoginResponse> LoginAsync(LoginRequest request);
    }
}
