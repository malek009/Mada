using Mada.Core.ModelsCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Data.IRepository
{
    internal interface IClientRepository
    {
        Task<ClientCore> GetByIdAsync(int clientId);
        Task<ClientCore> CreateAsync(ClientCore client);
        Task DeleteAsync(int clientId);
        Task<bool> Exist(int clientId);
        Task<IEnumerable<ClientCore>> GetAllAsync();
    }
}
