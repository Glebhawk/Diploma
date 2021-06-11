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

        public async Task<bool> Add(Spacecraft item)
        {
            var country = context.Countries.Where(c => c.Name == item.Country.Name).FirstOrDefault();
            if (country != null) item.Country = country;

            var rocket = context.Rockets.Where(r => r.Name == item.Launch.Rocket.Name).FirstOrDefault();
            if (rocket != null) item.Launch.Rocket = rocket;

            var launch = context.Launches.Where(l => l.LaunchDate == item.Launch.LaunchDate && l.LaunchSite == item.Launch.LaunchSite
            && l.Success == item.Launch.Success && l.Rocket.Name == l.Rocket.Name).Include(l => l.Rocket).FirstOrDefault();
            if (launch != null) item.Launch = launch;

            context.Spacecrafts.Add(item);

            int result = await context.SaveChangesAsync();
            if (result != 0) return true;
            else return false;
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

        public async Task<bool> Update(Spacecraft item)
        {
            context.Spacecrafts.Update(item);
            int result = await context.SaveChangesAsync();
            if (result != 0) return true;
            else return false;
        }
    }
}
