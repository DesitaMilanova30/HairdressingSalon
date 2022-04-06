using HairDressingSalonApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressingSalonApp.Abstractions
{
   public interface IClientService
    {
        List<Client> GetClients();
        Client GetClientsById(int clientId);
        public bool RemoveById(int clientId);
        string GetFullName(int clientId);

        bool CreateClient(string firstName, string lastName, DateTime birthday, string userId);
    }
}
    

