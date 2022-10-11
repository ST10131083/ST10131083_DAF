using Microsoft.EntityFrameworkCore;
using ST10131083_DAF.Models;
using ST10131083_DAF.Models.Account;
using ST10131083_DAF.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ST10131083_DAF.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options) : base(options) { }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Disaster> Disasters { get; set; }
        public DbSet<DisasterAllocation> DisasterAllocations { get; set; }
    }
}
