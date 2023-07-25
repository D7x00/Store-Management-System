using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModel.Models
{
    public class StoreContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
           UseSqlServer("Data Source =.; Initial Catalog = StoreManagement; Integrated Security = True; TrustServerCertificate = True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
