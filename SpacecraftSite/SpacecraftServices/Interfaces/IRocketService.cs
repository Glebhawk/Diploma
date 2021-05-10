using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using SpacecraftServices.Models;

namespace SpacecraftServices.Interfaces
{
    public interface IRocketService
    {
        public Task<IEnumerable<IEnumerable<RocketStatistics>>> GetRocketStatisticsForAllCountries();
    }
}
