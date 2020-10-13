using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Repository
{
    public interface ITagListRepository : IRepositoryBase<TagList>
    {
        Task<IEnumerable<TagList>> GetAllTagListsAsync();
        Task<TagList> GetTagListByIdAsync(int Id);
        Task<IEnumerable<TagList>> GetTagListByNCTIdAsync(string NCTId);
        Task<IEnumerable<TagList>> GetTagListByTagIdAsync(int TagId);
    }
}
