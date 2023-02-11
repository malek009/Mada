using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Providers.Sql.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime CreationDate { get; set; }

        public IEnumerable<Vehicle> Vehicles { get; set; }
        public IEnumerable<Devis> Devises { get; set;}
    }
}
