using Mada.Providers.Sql.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Providers.Sql
{
    public class MadaDbContext : DbContext
    {
        public MadaDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Devis> Devises { get; set; }
        public DbSet<LigneDevis> LignesDevis { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
    
}
