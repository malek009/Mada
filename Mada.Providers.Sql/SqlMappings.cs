using AutoMapper;
using Mada.Core.ModelsCore;
using Mada.Providers.Sql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Providers.Sql
{
    public class SqlMappings : Profile
    {
        public SqlMappings()
        {
            CreateMap<Brand, BrandCore>().ReverseMap();
            CreateMap<Client, ClientCore>().ReverseMap();
            CreateMap<Devis, DevisCore>().ReverseMap();
            CreateMap<LigneDevis, LigneDevisCore>().ReverseMap();
            CreateMap<User, UserCore>().ReverseMap();
            CreateMap<Vehicle, VehicleCore>().ReverseMap();
        }
    }
}
