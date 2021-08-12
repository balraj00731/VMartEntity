using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VMart.Models;

namespace VMart.Data
{
    public class VMartContext : DbContext
    {
        public VMartContext (DbContextOptions<VMartContext> options)
            : base(options)
        {
        }

        public DbSet<VMart.Models.Login> Login { get; set; }

        public DbSet<VMart.Models.Items> Items { get; set; }

        public DbSet<VMart.Models.Sales> Sales { get; set; }

        public DbSet<VMart.Models.Feedback> Feedback { get; set; }
    }
}
