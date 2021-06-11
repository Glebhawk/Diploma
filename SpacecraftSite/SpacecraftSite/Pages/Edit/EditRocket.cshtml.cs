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
    [BindProperties]
    public class EditRocketModel : PageModel
    {
        public Rocket Rocket { get; set; }
        public List<Stage> rocketStages { get; set; }
        public string rocketMassString { get; set; }
        public string rocketHeightString { get; set; }
        public string ErrorMessage { get; set; } = "";

        IRocketService rocketService { get; set; }

        public EditRocketModel(IRocketService RocketService)
        {
            rocketService = RocketService;
        }
        public async void OnGet(int id)
        {
            Rocket = await rocketService.GetRocket(id);
            rocketMassString = Convert.ToString(Rocket.Mass);
            rocketHeightString = Convert.ToString(Rocket.Height);
            rocketStages = Rocket.Stages.ToList();
        }

        public async void OnPost()
        {
            rocketMassString = rocketMassString.Replace(".", ",");
            rocketHeightString = rocketHeightString.Replace(".",",");
            double rocketMass;
            double rocketHeight;
            if (Double.TryParse(rocketMassString, out rocketMass) && Double.TryParse(rocketHeightString, out rocketHeight))
            {
                Rocket.Mass = rocketMass;
                Rocket.Height = rocketHeight;
                Rocket.Stages = rocketStages;
                await rocketService.UpdateRocket(Rocket);
                Response.Redirect("/Rocket/" + Rocket.Id);
            }
            else
            {
                ErrorMessage = "Невірно введена маса або висота! Введіть масу і висоту у форматі \"0,00\" без додаткових позначок";
            }
        }

        public IActionResult OnPostUp(int data)
        {
            var stages = rocketStages;
            var temp = stages[data];
            stages.RemoveAt(data);
            stages.Insert(data - 1, temp);
            for(int i = 0; i < stages.Count; i++)
            {
                stages[i].Number = i + 1;
            }
            rocketStages = stages;
            return Page();
        }

        public IActionResult OnPostDown(int data)
        {
            var stages = rocketStages;
            var temp = stages[data];
            stages.RemoveAt(data);
            stages.Insert(data + 1, temp); 
            for (int i = 0; i < stages.Count; i++)
            {
                stages[i].Number = i + 1;
            }
            rocketStages = stages;
            return Page();
        }

        public IActionResult OnPostDeleteStage(int data)
        {
            var stages = rocketStages;
            stages.RemoveAt(data);
            for(int i = data - 1; i < stages.Count; i++)
            {
                stages[i].Number = i + 1;
            }
            rocketStages = stages;
            return Page();
        }

        public void OnPostAddStage()
        {
            var stages = rocketStages;
            stages.Add(new Stage() {Number = stages.Count() + 1 });
            rocketStages = stages;
        }
    }
}
