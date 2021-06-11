using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SpacecraftData.Entities;

namespace SpacecraftSearcher.Interfaces
{
    public interface ISoloSearcher
    {
        public Task<Spacecraft> SearchForSpacecraft(string NSSDCA);
    }
}
