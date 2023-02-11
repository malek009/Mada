using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Providers.Sql.Models
{
    [Table("LigneDevis")]
    public class LigneDevis
    {
        [Key]
        public int Id { get; set; }
        public int DevisId { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }

    }
}
