using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Model.Context
{
    public class ClinicalTrialsJSONContext : DbContext
    {
        public DbSet<ClinicalTrialJSON> Study { get; set; }
        public string ConnectionString { get; }

        public ClinicalTrialsJSONContext()
        {
            ConnectionStringSettings settings =
               ConfigurationManager.ConnectionStrings["ClinicalTrialsJSONConnection"];

            if (settings != null)
                ConnectionString = settings.ConnectionString;
            Console.WriteLine(ConnectionString + " connection string for model");
            Database.SetCommandTimeout((int)TimeSpan.FromMinutes(5).TotalSeconds);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
            optionsBuilder.UseSqlServer(ConnectionString);
            optionsBuilder.UseLazyLoadingProxies();
        }

    }
}
