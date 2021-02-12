using MightBlade.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MightBlade.DBContexts
{
    public class MyDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Use Fluent API to configure  

            // Map entities to tables  
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Item>().ToTable("Items");

            // Configure Primary Keys  
            modelBuilder.Entity<User>().HasKey(u => u.Id).HasName("PK_Users");
            modelBuilder.Entity<Item>().HasKey(i => i.Id).HasName("PK_Items");

            // Configure indexes  
            modelBuilder.Entity<User>().HasIndex(u => u.UserName).HasDatabaseName("Idx_UserName");
            modelBuilder.Entity<Item>().HasIndex(i => i.Name).HasDatabaseName("Idx_Name");

            // Configure columns  

            // Columns for Item Database
            modelBuilder.Entity<Item>().Property(i => i.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Item>().Property(i => i.Name).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Item>().Property(i => i.Type).HasColumnType("text").IsRequired();
            modelBuilder.Entity<Item>().Property(i => i.DamageMod).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Item>().Property(i => i.HealthMod).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Item>().Property(i => i.ManaMod).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Item>().Property(i => i.SellValue).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Item>().Property(i => i.BuyValue).HasColumnType("int").IsRequired();

            //Columns for User Database
            modelBuilder.Entity<User>().Property(u => u.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<User>().Property(u => u.UserName).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(u => u.UserClass).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Gold).HasColumnType("int").IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Stats).HasColumnType("text").IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Inventory).HasColumnType("text").IsRequired();

        }
    }
}