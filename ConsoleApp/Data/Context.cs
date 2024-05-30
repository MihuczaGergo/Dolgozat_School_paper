using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConsoleApp.Models;

namespace ConsoleApp.Data
{
    public class Context : DbContext
    {
        public Context() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MsSqlLocalDb;Database=Gergő;Trusted_Connection=True");
        }
        public DbSet<People> People { get; set; }
    }
}
