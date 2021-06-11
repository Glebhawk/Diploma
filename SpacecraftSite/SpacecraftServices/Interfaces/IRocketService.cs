using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using SpacecraftServices.Models;
using SpacecraftData.Entities;

namespace SpacecraftServices.Interfaces
{
    public interface IRocketService
    {
        public Task<Rocket> GetRocket(int id);
        public Task<bool> UpdateRocket(Rocket rocket);
        public Task<IEnumerable<IEnumerable<RocketStatistics>>> GetRocketStatisticsForAllCountries();
        public Task<RocketStatistics> GetRocketStatistics(int rocketId);
    }
}
