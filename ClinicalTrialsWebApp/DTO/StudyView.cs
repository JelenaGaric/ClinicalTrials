using System;
using System.Collections.Generic;
using Model;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.DTO
{
    public class StudyView
    {
        public int Id { get; set; }
        public string NCTId { get; set; }
        public string BriefTitle { get; set; }
        public List<string> Condition { get; set; }
        public string StudyType { get; set; }
        public List<Intervention> Intervention { get; set; }
        public string OverallStatus { get; set; }
        public string StudyFirstPostDate { get; set; }
        public string LastUpdateSubmitDate { get; set; }
        public List<Location> Location { get; set; }
        public string DetailedDescription { get; set; }
        public string LeadSponsorName { get; set; }
        public List<TagList> TagLists { get; set; }
    }
}
