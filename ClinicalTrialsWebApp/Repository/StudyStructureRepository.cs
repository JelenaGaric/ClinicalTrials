using ClinicalTrialsWebApp.DTO;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Repository
{
    public class StudyStructureRepository : RepositoryBase<Root>, IStudyStructureRepository
    {
        public StudyStructureRepository(ClinicalTrialsContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Root>> GetAllStudiesAsync()
        {
            
            return await FindAll()
                .OrderBy(s => s.Id)
                .ToListAsync();
        }

        public async Task<Root> GetStudyByIdAsync(int studyId)
        {
            return await FindByCondition(s => s.Id.Equals(studyId))
                .FirstOrDefaultAsync();
        }

        public async Task<Root> GetStudyWithDetailsAsync(long studyId)
        {
            //not using this
            return await FindByCondition(s => s.Id.Equals(studyId))
                .FirstOrDefaultAsync();
        }


        IEnumerable<Root> IStudyStructureRepository.FindInsideConditionList(string toFind)
        {
            return RepositoryContext.Studies
                .Where(x => x.FullStudy.Study.DerivedSection.ConditionBrowseModule.ConditionMeshList
                    .ConditionMesh.Any(y => y.ConditionMeshTerm.ToLower().Contains(toFind.ToLower())))
                .ToList();
        }

        IEnumerable<Root> IStudyStructureRepository.FindInsideLocationList(string toFind)
        {
            return RepositoryContext.Studies
                .Where(x => x.FullStudy.Study.ProtocolSection.ContactsLocationsModule.LocationList
                    .Location.Any(y => y.LocationCountry.ToLower().Contains(toFind.ToLower())))
                .ToList();
        }

        IEnumerable<Root> IStudyStructureRepository.SimpleSearch(SearchDTO searchDTO)
        {
            IEnumerable<Root> retVal = new List<Root>();
           
            if (!String.IsNullOrEmpty(searchDTO.Condition))
            {
                retVal = RepositoryContext.Studies
                .Where(x => x.FullStudy.Study.DerivedSection.ConditionBrowseModule.ConditionMeshList
                    .ConditionMesh.Any(y => y.ConditionMeshTerm.ToLower().Contains(searchDTO.Condition.ToLower())));
            }
            if (!String.IsNullOrEmpty(searchDTO.Country))
            {
                if (retVal.Count() == 0)
                    retVal = RepositoryContext.Studies.Where(x => x.FullStudy.Study.ProtocolSection.ContactsLocationsModule.LocationList
                    .Location.Any(y => y.LocationCountry.ToLower().Contains(searchDTO.Country.ToLower())));
                else
                    retVal = retVal.Where(x => x.FullStudy.Study.ProtocolSection.ContactsLocationsModule != null
                    && x.FullStudy.Study.ProtocolSection.ContactsLocationsModule.LocationList != null
                    && x.FullStudy.Study.ProtocolSection.ContactsLocationsModule.LocationList.Location
                    .Any(y => y.LocationCountry.ToLower().Contains(searchDTO.Country.ToLower()))).ToList();
            }

            if (!String.IsNullOrEmpty(searchDTO.Sponsor))
            {
                if (retVal.Count() == 0)
                    retVal = RepositoryContext.Studies.Where(x => (x.FullStudy.Study.ProtocolSection.IdentificationModule.Organization.OrgFullName.ToLower())
                            .Contains(searchDTO.Sponsor.ToLower()));
                else
                    retVal = retVal.Where(x => (x.FullStudy.Study.ProtocolSection.IdentificationModule.Organization.OrgFullName.ToLower()).Contains(searchDTO.Sponsor.ToLower()));
            }
            

            return retVal;
        }
    }
}