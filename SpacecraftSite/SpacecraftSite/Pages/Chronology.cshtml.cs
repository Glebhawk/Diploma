using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpacecraftData.Entities;
using SpacecraftServices.Interfaces;

namespace SpacecraftSite.Pages
{
    public class ChronologyModel : PageModel
    {
        public List<Spacecraft> spacecrafts;
        public List<int> years;

        public ISpacecraftService spacecraftService;

        public ChronologyModel(ISpacecraftService SpacecraftService)
        {
            spacecrafts = new List<Spacecraft>();
            spacecraftService = SpacecraftService;
        }

        public async void OnGet()
        {
            spacecrafts = (List<Spacecraft>)await spacecraftService.GetAllSpacecrafts();
            spacecrafts = spacecrafts.OrderBy(s => s.Launch.LaunchDate).ToList();
            years = spacecrafts.Select(s => s.Launch.LaunchDate.Year).Distinct().ToList();
        }
    }
}
