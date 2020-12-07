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
            string[] directories = Directory.GetDirectories(@"C:\Users\Dedo iz Njemačke\Desktop\Posao\tmp\test\AllAPIJSON");
            using (var writer = new StreamWriter(@"C:\Users\Dedo iz Njemačke\Desktop\Posao\tmp\test.csv"))
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
            List<string> secondaryIds = new List<string>();
            List<string> NCTIdAliases = new List<string>();
            List<string> colNames = new List<string>();
            List<string> colClasses = new List<string>();

           
            csv.NCTId = "" + idModule?.NCTId;
            csv.BriefTitle = "" + idModule?.BriefTitle?.Replace("\n", ";");
            csv.OfficialTitle = "" + idModule?.OfficialTitle?.Replace("\n", ";");
            csv.Acronym = "" + idModule?.Acronym;
            csv.OrgStudyId = "" + idModule?.OrgStudyIdInfo?.OrgStudyId?.Replace("\n", ";");
            csv.OrgFullName = "" + idModule?.Organization?.OrgFullName?.Replace("\n", ";");
            csv.OrgClass = "" + idModule?.Organization?.OrgClass?.Replace("\n", ";");

             if (idModule?.SecondaryIdInfoList?.SecondaryIdInfo != null)
             {
                foreach (SecondaryIdInfo t in idModule?.SecondaryIdInfoList?.SecondaryIdInfo)
                {
                    secondaryIds.Add("SecondaryId=" + t.SecondaryId + "|SecondaryIdType=" + t.SecondaryIdType + "|SecondaryIdLink=" + t.SecondaryIdLink);
                }
                csv.SecondaryIdInfoList = string.Join(";", secondaryIds);
             }
            
             if (idModule?.NCTIdAliasList?.NCTIdAlias != null)
             {
                 foreach (var t in idModule?.NCTIdAliasList.NCTIdAlias)
                 {
                     NCTIdAliases.Add(t);
                 }
                 csv.NCTIdAliasList = string.Join(",", NCTIdAliases);
             }

             var oversightModule = protocol?.OversightModule;
             csv.OversightHasDMC = "" + oversightModule?.OversightHasDMC?.Replace("\n", ";");
             csv.IsFDARegulatedDevice = "" + oversightModule?.IsFDARegulatedDevice?.Replace("\n", ";");
             csv.IsPPSD = "" + oversightModule?.IsPPSD?.Replace("\n", ";");
             csv.IsUSExport = "" + oversightModule?.IsUSExport?.Replace("\n", ";");
             csv.IsUnapprovedDevice = "" + oversightModule?.IsUnapprovedDevice?.Replace("\n", ";");
             csv.IsFDARegulatedDrug = "" + oversightModule?.IsFDARegulatedDrug?.Replace("\n", ";");

             csv.LeadSponsorName = "" + protocol?.SponsorCollaboratorsModule.LeadSponsor.LeadSponsorName?.Replace("\n", ";");
             csv.LeadSponsorClass = "" + protocol?.SponsorCollaboratorsModule.LeadSponsor.LeadSponsorClass?.Replace("\n", ";");



             var desModule = protocol?.DesignModule;
             csv.StudyType = "" + desModule?.StudyType?.Replace("\n", ";");
             csv.EnrollmentType = "" + desModule?.EnrollmentInfo?.EnrollmentType?.Replace("\n", ";");
             csv.EnrollmentCount = "" + desModule?.EnrollmentInfo?.EnrollmentCount?.Replace("\n", ";");

             if (desModule?.DesignInfo?.DesignObservationalModelList?.DesignObservationalModel != null)
                 csv.DesignObservationalModelList = string.Join(",", desModule?.DesignInfo?.DesignObservationalModelList?.DesignObservationalModel);
             if (desModule?.DesignInfo?.DesignTimePerspectiveList?.DesignTimePerspective != null)
                 csv.DesignTimePerspective = string.Join(",", desModule?.DesignInfo?.DesignTimePerspectiveList?.DesignTimePerspective);

             List<string> phases = new List<string>();
             if (desModule?.PhaseList != null)
             {
                 foreach (var p in desModule.PhaseList.Phase)
                 {
                     phases.Add(p);
                 }
                 csv.PhaseList = string.Join(",", phases);
             }

             csv.ExpAccTypeIndividual = "" + desModule?.ExpandedAccessTypes?.ExpAccTypeIndividual?.Replace("\n", ";");
             csv.ExpAccTypeTreatment = "" + desModule?.ExpandedAccessTypes?.ExpAccTypeTreatment?.Replace("\n", ";");
             csv.ExpAccTypeIntermediate = "" + desModule?.ExpandedAccessTypes?.ExpAccTypeIntermediate?.Replace("\n", ";");
             csv.DesignAllocation = "" + desModule?.DesignInfo?.DesignAllocation?.Replace("\n", ";");
             csv.DesignInterventionModel = "" + desModule?.DesignInfo?.DesignInterventionModel?.Replace("\n", ";");
             csv.DesignInterventionModelDescription = "" + desModule?.DesignInfo?.DesignInterventionModelDescription?.Replace("\n", ";");
             csv.DesignPrimaryPurpose = "" + desModule?.DesignInfo?.DesignPrimaryPurpose?.Replace("\n", ";");
             csv.DesignMasking = "" + desModule?.DesignInfo?.DesignMaskingInfo?.DesignMasking?.Replace("\n", ";");
             csv.DesignMaskingDescription = "" + desModule?.DesignInfo?.DesignMaskingInfo?.DesignMaskingDescription?.Replace("\n", ";");
             if (desModule?.DesignInfo?.DesignMaskingInfo?.DesignWhoMaskedList != null)
                 csv.DesignWhoMasked = string.Join(",", desModule?.DesignInfo?.DesignMaskingInfo?.DesignWhoMaskedList.DesignWhoMasked);

             csv.TargetDuration = "" + desModule?.TargetDuration?.Replace("\n", ";");
             csv.BioSpecRetention = "" + desModule?.BioSpec?.BioSpecRetention?.Replace("\n", ";");
             csv.BioSpecDescription = "" + desModule?.BioSpec?.BioSpecDescription?.Replace("\n", ";");
             csv.PatientRegistry = "" + desModule?.PatientRegistry?.Replace("\n", ";");

             csv.IPDSharing = "" + protocol?.IPDSharingStatementModule?.IPDSharing?.Replace("\n", ";");
             csv.IPDSharingDescription = "" + protocol?.IPDSharingStatementModule?.IPDSharingDescription?.Replace("\n", ";");
             csv.IPDSharingAccessCriteria = "" + protocol?.IPDSharingStatementModule?.IPDSharingAccessCriteria?.Replace("\n", ";");
             csv.IPDSharingURL = "" + protocol?.IPDSharingStatementModule?.IPDSharingURL?.Replace("\n", ";");

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

             csv.StatusVerifiedDate = "" + staModule?.StatusVerifiedDate?.Replace("\n", ";");
             csv.ExpandedAccessNCTId = "" + staModule?.ExpandedAccessInfo?.ExpandedAccessNCTId?.Replace("\n", ";");
             csv.ExpandedAccessStatusForNCTId = "" + staModule?.ExpandedAccessInfo?.ExpandedAccessStatusForNCTId?.Replace("\n", ";");
             csv.DelayedPosting = "" + staModule?.DelayedPosting;
            
             var colModule = protocol?.SponsorCollaboratorsModule; ;

             csv.ResponsiblePartyInvestigatorTitle = "" + colModule?.ResponsibleParty?.ResponsiblePartyInvestigatorTitle?.Replace("\n", ";");
             csv.ResponsiblePartyInvestigatorFullName = "" + colModule?.ResponsibleParty?.ResponsiblePartyInvestigatorFullName?.Replace("\n", ";");
             csv.ResponsiblePartyType = "" + colModule?.ResponsibleParty?.ResponsiblePartyType?.Replace("\n", ";");
             csv.ResponsiblePartyOldNameTitle = "" + colModule?.ResponsibleParty?.ResponsiblePartyOldNameTitle?.Replace("\n", ";");
             csv.ResponsiblePartyOldOrganization = "" + colModule?.ResponsibleParty?.ResponsiblePartyOldOrganization?.Replace("\n", ";");
             

            if (colModule?.CollaboratorList != null)
            {
                foreach (Collaborator c in colModule?.CollaboratorList?.Collaborator)
                {
                    colNames.Add(c.CollaboratorName);
                    colClasses.Add(c.CollaboratorClass);
                }

                csv.CollaboratorNames = string.Join(",", colNames);
                csv.CollaboratorClasses = string.Join(",", colClasses);
            }
            
            
         
            var conditionsModule = protocol?.ConditionsModule;
            List<string> conditions = new List<string>();

            if (conditionsModule?.ConditionList != null)
            {
                foreach (var c in conditionsModule?.ConditionList.Condition)
                {
                    conditions.Add(c);
                }

                csv.ConditionList = string.Join(",", conditions);
            }

            List<string> keywords = new List<string>();

            if (conditionsModule?.KeywordList != null)
            {
                foreach (var c in conditionsModule?.KeywordList.Keyword)
                {
                    keywords.Add(c);
                }

                csv.KeywordList = string.Join(",", keywords);
            }

            var descModule = protocol?.DescriptionModule;
            csv.BriefSummary = "" + descModule?.BriefSummary?.Replace("\n", ";");
            //csv.DetailedDescription = "" + descModule?.DetailedDescription?.Replace("\n", ";");

            var armsIntModule = protocol?.ArmsInterventionsModule;
            List<string> interventions = new List<string>();
            List<string> arms = new List<string>();
            string armGroupInterventionNames = "";

            if (armsIntModule?.InterventionList != null)
            {
                foreach (Intervention i in armsIntModule?.InterventionList.Intervention)
                {
                    interventions.Add("InterventionName=" + i.InterventionName + "|InterventionType=" + i.InterventionType);
                }
                csv.InterventionList = string.Join(";", interventions);
            }
            if (armsIntModule?.ArmGroupList != null)
            {
                foreach (ArmGroup a in armsIntModule?.ArmGroupList.ArmGroup)
                {
                    if (a.ArmGroupInterventionList?.ArmGroupInterventionName != null)
                        armGroupInterventionNames = string.Join(",", a.ArmGroupInterventionList?.ArmGroupInterventionName);

                    arms.Add("ArmGroupLabel=" + a.ArmGroupLabel + "|ArmGroupType" + a.ArmGroupType + "|ArmGroupDescription=" + a.ArmGroupDescription 
                        + "|ArmGroupInterventionNameList=" + string.Join(",", armGroupInterventionNames));
                }
                csv.ArmGroupList = string.Join(";", arms);
            }

            var outcomesModule = protocol?.OutcomesModule;

            List<string> primaryOutcomes = new List<string>();
            List<string> secondaryOutcomes = new List<string>();
            List<string> otherOutcomes = new List<string>();

            if (outcomesModule != null)
            {
                if(outcomesModule?.PrimaryOutcomeList?.PrimaryOutcome != null)
                {

                    foreach (PrimaryOutcome p in outcomesModule?.PrimaryOutcomeList?.PrimaryOutcome)
                    {
                        primaryOutcomes.Add(p.PrimaryOutcomeMeasure?.Replace("\n", " ") +
                            "|" + p.PrimaryOutcomeDescription?.Replace("\n", " ") + "|" + p.PrimaryOutcomeTimeFrame?.Replace("\n", " "));
                    }
                    csv.PrimaryOutcomeList = string.Join(";", primaryOutcomes);

                }
                if (outcomesModule.SecondaryOutcomeList != null)
                {
                    foreach (SecondaryOutcome s in outcomesModule?.SecondaryOutcomeList?.SecondaryOutcome)
                    {
                        secondaryOutcomes.Add(s.SecondaryOutcomeMeasure?.Replace("\n", " ") +
                            "|" + s.SecondaryOutcomeDescription?.Replace("\n", " ") + "|" + s.SecondaryOutcomeTimeFrame?.Replace("\n", " "));
                    }
                    csv.SecondaryOutcomeList = string.Join(";", secondaryOutcomes);
                }

                if (outcomesModule.OtherOutcomeList != null)
                {
                    foreach (OtherOutcome o in outcomesModule?.OtherOutcomeList.OtherOutcome)
                    {
                        otherOutcomes.Add(o.OtherOutcomeMeasure?.Replace("\n", " ") +
                            "|" + o.OtherOutcomeDescription?.Replace("\n", " ") + "|" + o.OtherOutcomeTimeFrame?.Replace("\n", " "));
                    }
                    csv.OtherOutcomeList = string.Join(";", secondaryOutcomes);
                }
            }

            var eligibilityModule = protocol?.EligibilityModule;
            csv.EligibilityCriteria = "" + eligibilityModule?.EligibilityCriteria?.Replace("\n", ";");
            csv.HealthyVolunteers = "" + eligibilityModule?.HealthyVolunteers?.Replace("\n", ";");
            csv.Gender = "" + eligibilityModule?.Gender?.Replace("\n", ";");
            csv.MinimumAge = "" + eligibilityModule?.MinimumAge?.Replace("\n", ";");
            csv.MaximumAge = "" + eligibilityModule?.MaximumAge?.Replace("\n", ";");
            csv.GenderBased = "" + eligibilityModule?.GenderBased?.Replace("\n", ";");
            csv.GenderDescription = "" + eligibilityModule?.GenderDescription?.Replace("\n", ";");
            csv.StudyPopulation = "" + eligibilityModule?.StudyPopulation?.Replace("\n", ";");
            csv.SamplingMethod = "" + eligibilityModule?.SamplingMethod?.Replace("\n", ";");
            if (eligibilityModule?.StdAgeList != null)
                csv.StdAgeList = string.Join(",", eligibilityModule?.StdAgeList.StdAge);

            var contactsLocationModule = protocol?.ContactsLocationsModule;

            List<string> locations = new List<string>();
            List<string> locationContacts = new List<string>();

            if (contactsLocationModule?.LocationList != null)
            {
                foreach (Location l in contactsLocationModule?.LocationList?.Location)
                {
                    if(l.LocationContactList?.LocationContact != null) { 
                        foreach(LocationContact lc in l.LocationContactList?.LocationContact)
                        {
                            locationContacts.Add("LocationContactName" + lc.LocationContactName + " - LocationContactRole=" + lc.LocationContactRole + " - LocationContactEMail=" + lc.LocationContactEMail
                                + " - LocationContactPhone=" + lc.LocationContactPhone + " - LocationContactPhoneExt=" + lc.LocationContactPhoneExt);
                        }
                    }
                    locations.Add("LocationFacility=" + l.LocationFacility + "|LocationCity=" + l.LocationCity?.Replace("\n", " ") +
                        "|LocationState=" + l.LocationState?.Replace("\n", " ") +
                        "|LocationCountry=" + l.LocationCountry?.Replace("\n", " ") +
                        "|LocationStatus=" + l.LocationStatus?.Replace("\n", " ") + "|LocationZip=" +
                        l.LocationZip?.Replace("\n", " ")
                        + "|LocationContactList=" + string.Join(",", locationContacts));
                }
                csv.LocationList = string.Join(";", locations);
            }

            List<string> centralContacts = new List<string>();

            if (contactsLocationModule?.CentralContactList != null)
            {
                foreach (CentralContact c in contactsLocationModule?.CentralContactList?.CentralContact)
                {
                    centralContacts.Add("CentralContactName=" + c.CentralContactName + "|CentralContactEMail=" + c.CentralContactEMail + "|CentralContactPhone=" + c.CentralContactPhone 
                        + "|CentralContactPhoneExt=" + c.CentralContactPhoneExt + "|CentralContactRole=" + c.CentralContactRole);
                }
                csv.CentralContactList = string.Join(";", centralContacts);
            }

            List<string> overallOficials = new List<string>();

            if (contactsLocationModule?.OverallOfficialList != null)
            {
                foreach (OverallOfficial c in contactsLocationModule?.OverallOfficialList?.OverallOfficial)
                {
                    overallOficials.Add("OverallOfficialName" + c.OverallOfficialName + "|OverallOfficialAffiliation=" 
                        + c.OverallOfficialAffiliation + "|OverallOfficialRole=" + c.OverallOfficialRole);
                }
                csv.OverallOfficialList = string.Join(";", overallOficials);
            }

            var referenceModule = protocol?.ReferencesModule;
            List<string> references = new List<string>();
            List<string> retractions = new List<string>();
            List<string> seeAlsoLinks = new List<string>();
            List<string> availPDs = new List<string>();

            if (referenceModule?.ReferenceList != null)
            {
                foreach (Reference reference in referenceModule?.ReferenceList?.Reference)
                {
                    if (reference.RetractionList != null)
                    {
                        foreach (Retraction ret in reference.RetractionList?.Retraction)
                        {
                            retractions.Add("RetractionPMID=" + ret.RetractionPMID + " - RetractionSource=" + ret.RetractionSource);
                        }
                    }

                    references.Add("ReferenceType" + reference.ReferenceType + "|ReferencePMID=" + reference.ReferencePMID + "|ReferenceCitation=" + reference.ReferenceCitation
                        + "|RetractionList=" + string.Join(",", retractions));
                }
                csv.ReferenceList = string.Join(";", references);
            }

            if (referenceModule?.SeeAlsoLinkList != null)
            {
                foreach (SeeAlsoLink s in referenceModule?.SeeAlsoLinkList?.SeeAlsoLink)
                {
                    seeAlsoLinks.Add("SeeAlsoLinkLabel=" + s.SeeAlsoLinkLabel + "|SeeAlsoLinkURL=" + s.SeeAlsoLinkURL);
                }
                csv.SeeAlsoLinkList = string.Join(";", seeAlsoLinks);
            }

            if (referenceModule?.AvailIPDList != null)
            {
                foreach (AvailIPD a in referenceModule?.AvailIPDList?.AvailIPD)
                {
                    availPDs.Add("AvailIPDId=" + a.AvailIPDId + "|AvailIPDType=" + a.AvailIPDType + "|AvailIPDComment=" + a.AvailIPDComment + "|AvailIPDURL=" + a.AvailIPDURL);
                }
                csv.AvailIPDList = string.Join(";", availPDs);
            }

            if (protocol?.IPDSharingStatementModule?.IPDSharingInfoTypeList != null)
                csv.IPDSharingInfoTypeList = string.Join(",", protocol?.IPDSharingStatementModule.IPDSharingInfoTypeList.IPDSharingInfoType);

            var resultsSection = r.FullStudy.Study.ResultsSection;
            var participantFlowModule = resultsSection?.ParticipantFlowModule;

            csv.FlowPreAssignmentDetails = "" + participantFlowModule?.FlowPreAssignmentDetails?.Replace("\n", ";");
            csv.FlowRecruitmentDetails = "" + participantFlowModule?.FlowRecruitmentDetails?.Replace("\n", ";");
            csv.FlowTypeUnitsAnalyzed = "" + participantFlowModule?.FlowTypeUnitsAnalyzed?.Replace("\n", ";");

            List<string> flowGroups = new List<string>();
            List<string> flowPeriods = new List<string>();
            List<string> flowDropWithdraws = new List<string>();
            List<string> flowReasons = new List<string>();

            if (participantFlowModule?.FlowGroupList != null)
            {
                foreach (FlowGroup a in participantFlowModule?.FlowGroupList?.FlowGroup)
                {
                    availPDs.Add("FlowGroupId=" + a.FlowGroupId + "|FlowGroupTitle=" + a.FlowGroupTitle + "|FlowGroupDescription=" + a.FlowGroupDescription);
                }
                csv.FlowGroupList = string.Join(";", flowGroups);
            }

            if (participantFlowModule?.FlowPeriodList != null)
            {
                foreach (FlowPeriod a in participantFlowModule?.FlowPeriodList?.FlowPeriod)
                {
                    //fali 1 lista
                    if (a.FlowDropWithdrawList != null)
                    {
                        foreach (FlowDropWithdraw f in a.FlowDropWithdrawList?.FlowDropWithdraw)
                        {
                            if (f.FlowReasonList != null)
                            {
                                foreach (FlowReason fr in f.FlowReasonList.FlowReason)
                                    flowReasons.Add("FlowReasonGroupId=" + fr.FlowReasonGroupId + 
                                        " + FlowReasonComment=" + fr.FlowReasonComment + 
                                        " + FlowReasonNumSubjects=" + fr.FlowReasonNumSubjects 
                                        + " + FlowReasonNumUnits=" + fr.FlowReasonNumUnits);
                            }
                            flowDropWithdraws.Add("FlowDropWithdrawType=" + f.FlowDropWithdrawType 
                                + " - FlowDropWithdrawComment=" + f.FlowDropWithdrawComment + " - FlowReasonList=" + string.Join(",", flowReasons));
                        }
                    }
                    flowDropWithdraws.Add("FlowPeriodTitle=" + a.FlowPeriodTitle /* + "|FlowDropWithdrawList=" + string.Join(",", flowDropWithdraws)*/);
                }
                csv.FlowPeriodList = string.Join(";", flowPeriods);
            }

            var basModule = resultsSection?.BaselineCharacteristicsModule;

            csv.BaselinePopulationDescription = "" + basModule?.BaselinePopulationDescription?.Replace("\n", ";");
            csv.BaselineTypeUnitsAnalyzed = "" + basModule?.BaselineTypeUnitsAnalyzed?.Replace("\n", ";");
            
            List<string> baselineGroups = new List<string>();

            if (basModule?.BaselineGroupList != null)
            {
                foreach (BaselineGroup a in basModule?.BaselineGroupList?.BaselineGroup)
                {
                    baselineGroups.Add("BaselineGroupId=" + a.BaselineGroupId + "|BaselineGroupTitle=" + a.BaselineGroupTitle + "|BaselineGroupDescription=" + a.BaselineGroupDescription);
                }
                csv.BaselineGroupList = string.Join(";", baselineGroups);
            }

            List<string> denomGroups = new List<string>();
            List<string> denomCounts = new List<string>();

            if (basModule?.BaselineDenomList != null)
            {
                foreach (BaselineDenom a in basModule?.BaselineDenomList?.BaselineDenom)
                {
                    foreach (BaselineDenomCount b in a.BaselineDenomCountList.BaselineDenomCount)
                    {
                        denomCounts.Add("BaselineDenomCountGroupId" + b.BaselineDenomCountGroupId + "+BaselineDenomCountValue=" + b.BaselineDenomCountValue);
                    }

                    denomGroups.Add("BaselineDenomUnits=" + a.BaselineDenomUnits + "|BaselineDenomCounts=" + string.Join(",", denomCounts));
                }
                csv.BaselineGroupList = string.Join(";", denomGroups);
            }

            List<string> baselineMeasures = new List<string>();

            if (basModule?.BaselineMeasureList != null)
            {
                foreach (BaselineMeasure a in basModule?.BaselineMeasureList?.BaselineMeasure)
                {
                    //fale 2 liste ovdje

                    baselineMeasures.Add("BaselineMeasureTitle=" + a.BaselineMeasureTitle +
                        "|BaselineMeasureUnitOfMeasure=" + a.BaselineMeasureUnitOfMeasure +
                        "|BaselineMeasurePopulationDescription=" + a.BaselineMeasurePopulationDescription
                        + "|BaselineMeasureParamType=" + a.BaselineMeasureParamType +
                        "|BaselineMeasureDispersionType=" + a.BaselineMeasureDispersionType 
                        + "|BaselineMeasureDescription=" + a.BaselineMeasureDescription +
                        "|BaselineMeasureDenomUnitsSelected=" + a.BaselineMeasureDenomUnitsSelected
                        + "|BaselineMeasureCalculatePct=" + a.BaselineMeasureCalculatePct);
                }
                csv.BaselineGroupList = string.Join(";", baselineMeasures);
            }

            List<string> outcomeMeasures = new List<string>();
            if (resultsSection?.OutcomeMeasuresModule?.OutcomeMeasureList != null)
            {
                foreach (OutcomeMeasure a in resultsSection?.OutcomeMeasuresModule?.OutcomeMeasureList.OutcomeMeasure)
                {
                    //+ 2 liste
                    outcomeMeasures.Add("OutcomeMeasureTitle=" + a.OutcomeMeasureTitle 
                        + "|OutcomeMeasureType=" + a.OutcomeMeasureType 
                        + "|OutcomeMeasureTypeUnitsAnalyzed=" + a.OutcomeMeasureTypeUnitsAnalyzed
                        + "|OutcomeMeasureDescription=" +  a.OutcomeMeasureDescription 
                        + "|OutcomeMeasureUnitOfMeasure=" + a.OutcomeMeasureUnitOfMeasure +
                        "|OutcomeMeasureTimeFrame=" + a.OutcomeMeasureTimeFrame +
                        "|OutcomeMeasureReportingStatus=" + a.OutcomeMeasureReportingStatus
                        + "|OutcomeMeasurePopulationDescription=" + a.OutcomeMeasurePopulationDescription + "|" + a.OutcomeMeasureParamType + "|" + a.OutcomeMeasureDispersionType 
                        + "|OutcomeMeasureDenomUnitsSelected=" + a.OutcomeMeasureDenomUnitsSelected 
                        + "|OutcomeMeasureCalculatePct=" + a.OutcomeMeasureCalculatePct +
                        "|OutcomeMeasureAnticipatedPostingDate=" + a.OutcomeMeasureAnticipatedPostingDate);
                }
                csv.BaselineGroupList = string.Join(";", baselineMeasures);
            }

            var adverseEventsModule = resultsSection?.AdverseEventsModule;
            csv.EventsFrequencyThreshold = "" + adverseEventsModule?.EventsFrequencyThreshold?.Replace("\n", ";");
            csv.EventsTimeFrame = "" + adverseEventsModule?.EventsTimeFrame?.Replace("\n", ";");
            csv.EventsDescription = "" + adverseEventsModule?.EventsDescription?.Replace("\n", ";");

            List<string> eventGroups = new List<string>();

            if (adverseEventsModule?.EventGroupList != null)
            {
                foreach (EventGroup a in adverseEventsModule?.EventGroupList?.EventGroup)
                {
                    eventGroups.Add("EventGroupId=" + a.EventGroupId?.Replace("\n", ";") + 
                        "|EventGroupDescription=" + a.EventGroupDescription?.Replace("\n", ";") 
                        + "|EventGroupTitle" + a.EventGroupTitle?.Replace("\n", ";")
                        + "|EventGroupSeriousNumAtRisk=" + a.EventGroupSeriousNumAtRisk?.Replace("\n", ";") +
                        "|EventGroupSeriousNumAffected=" + a.EventGroupSeriousNumAffected?.Replace("\n", ";")?.Replace("\n", ";")
                        + "|EventGroupOtherNumAffected=" + a.EventGroupOtherNumAffected?.Replace("\n", ";") + 
                        "|EventGroupDeathsNumAtRisk=" + a.EventGroupDeathsNumAtRisk?.Replace("\n", ";")
                        + "|EventGroupDeathsNumAffected=" + a.EventGroupDeathsNumAffected?.Replace("\n", ";")
                        + "|EventGroupOtherNumAtRisk=" + a.EventGroupOtherNumAtRisk?.Replace("\n", ";"));
                }
                csv.EventGroupList = string.Join(";", eventGroups);
            }

            var moreInfoModule = resultsSection?.MoreInfoModule;
            csv.AgreementRestrictiveAgreement = "" + moreInfoModule?.CertainAgreement?.AgreementRestrictiveAgreement?.Replace("\n", ";");
            csv.AgreementPISponsorEmployee = "" + moreInfoModule?.CertainAgreement?.AgreementPISponsorEmployee?.Replace("\n", ";");
            csv.AgreementRestrictionType = "" + moreInfoModule?.CertainAgreement?.AgreementRestrictionType?.Replace("\n", ";");
            csv.AgreementOtherDetails = "" + moreInfoModule?.CertainAgreement?.AgreementOtherDetails?.Replace("\n", ";");

            csv.PointOfContactTitle = "" + moreInfoModule?.PointOfContact?.PointOfContactTitle?.Replace("\n", ";");
            csv.PointOfContactOrganization = "" + moreInfoModule?.PointOfContact?.PointOfContactOrganization?.Replace("\n", ";");
            csv.PointOfContactEMail = "" + moreInfoModule?.PointOfContact?.PointOfContactEMail?.Replace("\n", ";");
            csv.PointOfContactPhone = "" + moreInfoModule?.PointOfContact?.PointOfContactPhone?.Replace("\n", ";");
            csv.PointOfContactPhoneExt = "" + moreInfoModule?.PointOfContact?.PointOfContactPhoneExt?.Replace("\n", ";");

            var annotationModule = r.FullStudy?.Study?.AnnotationSection?.AnnotationModule;

            csv.UnpostedResponsibleParty = annotationModule?.UnpostedAnnotation?.UnpostedResponsibleParty;
           
            List<string> unpostedEvents = new List<string>();

            if (annotationModule?.UnpostedAnnotation?.UnpostedEventList != null)
            {
                foreach (UnpostedEvent a in annotationModule?.UnpostedAnnotation.UnpostedEventList.UnpostedEvent)
                {
                    eventGroups.Add("UnpostedEventDate=" + a.UnpostedEventDate.Replace("\n", ";") +
                        "|UnpostedEventType=" + a.UnpostedEventType.Replace("\n", ";"));
                }
                csv.UnpostedEventList = string.Join(";", unpostedEvents);
            }

            var largeDocumentModule = r.FullStudy?.Study?.DocumentSection?.LargeDocumentModule;
            List<string> largeDocs = new List<string>();
            if (largeDocumentModule?.LargeDocList != null)
            {
                foreach (LargeDoc a in largeDocumentModule?.LargeDocList.LargeDoc)
                {
                    largeDocs.Add("LargeDocFilename=" + a.LargeDocFilename.Replace("\n", ";") +
                        "|LargeDocDate=" + a.LargeDocDate.Replace("\n", ";") +
                        "|LargeDocHasICF=" + a.LargeDocHasICF.Replace("\n", ";") +
                        "|LargeDocHasProtocol=" + a.LargeDocHasProtocol.Replace("\n", ";") +
                        "|LargeDocHasSAP=" + a.LargeDocHasSAP.Replace("\n", ";") +
                        "|LargeDocLabel=" + a.LargeDocLabel.Replace("\n", ";") +
                        "|LargeDocTypeAbbrev=" + a.LargeDocTypeAbbrev.Replace("\n", ";")
                        + "|LargeDocUploadDate=" + a.LargeDocUploadDate.Replace("\n", ";"));
                }
                csv.LargeDocList = string.Join(";", largeDocs);
            }

            var miscInfo = r.FullStudy?.Study?.DerivedSection?.MiscInfoModule;
            csv.VersionHolder = "" + miscInfo?.VersionHolder?.Replace("\n", ";");
            if(miscInfo?.RemovedCountryList?.RemovedCountry != null)
                csv.RemovedCountryList = string.Join(",", miscInfo?.RemovedCountryList?.RemovedCountry);
            
            var intModule = r.FullStudy.Study.DerivedSection.InterventionBrowseModule;
            List<string> meshes= new List<string>();
            if(intModule?.InterventionMeshList?.InterventionMesh != null)
            {
                foreach (InterventionMesh a in intModule.InterventionMeshList?.InterventionMesh)
                {
                    meshes.Add("InterventionMeshId=" + a.InterventionMeshId.Replace("\n", ";") +
                        "|InterventionMeshTerm=" + a.InterventionMeshTerm.Replace("\n", ";"));
                }
                csv.InterventionMeshList = string.Join(";", meshes);
            }

            List<string> ancestors = new List<string>();
            if (intModule?.InterventionAncestorList?.InterventionAncestor != null)
            {
                foreach (InterventionAncestor a in intModule?.InterventionAncestorList?.InterventionAncestor)
                {
                    ancestors.Add("InterventionAncestorId=" + a.InterventionAncestorId.Replace("\n", ";") +
                        "|InterventionAncestorTerm=" + a.InterventionAncestorTerm.Replace("\n", ";"));
                }
                csv.InterventionAncestorList = string.Join(";", ancestors);
            }
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
        public virtual string SecondaryIdInfoList { get; set; }
        public virtual string NCTIdAliasList { get; set; }

        public string OversightHasDMC { get; set; }
        public string IsFDARegulatedDrug { get; set; }
        public string IsFDARegulatedDevice { get; set; }
        public string IsUnapprovedDevice { get; set; }
        public string IsPPSD { get; set; }
        public string IsUSExport { get; set; }

        public string LeadSponsorName { get; set; }
        public string LeadSponsorClass { get; set; }
        public string CollaboratorNames { get; set; }
        public string CollaboratorClasses { get; set; }
        public string OverallStatus { get; set; }
        public string LastKnownStatus { get; set; }
        public string WhyStopped { get; set; }

        //public List<string> Phase { get; set; }

        public string StudyType { get; set; }

        public string EnrollmentType { get; set; }
        public string EnrollmentCount { get; set; }
        public string PhaseList { get; set; }

        public string HasExpandedAccess { get; set; }
        public string ExpAccTypeIndividual { get; set; }

        public string ExpAccTypeIntermediate { get; set; }
        public string ExpAccTypeTreatment { get; set; }
        public string ExpandedAccessNCTId { get; set; }
        public string ExpandedAccessStatusForNCTId { get; set; }
        public string DesignAllocation { get; set; }
        public string DesignInterventionModel { get; set; }
        public string DesignInterventionModelDescription { get; set; }
        public string DesignPrimaryPurpose { get; set; }
        public string DesignMasking { get; set; }
        public string DesignMaskingDescription { get; set; }
        public string DesignWhoMasked { get; set; }

        public string TargetDuration { get; set; }   
        public string DesignObservationalModelList { get; set; }
        public string DesignTimePerspective { get; set; }

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
        public string DelayedPosting { get; set; }

        public string ResponsiblePartyType { get; set; }
        public string ResponsiblePartyInvestigatorFullName { get; set; }
        public string ResponsiblePartyInvestigatorTitle { get; set; }
        public string ResponsiblePartyInvestigatorAffiliation { get; set; }
        public string ResponsiblePartyOldNameTitle { get; set; }
        public string ResponsiblePartyOldOrganization { get; set; }

        public string ConditionList { get; set; }
        public string KeywordList { get; set; }

        public string BriefSummary { get; set; }
        public string DetailedDescription { get; set; }
        public string InterventionList { get; set; }
        public string ArmGroupList { get; set; }

        public string PrimaryOutcomeList { get; set; }
        public string SecondaryOutcomeList { get; set; }
        public string OtherOutcomeList { get; set; }

        public string EligibilityCriteria { get; set; }
        public string HealthyVolunteers { get; set; }
        public string Gender { get; set; }
        public string MinimumAge { get; set; }
        public string MaximumAge { get; set; }
        public string StdAgeList { get; set; }
        public string GenderBased { get; set; }
        public string GenderDescription { get; set; }
        public string StudyPopulation { get; set; }
        public string SamplingMethod { get; set; }

        public string LocationList { get; set; }
        public string CentralContactList { get; set; }
        public string OverallOfficialList { get; set; }

        public string ReferenceList { get; set; }
        public string SeeAlsoLinkList { get; set; }
        public string AvailIPDList { get; set; }
        public string IPDSharingAccessCriteria { get; set; }
        public string IPDSharingURL { get; set; }
        public string IPDSharingInfoTypeList { get; set; }

        public string FlowPreAssignmentDetails { get; set; }
        public string FlowRecruitmentDetails { get; set; }
        public string FlowTypeUnitsAnalyzed { get; set; }
        public string FlowGroupList { get; set; }
        public string FlowPeriodList { get; set; }

        public string BaselinePopulationDescription { get; set; }
        public string BaselineTypeUnitsAnalyzed { get; set; }
        public string BaselineGroupList { get; set; }
        public string BaselineDenomList { get; set; }
        public string BaselineMeasureList { get; set; }

        public string OutcomeMeasureList { get; set; }

        public string EventsFrequencyThreshold { get; set; }
        public string EventsTimeFrame { get; set; }
        public string EventsDescription { get; set; }
        public string EventGroupList { get; set; }

        public string AgreementPISponsorEmployee { get; set; }
        public string AgreementRestrictionType { get; set; }
        public string AgreementRestrictiveAgreement { get; set; }
        public string AgreementOtherDetails { get; set; }
        public string PointOfContactTitle { get; set; }
        public string PointOfContactOrganization { get; set; }
        public string PointOfContactEMail { get; set; }
        public string PointOfContactPhone { get; set; }
        public string PointOfContactPhoneExt { get; set; }
        public string UnpostedResponsibleParty { get; set; }
        public string UnpostedEventList { get; set; }
        public string LargeDocList { get; set; }

        public string InterventionMeshList { get; set; }
        public string InterventionAncestorList { get; set; }
        public string InterventionBrowseLeafList { get; set; }
        public string InterventionBrowseBranchList { get; set; }

        public string RemovedCountryList { get; set; }

        public string VersionHolder { get; set; }

    }

}
