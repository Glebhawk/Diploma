using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpacecraftServices.Interfaces
{
    public interface ILaunchService
    {
        Task<IEnumerable<int>> GetAllYearsOfLaunches();
        Task<bool> YearExists(int year);
    }
}
