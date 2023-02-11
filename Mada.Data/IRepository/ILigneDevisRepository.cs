using Mada.Core.ModelsCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Data.IRepository
{
    internal interface ILigneDevisRepository
    {
        Task<LigneDevisCore> GetByIdAsync(int ligneDevisId);
        Task<LigneDevisCore> CreateAsync(LigneDevisCore ligneDevis);
        Task DeleteAsync(int ligneDevisId);
        Task<bool> Exist(int ligneDevisId);
        Task<IEnumerable<LigneDevisCore>> GetAllAsync();
    }
}
