using System;
using System.Linq;
using System.Collections.Generic;
using SpacecraftData.Entities;

namespace SpacecraftServices.Models
{
    public class Statistics
    {
        public Country country { get; set; }
        public int allSpacecraft { get; set; }
        public int successfull { get; set; }
        public int failed { get; set; }
        public double percentage { get; set; }

        public Statistics(Country Country, int AllSpacecraft, int Successfull, int Failed)
        {
            country = Country;
            allSpacecraft = AllSpacecraft;
            successfull = Successfull;
            failed = Failed;
            percentage = Math.Round((successfull / allSpacecraft) * 100.0);
        }

        public Statistics(Country Country, IEnumerable<Spacecraft> spacecrafts)
        {
            country = Country;
            allSpacecraft = spacecrafts.Count();
            successfull = spacecrafts.Where(s => s.Launch.Success).ToList().Count();
            failed = spacecrafts.Where(s => !s.Launch.Success).ToList().Count();
            percentage = Math.Round(((double)successfull / (double)allSpacecraft) * 100.0, 1);
        }
    }
}
