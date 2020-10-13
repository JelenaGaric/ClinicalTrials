﻿using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Model.Context
{

    public class ClinicalTrialsContext : DbContext
    {
        public DbSet<Root> Studies { get; set; }
        public DbSet<TagList> TagLists { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public IConfiguration Configuration { get; }
        public string ConnectionString { get; }
        public ClinicalTrialsContext(IConfiguration configuration)
        {
            Configuration = configuration;
            Database.SetCommandTimeout((int)TimeSpan.FromMinutes(5).TotalSeconds);
        }

        public ClinicalTrialsContext(string connectionString)
        {
            ConnectionString = connectionString;
            Database.SetCommandTimeout((int)TimeSpan.FromMinutes(5).TotalSeconds);
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlServer(Configuration["ConnectionStrings:ClinicalTrialsConnection"]);
            } catch(Exception e)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConditionList>()
            .Property(e => e.Condition)
            .HasConversion(
                 v => JsonConvert.SerializeObject(v),
                 v => JsonConvert.DeserializeObject<List<string>>(v));

            modelBuilder.Entity<PhaseList>()
            .Property(e => e.Phase)
            .HasConversion(
                 v => JsonConvert.SerializeObject(v),
                 v => JsonConvert.DeserializeObject<List<string>>(v));

            modelBuilder.Entity<StdAgeList>()
            .Property(e => e.StdAge)
            .HasConversion(
                 v => JsonConvert.SerializeObject(v),
                 v => JsonConvert.DeserializeObject<List<string>>(v));
        }
    }
}