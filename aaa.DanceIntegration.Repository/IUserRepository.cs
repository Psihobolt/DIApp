using System.Collections.Generic;
using System.Threading.Tasks;
using aaa.DanceIntegration.Models;

namespace aaa.DanceIntegration.Repository
{
    public interface IUserRepository
    {
        Task<IReadOnlyCollection<User>> Get();
    }
}
