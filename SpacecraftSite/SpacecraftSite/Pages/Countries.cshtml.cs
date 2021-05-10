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
    public class CountriesModel : PageModel
    {
        public IEnumerable<Statistics> statistics;

        public IStatisticsService statisticsService;

        public CountriesModel(IStatisticsService StatisticsService)
        {
            statisticsService = StatisticsService;
        }

        public async void OnGet()
        {
            statistics = await statisticsService.GetStatisticsForAllCountries();
        }
    }
}
