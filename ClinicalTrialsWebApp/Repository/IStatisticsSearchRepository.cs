using ClinicalTrialsWebApp.DTO;
using Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Repository
{
    public interface IStatisticsSearchRepository : IRepositoryBase<StatisticsSearch>
    {
        Task<IEnumerable<StatisticsSearch>> GetAllStatisticsSearchesAsync();
        Task<StatisticsSearch> GetStatisticsSearchByIdAsync(int Id);
        string TrialsByYearsStatistics();
        string StudyTypeStatistics();
        string StatusStatistics();
        string PhaseListStatistics();
        string CountryStatistics(SearchDTO searchDTO);
        string LocationStatistics(SearchDTO searchDTO);
        string LocationFromViewStatistics();
        string SponsorStatistics();
        string DurationStatistics();
        string InterventionalStudiesStatistics();
        bool getRegression();
        string getStatsCsv(string type);
        string RunRScript(string rPath, string scriptPath);
        Task<string> GetLocationCitiesAsync();

    }
}

