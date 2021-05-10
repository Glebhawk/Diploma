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
    public class SpacecraftModel : PageModel
    {
        public Spacecraft spacecraft { get; set; }

        public ISpacecraftService spacecraftService { get; set; }

        public SpacecraftModel(ISpacecraftService SpacecraftService)
        {
            spacecraftService = SpacecraftService;
        }

        public async void OnGet(int id)
        {
            spacecraft = await spacecraftService.GetSpacecraft(id);
        }
    }
}
