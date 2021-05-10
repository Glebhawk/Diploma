using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using SpacecraftServices.Interfaces;
using SpacecraftData.Repositories.Interfaces;

namespace SpacecraftServices.Concrete
{
    public class LaunchService : ILaunchService
    {
        private ILaunchRepository launchRepository;

        public LaunchService(ILaunchRepository LaunchRepository)
        {
            launchRepository = LaunchRepository;
        }
        public async Task<IEnumerable<int>> GetAllYearsOfLaunches()
        {
            var launches = await launchRepository.GetAll();
            return launches.Select(l => l.LaunchDate.Year).Distinct().ToList();
        }

        public async Task<bool> YearExists(int year)
        {
            var launches = await launchRepository.Find(l => l.LaunchDate.Year == year);
            if (launches.Count() == 0) return false;
            else return true;
        }
    }
}
