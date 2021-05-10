using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SpacecraftData.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
