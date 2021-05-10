using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpacecraftData.Entities;
using SpacecraftServices.Interfaces;
using SpacecraftServices.Models;

namespace SpacecraftSite.Pages
{
    public class YearModel : PageModel
    {
        public int Year;
        public List<Spacecraft> spacecrafts;
        public bool previousYear;
        public bool nextYear;
        public IEnumerable<Statistics> statistics;
        public Statistics completeStatistics;

        public ISpacecraftService spacecraftService;
        public ILaunchService launchService;
        public IStatisticsService statisticsService;

        public YearModel(ISpacecraftService SpacecraftService, ILaunchService LaunchService, IStatisticsService StatisticsService)
        {
            spacecrafts = new List<Spacecraft>();
            spacecraftService = SpacecraftService;
            launchService = LaunchService;
            statisticsService = StatisticsService;
        }

        public async void OnGet(int year)
        {
            Year = year;
            spacecrafts = (List<Spacecraft>)await spacecraftService.GetAllSpacecraftsByYear(year);
            spacecrafts = spacecrafts.OrderBy(s => s.Launch.LaunchDate).ToList();
            previousYear = await launchService.YearExists(year - 1);
            nextYear = await launchService.YearExists(year + 1);
            statistics = await statisticsService.GetStatisticsForAllCountriesByYear(year);
            completeStatistics = await statisticsService.GetStatisticsByYear(year);
        }
    }
}
