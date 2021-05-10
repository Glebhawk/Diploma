using System;
using System.Collections.Generic;
using System.Text;

namespace SpacecraftData.Entities
{
    public class Launch
    {
        public int Id { get; set; }
        public DateTime LaunchDate { get; set; }
        public bool Success { get; set; }
        public string LaunchSite { get; set; }
        public Rocket Rocket { get; set; }
        public IEnumerable<Spacecraft> Payload { get; set; }
    }
}
