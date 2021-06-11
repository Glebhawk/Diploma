using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SpacecraftServices.Interfaces;
using SpacecraftServices.Models;
using SpacecraftData.Repositories.Interfaces;
using SpacecraftData.Entities;

namespace SpacecraftServices.Concrete
{
    public class RocketService : IRocketService
    {
        public IRocketRepository rocketRepository { get; set; }
        public ILaunchRepository launchRepository { get; set; }

        public RocketService(IRocketRepository RocketRepository, ILaunchRepository LaunchRepository)
        {
            rocketRepository = RocketRepository;
            launchRepository = LaunchRepository;
        }
        public async Task<IEnumerable<IEnumerable<RocketStatistics>>> GetRocketStatisticsForAllCountries()
        {
            var launches = await launchRepository.GetAll();
            var countries = launches.Select(l => l.Rocket.Country).Distinct().OrderBy(c => c.Name).ToList();

            var rocketStatistics = new List<List<RocketStatistics>>();
            foreach (Country country in countries)
            {
                rocketStatistics.Add(new List<RocketStatistics>());
                foreach (Rocket rocket in launches.Select(l => l.Rocket).Distinct().Where(r => r.Country == country))
                {
                    rocketStatistics[rocketStatistics.Count - 1].Add(new RocketStatistics(launches.Where(l => l.Rocket == rocket)));
                }
            }
            return rocketStatistics;
        }

        public async Task<Rocket> GetRocket(int id)
        {
            return await rocketRepository.Get(id);
        }

        public async Task<RocketStatistics> GetRocketStatistics(int rocketId)
        {
            var launches = await launchRepository.Find(l => l.Rocket.Id == rocketId);

            return new RocketStatistics(launches);
        }

        public async Task<bool> UpdateRocket(Rocket rocket)
        {
            return await rocketRepository.Update(rocket);
        }
    }
}
