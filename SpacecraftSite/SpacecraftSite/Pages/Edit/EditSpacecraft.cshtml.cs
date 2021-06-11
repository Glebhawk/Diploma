using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpacecraftData.Entities;
using SpacecraftServices.Interfaces;

namespace SpacecraftSite.Pages.Edit
{
    [BindProperties(SupportsGet=true)]
    public class EditSpacecraftModel : PageModel
    {
        public Spacecraft spacecraft { get; set; }
        public string spacecraftMassString { get; set; }
        public string ErrorMessage { get; set; } = "";

        ISpacecraftService spacecraftService { get; set; }

        public EditSpacecraftModel(ISpacecraftService SpacecraftService)
        {
            spacecraftService = SpacecraftService;
        }

        public async void OnGet(int id)
        {
            spacecraft = await spacecraftService.GetSpacecraft(id);
            spacecraftMassString = Convert.ToString(spacecraft.Mass);
            ErrorMessage = "";
        }

        public async Task OnPost()
        {
            spacecraftMassString = spacecraftMassString.Replace(".", ",");
            double spacecraftMass;
            if(Double.TryParse(spacecraftMassString, out spacecraftMass))
            {
                spacecraft.Mass = spacecraftMass;
                await spacecraftService.UpdateSpacecraft(spacecraft);
                Response.Redirect("/Spacecraft/"+spacecraft.Id);
            }
            else
            {
                ErrorMessage = "Невірно введена маса! Введіть масу у форматі \"0,00\" без додаткових позначок";
            }
        }
    }
}
