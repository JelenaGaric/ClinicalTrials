﻿using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Model.Context
{

    public class ClinicalTrialsContext : DbContext
    {
        public DbSet<Root> Studies { get; set; }
        public DbSet<TagList> TagLists { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<StatisticsSearch> StatisticsSearches { get; set; }
        public DbSet<CityCoordinates> CityCoordinates { get; set; }
        public DbSet<ClinicalTrialJSON> JSONStudy { get; set; }

        public IConfiguration Configuration { get; }
        public string ConnectionString { get; }
        public ClinicalTrialsContext(IConfiguration configuration)
        {
            Configuration = configuration;
            Database.SetCommandTimeout((int)TimeSpan.FromMinutes(5).TotalSeconds);
        }

        public ClinicalTrialsContext() {
            ConnectionStringSettings settings =
               ConfigurationManager.ConnectionStrings["ClinicalTrialsConnection"];

            if (settings != null)
                ConnectionString = settings.ConnectionString;
            Console.WriteLine(ConnectionString + " connection string for model");

            Database.SetCommandTimeout((int)TimeSpan.FromMinutes(5).TotalSeconds);

        }

        public static readonly Microsoft.Extensions.Logging.LoggerFactory _myLoggerFactory =
            new LoggerFactory(new[] {
            new Microsoft.Extensions.Logging.Debug.DebugLoggerProvider()
            });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder
                    .UseLoggerFactory(_myLoggerFactory)  
                    .EnableSensitiveDataLogging()
                    .UseSqlServer(Configuration["ConnectionStrings:ClinicalTrialsConnection"]);
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

            modelBuilder.Entity<ArmGroupInterventionList>()
           .Property(e => e.ArmGroupInterventionName)
           .HasConversion(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<List<string>>(v));

            modelBuilder.Entity<DesignObservationalModelList>()
             .Property(e => e.DesignObservationalModel)
             .HasConversion(
                  v => JsonConvert.SerializeObject(v),
                  v => JsonConvert.DeserializeObject<List<string>>(v));

            modelBuilder.Entity<DesignTimePerspectiveList>()
             .Property(e => e.DesignTimePerspective)
             .HasConversion(
                  v => JsonConvert.SerializeObject(v),
                  v => JsonConvert.DeserializeObject<List<string>>(v));

            modelBuilder.Entity<DesignWhoMaskedList>()
             .Property(e => e.DesignWhoMasked)
             .HasConversion(
                  v => JsonConvert.SerializeObject(v),
                  v => JsonConvert.DeserializeObject<List<string>>(v));

            modelBuilder.Entity<KeywordList>()
             .Property(e => e.Keyword)
             .HasConversion(
                  v => JsonConvert.SerializeObject(v),
                  v => JsonConvert.DeserializeObject<List<string>>(v));

            modelBuilder.Entity<NCTIdAliasList>()
             .Property(e => e.NCTIdAlias)
             .HasConversion(
                  v => JsonConvert.SerializeObject(v),
                  v => JsonConvert.DeserializeObject<List<string>>(v));

            modelBuilder.Entity<OutcomeAnalysisGroupIdList>()
             .Property(e => e.OutcomeAnalysisGroupId)
             .HasConversion(
                  v => JsonConvert.SerializeObject(v),
                  v => JsonConvert.DeserializeObject<List<string>>(v));

            modelBuilder.Entity<RemovedCountryList>()
             .Property(e => e.RemovedCountry)
             .HasConversion(
                  v => JsonConvert.SerializeObject(v),
                  v => JsonConvert.DeserializeObject<List<string>>(v));


            modelBuilder.Entity<IPDSharingInfoTypeList>()
             .Property(e => e.IPDSharingInfoType)
             .HasConversion(
                  v => JsonConvert.SerializeObject(v),
                  v => JsonConvert.DeserializeObject<List<string>>(v));
        }
    }
}
