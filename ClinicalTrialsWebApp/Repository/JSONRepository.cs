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
    public class JSONRepository : ClinicalTrialsJSONRepository<ClinicalTrialJSON>, IJSONRepository
    {
        public JSONRepository(ClinicalTrialsJSONContext repositoryContext) : base(repositoryContext)
        {
        }
        public string FullTextTermSearch()
        {
            string sql = "SELECT [Id],[NCTId], [JSON]b FROM[ClinicalTrialsJSON].[dbo].[Study] WHERE contains([JSON], 'ophthalmology')";
            //ExecuteCommand("SELECT [Id],[NCTId], [JSON]b FROM[ClinicalTrialsJSON].[dbo].[Study] WHERE contains([JSON], 'ophthalmology') ");
            using (var command = RepositoryContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                RepositoryContext.Database.OpenConnection();
                command.CommandTimeout = 120;
                command.Prepare();

                using (var result = command.ExecuteReader())
                {
                    string retVal = "";
                    while (result.Read())
                    {
                        retVal += result.GetString(0);
                    }

                    Console.WriteLine(retVal);
                    return retVal;
                }
            }
        }
        public string ExecuteCommand(string sql)
        {
            using (var command = RepositoryContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                RepositoryContext.Database.OpenConnection();
                command.CommandTimeout = 120;
                command.Prepare();

                using (var result = command.ExecuteReader())
                {
                    string retVal = "";
                    while (result.Read())
                    {
                        retVal += result.GetString(0);
                    }

                    return retVal;
                }
            }
        }

        public async Task<IEnumerable<ClinicalTrialJSON>> GetAllTrialsAsync()
        {
            return await FindAll()
                .OrderBy(t => t.Id)
                .ToListAsync();
        }

        public async Task<ClinicalTrialJSON> GetTrialByIdAsync(int Id)
        {
            return await FindByCondition(t => t.Id.Equals(Id))
                .FirstOrDefaultAsync();
        }
    }
}
