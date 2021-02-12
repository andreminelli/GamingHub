using GrainInterfaces;
using Orleans.Concurrency;
using System.Threading.Tasks;

namespace Grains
{
    [StatelessWorker]
    public class LoginWorker : Orleans.Grain, ILoginWorker
    {
        public async Task<LoginResponse> LoginAsync(LoginRequest request)
        {
            var userGrain = GrainFactory.GetGrain<IUser>(request.Name);
            return new LoginResponse
            {
                User = userGrain,
                Message = $"Welcome, {request.Name}"
            };
        }
    }
}
