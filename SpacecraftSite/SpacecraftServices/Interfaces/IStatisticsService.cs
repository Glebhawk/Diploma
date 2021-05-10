using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SpacecraftServices.Models;

namespace SpacecraftServices.Interfaces
{
    public interface IStatisticsService
    {
        public Task<Statistics> GetStatisticsByYear(int year);
        public Task<IEnumerable<Statistics>> GetStatisticsForAllCountries();
        public Task<IEnumerable<Statistics>> GetStatisticsForAllCountriesByYear(int year);
        public Task<Statistics> GetStatisticsByCountry(int countryId);
        public Task<Statistics> GetStatisticsByYearAndCountry(int year, int countryId);
    }
}
