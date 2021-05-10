using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SpacecraftData.Entities;

namespace SpacecraftServices.Interfaces
{
    public interface ISpacecraftService
    {
        Task<Spacecraft> GetSpacecraft(int id);
        Task<IEnumerable<Spacecraft>> GetAllSpacecrafts();
        Task<IEnumerable<Spacecraft>> GetAllSpacecraftsByYear(int year);
        Task<IEnumerable<Spacecraft>> GetAllSpacecraftsByCountry(int countryId);
    }
}
