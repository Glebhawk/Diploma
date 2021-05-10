using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SpacecraftData.Entities;
using SpacecraftData.Repositories.Interfaces;
using SpacecraftSite.SpacecraftData;

namespace SpacecraftData.Repositories.Concrete
{
    public class SpacecraftRepository : ISpacecraftRepository
    {

        public ApplicationDbContext context { get; set; }

        public SpacecraftRepository(ApplicationDbContext Context)
        {
            context = Context;
        }

        public Task<bool> Add(Spacecraft item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Spacecraft>> Find(Expression<Func<Spacecraft, bool>> predicate)
        {
            return await context.Spacecrafts.Where(predicate).Include(s => s.Launch).ThenInclude(l => l.Rocket).Include(s => s.Country).ToListAsync();
        }

        public async Task<Spacecraft> Get(int id)
        {
            return await context.Spacecrafts.Include(s => s.Launch).ThenInclude(l => l.Rocket).Include(s => s.Country).FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<Spacecraft>> GetAll()
        {
            return await context.Spacecrafts.Include(s => s.Launch).ThenInclude(l => l.Rocket).Include(s => s.Country).ToListAsync();
        }

        public Task<bool> Update(Spacecraft item)
        {
            throw new NotImplementedException();
        }
    }
}
