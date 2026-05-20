using Microsoft.EntityFrameworkCore;
using DentalLabAPI.Models;
using DentalLabAPI.Class;
using System.Collections.Generic;

namespace DentalLabAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}