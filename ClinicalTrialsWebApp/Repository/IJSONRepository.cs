using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Repository
{
    public interface IJSONRepository : IClinicalTrialsJSONRepository<ClinicalTrialJSON>
    {
        Task<IEnumerable<ClinicalTrialJSON>> GetAllTrialsAsync();
        Task<ClinicalTrialJSON> GetTrialByIdAsync(int Id);

        string FullTextTermSearch();
    }
}
