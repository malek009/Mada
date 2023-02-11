using Mada.Core.ModelsCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Data.IRepository
{
    internal interface IDevisRepository
    {
        Task<DevisCore> GetByIdAsync(int devisId);
        Task<DevisCore> CreateAsync(DevisCore devis);
        Task DeleteAsync(int devisId);
        Task<bool> Exist(int devisId);
        Task<IEnumerable<DevisCore>> GetAllAsync();
    }
}
