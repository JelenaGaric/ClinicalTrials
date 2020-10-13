using Microsoft.EntityFrameworkCore;
using Model;
using Model.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Repository
{
    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(ClinicalTrialsContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Tag>> GetAllTagsAsync()
        {
            return await FindAll()
                .OrderBy(t => t.Id).Where(t => t.Deleted == false)
                .ToListAsync();
        }

        public async Task<Tag> GetTagByIdAsync(int Id)
        {
            return await FindByCondition(t => t.Id.Equals(Id) && t.Deleted == false)
                .FirstOrDefaultAsync();
        }

        public async Task<Tag> GetTagWithDetailsAsync(long Id)
        {
            //not using this
            return await FindByCondition(t => t.Id.Equals(Id) && t.Deleted == false)
                .FirstOrDefaultAsync();
        }

        public void DeleteTag(Tag tag)
        {
            if (!tag.Deleted)
            {
                tag.Deleted = true;
            }
        }

    }
}
