using System;
using final_app.Models;
using Microsoft.EntityFrameworkCore;

namespace final_app
{
    public class InventoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<CategoryDetail> CategoryDetails { get; set; }


    
    }
}