using ClinicalTrialsWebApp.DTO;
using ClinicalTrialsWebApp.Pagination;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Repository
{
    public interface IStudyStructureRepository : IRepositoryBase<Root>
    {
        Task<IEnumerable<Root>> GetAllStudiesAsync();
        Task<Root> GetStudyByIdAsync(int studyId);
        Task<StudyView> GetStudyWithDetailsAsync(int studyId);
        IEnumerable<Root> FindInsideConditionList(String toFind);
        IEnumerable<Root> FindInsideLocationList(String toFind);
        List<ResultDTO> SimpleSearch(PaginationFilter filter);
        int GetSearchCount(PaginationFilter filter);
        int[] SearchStudyIds(SearchDTO searchDTO);

    }
}