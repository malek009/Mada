using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Core.ModelsCore
{
    public class DevisCore
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ClientId { get; set; }
        public int VehicleId { get; set; }
        public DateTime Date { get; set; }
        public float Total { get; set; }

        public UserCore User { get; set; }
        public ClientCore Client { get; set; }
        public VehicleCore Vehicle { get; set; }
        public IEnumerable<LigneDevisCore> LignesDevis { get; set; }
    }
}
