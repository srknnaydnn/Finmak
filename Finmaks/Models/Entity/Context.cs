using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finmaks.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SERKAN\\MSSQLSERVER01; database=Finmaks; integrated security=true");
        }

        public DbSet<Currency> Currencies { get; set; }
    }
}
