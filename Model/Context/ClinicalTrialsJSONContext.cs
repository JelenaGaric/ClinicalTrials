using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Model.Context
{
    public class ClinicalTrialsJSONContext : DbContext
    {
        public DbSet<ClinicalTrialJSON> Study { get; set; }
        public string ConnectionString { get; }
        public IConfiguration Configuration { get; }
        public ClinicalTrialsJSONContext(IConfiguration configuration)
        {
            Configuration = configuration;
            Database.SetCommandTimeout((int)TimeSpan.FromMinutes(5).TotalSeconds);
        }
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
            try
            {
                if(ConnectionString == null) {
                    optionsBuilder
                        .UseSqlServer(Configuration["ConnectionStrings:ClinicalTrialsJSONConnection"]);
                } else
                    optionsBuilder.UseSqlServer(ConnectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }

    }
}
