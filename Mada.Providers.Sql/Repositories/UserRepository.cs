using AutoMapper;
using Mada.Core.ModelsCore;
using Mada.Providers.Sql.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mada.Providers.Sql.Repositories
{
    internal class UserRepository
    {
        private readonly MadaDbContext _context;
        private readonly IMapper _mapper;

        public UserRepository(MadaDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
        public async Task<UserCore> CreateAsync(UserCore user)
        {
            var userEntity = this._mapper.Map<User>(user);
            await _context.Users.AddAsync(userEntity);
            await _context.SaveChangesAsync();
            user.Id = userEntity.Id;
            return user;
        }

        public async Task<bool> Exist(int id)
        {
            return await this._context.Users.AsNoTracking().AnyAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<UserCore>> GetAllAsync()
        {
            return this._mapper.Map<IEnumerable<UserCore>>(await this._context.Users.AsNoTracking().ToListAsync());
        }

        public async Task<UserCore> GetUserByEmailAsync(string email)
        {
            var userDb = await this._context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Email.Equals(email));
            return this._mapper.Map<UserCore>(userDb);
        }
    }
}
