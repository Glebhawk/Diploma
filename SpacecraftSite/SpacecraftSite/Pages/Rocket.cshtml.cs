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
    public class RocketModel : PageModel
    {
        public Rocket rocket { get; set; }
        public RocketStatistics rocketStatistics { get; set; }

        public IRocketService rocketService { get; set; }

        public RocketModel(IRocketService RocketService)
        {
            rocketService = RocketService;
        }

        public async void OnGet(int id)
        {
            rocket = await rocketService.GetRocket(id);
            rocketStatistics = await rocketService.GetRocketStatistics(id);
        }
    }
}
