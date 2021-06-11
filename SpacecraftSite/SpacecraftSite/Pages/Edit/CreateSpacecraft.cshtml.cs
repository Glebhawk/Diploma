using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpacecraftData.Entities;
using SpacecraftServices.Interfaces;
using SpacecraftSearcher.Interfaces;

namespace SpacecraftSite.Pages.Edit
{
    [BindProperties]
    public class CreateSpacecraftModel : PageModel
    {
        public Spacecraft spacecraft { get; set; }
        public string spacecraftMassString { get; set; }
        public string ErrorMessage { get; set; } = "";
        public string SearchNSSDC { get; set; } = "";

        ISpacecraftService spacecraftService { get; set; }
        ISoloSearcher soloSearcher { get; set; }

        public CreateSpacecraftModel(ISpacecraftService SpacecraftService, ISoloSearcher SoloSearcher)
        {
            spacecraftService = SpacecraftService;
            soloSearcher = SoloSearcher;
        }

        public void OnGet()
        {
            spacecraft = new Spacecraft();
            spacecraftMassString = Convert.ToString(0.0);
            ErrorMessage = "";
        }

        public async Task OnPost()
        {
            spacecraftMassString = spacecraftMassString.Replace(".", ",");
            double spacecraftMass;
            if (Double.TryParse(spacecraftMassString, out spacecraftMass))
            {
                spacecraft.Mass = spacecraftMass;
                await spacecraftService.CreateSpacecraft(spacecraft);
                Response.Redirect("/Spacecrafts");
            }
            else
            {
                ErrorMessage = "Невірно введена маса! Введіть масу у форматі \"0,00\" без додаткових позначок";
            }
        }

        public async Task OnPostSearch()
        {
            spacecraft = await soloSearcher.SearchForSpacecraft(SearchNSSDC);
            if (spacecraft.Mass != 0)
            {
                spacecraftMassString = Convert.ToString(spacecraft.Mass);
            }
            if (spacecraft.Name == "NoData")
            {
                ErrorMessage = "Нічого не знайдено!";
            }
            else ErrorMessage = "";
        }
    }
}
