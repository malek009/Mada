using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Providers.Sql.Models
{
    [Table("Devis")]
    public class Devis
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ClientId { get; set; }
        public int VehicleId { get; set; }
        public DateTime Date { get; set; }
        public float Total { get; set; }

        public User User { get; set; }
        public Client Client { get; set; }
        public Vehicle Vehicle { get; set; }
        public IEnumerable<LigneDevis> LignesDevis { get; set;}
    }
}
