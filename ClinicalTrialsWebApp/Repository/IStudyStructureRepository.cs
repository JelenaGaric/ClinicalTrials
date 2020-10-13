using ClinicalTrialsWebApp.DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Repository
{
    public interface IStudyStructureRepository : IRepositoryBase<Root>
    {
        Task<IEnumerable<Root>> GetAllStudiesAsync();
        Task<Root> GetStudyByIdAsync(int studyId);
        Task<Root> GetStudyWithDetailsAsync(long studyId);
        public IEnumerable<Root> FindInsideConditionList(String toFind);
        public IEnumerable<Root> FindInsideLocationList(String toFind);
        IEnumerable<Root> SimpleSearch(SearchDTO searchDTO);

    }
}