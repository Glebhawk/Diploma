using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpacecraftData.Entities;
using SpacecraftServices.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SpacecraftSite.Pages
{
    public class SpacecraftsModel : PageModel
    {
        public List<Spacecraft> spacecrafts;

        public ISpacecraftService spacecraftService;

        public SpacecraftsModel(ISpacecraftService SpacecraftService)
        {
            spacecrafts = new List<Spacecraft>();
            spacecraftService = SpacecraftService;
        }

        public async void OnGet()
        {
            spacecrafts = (List<Spacecraft>) await spacecraftService.GetAllSpacecrafts();
            spacecrafts = spacecrafts.OrderBy(s => s.Launch.LaunchDate).ToList();
        }
    }
}
