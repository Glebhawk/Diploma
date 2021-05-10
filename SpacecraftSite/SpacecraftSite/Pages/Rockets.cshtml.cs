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
    public class RocketsModel : PageModel
    {
        public IEnumerable<IEnumerable<RocketStatistics>> RocketStatistics;

        public IRocketService rocketService;

        public RocketsModel(IRocketService RocketService)
        {
            rocketService = RocketService;
        }

        public async void OnGet()
        {
            RocketStatistics = await rocketService.GetRocketStatisticsForAllCountries();
        }
    }
}
