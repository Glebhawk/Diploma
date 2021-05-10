using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpacecraftData.Entities;
using SpacecraftSite.SpacecraftData;
using SpacecraftData.Repositories.Interfaces;

namespace SpacecraftData.Repositories.Concrete
{
    class RocketRepository : IRocketRepository
    {
        public ApplicationDbContext context { get; set; }

        public RocketRepository(ApplicationDbContext Context)
        {
            context = Context;
        }

        public Task<bool> Add(Rocket item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Rocket>> Find(Expression<Func<Rocket, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<Rocket> Get(int id)
        {
            return await context.Rockets.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<IEnumerable<Rocket>> GetAll()
        {
            return await context.Rockets.ToListAsync();
        }

        public Task<bool> Update(Rocket item)
        {
            throw new NotImplementedException();
        }
    }
}
