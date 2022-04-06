using HairDressingSalonApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressingSalonApp.Abstractions
{
    public interface IHairdresserService
    {
        List<Hairdresser> GetHairdressers();
        Hairdresser GetHairdresserById(int hairdresser);
        public bool RemoveById(int hairdresser);
        string GetFullName(int hairdresser);

        bool CreateHairdresser(string firstName, string lastName, string userId);
    }
}
