using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.DTO
{
    public class ResultDTO
    {
        public int Id { get; set; }
        public string BriefTitle { get; set; }
        public List<string> Condition { get; set; }
        public string OrgFullName { get; set; }
        public string BriefSummary { get; set; }
        public string EligibilityCriteria { get; set; }
        public string OverallStatus { get; set; }
        public string LastUpdateSubmitDate { get; set; }


    }
}
