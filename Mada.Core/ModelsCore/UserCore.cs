using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Core.ModelsCore
{
    public class UserCore
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Role { get; set; }
        public DateTime CreatedDate { get; set; }
        public IEnumerable<DevisCore> Devises { get; set; }
    }
}
