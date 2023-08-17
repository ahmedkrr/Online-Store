﻿using Microsoft.EntityFrameworkCore;
using Online_Store.Domain.Config;

namespace Online_Store.Domain
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions option): base(option)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("Schema");

            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new SubCategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new ProudctOrderConfig());

        }
    }
    }
