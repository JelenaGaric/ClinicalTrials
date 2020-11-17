using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    /*
    public class NCTIdAliasList
    {
        public string type { get; set; }
        public NCTIdAlias NCTIdAlias { get; set; }
    }


    public class OrgStudyIdInfo
    {
        public string type { get; set; }
        public OrgStudyId OrgStudyId { get; set; }
        public OrgStudyIdType OrgStudyIdType { get; set; }
        public OrgStudyIdDomain OrgStudyIdDomain { get; set; }
        public OrgStudyIdLink OrgStudyIdLink { get; set; }
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


    public class Organization
    {
        public string type { get; set; }
        public OrgFullName OrgFullName { get; set; }
        public OrgClass OrgClass { get; set; }
    }
    */

   

    public class PrimaryCompletionDateStruct
    {
        public string PrimaryCompletionDate { get; set; }
        public string PrimaryCompletionDateType { get; set; }
    }


    public class CompletionDateStruct
    {
        public string CompletionDate { get; set; }
        public string CompletionDateType { get; set; }
    }

    public class ResultsFirstPostDateStruct
    {
        public string ResultsFirstPostDate { get; set; }
        public string ResultsFirstPostDateType { get; set; }
    }
    public class DispFirstPostDateStruct
    {
        public string DispFirstPostDate { get; set; }
        public string DispFirstPostDateType { get; set; }
    }


    public class ResponsibleParty
    {
        public string ResponsiblePartyType { get; set; }
        public string ResponsiblePartyInvestigatorFullName { get; set; }
        public string ResponsiblePartyInvestigatorTitle { get; set; }
        public string ResponsiblePartyInvestigatorAffiliation { get; set; }
        public string ResponsiblePartyOldNameTitle { get; set; }
        public string ResponsiblePartyOldOrganization { get; set; }
    }

 

    public class Collaborator
    {
        public string CollaboratorName { get; set; }
        public string CollaboratorClass { get; set; }
    }

    public class CollaboratorList
    {
        public List<Collaborator> Collaborator { get; set; }
    }

    public class SponsorCollaboratorsModule
    {
        public string dedLink { get; set; }
        public ResponsibleParty ResponsibleParty { get; set; }
        public LeadSponsor LeadSponsor { get; set; }
        public CollaboratorList CollaboratorList { get; set; }
    }


    public class OversightModule
    {
        public string OversightHasDMC { get; set; }
        public string IsFDARegulatedDrug { get; set; }
        public string IsFDARegulatedDevice { get; set; }
        public string IsUnapprovedDevice { get; set; }
        public string IsPPSD { get; set; }
        public string IsUSExport { get; set; }
    }


    public class KeywordList
    {
        public List<string> Keyword { get; set; }
    }


    public class ExpandedAccessTypes
    {
        public string ExpAccTypeIndividual { get; set; }
        public string ExpAccTypeIntermediate { get; set; }
        public string ExpAccTypeTreatment { get; set; }
    }


    public class DesignObservationalModelList
    {
        public List<string> DesignObservationalModel { get; set; }
    }


    public class DesignTimePerspectiveList
    {
        public List<string> DesignTimePerspective { get; set; }
    }

  

    public class BioSpec
    {
        public string BioSpecRetention { get; set; }
        public string BioSpecDescription { get; set; }
    }


    public class EnrollmentInfo
    {
        public string EnrollmentCount { get; set; }
        public string EnrollmentType { get; set; }
    }

    public class StartDateStruct
{
        public string StartDate { get; set; }
        public string StartDateType { get; set; }
    }
    public class ArmGroupInterventionList
    {
        public List<string> ArmGroupInterventionName { get; set; }
    }

    public class ArmGroup
    {
        public string ArmGroupLabel { get; set; }
        public string ArmGroupType { get; set; }
        public string ArmGroupDescription { get; set; }
        public ArmGroupInterventionList ArmGroupInterventionList { get; set; }
    }


 
    public class PrimaryOutcome
    {
        public string PrimaryOutcomeMeasure { get; set; }
        public string PrimaryOutcomeDescription { get; set; }
        public string PrimaryOutcomeTimeFrame { get; set; }
    }

    public class PrimaryOutcomeList
    {
        public List<PrimaryOutcome> PrimaryOutcome { get; set; }
    }


    public class SecondaryOutcome
    {
        public string SecondaryOutcomeMeasure { get; set; }
        public string SecondaryOutcomeDescription { get; set; }
        public string SecondaryOutcomeTimeFrame { get; set; }
    }

    public class SecondaryOutcomeList
    {
        public List<SecondaryOutcome> SecondaryOutcome { get; set; }
    }

    public class OtherOutcome
    {
        public string OtherOutcomeMeasure { get; set; }
        public string OtherOutcomeDescription { get; set; }
        public string OtherOutcomeTimeFrame { get; set; }
    }

    public class OtherOutcomeList
    {
        public List<OtherOutcome> OtherOutcome { get; set; }
    }

    public class OutcomesModule
    {
        public string dedLink { get; set; }
        public PrimaryOutcomeList PrimaryOutcomeList { get; set; }
        public SecondaryOutcomeList SecondaryOutcomeList { get; set; }
        public OtherOutcomeList OtherOutcomeList { get; set; }
    }


    public class CentralContact
    {
        public string CentralContactName { get; set; }
        public string CentralContactRole { get; set; }
        public string CentralContactPhone { get; set; }
        public string CentralContactPhoneExt { get; set; }
        public string CentralContactEMail { get; set; }
    }

    public class CentralContactList
    {
        public List<CentralContact> CentralContact { get; set; }
    }


    public class OverallOfficial
    {
        public string OverallOfficialName { get; set; }
        public string OverallOfficialAffiliation { get; set; }
        public string OverallOfficialRole { get; set; }
    }

    public class OverallOfficialList
    {
        public List<OverallOfficial> OverallOfficial { get; set; }
    }

    public class LocationContact : StudyStructureEntity
    {
        public string LocationContactName { get; set; }
        public string LocationContactRole { get; set; }
        public string LocationContactPhone { get; set; }
        public string LocationContactPhoneExt { get; set; }
        public string LocationContactEMail { get; set; }
    }

    /* public class LocationContactList
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
     }*/

 
    public class Retraction : StudyStructureEntity
    {
        public string RetractionPMID { get; set; }
        public string RetractionSource { get; set; }
    }

    public class RetractionList : StudyStructureEntity
    {
        public List<Retraction> Retraction { get; set; }
    }

    public class Reference : StudyStructureEntity
    {
        public string ReferencePMID { get; set; }
        public string ReferenceType { get; set; }
        public string ReferenceCitation { get; set; }
        public RetractionList RetractionList { get; set; }
    }

    public class ReferenceList
    {
        public List<Reference> Reference { get; set; }
    }

 

    public class SeeAlsoLink : StudyStructureEntity
    {
        public string SeeAlsoLinkLabel { get; set; }
        public string SeeAlsoLinkURL { get; set; }
    }

    public class SeeAlsoLinkList : StudyStructureEntity
    {
        public List<SeeAlsoLink> SeeAlsoLink { get; set; }
    }

    public class AvailIPD : StudyStructureEntity
    {
        public string AvailIPDId { get; set; }
        public string AvailIPDType { get; set; }
        public string AvailIPDURL { get; set; }
        public string AvailIPDComment { get; set; }
    }

    public class AvailIPDList : StudyStructureEntity
    {
        public List<AvailIPD> AvailIPD { get; set; }
    }

    public class ReferencesModule : StudyStructureEntity
    {
        public string dedLink { get; set; }
        public ReferenceList ReferenceList { get; set; }
        public SeeAlsoLinkList SeeAlsoLinkList { get; set; }
        public AvailIPDList AvailIPDList { get; set; }
    }

    public class IPDSharingInfoTypeList
    {
        public List<string> IPDSharingInfoType;
    }

    public class IPDSharingStatementModule : StudyStructureEntity
    {
        public string dedLink { get; set; }
        public string IPDSharing { get; set; }
        public string IPDSharingDescription { get; set; }
        public IPDSharingInfoTypeList IPDSharingInfoTypeList { get; set; }
        public string IPDSharingTimeFrame { get; set; }
        public string IPDSharingAccessCriteria { get; set; }
        public string IPDSharingURL { get; set; }
    }
    /*
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
    }*/



    public class FlowGroup : StudyStructureEntity
    {
        public string FlowGroupId { get; set; }
        public string FlowGroupTitle { get; set; }
        public string FlowGroupDescription { get; set; }
    }

    public class FlowGroupList : StudyStructureEntity
    {
        public List<FlowGroup> FlowGroup { get; set; }
    }


    public class FlowAchievement : StudyStructureEntity
    {
        public string FlowAchievementGroupId { get; set; }
        public string FlowAchievementComment { get; set; }
        public string FlowAchievementNumSubjects { get; set; }
        public string FlowAchievementNumUnits { get; set; }
    }

    public class FlowAchievementList : StudyStructureEntity
    {
        public List<FlowAchievement> FlowAchievement { get; set; }
    }

    public class FlowMilestone : StudyStructureEntity
    {
        public string FlowMilestoneType { get; set; }
        public string FlowMilestoneComment { get; set; }
        public FlowAchievementList FlowAchievementList { get; set; }
    }

    public class FlowMilestoneList : StudyStructureEntity
    {
        public List<FlowMilestone> FlowMilestone { get; set; }
    }

    public class FlowReason : StudyStructureEntity
    {
        public string FlowReasonGroupId { get; set; }
        public string FlowReasonComment { get; set; }
        public string FlowReasonNumSubjects { get; set; }
        public string FlowReasonNumUnits { get; set; }
    }

    public class FlowReasonList : StudyStructureEntity
    {
        public List<FlowReason> FlowReason { get; set; }
    }

    public class FlowDropWithdraw : StudyStructureEntity
    {
        public string FlowDropWithdrawType { get; set; }
        public string FlowDropWithdrawComment { get; set; }
        public FlowReasonList FlowReasonList { get; set; }
    }

    public class FlowDropWithdrawList : StudyStructureEntity
    {
        public List<FlowDropWithdraw> FlowDropWithdraw { get; set; }
    }

    public class FlowPeriod : StudyStructureEntity
    {
        public string FlowPeriodTitle { get; set; }
        public FlowMilestoneList FlowMilestoneList { get; set; }
        public FlowDropWithdrawList FlowDropWithdrawList { get; set; }
    }

    public class FlowPeriodList : StudyStructureEntity
    {
        public List<FlowPeriod> FlowPeriod { get; set; }
    }

    public class ParticipantFlowModule : StudyStructureEntity
    {
        public string dedLink { get; set; }
        public string FlowPreAssignmentDetails { get; set; }
        public string FlowRecruitmentDetails { get; set; }
        public string FlowTypeUnitsAnalyzed { get; set; }
        public FlowGroupList FlowGroupList { get; set; }
        public FlowPeriodList FlowPeriodList { get; set; }
    }

    
    public class BaselineGroup : StudyStructureEntity
    {
        public string BaselineGroupId { get; set; }
        public string BaselineGroupTitle { get; set; }
        public string BaselineGroupDescription { get; set; }
    }

    public class BaselineGroupList : StudyStructureEntity
    {
        public virtual List<BaselineGroup> BaselineGroup { get; set; }
    }

   
    public class BaselineDenomCount : StudyStructureEntity
    {
        public string BaselineDenomCountGroupId { get; set; }
        public string BaselineDenomCountValue { get; set; }
    }

    public class BaselineDenomCountList : StudyStructureEntity
    {
        public virtual List<BaselineDenomCount> BaselineDenomCount { get; set; }
    }

    public class BaselineDenom : StudyStructureEntity
    {
        public string BaselineDenomUnits { get; set; }
        public BaselineDenomCountList BaselineDenomCountList { get; set; }
    }

    public class BaselineDenomList : StudyStructureEntity
    {
        public virtual List<BaselineDenom> BaselineDenom { get; set; }
    }


    public class BaselineMeasureDenomCount : StudyStructureEntity
    {
        public string BaselineMeasureDenomCountGroupId { get; set; }
        public string BaselineMeasureDenomCountValue { get; set; }
    }

    public class BaselineMeasureDenomCountList : StudyStructureEntity
    {
        public List<BaselineMeasureDenomCount> BaselineMeasureDenomCount { get; set; }
    }

    public class BaselineMeasureDenom : StudyStructureEntity
    {
        public string BaselineMeasureDenomUnits { get; set; }
        public BaselineMeasureDenomCountList BaselineMeasureDenomCountList { get; set; }
    }

    public class BaselineMeasureDenomList : StudyStructureEntity
    
    {
        public List<BaselineMeasureDenom> BaselineMeasureDenom { get; set; }
    }

   
    public class BaselineClassDenomCount
    {
        public string BaselineClassDenomCountGroupId { get; set; }
        public string BaselineClassDenomCountValue { get; set; }
    }

    public class BaselineClassDenomCountList
    {
        public List<BaselineClassDenomCount> BaselineClassDenomCount { get; set; }
    }

    public class BaselineClassDenom
    {
        public string BaselineClassDenomUnits { get; set; }
        public BaselineClassDenomCountList BaselineClassDenomCountList { get; set; }
    }

    public class BaselineClassDenomList
    {
        public List<BaselineClassDenom> BaselineClassDenom { get; set; }
    }

    public class BaselineMeasurement
    {
        public string BaselineMeasurementGroupId { get; set; }
        public string BaselineMeasurementValue { get; set; }
        public string BaselineMeasurementSpread { get; set; }
        public string BaselineMeasurementLowerLimit { get; set; }
        public string BaselineMeasurementUpperLimit { get; set; }
        public string BaselineMeasurementComment { get; set; }
    }

    public class BaselineMeasurementList
    {
        public List<BaselineMeasurement> BaselineMeasurement { get; set; }
    }

    public class BaselineCategory
    {
        public string BaselineCategoryTitle { get; set; }
        public BaselineMeasurementList BaselineMeasurementList { get; set; }
    }

    public class BaselineCategoryList
    {
        public List<BaselineCategory> BaselineCategory { get; set; }
    }

    public class BaselineClass
    {
        public string BaselineClassTitle { get; set; }
        public BaselineClassDenomList BaselineClassDenomList { get; set; }
        public BaselineCategoryList BaselineCategoryList { get; set; }
    }

    public class BaselineClassList
    {
        public List<BaselineClass> BaselineClass { get; set; }
    }

    public class BaselineMeasure
    {
        public string BaselineMeasureTitle { get; set; }
        public string BaselineMeasureDescription { get; set; }
        public string BaselineMeasurePopulationDescription { get; set; }
        public string BaselineMeasureParamType { get; set; }
        public string BaselineMeasureDispersionType { get; set; }
        public string BaselineMeasureUnitOfMeasure { get; set; }
        public string BaselineMeasureCalculatePct { get; set; }
        public string BaselineMeasureDenomUnitsSelected { get; set; }
        public BaselineMeasureDenomList BaselineMeasureDenomList { get; set; }
        public BaselineClassList BaselineClassList { get; set; }
    }

    public class BaselineMeasureList
    {
        public List<BaselineMeasure> BaselineMeasure { get; set; }
    }

    public class BaselineCharacteristicsModule
    {
        public string dedLink { get; set; }
        public string BaselinePopulationDescription { get; set; }
        public string BaselineTypeUnitsAnalyzed { get; set; }
        public BaselineGroupList BaselineGroupList { get; set; }
        public BaselineDenomList BaselineDenomList { get; set; }
        public BaselineMeasureList BaselineMeasureList { get; set; }
    }


    public class OutcomeGroup
    {
        public string OutcomeGroupId { get; set; }
        public string OutcomeGroupTitle { get; set; }
        public string OutcomeGroupDescription { get; set; }
    }

    public class OutcomeGroupList
    {
        public List<OutcomeGroup> OutcomeGroup { get; set; }
    }

    public class OutcomeDenomCount
    {
        public string type { get; set; }
        public string OutcomeDenomCountGroupId { get; set; }
        public string OutcomeDenomCountValue { get; set; }
    }

    public class OutcomeDenomCountList
    {
        public List<OutcomeDenomCount> OutcomeDenomCount { get; set; }
    }

    public class OutcomeDenom
    {
        public string OutcomeDenomUnits { get; set; }
        public OutcomeDenomCountList OutcomeDenomCountList { get; set; }
    }

    public class OutcomeDenomList
    {
        public List<OutcomeDenom> OutcomeDenom { get; set; }
    }


    public class OutcomeClassDenomCount
    {
        public string OutcomeClassDenomCountGroupId { get; set; }
        public string OutcomeClassDenomCountValue { get; set; }
    }

    public class OutcomeClassDenomCountList
    {
        public List<OutcomeClassDenomCount> OutcomeClassDenomCount { get; set; }
    }

    public class OutcomeClassDenom
    {
        public string OutcomeClassDenomUnits { get; set; }
        public OutcomeClassDenomCountList OutcomeClassDenomCountList { get; set; }
    }

    public class OutcomeClassDenomList
    {
        public List<OutcomeClassDenom> OutcomeClassDenom { get; set; }
    }


    public class OutcomeMeasurement
    {
        public string OutcomeMeasurementGroupId { get; set; }
        public string OutcomeMeasurementValue { get; set; }
        public string OutcomeMeasurementSpread { get; set; }
        public string OutcomeMeasurementLowerLimit { get; set; }
        public string OutcomeMeasurementUpperLimit { get; set; }
        public string OutcomeMeasurementComment { get; set; }
    }

    public class OutcomeMeasurementList
    {
        public List<OutcomeMeasurement> OutcomeMeasurement { get; set; }
    }

    public class OutcomeCategory
    {
        public string OutcomeCategoryTitle { get; set; }
        public OutcomeMeasurementList OutcomeMeasurementList { get; set; }
    }

    public class OutcomeCategoryList
    {
        public List<OutcomeCategory> OutcomeCategory { get; set; }
    }

    public class OutcomeClass
    {
        public string OutcomeClassTitle { get; set; }
        public OutcomeClassDenomList OutcomeClassDenomList { get; set; }
        public OutcomeCategoryList OutcomeCategoryList { get; set; }
    }

    public class OutcomeClassList
    {
        public List<OutcomeClass> OutcomeClass { get; set; }
    }

    public class OutcomeAnalysis
    {
        public string type { get; set; }
        public OutcomeAnalysisGroupIdList OutcomeAnalysisGroupIdList { get; set; }
        public string OutcomeAnalysisGroupDescription { get; set; }
        public string OutcomeAnalysisTestedNonInferiority { get; set; }
        public string OutcomeAnalysisNonInferiorityType { get; set; }
        public string OutcomeAnalysisNonInferiorityComment { get; set; }
        public string OutcomeAnalysisPValue { get; set; }
        public string OutcomeAnalysisPValueComment { get; set; }
        public string OutcomeAnalysisStatisticalMethod { get; set; }
        public string OutcomeAnalysisStatisticalComment { get; set; }
        public string OutcomeAnalysisParamType { get; set; }
        public string OutcomeAnalysisParamValue { get; set; }
        public string OutcomeAnalysisCIPctValue { get; set; }
        public string OutcomeAnalysisCINumSides { get; set; }
        public string OutcomeAnalysisCILowerLimit { get; set; }
        public string OutcomeAnalysisCIUpperLimit { get; set; }
        public string OutcomeAnalysisCILowerLimitComment { get; set; }
        public string OutcomeAnalysisCIUpperLimitComment { get; set; }
        public string OutcomeAnalysisDispersionType { get; set; }
        public string OutcomeAnalysisDispersionValue { get; set; }
        public string OutcomeAnalysisEstimateComment { get; set; }
        public string OutcomeAnalysisOtherAnalysisDescription { get; set; }
    }

    public class OutcomeAnalysisGroupIdList
    {
        public List<string> OutcomeAnalysisGroupId { get; set; }
    }
    public class OutcomeAnalysisList
    {
        public string dedLink { get; set; }
        public List<OutcomeAnalysis> OutcomeAnalysis { get; set; }
    }

    public class OutcomeMeasure
    {
        public string OutcomeMeasureType { get; set; }
        public string OutcomeMeasureTitle { get; set; }
        public string OutcomeMeasureDescription { get; set; }
        public string OutcomeMeasurePopulationDescription { get; set; }
        public string OutcomeMeasureReportingStatus { get; set; }
        public string OutcomeMeasureAnticipatedPostingDate { get; set; }
        public string OutcomeMeasureParamType { get; set; }
        public string OutcomeMeasureDispersionType { get; set; }
        public string OutcomeMeasureUnitOfMeasure { get; set; }
        public string OutcomeMeasureCalculatePct { get; set; }
        public string OutcomeMeasureTimeFrame { get; set; }
        public string OutcomeMeasureTypeUnitsAnalyzed { get; set; }
        public string OutcomeMeasureDenomUnitsSelected { get; set; }
        public OutcomeGroupList OutcomeGroupList { get; set; }
        public OutcomeDenomList OutcomeDenomList { get; set; }
        public OutcomeClassList OutcomeClassList { get; set; }
        public OutcomeAnalysisList OutcomeAnalysisList { get; set; }
    }

    public class OutcomeMeasureList
    {
        public List<OutcomeMeasure> OutcomeMeasure { get; set; }
    }

    public class OutcomeMeasuresModule
    {
        public string dedLink { get; set; }
        public OutcomeMeasureList OutcomeMeasureList { get; set; }
    }

  

    public class EventGroup
    {
        public string EventGroupId { get; set; }
        public string EventGroupTitle { get; set; }
        public string EventGroupDescription { get; set; }
        public string EventGroupDeathsNumAffected { get; set; }
        public string EventGroupDeathsNumAtRisk { get; set; }
        public string EventGroupSeriousNumAffected { get; set; }
        public string EventGroupSeriousNumAtRisk { get; set; }
        public string EventGroupOtherNumAffected { get; set; }
        public string EventGroupOtherNumAtRisk { get; set; }
    }

    public class EventGroupList
    {
        public List<EventGroup> EventGroup { get; set; }
    }

    public class OtherEventStats
    {
        public string OtherEventStatsGroupId { get; set; }
        public string OtherEventStatsNumEvents { get; set; }
        public string OtherEventStatsNumAffected { get; set; }
        public string OtherEventStatsNumAtRisk { get; set; }
    }

    public class OtherEventStatsList
    {
        public List<OtherEventStats> OtherEventStats { get; set; }
    }

    public class OtherEvent
    {
        public string OtherEventTerm { get; set; }
        public string OtherEventOrganSystem { get; set; }
        public string OtherEventSourceVocabulary { get; set; }
        public string OtherEventAssessmentType { get; set; }
        public string OtherEventNotes { get; set; }
        public OtherEventStatsList OtherEventStatsList { get; set; }
    }

    public class OtherEventList
    {
        public List<OtherEvent> OtherEvent { get; set; }
    }
   

    public class SeriousEventStats
    {
        public string SeriousEventStatsGroupId { get; set; }
        public string SeriousEventStatsNumEvents { get; set; }
        public string SeriousEventStatsNumAffected { get; set; }
        public string SeriousEventStatsNumAtRisk { get; set; }
    }

    public class SeriousEventStatsList
    {
        public List<SeriousEventStats> SeriousEventStats { get; set; }
    }

    public class SeriousEvent
    {
        public string SeriousEventTerm { get; set; }
        public string SeriousEventOrganSystem { get; set; }
        public string SeriousEventSourceVocabulary { get; set; }
        public string SeriousEventAssessmentType { get; set; }
        public string SeriousEventNotes { get; set; }
        public SeriousEventStatsList SeriousEventStatsList { get; set; }
    }

    public class SeriousEventList
    {
        public List<SeriousEvent> SeriousEvent { get; set; }
    }
    public class AdverseEventsModule
    {
        public string EventsFrequencyThreshold { get; set; }
        public string EventsTimeFrame { get; set; }
        public string EventsDescription { get; set; }
        public EventGroupList EventGroupList { get; set; }
        public SeriousEventList SeriousEventList { get; set; }
        public OtherEventList OtherEventList { get; set; }
    }

    public class LimitationsAndCaveats
    {
        public string dedLink { get; set; }
    }

   
    public class CertainAgreement
    {
        public string dedLink { get; set; }
        public string AgreementPISponsorEmployee { get; set; }
        public string AgreementRestrictionType { get; set; }
        public string AgreementRestrictiveAgreement { get; set; }
        public string AgreementOtherDetails { get; set; }
    }

    public class PointOfContact
    {
        public string dedLink { get; set; }
        public string PointOfContactTitle { get; set; }
        public string PointOfContactOrganization { get; set; }
        public string PointOfContactEMail { get; set; }
        public string PointOfContactPhone { get; set; }
        public string PointOfContactPhoneExt { get; set; }
    }

    public class MoreInfoModule
    {
        public LimitationsAndCaveats LimitationsAndCaveats { get; set; }
        public CertainAgreement CertainAgreement { get; set; }
        public PointOfContact PointOfContact { get; set; }
    }

    public class ResultsSection
    {
        public ParticipantFlowModule ParticipantFlowModule { get; set; }
        public BaselineCharacteristicsModule BaselineCharacteristicsModule { get; set; }
        public OutcomeMeasuresModule OutcomeMeasuresModule { get; set; }
        public AdverseEventsModule AdverseEventsModule { get; set; }
        public MoreInfoModule MoreInfoModule { get; set; }
    }


    public class UnpostedEvent
    {
        public string UnpostedEventType { get; set; }
        public string UnpostedEventDate { get; set; }
    }

    public class UnpostedEventList
    {
        public List<UnpostedEvent> UnpostedEvent { get; set; }
    }

    public class UnpostedAnnotation
    {
        public string UnpostedResponsibleParty { get; set; }
        public UnpostedEventList UnpostedEventList { get; set; }
    }

    public class AnnotationModule
    {
        public UnpostedAnnotation UnpostedAnnotation { get; set; }
    }

    public class AnnotationSection
    {
        public AnnotationModule AnnotationModule { get; set; }
    }


    public class LargeDoc
    {
        public string LargeDocTypeAbbrev { get; set; }
        public string LargeDocHasProtocol { get; set; }
        public string LargeDocHasSAP { get; set; }
        public string LargeDocHasICF { get; set; }
        public string LargeDocLabel { get; set; }
        public string LargeDocDate { get; set; }
        public string LargeDocUploadDate { get; set; }
        public string LargeDocFilename { get; set; }
    }

    public class LargeDocList
    {
        public List<LargeDoc> LargeDoc { get; set; }
    }

    public class LargeDocumentModule
    {
        public string dedLink { get; set; }
        public LargeDocList LargeDocList { get; set; }
    }

    public class DocumentSection
    {
        public LargeDocumentModule LargeDocumentModule { get; set; }
    }
    /*
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
   }*/


}
