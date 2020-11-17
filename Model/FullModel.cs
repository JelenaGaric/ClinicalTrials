using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class NCTId
    {
        public string type { get; set; }
    }

    public class NCTIdAlias
    {
        public string type { get; set; }
    }

    public class NCTIdAliasList
    {
        public string type { get; set; }
        public NCTIdAlias NCTIdAlias { get; set; }
    }

    public class OrgStudyId
    {
        public string type { get; set; }
    }

    public class OrgStudyIdType
    {
        public string type { get; set; }
    }

    public class OrgStudyIdDomain
    {
        public string type { get; set; }
    }

    public class OrgStudyIdLink
    {
        public string type { get; set; }
    }

    public class OrgStudyIdInfo
    {
        public string type { get; set; }
        public OrgStudyId OrgStudyId { get; set; }
        public OrgStudyIdType OrgStudyIdType { get; set; }
        public OrgStudyIdDomain OrgStudyIdDomain { get; set; }
        public OrgStudyIdLink OrgStudyIdLink { get; set; }
    }

    public class SecondaryId
    {
        public string type { get; set; }
    }

    public class SecondaryIdType
    {
        public string type { get; set; }
    }

    public class SecondaryIdDomain
    {
        public string type { get; set; }
    }

    public class SecondaryIdLink
    {
        public string type { get; set; }
    }

    public class SecondaryIdInfo
    {
        public string type { get; set; }
        public SecondaryId SecondaryId { get; set; }
        public SecondaryIdType SecondaryIdType { get; set; }
        public SecondaryIdDomain SecondaryIdDomain { get; set; }
        public SecondaryIdLink SecondaryIdLink { get; set; }
    }

    public class SecondaryIdInfoList
    {
        public string type { get; set; }
        public SecondaryIdInfo SecondaryIdInfo { get; set; }
    }

    public class OrgFullName
    {
        public string type { get; set; }
    }

    public class OrgClass
    {
        public string type { get; set; }
    }

    public class Organization
    {
        public string type { get; set; }
        public OrgFullName OrgFullName { get; set; }
        public OrgClass OrgClass { get; set; }
    }

    public class BriefTitle
    {
        public string type { get; set; }
    }

    public class OfficialTitle
    {
        public string type { get; set; }
    }

    public class Acronym
    {
        public string type { get; set; }
    }

    public class IdentificationModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public NCTId NCTId { get; set; }
        public NCTIdAliasList NCTIdAliasList { get; set; }
        public OrgStudyIdInfo OrgStudyIdInfo { get; set; }
        public SecondaryIdInfoList SecondaryIdInfoList { get; set; }
        public Organization Organization { get; set; }
        public BriefTitle BriefTitle { get; set; }
        public OfficialTitle OfficialTitle { get; set; }
        public Acronym Acronym { get; set; }
    }

    public class StatusVerifiedDate
    {
        public string type { get; set; }
    }

    public class OverallStatus
    {
        public string type { get; set; }
    }

    public class LastKnownStatus
    {
        public string type { get; set; }
    }

    public class DelayedPosting
    {
        public string type { get; set; }
    }

    public class WhyStopped
    {
        public string type { get; set; }
    }

    public class HasExpandedAccess
    {
        public string type { get; set; }
    }

    public class ExpandedAccessNCTId
    {
        public string type { get; set; }
    }

    public class ExpandedAccessStatusForNCTId
    {
        public string type { get; set; }
    }

    public class ExpandedAccessInfo
    {
        public string type { get; set; }
        public HasExpandedAccess HasExpandedAccess { get; set; }
        public ExpandedAccessNCTId ExpandedAccessNCTId { get; set; }
        public ExpandedAccessStatusForNCTId ExpandedAccessStatusForNCTId { get; set; }
    }

    public class StartDate
    {
        public string type { get; set; }
    }

    public class StartDateType
    {
        public string type { get; set; }
    }

    public class StartDateStruct
    {
        public string type { get; set; }
        public StartDate StartDate { get; set; }
        public StartDateType StartDateType { get; set; }
    }

    public class PrimaryCompletionDate
    {
        public string type { get; set; }
    }

    public class PrimaryCompletionDateType
    {
        public string type { get; set; }
    }

    public class PrimaryCompletionDateStruct
    {
        public string type { get; set; }
        public PrimaryCompletionDate PrimaryCompletionDate { get; set; }
        public PrimaryCompletionDateType PrimaryCompletionDateType { get; set; }
    }

    public class CompletionDate
    {
        public string type { get; set; }
    }

    public class CompletionDateType
    {
        public string type { get; set; }
    }

    public class CompletionDateStruct
    {
        public string type { get; set; }
        public CompletionDate CompletionDate { get; set; }
        public CompletionDateType CompletionDateType { get; set; }
    }

    public class StudyFirstSubmitDate
    {
        public string type { get; set; }
    }

    public class StudyFirstSubmitQCDate
    {
        public string type { get; set; }
    }

    public class StudyFirstPostDate
    {
        public string type { get; set; }
    }

    public class StudyFirstPostDateType
    {
        public string type { get; set; }
    }

    public class StudyFirstPostDateStruct
    {
        public string type { get; set; }
        public StudyFirstPostDate StudyFirstPostDate { get; set; }
        public StudyFirstPostDateType StudyFirstPostDateType { get; set; }
    }

    public class ResultsFirstSubmitDate
    {
        public string type { get; set; }
    }

    public class ResultsFirstSubmitQCDate
    {
        public string type { get; set; }
    }

    public class ResultsFirstPostDate
    {
        public string type { get; set; }
    }

    public class ResultsFirstPostDateType
    {
        public string type { get; set; }
    }

    public class ResultsFirstPostDateStruct
    {
        public string type { get; set; }
        public ResultsFirstPostDate ResultsFirstPostDate { get; set; }
        public ResultsFirstPostDateType ResultsFirstPostDateType { get; set; }
    }

    public class DispFirstSubmitDate
    {
        public string type { get; set; }
    }

    public class DispFirstSubmitQCDate
    {
        public string type { get; set; }
    }

    public class DispFirstPostDate
    {
        public string type { get; set; }
    }

    public class DispFirstPostDateType
    {
        public string type { get; set; }
    }

    public class DispFirstPostDateStruct
    {
        public string type { get; set; }
        public DispFirstPostDate DispFirstPostDate { get; set; }
        public DispFirstPostDateType DispFirstPostDateType { get; set; }
    }

    public class LastUpdateSubmitDate
    {
        public string type { get; set; }
    }

    public class LastUpdatePostDate
    {
        public string type { get; set; }
    }

    public class LastUpdatePostDateType
    {
        public string type { get; set; }
    }

    public class LastUpdatePostDateStruct
    {
        public string type { get; set; }
        public LastUpdatePostDate LastUpdatePostDate { get; set; }
        public LastUpdatePostDateType LastUpdatePostDateType { get; set; }
    }

    public class StatusModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public StatusVerifiedDate StatusVerifiedDate { get; set; }
        public OverallStatus OverallStatus { get; set; }
        public LastKnownStatus LastKnownStatus { get; set; }
        public DelayedPosting DelayedPosting { get; set; }
        public WhyStopped WhyStopped { get; set; }
        public ExpandedAccessInfo ExpandedAccessInfo { get; set; }
        public StartDateStruct StartDateStruct { get; set; }
        public PrimaryCompletionDateStruct PrimaryCompletionDateStruct { get; set; }
        public CompletionDateStruct CompletionDateStruct { get; set; }
        public StudyFirstSubmitDate StudyFirstSubmitDate { get; set; }
        public StudyFirstSubmitQCDate StudyFirstSubmitQCDate { get; set; }
        public StudyFirstPostDateStruct StudyFirstPostDateStruct { get; set; }
        public ResultsFirstSubmitDate ResultsFirstSubmitDate { get; set; }
        public ResultsFirstSubmitQCDate ResultsFirstSubmitQCDate { get; set; }
        public ResultsFirstPostDateStruct ResultsFirstPostDateStruct { get; set; }
        public DispFirstSubmitDate DispFirstSubmitDate { get; set; }
        public DispFirstSubmitQCDate DispFirstSubmitQCDate { get; set; }
        public DispFirstPostDateStruct DispFirstPostDateStruct { get; set; }
        public LastUpdateSubmitDate LastUpdateSubmitDate { get; set; }
        public LastUpdatePostDateStruct LastUpdatePostDateStruct { get; set; }
    }

    public class ResponsiblePartyType
    {
        public string type { get; set; }
    }

    public class ResponsiblePartyInvestigatorFullName
    {
        public string type { get; set; }
    }

    public class ResponsiblePartyInvestigatorTitle
    {
        public string type { get; set; }
    }

    public class ResponsiblePartyInvestigatorAffiliation
    {
        public string type { get; set; }
    }

    public class ResponsiblePartyOldNameTitle
    {
        public string type { get; set; }
    }

    public class ResponsiblePartyOldOrganization
    {
        public string type { get; set; }
    }

    public class ResponsibleParty
    {
        public string type { get; set; }
        public ResponsiblePartyType ResponsiblePartyType { get; set; }
        public ResponsiblePartyInvestigatorFullName ResponsiblePartyInvestigatorFullName { get; set; }
        public ResponsiblePartyInvestigatorTitle ResponsiblePartyInvestigatorTitle { get; set; }
        public ResponsiblePartyInvestigatorAffiliation ResponsiblePartyInvestigatorAffiliation { get; set; }
        public ResponsiblePartyOldNameTitle ResponsiblePartyOldNameTitle { get; set; }
        public ResponsiblePartyOldOrganization ResponsiblePartyOldOrganization { get; set; }
    }

    public class LeadSponsorName
    {
        public string type { get; set; }
    }

    public class LeadSponsorClass
    {
        public string type { get; set; }
    }

    public class LeadSponsor
    {
        public string type { get; set; }
        public LeadSponsorName LeadSponsorName { get; set; }
        public LeadSponsorClass LeadSponsorClass { get; set; }
    }

    public class CollaboratorName
    {
        public string type { get; set; }
    }

    public class CollaboratorClass
    {
        public string type { get; set; }
    }

    public class Collaborator
    {
        public string type { get; set; }
        public CollaboratorName CollaboratorName { get; set; }
        public CollaboratorClass CollaboratorClass { get; set; }
    }

    public class CollaboratorList
    {
        public string type { get; set; }
        public Collaborator Collaborator { get; set; }
    }

    public class SponsorCollaboratorsModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public ResponsibleParty ResponsibleParty { get; set; }
        public LeadSponsor LeadSponsor { get; set; }
        public CollaboratorList CollaboratorList { get; set; }
    }

    public class OversightHasDMC
    {
        public string type { get; set; }
    }

    public class IsFDARegulatedDrug
    {
        public string type { get; set; }
    }

    public class IsFDARegulatedDevice
    {
        public string type { get; set; }
    }

    public class IsUnapprovedDevice
    {
        public string type { get; set; }
    }

    public class IsPPSD
    {
        public string type { get; set; }
    }

    public class IsUSExport
    {
        public string type { get; set; }
    }

    public class OversightModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public OversightHasDMC OversightHasDMC { get; set; }
        public IsFDARegulatedDrug IsFDARegulatedDrug { get; set; }
        public IsFDARegulatedDevice IsFDARegulatedDevice { get; set; }
        public IsUnapprovedDevice IsUnapprovedDevice { get; set; }
        public IsPPSD IsPPSD { get; set; }
        public IsUSExport IsUSExport { get; set; }
    }

    public class BriefSummary
    {
        public string type { get; set; }
    }

    public class DetailedDescription
    {
        public string type { get; set; }
    }

    public class DescriptionModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public BriefSummary BriefSummary { get; set; }
        public DetailedDescription DetailedDescription { get; set; }
    }

    public class Condition
    {
        public string type { get; set; }
    }

    public class ConditionList
    {
        public string type { get; set; }
        public Condition Condition { get; set; }
    }

    public class Keyword
    {
        public string type { get; set; }
    }

    public class KeywordList
    {
        public string type { get; set; }
        public Keyword Keyword { get; set; }
    }

    public class ConditionsModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public ConditionList ConditionList { get; set; }
        public KeywordList KeywordList { get; set; }
    }

    public class StudyType
    {
        public string type { get; set; }
        public string dedLink { get; set; }
    }

    public class ExpAccTypeIndividual
    {
        public string type { get; set; }
    }

    public class ExpAccTypeIntermediate
    {
        public string type { get; set; }
    }

    public class ExpAccTypeTreatment
    {
        public string type { get; set; }
    }

    public class ExpandedAccessTypes
    {
        public string type { get; set; }
        public ExpAccTypeIndividual ExpAccTypeIndividual { get; set; }
        public ExpAccTypeIntermediate ExpAccTypeIntermediate { get; set; }
        public ExpAccTypeTreatment ExpAccTypeTreatment { get; set; }
    }

    public class PatientRegistry
    {
        public string type { get; set; }
    }

    public class TargetDuration
    {
        public string type { get; set; }
    }

    public class Phase
    {
        public string type { get; set; }
    }

    public class PhaseList
    {
        public string type { get; set; }
        public Phase Phase { get; set; }
    }

    public class DesignAllocation
    {
        public string type { get; set; }
    }

    public class DesignInterventionModel
    {
        public string type { get; set; }
    }

    public class DesignInterventionModelDescription
    {
        public string type { get; set; }
    }

    public class DesignPrimaryPurpose
    {
        public string type { get; set; }
    }

    public class DesignObservationalModel
    {
        public string type { get; set; }
    }

    public class DesignObservationalModelList
    {
        public string type { get; set; }
        public DesignObservationalModel DesignObservationalModel { get; set; }
    }

    public class DesignTimePerspective
    {
        public string type { get; set; }
    }

    public class DesignTimePerspectiveList
    {
        public string type { get; set; }
        public DesignTimePerspective DesignTimePerspective { get; set; }
    }

    public class DesignMasking
    {
        public string type { get; set; }
    }

    public class DesignMaskingDescription
    {
        public string type { get; set; }
    }

    public class DesignWhoMasked
    {
        public string type { get; set; }
    }

    public class DesignWhoMaskedList
    {
        public string type { get; set; }
        public DesignWhoMasked DesignWhoMasked { get; set; }
    }

    public class DesignMaskingInfo
    {
        public string type { get; set; }
        public DesignMasking DesignMasking { get; set; }
        public DesignMaskingDescription DesignMaskingDescription { get; set; }
        public DesignWhoMaskedList DesignWhoMaskedList { get; set; }
    }

    public class DesignInfo
    {
        public string type { get; set; }
        public DesignAllocation DesignAllocation { get; set; }
        public DesignInterventionModel DesignInterventionModel { get; set; }
        public DesignInterventionModelDescription DesignInterventionModelDescription { get; set; }
        public DesignPrimaryPurpose DesignPrimaryPurpose { get; set; }
        public DesignObservationalModelList DesignObservationalModelList { get; set; }
        public DesignTimePerspectiveList DesignTimePerspectiveList { get; set; }
        public DesignMaskingInfo DesignMaskingInfo { get; set; }
    }

    public class BioSpecRetention
    {
        public string type { get; set; }
    }

    public class BioSpecDescription
    {
        public string type { get; set; }
    }

    public class BioSpec
    {
        public string type { get; set; }
        public BioSpecRetention BioSpecRetention { get; set; }
        public BioSpecDescription BioSpecDescription { get; set; }
    }

    public class EnrollmentCount
    {
        public string type { get; set; }
    }

    public class EnrollmentType
    {
        public string type { get; set; }
    }

    public class EnrollmentInfo
    {
        public string type { get; set; }
        public EnrollmentCount EnrollmentCount { get; set; }
        public EnrollmentType EnrollmentType { get; set; }
    }

    public class DesignModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public StudyType StudyType { get; set; }
        public ExpandedAccessTypes ExpandedAccessTypes { get; set; }
        public PatientRegistry PatientRegistry { get; set; }
        public TargetDuration TargetDuration { get; set; }
        public PhaseList PhaseList { get; set; }
        public DesignInfo DesignInfo { get; set; }
        public BioSpec BioSpec { get; set; }
        public EnrollmentInfo EnrollmentInfo { get; set; }
    }

    public class ArmGroupLabel
    {
        public string type { get; set; }
    }

    public class ArmGroupType
    {
        public string type { get; set; }
    }

    public class ArmGroupDescription
    {
        public string type { get; set; }
    }

    public class ArmGroupInterventionName
    {
        public string type { get; set; }
    }

    public class ArmGroupInterventionList
    {
        public string type { get; set; }
        public ArmGroupInterventionName ArmGroupInterventionName { get; set; }
    }

    public class ArmGroup
    {
        public string type { get; set; }
        public ArmGroupLabel ArmGroupLabel { get; set; }
        public ArmGroupType ArmGroupType { get; set; }
        public ArmGroupDescription ArmGroupDescription { get; set; }
        public ArmGroupInterventionList ArmGroupInterventionList { get; set; }
    }

    public class ArmGroupList
    {
        public string type { get; set; }
        public ArmGroup ArmGroup { get; set; }
    }

    public class InterventionType
    {
        public string type { get; set; }
    }

    public class InterventionName
    {
        public string type { get; set; }
    }

    public class InterventionDescription
    {
        public string type { get; set; }
    }

    public class InterventionArmGroupLabel
    {
        public string type { get; set; }
    }

    public class InterventionArmGroupLabelList
    {
        public string type { get; set; }
        public InterventionArmGroupLabel InterventionArmGroupLabel { get; set; }
    }

    public class InterventionOtherName
    {
        public string type { get; set; }
    }

    public class InterventionOtherNameList
    {
        public string type { get; set; }
        public InterventionOtherName InterventionOtherName { get; set; }
    }

    public class Intervention
    {
        public string type { get; set; }
        public InterventionType InterventionType { get; set; }
        public InterventionName InterventionName { get; set; }
        public InterventionDescription InterventionDescription { get; set; }
        public InterventionArmGroupLabelList InterventionArmGroupLabelList { get; set; }
        public InterventionOtherNameList InterventionOtherNameList { get; set; }
    }

    public class InterventionList
    {
        public string type { get; set; }
        public Intervention Intervention { get; set; }
    }

    public class ArmsInterventionsModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public ArmGroupList ArmGroupList { get; set; }
        public InterventionList InterventionList { get; set; }
    }

    public class PrimaryOutcomeMeasure
    {
        public string type { get; set; }
    }

    public class PrimaryOutcomeDescription
    {
        public string type { get; set; }
    }

    public class PrimaryOutcomeTimeFrame
    {
        public string type { get; set; }
    }

    public class PrimaryOutcome
    {
        public string type { get; set; }
        public PrimaryOutcomeMeasure PrimaryOutcomeMeasure { get; set; }
        public PrimaryOutcomeDescription PrimaryOutcomeDescription { get; set; }
        public PrimaryOutcomeTimeFrame PrimaryOutcomeTimeFrame { get; set; }
    }

    public class PrimaryOutcomeList
    {
        public string type { get; set; }
        public PrimaryOutcome PrimaryOutcome { get; set; }
    }

    public class SecondaryOutcomeMeasure
    {
        public string type { get; set; }
    }

    public class SecondaryOutcomeDescription
    {
        public string type { get; set; }
    }

    public class SecondaryOutcomeTimeFrame
    {
        public string type { get; set; }
    }

    public class SecondaryOutcome
    {
        public string type { get; set; }
        public SecondaryOutcomeMeasure SecondaryOutcomeMeasure { get; set; }
        public SecondaryOutcomeDescription SecondaryOutcomeDescription { get; set; }
        public SecondaryOutcomeTimeFrame SecondaryOutcomeTimeFrame { get; set; }
    }

    public class SecondaryOutcomeList
    {
        public string type { get; set; }
        public SecondaryOutcome SecondaryOutcome { get; set; }
    }

    public class OtherOutcomeMeasure
    {
        public string type { get; set; }
    }

    public class OtherOutcomeDescription
    {
        public string type { get; set; }
    }

    public class OtherOutcomeTimeFrame
    {
        public string type { get; set; }
    }

    public class OtherOutcome
    {
        public string type { get; set; }
        public OtherOutcomeMeasure OtherOutcomeMeasure { get; set; }
        public OtherOutcomeDescription OtherOutcomeDescription { get; set; }
        public OtherOutcomeTimeFrame OtherOutcomeTimeFrame { get; set; }
    }

    public class OtherOutcomeList
    {
        public string type { get; set; }
        public OtherOutcome OtherOutcome { get; set; }
    }

    public class OutcomesModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public PrimaryOutcomeList PrimaryOutcomeList { get; set; }
        public SecondaryOutcomeList SecondaryOutcomeList { get; set; }
        public OtherOutcomeList OtherOutcomeList { get; set; }
    }

    public class EligibilityCriteria
    {
        public string type { get; set; }
    }

    public class HealthyVolunteers
    {
        public string type { get; set; }
    }

    public class Gender
    {
        public string type { get; set; }
    }

    public class GenderBased
    {
        public string type { get; set; }
    }

    public class GenderDescription
    {
        public string type { get; set; }
    }

    public class MinimumAge
    {
        public string type { get; set; }
    }

    public class MaximumAge
    {
        public string type { get; set; }
    }

    public class StdAge
    {
        public string type { get; set; }
    }

    public class StdAgeList
    {
        public string type { get; set; }
        public StdAge StdAge { get; set; }
    }

    public class StudyPopulation
    {
        public string type { get; set; }
    }

    public class SamplingMethod
    {
        public string type { get; set; }
    }

    public class EligibilityModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public EligibilityCriteria EligibilityCriteria { get; set; }
        public HealthyVolunteers HealthyVolunteers { get; set; }
        public Gender Gender { get; set; }
        public GenderBased GenderBased { get; set; }
        public GenderDescription GenderDescription { get; set; }
        public MinimumAge MinimumAge { get; set; }
        public MaximumAge MaximumAge { get; set; }
        public StdAgeList StdAgeList { get; set; }
        public StudyPopulation StudyPopulation { get; set; }
        public SamplingMethod SamplingMethod { get; set; }
    }

    public class CentralContactName
    {
        public string type { get; set; }
    }

    public class CentralContactRole
    {
        public string type { get; set; }
    }

    public class CentralContactPhone
    {
        public string type { get; set; }
    }

    public class CentralContactPhoneExt
    {
        public string type { get; set; }
    }

    public class CentralContactEMail
    {
        public string type { get; set; }
    }

    public class CentralContact
    {
        public string type { get; set; }
        public CentralContactName CentralContactName { get; set; }
        public CentralContactRole CentralContactRole { get; set; }
        public CentralContactPhone CentralContactPhone { get; set; }
        public CentralContactPhoneExt CentralContactPhoneExt { get; set; }
        public CentralContactEMail CentralContactEMail { get; set; }
    }

    public class CentralContactList
    {
        public string type { get; set; }
        public CentralContact CentralContact { get; set; }
    }

    public class OverallOfficialName
    {
        public string type { get; set; }
    }

    public class OverallOfficialAffiliation
    {
        public string type { get; set; }
    }

    public class OverallOfficialRole
    {
        public string type { get; set; }
    }

    public class OverallOfficial
    {
        public string type { get; set; }
        public OverallOfficialName OverallOfficialName { get; set; }
        public OverallOfficialAffiliation OverallOfficialAffiliation { get; set; }
        public OverallOfficialRole OverallOfficialRole { get; set; }
    }

    public class OverallOfficialList
    {
        public string type { get; set; }
        public OverallOfficial OverallOfficial { get; set; }
    }

    public class LocationFacility
    {
        public string type { get; set; }
    }

    public class LocationStatus
    {
        public string type { get; set; }
    }

    public class LocationCity
    {
        public string type { get; set; }
    }

    public class LocationState
    {
        public string type { get; set; }
    }

    public class LocationZip
    {
        public string type { get; set; }
    }

    public class LocationCountry
    {
        public string type { get; set; }
    }

    public class LocationContactName
    {
        public string type { get; set; }
    }

    public class LocationContactRole
    {
        public string type { get; set; }
    }

    public class LocationContactPhone
    {
        public string type { get; set; }
    }

    public class LocationContactPhoneExt
    {
        public string type { get; set; }
    }

    public class LocationContactEMail
    {
        public string type { get; set; }
    }

    public class LocationContact
    {
        public string type { get; set; }
        public LocationContactName LocationContactName { get; set; }
        public LocationContactRole LocationContactRole { get; set; }
        public LocationContactPhone LocationContactPhone { get; set; }
        public LocationContactPhoneExt LocationContactPhoneExt { get; set; }
        public LocationContactEMail LocationContactEMail { get; set; }
    }

    public class LocationContactList
    {
        public string type { get; set; }
        public LocationContact LocationContact { get; set; }
    }

    public class Location
    {
        public string type { get; set; }
        public LocationFacility LocationFacility { get; set; }
        public LocationStatus LocationStatus { get; set; }
        public LocationCity LocationCity { get; set; }
        public LocationState LocationState { get; set; }
        public LocationZip LocationZip { get; set; }
        public LocationCountry LocationCountry { get; set; }
        public LocationContactList LocationContactList { get; set; }
    }

    public class LocationList
    {
        public string type { get; set; }
        public Location Location { get; set; }
    }

    public class ContactsLocationsModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public CentralContactList CentralContactList { get; set; }
        public OverallOfficialList OverallOfficialList { get; set; }
        public LocationList LocationList { get; set; }
    }

    public class ReferencePMID
    {
        public string type { get; set; }
    }

    public class ReferenceType
    {
        public string type { get; set; }
    }

    public class ReferenceCitation
    {
        public string type { get; set; }
    }

    public class RetractionPMID
    {
        public string type { get; set; }
    }

    public class RetractionSource
    {
        public string type { get; set; }
    }

    public class Retraction
    {
        public string type { get; set; }
        public RetractionPMID RetractionPMID { get; set; }
        public RetractionSource RetractionSource { get; set; }
    }

    public class RetractionList
    {
        public string type { get; set; }
        public Retraction Retraction { get; set; }
    }

    public class Reference
    {
        public string type { get; set; }
        public ReferencePMID ReferencePMID { get; set; }
        public ReferenceType ReferenceType { get; set; }
        public ReferenceCitation ReferenceCitation { get; set; }
        public RetractionList RetractionList { get; set; }
    }

    public class ReferenceList
    {
        public string type { get; set; }
        public Reference Reference { get; set; }
    }

    public class SeeAlsoLinkLabel
    {
        public string type { get; set; }
    }

    public class SeeAlsoLinkURL
    {
        public string type { get; set; }
    }

    public class SeeAlsoLink
    {
        public string type { get; set; }
        public SeeAlsoLinkLabel SeeAlsoLinkLabel { get; set; }
        public SeeAlsoLinkURL SeeAlsoLinkURL { get; set; }
    }

    public class SeeAlsoLinkList
    {
        public string type { get; set; }
        public SeeAlsoLink SeeAlsoLink { get; set; }
    }

    public class AvailIPDId
    {
        public string type { get; set; }
    }

    public class AvailIPDType
    {
        public string type { get; set; }
    }

    public class AvailIPDURL
    {
        public string type { get; set; }
    }

    public class AvailIPDComment
    {
        public string type { get; set; }
    }

    public class AvailIPD
    {
        public string type { get; set; }
        public AvailIPDId AvailIPDId { get; set; }
        public AvailIPDType AvailIPDType { get; set; }
        public AvailIPDURL AvailIPDURL { get; set; }
        public AvailIPDComment AvailIPDComment { get; set; }
    }

    public class AvailIPDList
    {
        public string type { get; set; }
        public AvailIPD AvailIPD { get; set; }
    }

    public class ReferencesModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public ReferenceList ReferenceList { get; set; }
        public SeeAlsoLinkList SeeAlsoLinkList { get; set; }
        public AvailIPDList AvailIPDList { get; set; }
    }

    public class IPDSharing
    {
        public string type { get; set; }
    }

    public class IPDSharingDescription
    {
        public string type { get; set; }
    }

    public class IPDSharingInfoType
    {
        public string type { get; set; }
    }

    public class IPDSharingInfoTypeList
    {
        public string type { get; set; }
        public IPDSharingInfoType IPDSharingInfoType { get; set; }
    }

    public class IPDSharingTimeFrame
    {
        public string type { get; set; }
    }

    public class IPDSharingAccessCriteria
    {
        public string type { get; set; }
    }

    public class IPDSharingURL
    {
        public string type { get; set; }
    }

    public class IPDSharingStatementModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public IPDSharing IPDSharing { get; set; }
        public IPDSharingDescription IPDSharingDescription { get; set; }
        public IPDSharingInfoTypeList IPDSharingInfoTypeList { get; set; }
        public IPDSharingTimeFrame IPDSharingTimeFrame { get; set; }
        public IPDSharingAccessCriteria IPDSharingAccessCriteria { get; set; }
        public IPDSharingURL IPDSharingURL { get; set; }
    }

    public class ProtocolSection
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public IdentificationModule IdentificationModule { get; set; }
        public StatusModule StatusModule { get; set; }
        public SponsorCollaboratorsModule SponsorCollaboratorsModule { get; set; }
        public OversightModule OversightModule { get; set; }
        public DescriptionModule DescriptionModule { get; set; }
        public ConditionsModule ConditionsModule { get; set; }
        public DesignModule DesignModule { get; set; }
        public ArmsInterventionsModule ArmsInterventionsModule { get; set; }
        public OutcomesModule OutcomesModule { get; set; }
        public EligibilityModule EligibilityModule { get; set; }
        public ContactsLocationsModule ContactsLocationsModule { get; set; }
        public ReferencesModule ReferencesModule { get; set; }
        public IPDSharingStatementModule IPDSharingStatementModule { get; set; }
    }

    public class FlowPreAssignmentDetails
    {
        public string type { get; set; }
    }

    public class FlowRecruitmentDetails
    {
        public string type { get; set; }
    }

    public class FlowTypeUnitsAnalyzed
    {
        public string type { get; set; }
    }

    public class FlowGroupId
    {
        public string type { get; set; }
    }

    public class FlowGroupTitle
    {
        public string type { get; set; }
    }

    public class FlowGroupDescription
    {
        public string type { get; set; }
    }

    public class FlowGroup
    {
        public string type { get; set; }
        public FlowGroupId FlowGroupId { get; set; }
        public FlowGroupTitle FlowGroupTitle { get; set; }
        public FlowGroupDescription FlowGroupDescription { get; set; }
    }

    public class FlowGroupList
    {
        public string type { get; set; }
        public FlowGroup FlowGroup { get; set; }
    }

    public class FlowPeriodTitle
    {
        public string type { get; set; }
    }

    public class FlowMilestoneType
    {
        public string type { get; set; }
    }

    public class FlowMilestoneComment
    {
        public string type { get; set; }
    }

    public class FlowAchievementGroupId
    {
        public string type { get; set; }
    }

    public class FlowAchievementComment
    {
        public string type { get; set; }
    }

    public class FlowAchievementNumSubjects
    {
        public string type { get; set; }
    }

    public class FlowAchievementNumUnits
    {
        public string type { get; set; }
    }

    public class FlowAchievement
    {
        public string type { get; set; }
        public FlowAchievementGroupId FlowAchievementGroupId { get; set; }
        public FlowAchievementComment FlowAchievementComment { get; set; }
        public FlowAchievementNumSubjects FlowAchievementNumSubjects { get; set; }
        public FlowAchievementNumUnits FlowAchievementNumUnits { get; set; }
    }

    public class FlowAchievementList
    {
        public string type { get; set; }
        public FlowAchievement FlowAchievement { get; set; }
    }

    public class FlowMilestone
    {
        public string type { get; set; }
        public FlowMilestoneType FlowMilestoneType { get; set; }
        public FlowMilestoneComment FlowMilestoneComment { get; set; }
        public FlowAchievementList FlowAchievementList { get; set; }
    }

    public class FlowMilestoneList
    {
        public string type { get; set; }
        public FlowMilestone FlowMilestone { get; set; }
    }

    public class FlowDropWithdrawType
    {
        public string type { get; set; }
    }

    public class FlowDropWithdrawComment
    {
        public string type { get; set; }
    }

    public class FlowReasonGroupId
    {
        public string type { get; set; }
    }

    public class FlowReasonComment
    {
        public string type { get; set; }
    }

    public class FlowReasonNumSubjects
    {
        public string type { get; set; }
    }

    public class FlowReasonNumUnits
    {
        public string type { get; set; }
    }

    public class FlowReason
    {
        public string type { get; set; }
        public FlowReasonGroupId FlowReasonGroupId { get; set; }
        public FlowReasonComment FlowReasonComment { get; set; }
        public FlowReasonNumSubjects FlowReasonNumSubjects { get; set; }
        public FlowReasonNumUnits FlowReasonNumUnits { get; set; }
    }

    public class FlowReasonList
    {
        public string type { get; set; }
        public FlowReason FlowReason { get; set; }
    }

    public class FlowDropWithdraw
    {
        public string type { get; set; }
        public FlowDropWithdrawType FlowDropWithdrawType { get; set; }
        public FlowDropWithdrawComment FlowDropWithdrawComment { get; set; }
        public FlowReasonList FlowReasonList { get; set; }
    }

    public class FlowDropWithdrawList
    {
        public string type { get; set; }
        public FlowDropWithdraw FlowDropWithdraw { get; set; }
    }

    public class FlowPeriod
    {
        public string type { get; set; }
        public FlowPeriodTitle FlowPeriodTitle { get; set; }
        public FlowMilestoneList FlowMilestoneList { get; set; }
        public FlowDropWithdrawList FlowDropWithdrawList { get; set; }
    }

    public class FlowPeriodList
    {
        public string type { get; set; }
        public FlowPeriod FlowPeriod { get; set; }
    }

    public class ParticipantFlowModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public FlowPreAssignmentDetails FlowPreAssignmentDetails { get; set; }
        public FlowRecruitmentDetails FlowRecruitmentDetails { get; set; }
        public FlowTypeUnitsAnalyzed FlowTypeUnitsAnalyzed { get; set; }
        public FlowGroupList FlowGroupList { get; set; }
        public FlowPeriodList FlowPeriodList { get; set; }
    }

    public class BaselinePopulationDescription
    {
        public string type { get; set; }
    }

    public class BaselineTypeUnitsAnalyzed
    {
        public string type { get; set; }
    }

    public class BaselineGroupId
    {
        public string type { get; set; }
    }

    public class BaselineGroupTitle
    {
        public string type { get; set; }
    }

    public class BaselineGroupDescription
    {
        public string type { get; set; }
    }

    public class BaselineGroup
    {
        public string type { get; set; }
        public BaselineGroupId BaselineGroupId { get; set; }
        public BaselineGroupTitle BaselineGroupTitle { get; set; }
        public BaselineGroupDescription BaselineGroupDescription { get; set; }
    }

    public class BaselineGroupList
    {
        public string type { get; set; }
        public BaselineGroup BaselineGroup { get; set; }
    }

    public class BaselineDenomUnits
    {
        public string type { get; set; }
    }

    public class BaselineDenomCountGroupId
    {
        public string type { get; set; }
    }

    public class BaselineDenomCountValue
    {
        public string type { get; set; }
    }

    public class BaselineDenomCount
    {
        public string type { get; set; }
        public BaselineDenomCountGroupId BaselineDenomCountGroupId { get; set; }
        public BaselineDenomCountValue BaselineDenomCountValue { get; set; }
    }

    public class BaselineDenomCountList
    {
        public string type { get; set; }
        public BaselineDenomCount BaselineDenomCount { get; set; }
    }

    public class BaselineDenom
    {
        public string type { get; set; }
        public BaselineDenomUnits BaselineDenomUnits { get; set; }
        public BaselineDenomCountList BaselineDenomCountList { get; set; }
    }

    public class BaselineDenomList
    {
        public string type { get; set; }
        public BaselineDenom BaselineDenom { get; set; }
    }

    public class BaselineMeasureTitle
    {
        public string type { get; set; }
    }

    public class BaselineMeasureDescription
    {
        public string type { get; set; }
    }

    public class BaselineMeasurePopulationDescription
    {
        public string type { get; set; }
    }

    public class BaselineMeasureParamType
    {
        public string type { get; set; }
    }

    public class BaselineMeasureDispersionType
    {
        public string type { get; set; }
    }

    public class BaselineMeasureUnitOfMeasure
    {
        public string type { get; set; }
    }

    public class BaselineMeasureCalculatePct
    {
        public string type { get; set; }
    }

    public class BaselineMeasureDenomUnitsSelected
    {
        public string type { get; set; }
    }

    public class BaselineMeasureDenomUnits
    {
        public string type { get; set; }
    }

    public class BaselineMeasureDenomCountGroupId
    {
        public string type { get; set; }
    }

    public class BaselineMeasureDenomCountValue
    {
        public string type { get; set; }
    }

    public class BaselineMeasureDenomCount
    {
        public string type { get; set; }
        public BaselineMeasureDenomCountGroupId BaselineMeasureDenomCountGroupId { get; set; }
        public BaselineMeasureDenomCountValue BaselineMeasureDenomCountValue { get; set; }
    }

    public class BaselineMeasureDenomCountList
    {
        public string type { get; set; }
        public BaselineMeasureDenomCount BaselineMeasureDenomCount { get; set; }
    }

    public class BaselineMeasureDenom
    {
        public string type { get; set; }
        public BaselineMeasureDenomUnits BaselineMeasureDenomUnits { get; set; }
        public BaselineMeasureDenomCountList BaselineMeasureDenomCountList { get; set; }
    }

    public class BaselineMeasureDenomList
    {
        public string type { get; set; }
        public BaselineMeasureDenom BaselineMeasureDenom { get; set; }
    }

    public class BaselineClassTitle
    {
        public string type { get; set; }
    }

    public class BaselineClassDenomUnits
    {
        public string type { get; set; }
    }

    public class BaselineClassDenomCountGroupId
    {
        public string type { get; set; }
    }

    public class BaselineClassDenomCountValue
    {
        public string type { get; set; }
    }

    public class BaselineClassDenomCount
    {
        public string type { get; set; }
        public BaselineClassDenomCountGroupId BaselineClassDenomCountGroupId { get; set; }
        public BaselineClassDenomCountValue BaselineClassDenomCountValue { get; set; }
    }

    public class BaselineClassDenomCountList
    {
        public string type { get; set; }
        public BaselineClassDenomCount BaselineClassDenomCount { get; set; }
    }

    public class BaselineClassDenom
    {
        public string type { get; set; }
        public BaselineClassDenomUnits BaselineClassDenomUnits { get; set; }
        public BaselineClassDenomCountList BaselineClassDenomCountList { get; set; }
    }

    public class BaselineClassDenomList
    {
        public string type { get; set; }
        public BaselineClassDenom BaselineClassDenom { get; set; }
    }

    public class BaselineCategoryTitle
    {
        public string type { get; set; }
    }

    public class BaselineMeasurementGroupId
    {
        public string type { get; set; }
    }

    public class BaselineMeasurementValue
    {
        public string type { get; set; }
    }

    public class BaselineMeasurementSpread
    {
        public string type { get; set; }
    }

    public class BaselineMeasurementLowerLimit
    {
        public string type { get; set; }
    }

    public class BaselineMeasurementUpperLimit
    {
        public string type { get; set; }
    }

    public class BaselineMeasurementComment
    {
        public string type { get; set; }
    }

    public class BaselineMeasurement
    {
        public string type { get; set; }
        public BaselineMeasurementGroupId BaselineMeasurementGroupId { get; set; }
        public BaselineMeasurementValue BaselineMeasurementValue { get; set; }
        public BaselineMeasurementSpread BaselineMeasurementSpread { get; set; }
        public BaselineMeasurementLowerLimit BaselineMeasurementLowerLimit { get; set; }
        public BaselineMeasurementUpperLimit BaselineMeasurementUpperLimit { get; set; }
        public BaselineMeasurementComment BaselineMeasurementComment { get; set; }
    }

    public class BaselineMeasurementList
    {
        public string type { get; set; }
        public BaselineMeasurement BaselineMeasurement { get; set; }
    }

    public class BaselineCategory
    {
        public string type { get; set; }
        public BaselineCategoryTitle BaselineCategoryTitle { get; set; }
        public BaselineMeasurementList BaselineMeasurementList { get; set; }
    }

    public class BaselineCategoryList
    {
        public string type { get; set; }
        public BaselineCategory BaselineCategory { get; set; }
    }

    public class BaselineClass
    {
        public string type { get; set; }
        public BaselineClassTitle BaselineClassTitle { get; set; }
        public BaselineClassDenomList BaselineClassDenomList { get; set; }
        public BaselineCategoryList BaselineCategoryList { get; set; }
    }

    public class BaselineClassList
    {
        public string type { get; set; }
        public BaselineClass BaselineClass { get; set; }
    }

    public class BaselineMeasure
    {
        public string type { get; set; }
        public BaselineMeasureTitle BaselineMeasureTitle { get; set; }
        public BaselineMeasureDescription BaselineMeasureDescription { get; set; }
        public BaselineMeasurePopulationDescription BaselineMeasurePopulationDescription { get; set; }
        public BaselineMeasureParamType BaselineMeasureParamType { get; set; }
        public BaselineMeasureDispersionType BaselineMeasureDispersionType { get; set; }
        public BaselineMeasureUnitOfMeasure BaselineMeasureUnitOfMeasure { get; set; }
        public BaselineMeasureCalculatePct BaselineMeasureCalculatePct { get; set; }
        public BaselineMeasureDenomUnitsSelected BaselineMeasureDenomUnitsSelected { get; set; }
        public BaselineMeasureDenomList BaselineMeasureDenomList { get; set; }
        public BaselineClassList BaselineClassList { get; set; }
    }

    public class BaselineMeasureList
    {
        public string type { get; set; }
        public BaselineMeasure BaselineMeasure { get; set; }
    }

    public class BaselineCharacteristicsModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public BaselinePopulationDescription BaselinePopulationDescription { get; set; }
        public BaselineTypeUnitsAnalyzed BaselineTypeUnitsAnalyzed { get; set; }
        public BaselineGroupList BaselineGroupList { get; set; }
        public BaselineDenomList BaselineDenomList { get; set; }
        public BaselineMeasureList BaselineMeasureList { get; set; }
    }

    public class OutcomeMeasureType
    {
        public string type { get; set; }
    }

    public class OutcomeMeasureTitle
    {
        public string type { get; set; }
    }

    public class OutcomeMeasureDescription
    {
        public string type { get; set; }
    }

    public class OutcomeMeasurePopulationDescription
    {
        public string type { get; set; }
    }

    public class OutcomeMeasureReportingStatus
    {
        public string type { get; set; }
    }

    public class OutcomeMeasureAnticipatedPostingDate
    {
        public string type { get; set; }
    }

    public class OutcomeMeasureParamType
    {
        public string type { get; set; }
    }

    public class OutcomeMeasureDispersionType
    {
        public string type { get; set; }
    }

    public class OutcomeMeasureUnitOfMeasure
    {
        public string type { get; set; }
    }

    public class OutcomeMeasureCalculatePct
    {
        public string type { get; set; }
    }

    public class OutcomeMeasureTimeFrame
    {
        public string type { get; set; }
    }

    public class OutcomeMeasureTypeUnitsAnalyzed
    {
        public string type { get; set; }
    }

    public class OutcomeMeasureDenomUnitsSelected
    {
        public string type { get; set; }
    }

    public class OutcomeGroupId
    {
        public string type { get; set; }
    }

    public class OutcomeGroupTitle
    {
        public string type { get; set; }
    }

    public class OutcomeGroupDescription
    {
        public string type { get; set; }
    }

    public class OutcomeGroup
    {
        public string type { get; set; }
        public OutcomeGroupId OutcomeGroupId { get; set; }
        public OutcomeGroupTitle OutcomeGroupTitle { get; set; }
        public OutcomeGroupDescription OutcomeGroupDescription { get; set; }
    }

    public class OutcomeGroupList
    {
        public string type { get; set; }
        public OutcomeGroup OutcomeGroup { get; set; }
    }

    public class OutcomeDenomUnits
    {
        public string type { get; set; }
    }

    public class OutcomeDenomCountGroupId
    {
        public string type { get; set; }
    }

    public class OutcomeDenomCountValue
    {
        public string type { get; set; }
    }

    public class OutcomeDenomCount
    {
        public string type { get; set; }
        public OutcomeDenomCountGroupId OutcomeDenomCountGroupId { get; set; }
        public OutcomeDenomCountValue OutcomeDenomCountValue { get; set; }
    }

    public class OutcomeDenomCountList
    {
        public string type { get; set; }
        public OutcomeDenomCount OutcomeDenomCount { get; set; }
    }

    public class OutcomeDenom
    {
        public string type { get; set; }
        public OutcomeDenomUnits OutcomeDenomUnits { get; set; }
        public OutcomeDenomCountList OutcomeDenomCountList { get; set; }
    }

    public class OutcomeDenomList
    {
        public string type { get; set; }
        public OutcomeDenom OutcomeDenom { get; set; }
    }

    public class OutcomeClassTitle
    {
        public string type { get; set; }
    }

    public class OutcomeClassDenomUnits
    {
        public string type { get; set; }
    }

    public class OutcomeClassDenomCountGroupId
    {
        public string type { get; set; }
    }

    public class OutcomeClassDenomCountValue
    {
        public string type { get; set; }
    }

    public class OutcomeClassDenomCount
    {
        public string type { get; set; }
        public OutcomeClassDenomCountGroupId OutcomeClassDenomCountGroupId { get; set; }
        public OutcomeClassDenomCountValue OutcomeClassDenomCountValue { get; set; }
    }

    public class OutcomeClassDenomCountList
    {
        public string type { get; set; }
        public OutcomeClassDenomCount OutcomeClassDenomCount { get; set; }
    }

    public class OutcomeClassDenom
    {
        public string type { get; set; }
        public OutcomeClassDenomUnits OutcomeClassDenomUnits { get; set; }
        public OutcomeClassDenomCountList OutcomeClassDenomCountList { get; set; }
    }

    public class OutcomeClassDenomList
    {
        public string type { get; set; }
        public OutcomeClassDenom OutcomeClassDenom { get; set; }
    }

    public class OutcomeCategoryTitle
    {
        public string type { get; set; }
    }

    public class OutcomeMeasurementGroupId
    {
        public string type { get; set; }
    }

    public class OutcomeMeasurementValue
    {
        public string type { get; set; }
    }

    public class OutcomeMeasurementSpread
    {
        public string type { get; set; }
    }

    public class OutcomeMeasurementLowerLimit
    {
        public string type { get; set; }
    }

    public class OutcomeMeasurementUpperLimit
    {
        public string type { get; set; }
    }

    public class OutcomeMeasurementComment
    {
        public string type { get; set; }
    }

    public class OutcomeMeasurement
    {
        public string type { get; set; }
        public OutcomeMeasurementGroupId OutcomeMeasurementGroupId { get; set; }
        public OutcomeMeasurementValue OutcomeMeasurementValue { get; set; }
        public OutcomeMeasurementSpread OutcomeMeasurementSpread { get; set; }
        public OutcomeMeasurementLowerLimit OutcomeMeasurementLowerLimit { get; set; }
        public OutcomeMeasurementUpperLimit OutcomeMeasurementUpperLimit { get; set; }
        public OutcomeMeasurementComment OutcomeMeasurementComment { get; set; }
    }

    public class OutcomeMeasurementList
    {
        public string type { get; set; }
        public OutcomeMeasurement OutcomeMeasurement { get; set; }
    }

    public class OutcomeCategory
    {
        public string type { get; set; }
        public OutcomeCategoryTitle OutcomeCategoryTitle { get; set; }
        public OutcomeMeasurementList OutcomeMeasurementList { get; set; }
    }

    public class OutcomeCategoryList
    {
        public string type { get; set; }
        public OutcomeCategory OutcomeCategory { get; set; }
    }

    public class OutcomeClass
    {
        public string type { get; set; }
        public OutcomeClassTitle OutcomeClassTitle { get; set; }
        public OutcomeClassDenomList OutcomeClassDenomList { get; set; }
        public OutcomeCategoryList OutcomeCategoryList { get; set; }
    }

    public class OutcomeClassList
    {
        public string type { get; set; }
        public OutcomeClass OutcomeClass { get; set; }
    }

    public class OutcomeAnalysisGroupId
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisGroupIdList
    {
        public string type { get; set; }
        public OutcomeAnalysisGroupId OutcomeAnalysisGroupId { get; set; }
    }

    public class OutcomeAnalysisGroupDescription
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisTestedNonInferiority
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisNonInferiorityType
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisNonInferiorityComment
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisPValue
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisPValueComment
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisStatisticalMethod
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisStatisticalComment
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisParamType
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisParamValue
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisCIPctValue
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisCINumSides
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisCILowerLimit
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisCIUpperLimit
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisCILowerLimitComment
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisCIUpperLimitComment
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisDispersionType
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisDispersionValue
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisEstimateComment
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysisOtherAnalysisDescription
    {
        public string type { get; set; }
    }

    public class OutcomeAnalysis
    {
        public string type { get; set; }
        public OutcomeAnalysisGroupIdList OutcomeAnalysisGroupIdList { get; set; }
        public OutcomeAnalysisGroupDescription OutcomeAnalysisGroupDescription { get; set; }
        public OutcomeAnalysisTestedNonInferiority OutcomeAnalysisTestedNonInferiority { get; set; }
        public OutcomeAnalysisNonInferiorityType OutcomeAnalysisNonInferiorityType { get; set; }
        public OutcomeAnalysisNonInferiorityComment OutcomeAnalysisNonInferiorityComment { get; set; }
        public OutcomeAnalysisPValue OutcomeAnalysisPValue { get; set; }
        public OutcomeAnalysisPValueComment OutcomeAnalysisPValueComment { get; set; }
        public OutcomeAnalysisStatisticalMethod OutcomeAnalysisStatisticalMethod { get; set; }
        public OutcomeAnalysisStatisticalComment OutcomeAnalysisStatisticalComment { get; set; }
        public OutcomeAnalysisParamType OutcomeAnalysisParamType { get; set; }
        public OutcomeAnalysisParamValue OutcomeAnalysisParamValue { get; set; }
        public OutcomeAnalysisCIPctValue OutcomeAnalysisCIPctValue { get; set; }
        public OutcomeAnalysisCINumSides OutcomeAnalysisCINumSides { get; set; }
        public OutcomeAnalysisCILowerLimit OutcomeAnalysisCILowerLimit { get; set; }
        public OutcomeAnalysisCIUpperLimit OutcomeAnalysisCIUpperLimit { get; set; }
        public OutcomeAnalysisCILowerLimitComment OutcomeAnalysisCILowerLimitComment { get; set; }
        public OutcomeAnalysisCIUpperLimitComment OutcomeAnalysisCIUpperLimitComment { get; set; }
        public OutcomeAnalysisDispersionType OutcomeAnalysisDispersionType { get; set; }
        public OutcomeAnalysisDispersionValue OutcomeAnalysisDispersionValue { get; set; }
        public OutcomeAnalysisEstimateComment OutcomeAnalysisEstimateComment { get; set; }
        public OutcomeAnalysisOtherAnalysisDescription OutcomeAnalysisOtherAnalysisDescription { get; set; }
    }

    public class OutcomeAnalysisList
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public OutcomeAnalysis OutcomeAnalysis { get; set; }
    }

    public class OutcomeMeasure
    {
        public string type { get; set; }
        public OutcomeMeasureType OutcomeMeasureType { get; set; }
        public OutcomeMeasureTitle OutcomeMeasureTitle { get; set; }
        public OutcomeMeasureDescription OutcomeMeasureDescription { get; set; }
        public OutcomeMeasurePopulationDescription OutcomeMeasurePopulationDescription { get; set; }
        public OutcomeMeasureReportingStatus OutcomeMeasureReportingStatus { get; set; }
        public OutcomeMeasureAnticipatedPostingDate OutcomeMeasureAnticipatedPostingDate { get; set; }
        public OutcomeMeasureParamType OutcomeMeasureParamType { get; set; }
        public OutcomeMeasureDispersionType OutcomeMeasureDispersionType { get; set; }
        public OutcomeMeasureUnitOfMeasure OutcomeMeasureUnitOfMeasure { get; set; }
        public OutcomeMeasureCalculatePct OutcomeMeasureCalculatePct { get; set; }
        public OutcomeMeasureTimeFrame OutcomeMeasureTimeFrame { get; set; }
        public OutcomeMeasureTypeUnitsAnalyzed OutcomeMeasureTypeUnitsAnalyzed { get; set; }
        public OutcomeMeasureDenomUnitsSelected OutcomeMeasureDenomUnitsSelected { get; set; }
        public OutcomeGroupList OutcomeGroupList { get; set; }
        public OutcomeDenomList OutcomeDenomList { get; set; }
        public OutcomeClassList OutcomeClassList { get; set; }
        public OutcomeAnalysisList OutcomeAnalysisList { get; set; }
    }

    public class OutcomeMeasureList
    {
        public string type { get; set; }
        public OutcomeMeasure OutcomeMeasure { get; set; }
    }

    public class OutcomeMeasuresModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public OutcomeMeasureList OutcomeMeasureList { get; set; }
    }

    public class EventsFrequencyThreshold
    {
        public string type { get; set; }
    }

    public class EventsTimeFrame
    {
        public string type { get; set; }
    }

    public class EventsDescription
    {
        public string type { get; set; }
    }

    public class EventGroupId
    {
        public string type { get; set; }
    }

    public class EventGroupTitle
    {
        public string type { get; set; }
    }

    public class EventGroupDescription
    {
        public string type { get; set; }
    }

    public class EventGroupDeathsNumAffected
    {
        public string type { get; set; }
    }

    public class EventGroupDeathsNumAtRisk
    {
        public string type { get; set; }
    }

    public class EventGroupSeriousNumAffected
    {
        public string type { get; set; }
    }

    public class EventGroupSeriousNumAtRisk
    {
        public string type { get; set; }
    }

    public class EventGroupOtherNumAffected
    {
        public string type { get; set; }
    }

    public class EventGroupOtherNumAtRisk
    {
        public string type { get; set; }
    }

    public class EventGroup
    {
        public string type { get; set; }
        public EventGroupId EventGroupId { get; set; }
        public EventGroupTitle EventGroupTitle { get; set; }
        public EventGroupDescription EventGroupDescription { get; set; }
        public EventGroupDeathsNumAffected EventGroupDeathsNumAffected { get; set; }
        public EventGroupDeathsNumAtRisk EventGroupDeathsNumAtRisk { get; set; }
        public EventGroupSeriousNumAffected EventGroupSeriousNumAffected { get; set; }
        public EventGroupSeriousNumAtRisk EventGroupSeriousNumAtRisk { get; set; }
        public EventGroupOtherNumAffected EventGroupOtherNumAffected { get; set; }
        public EventGroupOtherNumAtRisk EventGroupOtherNumAtRisk { get; set; }
    }

    public class EventGroupList
    {
        public string type { get; set; }
        public EventGroup EventGroup { get; set; }
    }

    public class SeriousEventTerm
    {
        public string type { get; set; }
    }

    public class SeriousEventOrganSystem
    {
        public string type { get; set; }
    }

    public class SeriousEventSourceVocabulary
    {
        public string type { get; set; }
    }

    public class SeriousEventAssessmentType
    {
        public string type { get; set; }
    }

    public class SeriousEventNotes
    {
        public string type { get; set; }
    }

    public class SeriousEventStatsGroupId
    {
        public string type { get; set; }
    }

    public class SeriousEventStatsNumEvents
    {
        public string type { get; set; }
    }

    public class SeriousEventStatsNumAffected
    {
        public string type { get; set; }
    }

    public class SeriousEventStatsNumAtRisk
    {
        public string type { get; set; }
    }

    public class SeriousEventStats
    {
        public string type { get; set; }
        public SeriousEventStatsGroupId SeriousEventStatsGroupId { get; set; }
        public SeriousEventStatsNumEvents SeriousEventStatsNumEvents { get; set; }
        public SeriousEventStatsNumAffected SeriousEventStatsNumAffected { get; set; }
        public SeriousEventStatsNumAtRisk SeriousEventStatsNumAtRisk { get; set; }
    }

    public class SeriousEventStatsList
    {
        public string type { get; set; }
        public SeriousEventStats SeriousEventStats { get; set; }
    }

    public class SeriousEvent
    {
        public string type { get; set; }
        public SeriousEventTerm SeriousEventTerm { get; set; }
        public SeriousEventOrganSystem SeriousEventOrganSystem { get; set; }
        public SeriousEventSourceVocabulary SeriousEventSourceVocabulary { get; set; }
        public SeriousEventAssessmentType SeriousEventAssessmentType { get; set; }
        public SeriousEventNotes SeriousEventNotes { get; set; }
        public SeriousEventStatsList SeriousEventStatsList { get; set; }
    }

    public class SeriousEventList
    {
        public string type { get; set; }
        public SeriousEvent SeriousEvent { get; set; }
    }

    public class OtherEventTerm
    {
        public string type { get; set; }
    }

    public class OtherEventOrganSystem
    {
        public string type { get; set; }
    }

    public class OtherEventSourceVocabulary
    {
        public string type { get; set; }
    }

    public class OtherEventAssessmentType
    {
        public string type { get; set; }
    }

    public class OtherEventNotes
    {
        public string type { get; set; }
    }

    public class OtherEventStatsGroupId
    {
        public string type { get; set; }
    }

    public class OtherEventStatsNumEvents
    {
        public string type { get; set; }
    }

    public class OtherEventStatsNumAffected
    {
        public string type { get; set; }
    }

    public class OtherEventStatsNumAtRisk
    {
        public string type { get; set; }
    }

    public class OtherEventStats
    {
        public string type { get; set; }
        public OtherEventStatsGroupId OtherEventStatsGroupId { get; set; }
        public OtherEventStatsNumEvents OtherEventStatsNumEvents { get; set; }
        public OtherEventStatsNumAffected OtherEventStatsNumAffected { get; set; }
        public OtherEventStatsNumAtRisk OtherEventStatsNumAtRisk { get; set; }
    }

    public class OtherEventStatsList
    {
        public string type { get; set; }
        public OtherEventStats OtherEventStats { get; set; }
    }

    public class OtherEvent
    {
        public string type { get; set; }
        public OtherEventTerm OtherEventTerm { get; set; }
        public OtherEventOrganSystem OtherEventOrganSystem { get; set; }
        public OtherEventSourceVocabulary OtherEventSourceVocabulary { get; set; }
        public OtherEventAssessmentType OtherEventAssessmentType { get; set; }
        public OtherEventNotes OtherEventNotes { get; set; }
        public OtherEventStatsList OtherEventStatsList { get; set; }
    }

    public class OtherEventList
    {
        public string type { get; set; }
        public OtherEvent OtherEvent { get; set; }
    }

    public class AdverseEventsModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public EventsFrequencyThreshold EventsFrequencyThreshold { get; set; }
        public EventsTimeFrame EventsTimeFrame { get; set; }
        public EventsDescription EventsDescription { get; set; }
        public EventGroupList EventGroupList { get; set; }
        public SeriousEventList SeriousEventList { get; set; }
        public OtherEventList OtherEventList { get; set; }
    }

    public class LimitationsAndCaveats
    {
        public string type { get; set; }
        public string dedLink { get; set; }
    }

    public class AgreementPISponsorEmployee
    {
        public string type { get; set; }
    }

    public class AgreementRestrictionType
    {
        public string type { get; set; }
    }

    public class AgreementRestrictiveAgreement
    {
        public string type { get; set; }
    }

    public class AgreementOtherDetails
    {
        public string type { get; set; }
    }

    public class CertainAgreement
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public AgreementPISponsorEmployee AgreementPISponsorEmployee { get; set; }
        public AgreementRestrictionType AgreementRestrictionType { get; set; }
        public AgreementRestrictiveAgreement AgreementRestrictiveAgreement { get; set; }
        public AgreementOtherDetails AgreementOtherDetails { get; set; }
    }

    public class PointOfContactTitle
    {
        public string type { get; set; }
    }

    public class PointOfContactOrganization
    {
        public string type { get; set; }
    }

    public class PointOfContactEMail
    {
        public string type { get; set; }
    }

    public class PointOfContactPhone
    {
        public string type { get; set; }
    }

    public class PointOfContactPhoneExt
    {
        public string type { get; set; }
    }

    public class PointOfContact
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public PointOfContactTitle PointOfContactTitle { get; set; }
        public PointOfContactOrganization PointOfContactOrganization { get; set; }
        public PointOfContactEMail PointOfContactEMail { get; set; }
        public PointOfContactPhone PointOfContactPhone { get; set; }
        public PointOfContactPhoneExt PointOfContactPhoneExt { get; set; }
    }

    public class MoreInfoModule
    {
        public string type { get; set; }
        public LimitationsAndCaveats LimitationsAndCaveats { get; set; }
        public CertainAgreement CertainAgreement { get; set; }
        public PointOfContact PointOfContact { get; set; }
    }

    public class ResultsSection
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public ParticipantFlowModule ParticipantFlowModule { get; set; }
        public BaselineCharacteristicsModule BaselineCharacteristicsModule { get; set; }
        public OutcomeMeasuresModule OutcomeMeasuresModule { get; set; }
        public AdverseEventsModule AdverseEventsModule { get; set; }
        public MoreInfoModule MoreInfoModule { get; set; }
    }

    public class UnpostedResponsibleParty
    {
        public string type { get; set; }
    }

    public class UnpostedEventType
    {
        public string type { get; set; }
    }

    public class UnpostedEventDate
    {
        public string type { get; set; }
    }

    public class UnpostedEvent
    {
        public string type { get; set; }
        public UnpostedEventType UnpostedEventType { get; set; }
        public UnpostedEventDate UnpostedEventDate { get; set; }
    }

    public class UnpostedEventList
    {
        public string type { get; set; }
        public UnpostedEvent UnpostedEvent { get; set; }
    }

    public class UnpostedAnnotation
    {
        public string type { get; set; }
        public UnpostedResponsibleParty UnpostedResponsibleParty { get; set; }
        public UnpostedEventList UnpostedEventList { get; set; }
    }

    public class AnnotationModule
    {
        public string type { get; set; }
        public UnpostedAnnotation UnpostedAnnotation { get; set; }
    }

    public class AnnotationSection
    {
        public string type { get; set; }
        public AnnotationModule AnnotationModule { get; set; }
    }

    public class LargeDocTypeAbbrev
    {
        public string type { get; set; }
    }

    public class LargeDocHasProtocol
    {
        public string type { get; set; }
    }

    public class LargeDocHasSAP
    {
        public string type { get; set; }
    }

    public class LargeDocHasICF
    {
        public string type { get; set; }
    }

    public class LargeDocLabel
    {
        public string type { get; set; }
    }

    public class LargeDocDate
    {
        public string type { get; set; }
    }

    public class LargeDocUploadDate
    {
        public string type { get; set; }
    }

    public class LargeDocFilename
    {
        public string type { get; set; }
    }

    public class LargeDoc
    {
        public string type { get; set; }
        public LargeDocTypeAbbrev LargeDocTypeAbbrev { get; set; }
        public LargeDocHasProtocol LargeDocHasProtocol { get; set; }
        public LargeDocHasSAP LargeDocHasSAP { get; set; }
        public LargeDocHasICF LargeDocHasICF { get; set; }
        public LargeDocLabel LargeDocLabel { get; set; }
        public LargeDocDate LargeDocDate { get; set; }
        public LargeDocUploadDate LargeDocUploadDate { get; set; }
        public LargeDocFilename LargeDocFilename { get; set; }
    }

    public class LargeDocList
    {
        public string type { get; set; }
        public LargeDoc LargeDoc { get; set; }
    }

    public class LargeDocumentModule
    {
        public string type { get; set; }
        public string dedLink { get; set; }
        public LargeDocList LargeDocList { get; set; }
    }

    public class DocumentSection
    {
        public string type { get; set; }
        public LargeDocumentModule LargeDocumentModule { get; set; }
    }

    public class VersionHolder
    {
        public string type { get; set; }
    }

    public class RemovedCountry
    {
        public string type { get; set; }
    }

    public class RemovedCountryList
    {
        public string type { get; set; }
        public RemovedCountry RemovedCountry { get; set; }
    }

    public class MiscInfoModule
    {
        public string type { get; set; }
        public VersionHolder VersionHolder { get; set; }
        public RemovedCountryList RemovedCountryList { get; set; }
    }

    public class ConditionMeshId
    {
        public string type { get; set; }
    }

    public class ConditionMeshTerm
    {
        public string type { get; set; }
    }

    public class ConditionMesh
    {
        public string type { get; set; }
        public ConditionMeshId ConditionMeshId { get; set; }
        public ConditionMeshTerm ConditionMeshTerm { get; set; }
    }

    public class ConditionMeshList
    {
        public string type { get; set; }
        public ConditionMesh ConditionMesh { get; set; }
    }

    public class ConditionAncestorId
    {
        public string type { get; set; }
    }

    public class ConditionAncestorTerm
    {
        public string type { get; set; }
    }

    public class ConditionAncestor
    {
        public string type { get; set; }
        public ConditionAncestorId ConditionAncestorId { get; set; }
        public ConditionAncestorTerm ConditionAncestorTerm { get; set; }
    }

    public class ConditionAncestorList
    {
        public string type { get; set; }
        public ConditionAncestor ConditionAncestor { get; set; }
    }

    public class ConditionBrowseLeafId
    {
        public string type { get; set; }
    }

    public class ConditionBrowseLeafName
    {
        public string type { get; set; }
    }

    public class ConditionBrowseLeafAsFound
    {
        public string type { get; set; }
    }

    public class ConditionBrowseLeafRelevance
    {
        public string type { get; set; }
    }

    public class ConditionBrowseLeaf
    {
        public string type { get; set; }
        public ConditionBrowseLeafId ConditionBrowseLeafId { get; set; }
        public ConditionBrowseLeafName ConditionBrowseLeafName { get; set; }
        public ConditionBrowseLeafAsFound ConditionBrowseLeafAsFound { get; set; }
        public ConditionBrowseLeafRelevance ConditionBrowseLeafRelevance { get; set; }
    }

    public class ConditionBrowseLeafList
    {
        public string type { get; set; }
        public ConditionBrowseLeaf ConditionBrowseLeaf { get; set; }
    }

    public class ConditionBrowseBranchAbbrev
    {
        public string type { get; set; }
    }

    public class ConditionBrowseBranchName
    {
        public string type { get; set; }
    }

    public class ConditionBrowseBranch
    {
        public string type { get; set; }
        public ConditionBrowseBranchAbbrev ConditionBrowseBranchAbbrev { get; set; }
        public ConditionBrowseBranchName ConditionBrowseBranchName { get; set; }
    }

    public class ConditionBrowseBranchList
    {
        public string type { get; set; }
        public ConditionBrowseBranch ConditionBrowseBranch { get; set; }
    }

    public class ConditionBrowseModule
    {
        public string type { get; set; }
        public ConditionMeshList ConditionMeshList { get; set; }
        public ConditionAncestorList ConditionAncestorList { get; set; }
        public ConditionBrowseLeafList ConditionBrowseLeafList { get; set; }
        public ConditionBrowseBranchList ConditionBrowseBranchList { get; set; }
    }

    public class InterventionMeshId
    {
        public string type { get; set; }
    }

    public class InterventionMeshTerm
    {
        public string type { get; set; }
    }

    public class InterventionMesh
    {
        public string type { get; set; }
        public InterventionMeshId InterventionMeshId { get; set; }
        public InterventionMeshTerm InterventionMeshTerm { get; set; }
    }

    public class InterventionMeshList
    {
        public string type { get; set; }
        public InterventionMesh InterventionMesh { get; set; }
    }

    public class InterventionAncestorId
    {
        public string type { get; set; }
    }

    public class InterventionAncestorTerm
    {
        public string type { get; set; }
    }

    public class InterventionAncestor
    {
        public string type { get; set; }
        public InterventionAncestorId InterventionAncestorId { get; set; }
        public InterventionAncestorTerm InterventionAncestorTerm { get; set; }
    }

    public class InterventionAncestorList
    {
        public string type { get; set; }
        public InterventionAncestor InterventionAncestor { get; set; }
    }

    public class InterventionBrowseLeafId
    {
        public string type { get; set; }
    }

    public class InterventionBrowseLeafName
    {
        public string type { get; set; }
    }

    public class InterventionBrowseLeafAsFound
    {
        public string type { get; set; }
    }

    public class InterventionBrowseLeafRelevance
    {
        public string type { get; set; }
    }

    public class InterventionBrowseLeaf
    {
        public string type { get; set; }
        public InterventionBrowseLeafId InterventionBrowseLeafId { get; set; }
        public InterventionBrowseLeafName InterventionBrowseLeafName { get; set; }
        public InterventionBrowseLeafAsFound InterventionBrowseLeafAsFound { get; set; }
        public InterventionBrowseLeafRelevance InterventionBrowseLeafRelevance { get; set; }
    }

    public class InterventionBrowseLeafList
    {
        public string type { get; set; }
        public InterventionBrowseLeaf InterventionBrowseLeaf { get; set; }
    }

    public class InterventionBrowseBranchAbbrev
    {
        public string type { get; set; }
    }

    public class InterventionBrowseBranchName
    {
        public string type { get; set; }
    }

    public class InterventionBrowseBranch
    {
        public string type { get; set; }
        public InterventionBrowseBranchAbbrev InterventionBrowseBranchAbbrev { get; set; }
        public InterventionBrowseBranchName InterventionBrowseBranchName { get; set; }
    }

    public class InterventionBrowseBranchList
    {
        public string type { get; set; }
        public InterventionBrowseBranch InterventionBrowseBranch { get; set; }
    }

    public class InterventionBrowseModule
    {
        public string type { get; set; }
        public InterventionMeshList InterventionMeshList { get; set; }
        public InterventionAncestorList InterventionAncestorList { get; set; }
        public InterventionBrowseLeafList InterventionBrowseLeafList { get; set; }
        public InterventionBrowseBranchList InterventionBrowseBranchList { get; set; }
    }

    public class DerivedSection
    {
        public string type { get; set; }
        public MiscInfoModule MiscInfoModule { get; set; }
        public ConditionBrowseModule ConditionBrowseModule { get; set; }
        public InterventionBrowseModule InterventionBrowseModule { get; set; }
    }

    public class Study
    {
        public string type { get; set; }
        public ProtocolSection ProtocolSection { get; set; }
        public ResultsSection ResultsSection { get; set; }
        public AnnotationSection AnnotationSection { get; set; }
        public DocumentSection DocumentSection { get; set; }
        public DerivedSection DerivedSection { get; set; }
    }

    public class FullStudy
    {
        public int Rank { get; set; }
        public virtual Study Study { get; set; }
    }

    public class Root
    {
        public virtual FullStudy FullStudy { get; set; }
    }


}
