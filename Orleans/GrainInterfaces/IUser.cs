using System.Threading.Tasks;

namespace GrainInterfaces
{
    public interface IUser : Orleans.IGrainWithStringKey
    {
        Task<string> GetNameAsync();
    }
}