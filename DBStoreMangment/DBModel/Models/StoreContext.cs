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
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Receiving> Receivings { get; set; }
        public DbSet<ItemStore> itemStores { get; set; }
        public DbSet<ReceivingItem> ReceivingItems { get; set; }
        public DbSet<Company> Companys { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
           UseSqlServer("Data Source =.; Initial Catalog = StoreManagement; Integrated Security = True; TrustServerCertificate = True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
