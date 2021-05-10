using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpacecraftData.Entities;
using SpacecraftServices.Models;
using SpacecraftServices.Interfaces;

namespace SpacecraftSite.Pages
{
    public class CountryModel : PageModel
    {
        public List<Spacecraft> spacecrafts;
        public Statistics statistics;
        public Country country;

        public ISpacecraftService spacecraftService;
        public ILaunchService launchService;
        public IStatisticsService statisticsService;

        public CountryModel(ISpacecraftService SpacecraftService, ILaunchService LaunchService, IStatisticsService StatisticsService)
        {
            spacecrafts = new List<Spacecraft>();
            spacecraftService = SpacecraftService;
            launchService = LaunchService;
            statisticsService = StatisticsService;
        }

        public async void OnGet(int id)
        {
            spacecrafts = (List<Spacecraft>)await spacecraftService.GetAllSpacecraftsByCountry(id);
            spacecrafts = spacecrafts.OrderBy(s => s.Launch.LaunchDate).ToList();
            country = spacecrafts.First().Country;
            statistics = await statisticsService.GetStatisticsByCountry(id);
        }
    }
}
