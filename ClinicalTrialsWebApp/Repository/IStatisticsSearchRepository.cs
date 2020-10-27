using Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Repository
{
    public interface IStatisticsSearchRepository : IRepositoryBase<StatisticsSearch>
    {
        Task<IEnumerable<StatisticsSearch>> GetAllStatisticsSearchesAsync();
        Task<StatisticsSearch> GetStatisticsSearchByIdAsync(int Id);
        string RunStatistics();
    }
}

