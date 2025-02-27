﻿using EssentialOilsCapstone.Areas.Identity.Data;
using EssentialOilsCapstone.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialOilsCapstone.Data
{
    public class OilDbContext : IdentityDbContext<EssentialOilsCapstoneUser>
    {
        public DbSet<Oil> EssentialOils { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<OilProperty> OilProperty { get; set; }
        public DbSet<UserOil> UserOil { get; set; }
        public OilDbContext(DbContextOptions<OilDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OilProperty>().HasKey(ot => new { ot.OilId, ot.PropertyId });
            modelBuilder.Entity<UserOil>().HasKey(uo => new { uo.OilId, uo.UserId });

            base.OnModelCreating(modelBuilder);
        }

    }
}