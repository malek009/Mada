using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Providers.Sql.Models
{
    [Table("Brand")]
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
    }

}
