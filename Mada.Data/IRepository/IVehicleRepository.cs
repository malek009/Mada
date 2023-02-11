using Mada.Core.ModelsCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Data.IRepository
{
    public interface IVehicleRepository
    {
        Task<VehicleCore> GetByIdAsync(int vehicleId);
        Task<VehicleCore> CreateAsync(VehicleCore vehicle);
        Task DeleteAsync(int vehicleId);
        Task<bool> Exist(int vehicleId);
        Task<IEnumerable<VehicleCore>> GetAllAsync();
    }
}
