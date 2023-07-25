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
        public DbSet<vendor> Vendors { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Store> Stores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
           UseSqlServer("Data Source =.; Initial Catalog = StoreManagement; Integrated Security = True; TrustServerCertificate = True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
