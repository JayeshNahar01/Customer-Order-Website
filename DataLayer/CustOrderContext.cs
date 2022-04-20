
using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer
{
    public class CustOrderContext : DbContext
    {
       
       
        public DbSet<Customer> Customers { get; set; }                             // creating dbset properties
        public DbSet<Order> Orders { get; set; }
        public DbSet<Owner> Owners { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)                                        // configuring connection with sql-server db
            {
                optionBuilder.UseSqlServer(@"Server =.\SQLEXPRESS; Database = CustOrderDB; Trusted_Connection = True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>(entity =>                                // validation for customer's unique EmailID
            {  
                entity.HasIndex(e => e.EmailID).IsUnique();
            });
        }
    }
}

