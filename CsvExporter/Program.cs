using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Context;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Linq;
using CsvHelper;
using System.Globalization;

namespace CsvExporter
{
    class Program
    {
        static List<Root> studies = new List<Root>();

        static void Main(string[] args)
        {
            int i = 0;
            string[] directories = Directory.GetDirectories(@"C:\GitCode\ClinicalTrials\Дата");
            using (var writer = new StreamWriter(@"C:\GitCode\ClinicalTirialsOut\test.csv"))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteHeader<StudyCsv>();
                    csv.NextRecord();
                    foreach (string dir in directories)
                    {
                        string[] fileEntries = Directory.GetFiles(dir);
                        foreach (string fileName in fileEntries)
                        {
                            Root root = JsonConvert.DeserializeObject<Root>(File.ReadAllText(fileName));
                            csv.WriteRecord(MakeCsvClass(root));
                            csv.NextRecord();
                            i++;
                        }
                        //csv.Flush();
                        Console.WriteLine(i);
                    }
                }
            }
        }

        public static StudyCsv MakeCsvClass(Root r)
        {
            StudyCsv csv = new StudyCsv();
            csv.Rank = "" + r.FullStudy?.Rank;
            var protocol = r.FullStudy?.Study?.ProtocolSection;

            var idModule = protocol?.IdentificationModule;

            csv.NCTId = "" + idModule?.NCTId;
            csv.BriefTitle = "" + idModule?.BriefTitle?.Replace("\n", ";");
            csv.OfficialTitle = "" + idModule?.OfficialTitle?.Replace("\n", ";");
            csv.Acronym = "" + idModule?.Acronym?.Replace("\n", ";");
            csv.OrgStudyId = "" + idModule?.OrgStudyIdInfo?.OrgStudyId?.Replace("\n", ";");
            csv.OrgFullName = "" + idModule?.Organization?.OrgFullName?.Replace("\n", ";");
            csv.OrgClass = "" + idModule?.Organization?.OrgClass?.Replace("\n", ";");

            var oversightModule = protocol?.OversightModule;
            csv.OversightHasDMC = "" + oversightModule?.OversightHasDMC?.Replace("\n", ";");
            csv.IsFDARegulatedDevice = "" + oversightModule?.IsFDARegulatedDevice?.Replace("\n", ";");
            csv.IsPPSD = "" + oversightModule?.IsPPSD?.Replace("\n", ";");
            csv.IsUSExport = "" + oversightModule?.IsUSExport?.Replace("\n", ";");
            csv.IsUnapprovedDevice = "" + oversightModule?.IsUnapprovedDevice?.Replace("\n", ";");
            csv.IsFDARegulatedDrug = "" + oversightModule?.IsFDARegulatedDrug?.Replace("\n", ";");

            csv.LeadSponsorName = "" + protocol?.SponsorCollaboratorsModule.LeadSponsor.LeadSponsorClass?.Replace("\n", ";");
            csv.LeadSponsorClass = "" + protocol?.SponsorCollaboratorsModule.LeadSponsor.LeadSponsorClass?.Replace("\n", ";");

            

            var desModule = protocol?.DesignModule;
            csv.StudyType = "" + desModule?.StudyType?.Replace("\n", ";");
            csv.EnrollmentType = "" + desModule?.EnrollmentInfo?.EnrollmentType?.Replace("\n", ";");
            csv.EnrollmentCount = "" + desModule?.EnrollmentInfo?.EnrollmentCount?.Replace("\n", ";");
            //csv.Phase = "" + desModule?.PhaseList.Phase?.Replace("\n", ";");
            
            csv.ExpAccTypeIndividual = "" + desModule?.ExpandedAccessTypes?.ExpAccTypeIndividual?.Replace("\n", ";");
            csv.ExpAccTypeTreatment = "" + desModule?.ExpandedAccessTypes?.ExpAccTypeTreatment?.Replace("\n", ";");
            csv.ExpAccTypeIntermediate = "" + desModule?.ExpandedAccessTypes?.ExpAccTypeIntermediate?.Replace("\n", ";");
            csv.DesignAllocation = "" + desModule?.DesignInfo?.DesignAllocation?.Replace("\n", ";");
            csv.DesignInterventionModel = "" + desModule?.DesignInfo?.DesignInterventionModel?.Replace("\n", ";");
            csv.DesignInterventionModelDescription = "" + desModule?.DesignInfo?.DesignInterventionModelDescription?.Replace("\n", ";");
            csv.DesignPrimaryPurpose = "" + desModule?.DesignInfo?.DesignPrimaryPurpose?.Replace("\n", ";");
            csv.DesignMasking = "" + desModule?.DesignInfo?.DesignMaskingInfo?.DesignMasking?.Replace("\n", ";");
            csv.DesignMaskingDescription = "" + desModule?.DesignInfo?.DesignMaskingInfo?.DesignMaskingDescription?.Replace("\n", ";");
            csv.TargetDuration = "" + desModule?.TargetDuration?.Replace("\n", ";");
            csv.BioSpecRetention = "" + desModule?.BioSpec?.BioSpecRetention?.Replace("\n", ";");
            csv.BioSpecDescription = "" + desModule?.BioSpec?.BioSpecDescription?.Replace("\n", ";");
            csv.PatientRegistry = "" + desModule?.PatientRegistry?.Replace("\n", ";");

            csv.IPDSharing = "" + protocol?.IPDSharingStatementModule?.IPDSharing?.Replace("\n", ";");
            csv.IPDSharingDescription = "" + protocol?.IPDSharingStatementModule?.IPDSharingDescription?.Replace("\n", ";");

            var staModule = protocol?.StatusModule;

            csv.OverallStatus = "" + staModule.OverallStatus?.Replace("\n", ";");
            csv.LastKnownStatus = "" + staModule.LastKnownStatus?.Replace("\n", ";");
            csv.WhyStopped = "" + staModule.WhyStopped?.Replace("\n", ";");
            csv.HasExpandedAccess = "" + staModule.ExpandedAccessInfo?.HasExpandedAccess?.Replace("\n", ";");
            csv.StudyFirstPostDate = "" + staModule?.StudyFirstPostDateStruct?.StudyFirstPostDate?.Replace("\n", ";");
            csv.StudyFirstPostDateType = "" + staModule?.StudyFirstPostDateStruct?.StudyFirstPostDateType?.Replace("\n", ";");
            csv.StudyFirstSubmitDate = "" + staModule?.StudyFirstSubmitDate;
            csv.StudyFirstSubmitQCDate = "" + staModule?.StudyFirstSubmitQCDate?.Replace("\n", ";");

            csv.ResultsFirstPostDate = "" + staModule.ResultsFirstPostDateStruct?.ResultsFirstPostDate?.Replace("\n", ";");
            csv.ResultsFirstPostDateType = "" + staModule.ResultsFirstPostDateStruct?.ResultsFirstPostDateType?.Replace("\n", ";");
            csv.ResultsFirstSubmitDate = "" + staModule?.ResultsFirstSubmitDate;
            csv.ResultsFirstSubmitQCDate = "" + staModule?.ResultsFirstSubmitQCDate?.Replace("\n", ";");

            csv.DispFirstPostDate = "" + staModule?.DispFirstPostDateStruct?.DispFirstPostDate?.Replace("\n", ";");
            csv.DispFirstPostDateType = "" + staModule?.DispFirstPostDateStruct?.DispFirstPostDateType?.Replace("\n", ";");
            csv.DispFirstSubmitDate = "" + staModule?.DispFirstSubmitDate?.Replace("\n", ";");
            csv.DispFirstSubmitQCDate = "" + staModule?.DispFirstSubmitQCDate?.Replace("\n", ";");

            csv.LastUpdatePostDate = "" + staModule?.LastUpdatePostDateStruct?.LastUpdatePostDate?.Replace("\n", ";");
            csv.LastUpdatePostDateType = "" + staModule?.LastUpdatePostDateStruct?.LastUpdatePostDateType?.Replace("\n", ";");
            csv.LastUpdateSubmitDate = "" + staModule?.LastUpdateSubmitDate;

            csv.StartDate = "" + staModule?.StartDateStruct?.StartDate?.Replace("\n", ";");
            csv.StartDateType = "" + staModule?.StartDateStruct?.StartDateType?.Replace("\n", ";");

            csv.CompletionDate = "" + staModule?.CompletionDateStruct?.CompletionDate?.Replace("\n", ";");
            csv.CompletionDateType = "" + staModule?.CompletionDateStruct?.CompletionDateType?.Replace("\n", ";");


            csv.PrimaryCompletionDate = "" + staModule?.PrimaryCompletionDateStruct?.PrimaryCompletionDate?.Replace("\n", ";");
            csv.PrimaryCompletionDateType = "" + staModule?.PrimaryCompletionDateStruct?.PrimaryCompletionDateType?.Replace("\n", ";");

            csv.StatusVerifiedDate = "" + staModule.StatusVerifiedDate?.Replace("\n", ";");
            return csv;
        }
    }
   

    public class StudyCsv
    {
        public string Rank { get; set; }

        public string NCTId { get; set; }

        public string BriefTitle { get; set; }
        public string OfficialTitle { get; set; }
        public string Acronym { get; set; }
        public string OrgStudyId { get; set; }
        /*public string SecondaryId { get; set; }
        public string SecondaryIdType { get; set; }
        public string SecondaryIdLink { get; set; }*/
        public string OrgFullName { get; set; }
        public string OrgClass { get; set; }
        //public List<string> NCTIdAlias { get; set; }

        public string OversightHasDMC { get; set; }
        public string IsFDARegulatedDrug { get; set; }
        public string IsFDARegulatedDevice { get; set; }
        public string IsUnapprovedDevice { get; set; }
        public string IsPPSD { get; set; }
        public string IsUSExport { get; set; }

        public string LeadSponsorName { get; set; }
        public string LeadSponsorClass { get; set; }

        public string OverallStatus { get; set; }
        public string LastKnownStatus { get; set; }
        public string WhyStopped { get; set; }

        //public List<string> Phase { get; set; }

        public string StudyType { get; set; }

        public string EnrollmentType { get; set; }
        public string EnrollmentCount { get; set; }

        public string HasExpandedAccess { get; set; }
        public string ExpAccTypeIndividual { get; set; }

        public string ExpAccTypeIntermediate { get; set; }
        public string ExpAccTypeTreatment { get; set; }
        public string DesignAllocation { get; set; }
        public string DesignInterventionModel { get; set; }
        public string DesignInterventionModelDescription { get; set; }
        public string DesignPrimaryPurpose { get; set; }
        public string DesignMasking { get; set; }
        public string DesignMaskingDescription { get; set; }
        public string TargetDuration { get; set; }

        public string BioSpecRetention { get; set; }
        public string BioSpecDescription { get; set; }
        public string PatientRegistry { get; set; }

        public string IPDSharing { get; set; }
        public string IPDSharingDescription { get; set; }

        public string StudyFirstSubmitDate { get; set; }
        public string StudyFirstSubmitQCDate { get; set; }
        public string StudyFirstPostDate { get; set; }
        public string StudyFirstPostDateType { get; set; }
        public string ResultsFirstPostDate { get; set; }
        public string ResultsFirstPostDateType { get; set; }
        public string ResultsFirstSubmitDate { get; set; }
        public string ResultsFirstSubmitQCDate { get; set; }

        public string DispFirstSubmitDate { get; set; }
        public string DispFirstSubmitQCDate { get; set; }
        public string DispFirstPostDate { get; set; }
        public string DispFirstPostDateType { get; set; }

        public string LastUpdateSubmitDate { get; set; }
        public string LastUpdatePostDate { get; set; }
        public string LastUpdatePostDateType { get; set; }

        public string StartDate { get; set; }
        public string StartDateType { get; set; }

        public string CompletionDate { get; set; }
        public string CompletionDateType { get; set; }
        public string PrimaryCompletionDate { get; set; }
        public string PrimaryCompletionDateType { get; set; }
        public string StatusVerifiedDate { get; set; }

    }

}
