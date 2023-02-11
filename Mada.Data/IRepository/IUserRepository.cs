using Mada.Core.ModelsCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Data.IRepository
{
    public interface IUserRepository
    {
        Task<UserCore> CreateAsync(UserCore user);
        Task<bool> Exist(int userId);
        Task<IEnumerable<UserCore>> GetAllAsync();
        Task<UserCore> GetUserByEmailAsync(string email);

    }
}
