using System;
using System.Collections.Generic;
using System.Text;

namespace SpacecraftData.Entities
{
    public class Stage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Engines { get; set; }
        public string Fuel { get; set; }
        public Rocket Rocket { get; set; }
    }
}
