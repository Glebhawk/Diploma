using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpacecraftData.Entities;
using SpacecraftData.Repositories.Interfaces;
using SpacecraftSite.SpacecraftData;

namespace SpacecraftData.Repositories.Concrete
{
    public class LaunchRepository : ILaunchRepository
    {
        public ApplicationDbContext context { get; set; }

        public LaunchRepository(ApplicationDbContext Context)
        {
            context = Context;
        }

        public Task<bool> Add(Launch item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Launch>> Find(Expression<Func<Launch, bool>> predicate)
        {
            return await context.Launches.Include(l => l.Rocket).ThenInclude(r => r.Country).Where(predicate).ToListAsync();
        }

        public async Task<Launch> Get(int id)
        {
            return await context.Launches.Include(l => l.Rocket).ThenInclude(r => r.Country).FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task<IEnumerable<Launch>> GetAll()
        {
            return await context.Launches.Include(l => l.Rocket).ThenInclude(r => r.Country).ToListAsync();
        }

        public Task<bool> Update(Launch item)
        {
            throw new NotImplementedException();
        }
    }
}
