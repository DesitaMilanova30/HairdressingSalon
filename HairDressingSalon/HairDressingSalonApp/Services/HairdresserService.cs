using HairDressingSalonApp.Abstractions;
using HairDressingSalonApp.Data;
using HairDressingSalonApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressingSalonApp.Services
{
    public class HairdresserService : IHairdresserService
    {
        private readonly ApplicationDbContext _context;

        public HairdresserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool CreateHairdresser(string firstName, string lastName,  string userId)

        {
            if (_context.Hairdressers.Any(x => x.UserId == userId))
                throw new InvalidOperationException("Hairdressers already exist.");

            Hairdresser hairdreeserForDb = new Hairdresser()
            {
                FirstName = firstName,
                LastName = lastName,
                UserId = userId,
            };
            _context.Hairdressers.Add(hairdreeserForDb);
            return _context.SaveChanges() != 0;
        }
    
        public string GetFullName(int hairdresser)
        {
            throw new NotImplementedException();
        }

        public IHairdresserService GetHairdresserById(int hairdresser)
        {
            throw new NotImplementedException();
        }

        public List<IHairdresserService> GetHairdressers()
        {
            throw new NotImplementedException();
        }

        public bool RemoveById(int hairdresser)
        {
            throw new NotImplementedException();
        }
    }
}
