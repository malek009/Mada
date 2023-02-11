using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Core.ModelsCore
{
    public class LigneDevisCore
    {
        public int Id { get; set; }
        public int DevisId { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
    }
}
