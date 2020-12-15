using ClinicalTrialsWebApp.DTO;
using ClinicalTrialsWebApp.Pagination;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Repository
{
    public class StudyStructureRepository : RepositoryBase<Root>, IStudyStructureRepository
    {
        public StudyStructureRepository(ClinicalTrialsContext repositoryContext) : base(repositoryContext)
        {
        }
        public List<ResultDTO> FullTextTermSearch(PaginationFilter filter)
        {
            List<ResultDTO> retVal = new List<ResultDTO>();
            List<string> terms = new List<string>();
            terms.Add(filter.Condition);
            terms.Add(filter.Country);
            terms.Add(filter.Sponsor);

            //make a string which goes into sql expression
            string searchString = terms[0];
            for (int i = 1; i < terms.Count - 1; i++)
            {
                if (terms[i].Length != 0)
                    searchString += " or " + terms[i];

            }


            string sql = "SELECT [NCTId] FROM[ClinicalTrials].[dbo].[JSONStudy] WHERE contains([JSON], '" + searchString + "')" +
                " ORDER BY[Id] OFFSET " + (filter.PageNumber - 1) * filter.PageSize + " ROWS FETCH NEXT " + filter.PageSize + " ROWS ONLY";

            using (var command = RepositoryContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                RepositoryContext.Database.OpenConnection();
                command.CommandTimeout = 120;
                command.Prepare();

                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        Console.WriteLine("{0}", result.GetString(0));
                        
                        var study = FindByCondition
                            (x => x.FullStudy.Study.ProtocolSection.IdentificationModule.NCTId.Equals(result.GetString(0)))
                            .Select(x => new ResultDTO
                            {
                                Id = x.Id,
                                BriefTitle = x.FullStudy.Study.ProtocolSection.IdentificationModule.BriefTitle,
                                OrgFullName = x.FullStudy.Study.ProtocolSection.IdentificationModule.Organization.OrgFullName,
                                Condition = x.FullStudy.Study.ProtocolSection.ConditionsModule.ConditionList.Condition,
                                BriefSummary = x.FullStudy.Study.ProtocolSection.DescriptionModule.BriefSummary,
                                EligibilityCriteria = x.FullStudy.Study.ProtocolSection.EligibilityModule.EligibilityCriteria,
                                OverallStatus = x.FullStudy.Study.ProtocolSection.StatusModule.OverallStatus,
                                LastUpdateSubmitDate = x.FullStudy.Study.ProtocolSection.StatusModule.LastUpdateSubmitDate.ToString()
                            });

                        retVal.Add(study.FirstOrDefault());
                    }
                }
            }
            return retVal;
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

        public async Task<StudyView> GetStudyWithDetailsAsync(int studyId)
        {
            return await FindByCondition(s => s.Id.Equals(studyId))
                .Select(x => new StudyView
                {
                    Id = x.Id,
                    NCTId = x.FullStudy.Study.ProtocolSection.IdentificationModule.NCTId,
                    BriefTitle = x.FullStudy.Study.ProtocolSection.IdentificationModule.BriefTitle,
                    Condition = x.FullStudy.Study.ProtocolSection.ConditionsModule.ConditionList.Condition,
                    StudyType = x.FullStudy.Study.ProtocolSection.DesignModule.StudyType,
                    Intervention = x.FullStudy.Study.ProtocolSection.ArmsInterventionsModule.InterventionList.Intervention,
                    OverallStatus = x.FullStudy.Study.ProtocolSection.StatusModule.OverallStatus,
                    LastUpdateSubmitDate = x.FullStudy.Study.ProtocolSection.StatusModule.LastUpdateSubmitDate.ToString(),
                    StudyFirstPostDate = x.FullStudy.Study.ProtocolSection.StatusModule.StudyFirstSubmitDate.ToString(),
                    Location = x.FullStudy.Study.ProtocolSection.ContactsLocationsModule.LocationList.Location,
                    DetailedDescription = x.FullStudy.Study.ProtocolSection.DescriptionModule.DetailedDescription,
                    LeadSponsorName = x.FullStudy.Study.ProtocolSection.SponsorCollaboratorsModule.LeadSponsor.LeadSponsorName
                }).FirstOrDefaultAsync();
        }


        public IEnumerable<Root> FindInsideConditionList(string toFind)
        {
            return RepositoryContext.Studies
                .Where(x => x.FullStudy.Study.DerivedSection.ConditionBrowseModule.ConditionMeshList
                    .ConditionMesh.Any(y => y.ConditionMeshTerm.ToLower().Contains(toFind.ToLower())))
                .ToList();
        }

        public IEnumerable<Root> FindInsideLocationList(string toFind)
        {
            return RepositoryContext.Studies
                .Where(x => x.FullStudy.Study.ProtocolSection.ContactsLocationsModule.LocationList
                    .Location.Any(y => y.LocationCountry.ToLower().Contains(toFind.ToLower())))
                .ToList();
        }
        public int GetSearchCount(PaginationFilter filter)
        {
            return RepositoryContext.Studies
           .Where(x => x.FullStudy.Study.DerivedSection.ConditionBrowseModule.ConditionMeshList
           .ConditionMesh.Any(y => y.ConditionMeshTerm.ToLower().Contains(filter.Condition.ToLower()))
           && x.FullStudy.Study.ProtocolSection.ContactsLocationsModule.LocationList
               .Location.Any(y => y.LocationCountry.ToLower().Contains(filter.Country.ToLower()))
           && (x.FullStudy.Study.ProtocolSection.IdentificationModule.Organization.OrgFullName.ToLower())
                           .Contains(filter.Sponsor.ToLower())).Count();
        }

        public List<ResultDTO> SimpleSearch(PaginationFilter filter)
        {

            var retVal = RepositoryContext.Studies.AsNoTracking()
            .Where(x => x.FullStudy.Study.DerivedSection.ConditionBrowseModule.ConditionMeshList
            .ConditionMesh.Any(y => y.ConditionMeshTerm.ToLower().Contains(filter.Condition.ToLower())) 
            && x.FullStudy.Study.ProtocolSection.ContactsLocationsModule.LocationList
                .Location.Any(y => y.LocationCountry.ToLower().Contains(filter.Country.ToLower()))
            && (x.FullStudy.Study.ProtocolSection.IdentificationModule.Organization.OrgFullName.ToLower())
                            .Contains(filter.Sponsor.ToLower())).OrderBy(x => x.Id)
            .Skip((filter.PageNumber - 1) * filter.PageSize)
            .Take(filter.PageSize)
            .Select(x => new ResultDTO
            {
                Id = x.Id,
                BriefTitle = x.FullStudy.Study.ProtocolSection.IdentificationModule.BriefTitle,
                OrgFullName = x.FullStudy.Study.ProtocolSection.IdentificationModule.Organization.OrgFullName,
                Condition = x.FullStudy.Study.ProtocolSection.ConditionsModule.ConditionList.Condition,
                BriefSummary = x.FullStudy.Study.ProtocolSection.DescriptionModule.BriefSummary,
                EligibilityCriteria = x.FullStudy.Study.ProtocolSection.EligibilityModule.EligibilityCriteria,
                OverallStatus = x.FullStudy.Study.ProtocolSection.StatusModule.OverallStatus,
                LastUpdateSubmitDate = x.FullStudy.Study.ProtocolSection.StatusModule.LastUpdateSubmitDate.ToString()
            });
            
            return retVal.ToList();
        }

        public int[] SearchStudyIds(SearchDTO searchDTO)
        {
            return RepositoryContext.Studies.AsNoTracking()
               .Where(x => x.FullStudy.Study.DerivedSection.ConditionBrowseModule.ConditionMeshList
               .ConditionMesh.Any(y => y.ConditionMeshTerm.ToLower().Contains(searchDTO.Condition.ToLower()))
               && x.FullStudy.Study.ProtocolSection.ContactsLocationsModule.LocationList
                   .Location.Any(y => y.LocationCountry.ToLower().Contains(searchDTO.Country.ToLower()))
               && (x.FullStudy.Study.ProtocolSection.IdentificationModule.Organization.OrgFullName.ToLower())
                    .Contains(searchDTO.Sponsor.ToLower())).OrderBy(x => x.Id)
                    .Select(x => x.Id).ToArray();
        }

    }
}