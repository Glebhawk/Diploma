using System;
using System.Collections.Generic;
using System.Text;

namespace SpacecraftData.Entities
{
    public class Rocket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Mass { get; set; }
        public double Height { get; set; }
        public Country Country { get; set; }
        public string Manufacturer { get; set; }
        public IEnumerable<Stage> Stages { get; set; }
    }
}
