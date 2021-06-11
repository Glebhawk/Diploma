using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpacecraftData.Entities;
using SpacecraftSite.SpacecraftData;
using SpacecraftData.Repositories.Interfaces;

namespace SpacecraftData.Repositories.Concrete
{
    public class RocketRepository : IRocketRepository
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
            var rocket = await context.Rockets.Include(r => r.Country).Include(r => r.Launches).ThenInclude(l => l.Payload)
                .Include(r => r.Stages).FirstOrDefaultAsync(r => r.Id == id);
            rocket.Stages.OrderBy(s => s.Number);
            return rocket;
        }

        public async Task<IEnumerable<Rocket>> GetAll()
        {
            var rockets = await context.Rockets.Include(r => r.Country).Include(r => r.Launches).ThenInclude(l => l.Payload)
                .Include(r => r.Stages).ToListAsync();
            foreach (var rocket in rockets)
            {
                rocket.Stages.OrderBy(s => s.Number);
            }
            return rockets;
        }

        public async Task<bool> Update(Rocket item)
        {
            context.Rockets.Update(item);
            int result = await context.SaveChangesAsync();
            if (result != 0) return true;
            else return false;
        }
    }
}
