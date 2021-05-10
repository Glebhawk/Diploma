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
    public class StatisticsService : IStatisticsService
    {
        public ISpacecraftRepository spacecraftRepository { get; set; }

        public StatisticsService(ISpacecraftRepository SpacecraftRepository)
        {
            spacecraftRepository = SpacecraftRepository;
        }

        public async Task<Statistics> GetStatisticsByCountry(int countryId)
        {
            var spacecrafts = await spacecraftRepository.Find(s => s.Country.Id == countryId);
            return new Statistics(spacecrafts.First().Country, spacecrafts);
        }

        public async Task<Statistics> GetStatisticsByYear(int year)
        {
            var spacecrafts = await spacecraftRepository.Find(s => s.Launch.LaunchDate.Year == year);
            return new Statistics(new Country(), spacecrafts);
        }

        public async Task<IEnumerable<Statistics>> GetStatisticsForAllCountriesByYear(int year)
        {
            var spacecrafts = await spacecraftRepository.Find(s => s.Launch.LaunchDate.Year == year);
            var countries = spacecrafts.Select(s => s.Country).Distinct().OrderBy(c => c.Name).ToList();

            var statistics = new List<Statistics>();
            foreach(Country country in countries)
            {
                statistics.Add(new Statistics(country, spacecrafts.Where(s => s.Country == country)));
            }
            return statistics;
        }

        public async Task<Statistics> GetStatisticsByYearAndCountry(int year, int countryId)
        {
            var spacecrafts = await spacecraftRepository.Find(s => s.Country.Id == countryId && s.Launch.LaunchDate.Year == year);
            return new Statistics(spacecrafts.First().Country, spacecrafts);
        }

        public async Task<IEnumerable<Statistics>> GetStatisticsForAllCountries()
        {
            var spacecrafts = await spacecraftRepository.GetAll();
            var countries = spacecrafts.Select(s => s.Country).Distinct().OrderBy(c => c.Name).ToList();

            var statistics = new List<Statistics>();
            foreach (Country country in countries)
            {
                statistics.Add(new Statistics(country, spacecrafts.Where(s => s.Country == country)));
            }
            return statistics;
        }
    }
}
