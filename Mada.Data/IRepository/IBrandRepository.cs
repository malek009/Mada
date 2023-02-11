using Mada.Core.ModelsCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Data.IRepository
{
    public interface IBrandRepository
    {
        Task<BrandCore> GetByIdAsync(int actorId);
        Task<BrandCore> CreateAsync(BrandCore actor);
        Task DeleteAsync(int BrandId);
        Task<bool> Exist(int BrandId);
        Task<IEnumerable<BrandCore>> GetAllAsync();
    }
}
