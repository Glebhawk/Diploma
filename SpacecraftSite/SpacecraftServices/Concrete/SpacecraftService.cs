using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SpacecraftData.Entities;
using SpacecraftData.Repositories.Interfaces;
using SpacecraftServices.Interfaces;

namespace SpacecraftServices.Concrete
{
    public class SpacecraftService : ISpacecraftService
    {

        private ISpacecraftRepository spacecraftRepository;

        public SpacecraftService(ISpacecraftRepository SpacecraftRepository)
        {
            spacecraftRepository = SpacecraftRepository;
        }

        public async Task<Spacecraft> GetSpacecraft(int id)
        {
            return await spacecraftRepository.Get(id);
        }

        public async Task<IEnumerable<Spacecraft>> GetAllSpacecrafts()
        {
            return await spacecraftRepository.GetAll();
        }

        public async Task<IEnumerable<Spacecraft>> GetAllSpacecraftsByYear(int year)
        {
            return await spacecraftRepository.Find(s => s.Launch.LaunchDate.Year == year);
        }

        public async Task<IEnumerable<Spacecraft>> GetAllSpacecraftsByCountry(int countryId)
        {
            return await spacecraftRepository.Find(s => s.Country.Id == countryId);
        }

        public async Task<bool> UpdateSpacecraft(Spacecraft spacecraft)
        {
            return await spacecraftRepository.Update(spacecraft);
        }

        public async Task<bool> CreateSpacecraft(Spacecraft spacecraft)
        {
            return await spacecraftRepository.Add(spacecraft);
        }
    }
}
