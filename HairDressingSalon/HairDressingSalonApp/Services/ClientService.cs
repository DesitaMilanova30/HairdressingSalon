using HairDressingSalonApp.Abstractions;
using HairDressingSalonApp.Data;
using HairDressingSalonApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressingSalonApp.Services
{
    public class ClientService : IClientService
    {
        private readonly ApplicationDbContext _context;

        public ClientService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool CreateClient(string firstName, string lastName, DateTime birthday, string userId)
        {
            if (_context.Clients.Any(x => x.UserId == userId))
                throw new InvalidOperationException("Client already exist.");

            Client clientForDb = new Client()
            {
                FirstName = firstName,
                LastName = lastName,
                UserId = userId,
                Birthday = birthday
            };
            _context.Clients.Add(clientForDb);
            return _context.SaveChanges() != 0;
        }


        public List<Client> GetClients()
        {
            return _context.Clients.ToList();
        }

        public Client GetClientsById(int clientId)
        {
            throw new NotImplementedException();
        }

        public string GetFullName(int clientId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveById(int clientId)
        {
            throw new NotImplementedException();
        }
    }
}
