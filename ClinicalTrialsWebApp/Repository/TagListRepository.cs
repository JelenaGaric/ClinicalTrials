using Microsoft.EntityFrameworkCore;
using Model;
using Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Repository
{
    public class TagListRepository : RepositoryBase<TagList>, ITagListRepository
    {
        public TagListRepository(ClinicalTrialsContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<TagList>> GetAllTagListsAsync()
        {
            return await FindAll()
                .OrderBy(t => t.Id)
                .ToListAsync();
        }

        public async Task<TagList> GetTagListByIdAsync(int Id)
        {
            return await FindByCondition(t => t.Id.Equals(Id))
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TagList>> GetTagListByNCTIdAsync(string NCTId)
        {
            return await FindByCondition(t => t.NCTId.Equals(NCTId))
                .ToListAsync();
        }

        public async Task<IEnumerable<TagList>> GetTagListByTagIdAsync(int TagId)
        {
            return await FindByCondition(t => t.TagId.Equals(TagId))
                .ToListAsync();
        }

        public async Task<TagList> GetTagWithDetailsAsync(long Id)
        {
            //not using this
            return await FindByCondition(s => s.Id.Equals(Id))
                .FirstOrDefaultAsync();
        }

    }
}
