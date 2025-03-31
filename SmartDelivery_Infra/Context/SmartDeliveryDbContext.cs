using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartDelivery_Infra.Models;

namespace SmartDelivery_Infra.Context
{
    public class SmartDeliveryDbContext:DbContext
    {
        public SmartDeliveryDbContext(DbContextOptions<SmartDeliveryDbContext> options): base(options)
        {
            
        }
        public DbSet<Category> categories {  get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<PurchaseDetail> purchaseDetails { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //base.OnConfiguring(optionsBuilder);
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SmartDelivery;Integrated Security=True");
        //    }
        //}
    }
}
