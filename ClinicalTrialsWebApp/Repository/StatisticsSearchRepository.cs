using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Repository
{
    public class StatisticsSearchRepository : RepositoryBase<StatisticsSearch>, IStatisticsSearchRepository
    {
        public StatisticsSearchRepository(ClinicalTrialsContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<StatisticsSearch>> GetAllStatisticsSearchesAsync()
        {
            return await FindAll()
                .OrderBy(s => s.Id)
                .ToListAsync();
        }

        public async Task<StatisticsSearch> GetStatisticsSearchByIdAsync(int Id)
        {
            return await FindByCondition(s => s.Id.Equals(Id))
                 .FirstOrDefaultAsync();
        }

        public string TrialsByYearsStatistics()
        {

            using (var command = RepositoryContext.Database.GetDbConnection().CreateCommand())
            {
                Console.WriteLine(RepositoryContext.Database.GetDbConnection());
                command.CommandText = "SELECT * from master.dbo.TRIALS_BY_YEAR_WITH_MESH_TERM ORDER BY NUM DESC FOR JSON AUTO;";
                command.CommandType = CommandType.Text;

                RepositoryContext.Database.OpenConnection();
                command.CommandTimeout = 120;
                command.Prepare();

                using (var result = command.ExecuteReader())
                {
                    string retVal = "";
                    while (result.Read())
                    {
                        retVal = result.GetString(0);
                    }

                    return retVal;
                }
            }

        }

        public string StudyTypeStatistics()
        {

            using (var command = RepositoryContext.Database.GetDbConnection().CreateCommand())
            {
                Console.WriteLine(RepositoryContext.Database.GetDbConnection());
                command.CommandText = "SELECT * FROM master.dbo.STUDY_TYPE_NUM_WITH_MESH_TERM ORDER BY NUM DESC FOR JSON AUTO";
                command.CommandType = CommandType.Text;

                RepositoryContext.Database.OpenConnection();
                command.CommandTimeout = 120;
                command.Prepare();

                using (var result = command.ExecuteReader())
                {
                    string retVal = "";
                    while (result.Read())
                    {
                        retVal = result.GetString(0);
                    }

                    return retVal;
                }
            }

        }

        public string StatusStatistics()
        {

            using (var command = RepositoryContext.Database.GetDbConnection().CreateCommand())
            {
                Console.WriteLine(RepositoryContext.Database.GetDbConnection());
                command.CommandText = "SELECT * FROM master.dbo.OVERALL_STATUS_WITH_MESH_TERM ORDER BY NUM DESC FOR JSON AUTO;";
                command.CommandType = CommandType.Text;

                RepositoryContext.Database.OpenConnection();
                command.CommandTimeout = 120;
                command.Prepare();

                using (var result = command.ExecuteReader())
                {
                    string retVal = "";
                    while (result.Read())
                    {
                        retVal = result.GetString(0);
                    }

                    return retVal;
                }
            }

        }

        public string PhaseListStatistics()
        {
          
            using (var command = RepositoryContext.Database.GetDbConnection().CreateCommand())
            {
                Console.WriteLine(RepositoryContext.Database.GetDbConnection());
                command.CommandText = "SELECT * FROM master.dbo.PHASE_WITH_MESH_TERM ORDER BY NUM DESC FOR JSON AUTO;";
                command.CommandType = CommandType.Text;

                RepositoryContext.Database.OpenConnection();
                command.CommandTimeout = 120;
                command.Prepare();

                using (var result = command.ExecuteReader())
                {
                    string retVal = "";
                    while (result.Read())
                    {
                        retVal = result.GetString(0);
                    }

                    return retVal;
                }
            }
            
        }

        public string LocationStatistics()
        {

            using (var command = RepositoryContext.Database.GetDbConnection().CreateCommand())
            {
                Console.WriteLine(RepositoryContext.Database.GetDbConnection());
                command.CommandText = "SELECT * FROM master.dbo.LOCATION_WITH_MESH_TERM ORDER BY NUM DESC FOR JSON AUTO;";
                command.CommandType = CommandType.Text;

                RepositoryContext.Database.OpenConnection();
                command.CommandTimeout = 120;
                command.Prepare();

                using (var result = command.ExecuteReader())
                {
                    string retVal = "";
                    while (result.Read())
                    {
                        retVal = result.GetString(0);
                    }

                    return retVal;
                }
            }
        }

        public string SponsorStatistics()
        {

            using (var command = RepositoryContext.Database.GetDbConnection().CreateCommand())
            {
                Console.WriteLine(RepositoryContext.Database.GetDbConnection());
                command.CommandText = "SELECT * FROM master.dbo.SPONSOR_WITH_MESH_TERM ORDER BY NUM DESC FOR JSON AUTO;";
                command.CommandType = CommandType.Text;

                RepositoryContext.Database.OpenConnection();
                command.CommandTimeout = 120;
                command.Prepare();

                using (var result = command.ExecuteReader())
                {
                    string retVal = "";
                    while (result.Read())
                    {
                        retVal = result.GetString(0);
                    }

                    return retVal;
                }
            }
        }

        public string DurationStatistics()
        {

            using (var command = RepositoryContext.Database.GetDbConnection().CreateCommand())
            {
                Console.WriteLine(RepositoryContext.Database.GetDbConnection());
                command.CommandText = "SELECT * FROM master.dbo.DURATION_WITH_MESH_TERM ORDER BY NUM DESC FOR JSON AUTO;";
                command.CommandType = CommandType.Text;

                RepositoryContext.Database.OpenConnection();
                command.CommandTimeout = 120;
                command.Prepare();

                using (var result = command.ExecuteReader())
                {
                    string retVal = "";
                    while (result.Read())
                    {
                        retVal = result.GetString(0);
                    }

                    return retVal;
                }
            }
        }
    }
}
