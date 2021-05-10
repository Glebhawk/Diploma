using System;
using System.Linq;
using System.Collections.Generic;
using SpacecraftData.Entities;

namespace SpacecraftServices.Models
{
    public class RocketStatistics
    {
        public Rocket Rocket { get; set; }
        public int allLaunches { get; set; }
        public int successfull { get; set; }
        public int failed { get; set; }
        public double percentage { get; set; }
        public DateTime firstLaunch { get; set; }
        public DateTime lastLaunch { get; set; }

        public RocketStatistics(Rocket rocket, int AllLaunches, int Successfull, int Failed, DateTime FirstLaunch, DateTime LastLaunch)
        {
            Rocket = rocket;
            allLaunches = AllLaunches;
            successfull = Successfull;
            failed = Failed;
            percentage = Math.Round(((double)successfull / (double)allLaunches) * 100.0, 1);
            firstLaunch = FirstLaunch;
            lastLaunch = LastLaunch;
        }

        public RocketStatistics(IEnumerable<Launch> rocketLaunches)
        {
            Rocket = rocketLaunches.First().Rocket;
            allLaunches = rocketLaunches.Count();
            successfull = rocketLaunches.Where(l => l.Success).ToList().Count();
            failed = rocketLaunches.Where(l => !l.Success).ToList().Count();
            percentage = Math.Round(((double)successfull / (double)allLaunches) * 100.0, 1);
            firstLaunch = rocketLaunches.Select(l => l.LaunchDate).Min();
            lastLaunch = rocketLaunches.Select(l => l.LaunchDate).Max();
        }
    }
}
