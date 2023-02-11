using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Core.ModelsCore
{
    public class ClientCore
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime CreationDate { get; set; }

        public IEnumerable<VehicleCore> Vehicles { get; set; }
        public IEnumerable<DevisCore> Devises { get; set; }
    }
}
