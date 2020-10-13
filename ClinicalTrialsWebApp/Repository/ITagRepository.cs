using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Repository
{
    public interface ITagRepository : IRepositoryBase<Tag>
    {
        Task<IEnumerable<Tag>> GetAllTagsAsync();
        Task<Tag> GetTagByIdAsync(int Id);
        Task<Tag> GetTagWithDetailsAsync(long Id);
        void DeleteTag(Tag tag);

    }
}
