using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Core.ModelsCore
{
    public class VehicleCore
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int BrandId { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Vin { get; set; }
        public ClientCore Client { get; set; }
        public BrandCore Brand { get; set; }
    }
}
