using HairDressingSalonApp.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using HairDressingSalonApp.Models.Client;
using HairDressingSalonApp.Models.Hairdresser;

namespace HairDressingSalonApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Hairdresser> Hairdressers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Hour> Hours { get; set; }
        public DbSet<Reservation> Reservations{ get; set; }
        public DbSet<Report> Reports { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<HairDressingSalonApp.Models.Client.CreateClientVM> CreateClientVM { get; set; }
        public DbSet<HairDressingSalonApp.Models.Client.ListingClientVM> ListingClientVM { get; set; }
        public DbSet<HairDressingSalonApp.Models.Hairdresser.ListingHairdresserVM> ListingHairdresserVM { get; set; }
    }
}
