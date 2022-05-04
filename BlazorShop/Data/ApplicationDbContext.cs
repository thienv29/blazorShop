﻿using BlazorShop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }



        public DbSet<Account> Accounts { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ColorDB> ColorDBs { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<SizeColorProduct> SizeColorProducts { get; set; }
        public DbSet<Customer> Users { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Product>()
                .HasMany(p => p.Sizes)
                .WithMany(p => p.Products)
                .UsingEntity(j => j.ToTable("ProductSize"));

            modelBuilder
               .Entity<Product>()
               .HasMany(p => p.ColorDBs)
               .WithMany(p => p.Products)
               .UsingEntity(j => j.ToTable("ColorDbProduct"));

            modelBuilder.Entity<Category>(entity => {
                entity.HasIndex(e => e.Name).IsUnique();
            });
        }

    }
}
