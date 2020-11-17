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
            string[] directories = Directory.GetDirectories(@"D:\tmpp");


            using (var writer = new StreamWriter(@"D:\test.csv"))
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
                            //csvs.Add(MakeCsvClass(root));
                            csv.WriteRecord(MakeCsvClass(root));
                            csv.NextRecord();
                        }

                        //Console.WriteLine("Written study: " + root.FullStudy.Study.ProtocolSection.IdentificationModule?.NCTId);
                    }
                    csv.Flush();
                }
            }
            /*
            string[] directories = Directory.GetDirectories(@"D:\proba");

            foreach (string dir in directories)
            {
                string[] fileEntries = Directory.GetFiles(dir);
                foreach (string fileName in fileEntries)
                {
                    Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(File.ReadAllText(fileName));
                    studies.Add(myDeserializedClass);
                }
            }
            Console.WriteLine("as");

            List<StudyCsv> csvs = new List<StudyCsv>();
            foreach (Root r in studies)
            {
                StudyCsv csv = new StudyCsv();
                var protocol = r.FullStudy?.Study?.ProtocolSection;

                csv.NCTId = "" + protocol?.IdentificationModule?.NCTId;
                csv.BriefTitle = "" + protocol?.IdentificationModule?.BriefTitle;
                csvs.Add(csv);
            }

            using (var writer = new StreamWriter(@"D:\test.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteHeader(typeof(StudyCsv));
                foreach (StudyCsv s in csvs)
                {
                    csv.WriteRecord(Environment.NewLine);
                    csv.WriteRecord(s);
                    csv.Flush();

                }

            }*/
        }

        public static StudyCsv MakeCsvClass(Root r)
        {
            StudyCsv csv = new StudyCsv();
            csv.Rank = "" + r.FullStudy?.Rank;
            var protocol = r.FullStudy?.Study?.ProtocolSection;

            csv.NCTId = "" + protocol?.IdentificationModule?.NCTId;
            csv.BriefTitle = "" + protocol?.IdentificationModule?.BriefTitle;
            csv.OfficialTitle = "" + protocol?.IdentificationModule?.OfficialTitle;
            csv.Acronym = "" + protocol?.IdentificationModule?.Acronym;
            csv.OrgStudyId = "" + protocol?.IdentificationModule?.OrgStudyIdInfo?.OrgStudyId;
            csv.OrgFullName = "" + protocol?.IdentificationModule?.Organization?.OrgFullName;
            csv.OrgClass = "" + protocol?.IdentificationModule?.Organization?.OrgClass;

            csv.OversightHasDMC = "" + protocol?.OversightModule?.OversightHasDMC;
            csv.IsFDARegulatedDevice = "" + protocol?.OversightModule?.IsFDARegulatedDevice;
            csv.IsPPSD = "" + protocol?.OversightModule?.IsPPSD;
            csv.IsUSExport = "" + protocol?.OversightModule?.IsUSExport;
            csv.IsUnapprovedDevice = "" + protocol?.OversightModule?.IsUnapprovedDevice;
            csv.IsFDARegulatedDrug = "" + protocol?.OversightModule?.IsFDARegulatedDrug;

            csv.LeadSponsorName = "" + protocol?.SponsorCollaboratorsModule.LeadSponsor.LeadSponsorClass;
            csv.LeadSponsorClass = "" + protocol?.SponsorCollaboratorsModule.LeadSponsor.LeadSponsorClass;

            csv.OverallStatus = "" + protocol?.StatusModule.OverallStatus;
            csv.LastKnownStatus = "" + protocol?.StatusModule.LastKnownStatus;
            csv.WhyStopped = "" + protocol?.StatusModule.WhyStopped;

            csv.StudyType = "" + protocol?.DesignModule?.StudyType;
            csv.EnrollmentType = "" + protocol?.DesignModule?.EnrollmentInfo?.EnrollmentType;
            csv.EnrollmentCount = "" + protocol?.DesignModule?.EnrollmentInfo?.EnrollmentCount;
            //csv.Phase = "" + protocol?.DesignModule?.PhaseList.Phase;
            csv.HasExpandedAccess = "" + protocol?.StatusModule.ExpandedAccessInfo?.HasExpandedAccess;
            csv.ExpAccTypeIndividual = "" + protocol?.DesignModule?.ExpandedAccessTypes?.ExpAccTypeIndividual;
            csv.ExpAccTypeTreatment = "" + protocol?.DesignModule?.ExpandedAccessTypes?.ExpAccTypeTreatment;
            csv.ExpAccTypeIntermediate = "" + protocol?.DesignModule?.ExpandedAccessTypes?.ExpAccTypeIntermediate;
            csv.DesignAllocation = "" + protocol?.DesignModule?.DesignInfo?.DesignAllocation;
            csv.DesignInterventionModel = "" + protocol?.DesignModule?.DesignInfo?.DesignInterventionModel;
            csv.DesignInterventionModelDescription = "" + protocol?.DesignModule?.DesignInfo?.DesignInterventionModelDescription;
            csv.DesignPrimaryPurpose = "" + protocol?.DesignModule?.DesignInfo?.DesignPrimaryPurpose;
            csv.DesignMasking = "" + protocol?.DesignModule?.DesignInfo?.DesignMaskingInfo?.DesignMasking;
            csv.DesignMaskingDescription = "" + protocol?.DesignModule?.DesignInfo?.DesignMaskingInfo?.DesignMaskingDescription;
            csv.TargetDuration = "" + protocol?.DesignModule?.TargetDuration;
            csv.BioSpecRetention = "" + protocol?.DesignModule?.BioSpec?.BioSpecRetention;
            csv.BioSpecDescription = "" + protocol?.DesignModule?.BioSpec?.BioSpecDescription;
            csv.PatientRegistry = "" + protocol?.DesignModule?.PatientRegistry;

            csv.IPDSharing = "" + protocol?.IPDSharingStatementModule?.IPDSharing;
            csv.IPDSharingDescription = "" + protocol?.IPDSharingStatementModule?.IPDSharingDescription;

            csv.StudyFirstPostDate = "" + protocol?.StatusModule?.StudyFirstPostDateStruct?.StudyFirstPostDate;
            csv.StudyFirstPostDateType = "" + protocol?.StatusModule?.StudyFirstPostDateStruct?.StudyFirstPostDateType;
            csv.StudyFirstSubmitDate = "" + protocol?.StatusModule?.StudyFirstSubmitDate;
            csv.StudyFirstSubmitQCDate = "" + protocol?.StatusModule?.StudyFirstSubmitQCDate;

            csv.ResultsFirstPostDate = "" + protocol?.StatusModule.ResultsFirstPostDateStruct?.ResultsFirstPostDate;
            csv.ResultsFirstPostDateType = "" + protocol?.StatusModule.ResultsFirstPostDateStruct?.ResultsFirstPostDateType;
            csv.ResultsFirstSubmitDate = "" + protocol?.StatusModule?.ResultsFirstSubmitDate;
            csv.ResultsFirstSubmitQCDate = "" + protocol?.StatusModule?.ResultsFirstSubmitQCDate;

            csv.DispFirstPostDate = "" + protocol?.StatusModule?.DispFirstPostDateStruct?.DispFirstPostDate;
            csv.DispFirstPostDateType = "" + protocol?.StatusModule?.DispFirstPostDateStruct?.DispFirstPostDateType;
            csv.DispFirstSubmitDate = "" + protocol?.StatusModule?.DispFirstSubmitDate;
            csv.DispFirstSubmitQCDate = "" + protocol?.StatusModule?.DispFirstSubmitQCDate;

            csv.LastUpdatePostDate = "" + protocol?.StatusModule?.LastUpdatePostDateStruct?.LastUpdatePostDate;
            csv.LastUpdatePostDateType = "" + protocol?.StatusModule?.LastUpdatePostDateStruct?.LastUpdatePostDateType;
            csv.LastUpdateSubmitDate = "" + protocol?.StatusModule?.LastUpdateSubmitDate;

            csv.StartDate = "" + protocol?.StatusModule?.StartDateStruct?.StartDate;
            csv.StartDateType = "" + protocol?.StatusModule?.StartDateStruct?.StartDateType;

            csv.CompletionDate = "" + protocol?.StatusModule?.CompletionDateStruct?.CompletionDate;
            csv.CompletionDateType = "" + protocol?.StatusModule?.CompletionDateStruct?.CompletionDateType;


            csv.PrimaryCompletionDate = "" + protocol?.StatusModule?.PrimaryCompletionDateStruct?.PrimaryCompletionDate;
            csv.PrimaryCompletionDateType = "" + protocol?.StatusModule?.PrimaryCompletionDateStruct?.PrimaryCompletionDateType;

            csv.StatusVerifiedDate = "" + protocol?.StatusModule.StatusVerifiedDate;
            return csv;
            //csvs.Add(csv);
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
