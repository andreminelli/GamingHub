using GrainInterfaces;
using Orleans;
using System;
using System.Threading.Tasks;

namespace Grains
{
    public class User : Orleans.Grain, IUser
    {
        public Task<string> GetNameAsync()
        {
            return Task.FromResult(this.GetPrimaryKeyString());
        }
    }
}
