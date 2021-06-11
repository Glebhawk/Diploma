using System;
using System.Collections.Generic;
using System.Text;

namespace SpacecraftData.Entities
{
    public class Spacecraft
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NSSDC { get; set; }
        public Country Country { get; set; }
        public string Operator { get; set; }
        public string Type { get; set; }
        public string Equipment { get; set; }
        public string Configuration { get; set; }
        public string Mission { get; set; }
        public double Mass { get; set; }
        public Launch Launch { get; set; }
    }
}
