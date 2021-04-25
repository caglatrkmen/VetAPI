using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinerAPI.Entities;

namespace VeterinerAPI.Data
{
    public class PatientsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-3K9BSJI;Database=Vet; Trusted_Connection=True");
        }

        public DbSet<Patients> Patients { get; set; } 
    }
}
