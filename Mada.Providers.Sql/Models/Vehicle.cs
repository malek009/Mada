using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Providers.Sql.Models
{
    [Table("Vehicle")]
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int BrandId { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Vin { get; set; }
        public Client Client { get; set; }
        public Brand Brand { get; set; }
    }
}
