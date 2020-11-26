using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class PrimaryCompletionDateStruct : StudyStructureEntity
    {
        public string PrimaryCompletionDate { get; set; }
        public string PrimaryCompletionDateType { get; set; }
    }


    public class CompletionDateStruct : StudyStructureEntity
    {
        public string CompletionDate { get; set; }
        public string CompletionDateType { get; set; }
    }

    public class ResultsFirstPostDateStruct : StudyStructureEntity
    {
        public string ResultsFirstPostDate { get; set; }
        public string ResultsFirstPostDateType { get; set; }
    }
    public class DispFirstPostDateStruct : StudyStructureEntity
    {
        public string DispFirstPostDate { get; set; }
        public string DispFirstPostDateType { get; set; }
    }


    public class ResponsibleParty : StudyStructureEntity
    {
        public string ResponsiblePartyType { get; set; }
        public string ResponsiblePartyInvestigatorFullName { get; set; }
        public string ResponsiblePartyInvestigatorTitle { get; set; }
        public string ResponsiblePartyInvestigatorAffiliation { get; set; }
        public string ResponsiblePartyOldNameTitle { get; set; }
        public string ResponsiblePartyOldOrganization { get; set; }
    }

 

    public class Collaborator : StudyStructureEntity
    {
        public string CollaboratorName { get; set; }
        public string CollaboratorClass { get; set; }
    }

    public class CollaboratorList : StudyStructureEntity
    {
        public virtual List<Collaborator> Collaborator { get; set; }
    }

    public class SponsorCollaboratorsModule : StudyStructureEntity
    {
        public virtual ResponsibleParty ResponsibleParty { get; set; }
        public virtual LeadSponsor LeadSponsor { get; set; }
        public virtual CollaboratorList CollaboratorList { get; set; }
    }


    public class OversightModule : StudyStructureEntity
    {
        public string OversightHasDMC { get; set; }
        public string IsFDARegulatedDrug { get; set; }
        public string IsFDARegulatedDevice { get; set; }
        public string IsUnapprovedDevice { get; set; }
        public string IsPPSD { get; set; }
        public string IsUSExport { get; set; }
    }


    public class KeywordList : StudyStructureEntity
    {
        public List<string> Keyword { get; set; }
    }


    public class ExpandedAccessTypes : StudyStructureEntity
    {
        public string ExpAccTypeIndividual { get; set; }
        public string ExpAccTypeIntermediate { get; set; }
        public string ExpAccTypeTreatment { get; set; }
    }


    public class DesignObservationalModelList : StudyStructureEntity
    {
        public List<string> DesignObservationalModel { get; set; }
    }


    public class DesignTimePerspectiveList : StudyStructureEntity
    {
        public List<string> DesignTimePerspective { get; set; }
    }

  

    public class BioSpec : StudyStructureEntity
    {
        public string BioSpecRetention { get; set; }
        public string BioSpecDescription { get; set; }
    }


    public class EnrollmentInfo : StudyStructureEntity
    {
        public string EnrollmentCount { get; set; }
        public string EnrollmentType { get; set; }
    }

    public class StartDateStruct : StudyStructureEntity
    {
        public string StartDate { get; set; }
        public string StartDateType { get; set; }
    }
    public class ArmGroupInterventionList : StudyStructureEntity
    {
        public List<string> ArmGroupInterventionName { get; set; }
    }

    public class ArmGroup : StudyStructureEntity
    {
        public string ArmGroupLabel { get; set; }
        public string ArmGroupType { get; set; }
        public string ArmGroupDescription { get; set; }
        public virtual ArmGroupInterventionList ArmGroupInterventionList { get; set; }
    }


 
    public class PrimaryOutcome : StudyStructureEntity
    {
        public string PrimaryOutcomeMeasure { get; set; }
        public string PrimaryOutcomeDescription { get; set; }
        public string PrimaryOutcomeTimeFrame { get; set; }
    }

    public class PrimaryOutcomeList : StudyStructureEntity
    {
        public virtual List<PrimaryOutcome> PrimaryOutcome { get; set; }
    }


    public class SecondaryOutcome : StudyStructureEntity
    {
        public string SecondaryOutcomeMeasure { get; set; }
        public string SecondaryOutcomeDescription { get; set; }
        public string SecondaryOutcomeTimeFrame { get; set; }
    }

    public class SecondaryOutcomeList : StudyStructureEntity
    {
        public virtual List<SecondaryOutcome> SecondaryOutcome { get; set; }
    }

    public class OtherOutcome : StudyStructureEntity
    {
        public string OtherOutcomeMeasure { get; set; }
        public string OtherOutcomeDescription { get; set; }
        public string OtherOutcomeTimeFrame { get; set; }
    }

    public class OtherOutcomeList : StudyStructureEntity
    {
        public virtual List<OtherOutcome> OtherOutcome { get; set; }
    }

    public class OutcomesModule : StudyStructureEntity
    {
        public virtual PrimaryOutcomeList PrimaryOutcomeList { get; set; }
        public virtual SecondaryOutcomeList SecondaryOutcomeList { get; set; }
        public virtual OtherOutcomeList OtherOutcomeList { get; set; }
    }


    public class CentralContact : StudyStructureEntity
    {
        public string CentralContactName { get; set; }
        public string CentralContactRole { get; set; }
        public string CentralContactPhone { get; set; }
        public string CentralContactPhoneExt { get; set; }
        public string CentralContactEMail { get; set; }
    }

    public class CentralContactList : StudyStructureEntity
    {
        public virtual List<CentralContact> CentralContact { get; set; }
    }


    public class OverallOfficial : StudyStructureEntity
    {
        public string OverallOfficialName { get; set; }
        public string OverallOfficialAffiliation { get; set; }
        public string OverallOfficialRole { get; set; }
    }

    public class OverallOfficialList : StudyStructureEntity
    {
        public virtual List<OverallOfficial> OverallOfficial { get; set; }
    }

    public class LocationContact : StudyStructureEntity
    {
        public string LocationContactName { get; set; }
        public string LocationContactRole { get; set; }
        public string LocationContactPhone { get; set; }
        public string LocationContactPhoneExt { get; set; }
        public string LocationContactEMail { get; set; }
    }

    public class Retraction : StudyStructureEntity
    {
        public string RetractionPMID { get; set; }
        public string RetractionSource { get; set; }
    }

    public class RetractionList : StudyStructureEntity
    {
        public virtual List<Retraction> Retraction { get; set; }
    }

    public class Reference : StudyStructureEntity
    {
        public string ReferencePMID { get; set; }
        public string ReferenceType { get; set; }
        public string ReferenceCitation { get; set; }
        public virtual RetractionList RetractionList { get; set; }
    }

    public class ReferenceList : StudyStructureEntity
    {
        public virtual List<Reference> Reference { get; set; }
    }

 

    public class SeeAlsoLink : StudyStructureEntity
    {
        public string SeeAlsoLinkLabel { get; set; }
        public string SeeAlsoLinkURL { get; set; }
    }

    public class SeeAlsoLinkList : StudyStructureEntity
    {
        public virtual List<SeeAlsoLink> SeeAlsoLink { get; set; }
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
        public virtual List<AvailIPD> AvailIPD { get; set; }
    }

    public class ReferencesModule : StudyStructureEntity
    {
        public virtual ReferenceList ReferenceList { get; set; }
        public virtual SeeAlsoLinkList SeeAlsoLinkList { get; set; }
        public virtual AvailIPDList AvailIPDList { get; set; }
    }

    public class IPDSharingInfoTypeList : StudyStructureEntity
    {
        public List<string> IPDSharingInfoType;
    }

    public class IPDSharingStatementModule : StudyStructureEntity
    {
        public string IPDSharing { get; set; }
        public string IPDSharingDescription { get; set; }
        public virtual IPDSharingInfoTypeList IPDSharingInfoTypeList { get; set; }
        public string IPDSharingTimeFrame { get; set; }
        public string IPDSharingAccessCriteria { get; set; }
        public string IPDSharingURL { get; set; }
    }
    

    public class FlowGroup : StudyStructureEntity
    {
        public string FlowGroupId { get; set; }
        public string FlowGroupTitle { get; set; }
        public string FlowGroupDescription { get; set; }
    }

    public class FlowGroupList : StudyStructureEntity
    {
        public virtual List<FlowGroup> FlowGroup { get; set; }
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
        public virtual List<FlowAchievement> FlowAchievement { get; set; }
    }

    public class FlowMilestone : StudyStructureEntity
    {
        public string FlowMilestoneType { get; set; }
        public string FlowMilestoneComment { get; set; }
        public virtual FlowAchievementList FlowAchievementList { get; set; }
    }

    public class FlowMilestoneList : StudyStructureEntity
    {
        public virtual List<FlowMilestone> FlowMilestone { get; set; }
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
        public virtual List<FlowReason> FlowReason { get; set; }
    }

    public class FlowDropWithdraw : StudyStructureEntity
    {
        public string FlowDropWithdrawType { get; set; }
        public string FlowDropWithdrawComment { get; set; }
        public virtual FlowReasonList FlowReasonList { get; set; }
    }

    public class FlowDropWithdrawList : StudyStructureEntity
    {
        public virtual List<FlowDropWithdraw> FlowDropWithdraw { get; set; }
    }

    public class FlowPeriod : StudyStructureEntity
    {
        public string FlowPeriodTitle { get; set; }
        public virtual FlowMilestoneList FlowMilestoneList { get; set; }
        public virtual FlowDropWithdrawList FlowDropWithdrawList { get; set; }
    }

    public class FlowPeriodList : StudyStructureEntity
    {
        public virtual List<FlowPeriod> FlowPeriod { get; set; }
    }

    public class ParticipantFlowModule : StudyStructureEntity
    {
        public string FlowPreAssignmentDetails { get; set; }
        public string FlowRecruitmentDetails { get; set; }
        public string FlowTypeUnitsAnalyzed { get; set; }
        public virtual FlowGroupList FlowGroupList { get; set; }
        public virtual FlowPeriodList FlowPeriodList { get; set; }
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
        public virtual BaselineDenomCountList BaselineDenomCountList { get; set; }
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
        public virtual List<BaselineMeasureDenomCount> BaselineMeasureDenomCount { get; set; }
    }

    public class BaselineMeasureDenom : StudyStructureEntity
    {
        public string BaselineMeasureDenomUnits { get; set; }
        public virtual BaselineMeasureDenomCountList BaselineMeasureDenomCountList { get; set; }
    }

    public class BaselineMeasureDenomList : StudyStructureEntity
    
    {
        public virtual List<BaselineMeasureDenom> BaselineMeasureDenom { get; set; }
    }

   
    public class BaselineClassDenomCount : StudyStructureEntity
    {
        public string BaselineClassDenomCountGroupId { get; set; }
        public string BaselineClassDenomCountValue { get; set; }
    }

    public class BaselineClassDenomCountList : StudyStructureEntity
    {
        public virtual List<BaselineClassDenomCount> BaselineClassDenomCount { get; set; }
    }

    public class BaselineClassDenom : StudyStructureEntity
    {
        public string BaselineClassDenomUnits { get; set; }
        public virtual BaselineClassDenomCountList BaselineClassDenomCountList { get; set; }
    }

    public class BaselineClassDenomList : StudyStructureEntity
    {
        public virtual List<BaselineClassDenom> BaselineClassDenom { get; set; }
    }

    public class BaselineMeasurement : StudyStructureEntity
    {
        public string BaselineMeasurementGroupId { get; set; }
        public string BaselineMeasurementValue { get; set; }
        public string BaselineMeasurementSpread { get; set; }
        public string BaselineMeasurementLowerLimit { get; set; }
        public string BaselineMeasurementUpperLimit { get; set; }
        public string BaselineMeasurementComment { get; set; }
    }

    public class BaselineMeasurementList : StudyStructureEntity
    {
        public virtual List<BaselineMeasurement> BaselineMeasurement { get; set; }
    }

    public class BaselineCategory : StudyStructureEntity
    {
        public string BaselineCategoryTitle { get; set; }
        public virtual BaselineMeasurementList BaselineMeasurementList { get; set; }
    }

    public class BaselineCategoryList : StudyStructureEntity
    {
        public virtual List<BaselineCategory> BaselineCategory { get; set; }
    }

    public class BaselineClass : StudyStructureEntity
    {
        public string BaselineClassTitle { get; set; }
        public virtual BaselineClassDenomList BaselineClassDenomList { get; set; }
        public virtual BaselineCategoryList BaselineCategoryList { get; set; }
    }

    public class BaselineClassList : StudyStructureEntity
    {
        public virtual List<BaselineClass> BaselineClass { get; set; }
    }

    public class BaselineMeasure : StudyStructureEntity
    {
        public string BaselineMeasureTitle { get; set; }
        public string BaselineMeasureDescription { get; set; }
        public string BaselineMeasurePopulationDescription { get; set; }
        public string BaselineMeasureParamType { get; set; }
        public string BaselineMeasureDispersionType { get; set; }
        public string BaselineMeasureUnitOfMeasure { get; set; }
        public string BaselineMeasureCalculatePct { get; set; }
        public string BaselineMeasureDenomUnitsSelected { get; set; }
        public virtual BaselineMeasureDenomList BaselineMeasureDenomList { get; set; }
        public virtual BaselineClassList BaselineClassList { get; set; }
    }

    public class BaselineMeasureList : StudyStructureEntity
    {
        public virtual List<BaselineMeasure> BaselineMeasure { get; set; }
    }

    public class BaselineCharacteristicsModule : StudyStructureEntity
    {
        public string BaselinePopulationDescription { get; set; }
        public string BaselineTypeUnitsAnalyzed { get; set; }
        public virtual BaselineGroupList BaselineGroupList { get; set; }
        public virtual BaselineDenomList BaselineDenomList { get; set; }
        public virtual BaselineMeasureList BaselineMeasureList { get; set; }
    }


    public class OutcomeGroup : StudyStructureEntity
    {
        public string OutcomeGroupId { get; set; }
        public string OutcomeGroupTitle { get; set; }
        public string OutcomeGroupDescription { get; set; }
    }

    public class OutcomeGroupList : StudyStructureEntity
    {
        public virtual List<OutcomeGroup> OutcomeGroup { get; set; }
    }

    public class OutcomeDenomCount : StudyStructureEntity
    {
        public string type { get; set; }
        public string OutcomeDenomCountGroupId { get; set; }
        public string OutcomeDenomCountValue { get; set; }
    }

    public class OutcomeDenomCountList : StudyStructureEntity
    {
        public virtual List<OutcomeDenomCount> OutcomeDenomCount { get; set; }
    }

    public class OutcomeDenom : StudyStructureEntity
    {
        public string OutcomeDenomUnits { get; set; }
        public virtual OutcomeDenomCountList OutcomeDenomCountList { get; set; }
    }

    public class OutcomeDenomList : StudyStructureEntity
    {
        public virtual List<OutcomeDenom> OutcomeDenom { get; set; }
    }


    public class OutcomeClassDenomCount : StudyStructureEntity
    {
        public string OutcomeClassDenomCountGroupId { get; set; }
        public string OutcomeClassDenomCountValue { get; set; }
    }

    public class OutcomeClassDenomCountList : StudyStructureEntity
    {
        public virtual List<OutcomeClassDenomCount> OutcomeClassDenomCount { get; set; }
    }

    public class OutcomeClassDenom : StudyStructureEntity
    {
        public string OutcomeClassDenomUnits { get; set; }
        public virtual OutcomeClassDenomCountList OutcomeClassDenomCountList { get; set; }
    }

    public class OutcomeClassDenomList : StudyStructureEntity
    {
        public virtual List<OutcomeClassDenom> OutcomeClassDenom { get; set; }
    }


    public class OutcomeMeasurement : StudyStructureEntity
    {
        public string OutcomeMeasurementGroupId { get; set; }
        public string OutcomeMeasurementValue { get; set; }
        public string OutcomeMeasurementSpread { get; set; }
        public string OutcomeMeasurementLowerLimit { get; set; }
        public string OutcomeMeasurementUpperLimit { get; set; }
        public string OutcomeMeasurementComment { get; set; }
    }

    public class OutcomeMeasurementList : StudyStructureEntity
    {
        public virtual List<OutcomeMeasurement> OutcomeMeasurement { get; set; }
    }

    public class OutcomeCategory : StudyStructureEntity
    {
        public string OutcomeCategoryTitle { get; set; }
        public virtual OutcomeMeasurementList OutcomeMeasurementList { get; set; }
    }

    public class OutcomeCategoryList : StudyStructureEntity
    {
        public virtual List<OutcomeCategory> OutcomeCategory { get; set; }
    }

    public class OutcomeClass : StudyStructureEntity
    {
        public string OutcomeClassTitle { get; set; }
        public virtual OutcomeClassDenomList OutcomeClassDenomList { get; set; }
        public virtual OutcomeCategoryList OutcomeCategoryList { get; set; }
    }

    public class OutcomeClassList : StudyStructureEntity
    {
        public virtual List<OutcomeClass> OutcomeClass { get; set; }
    }

    public class OutcomeAnalysis : StudyStructureEntity
    {
        public virtual OutcomeAnalysisGroupIdList OutcomeAnalysisGroupIdList { get; set; }
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

    public class OutcomeAnalysisGroupIdList : StudyStructureEntity
    {
        public virtual List<string> OutcomeAnalysisGroupId { get; set; }
    }
    public class OutcomeAnalysisList : StudyStructureEntity
    {
        public virtual List<OutcomeAnalysis> OutcomeAnalysis { get; set; }
    }

    public class OutcomeMeasure : StudyStructureEntity
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
        public virtual OutcomeGroupList OutcomeGroupList { get; set; }
        public virtual OutcomeDenomList OutcomeDenomList { get; set; }
        public virtual OutcomeClassList OutcomeClassList { get; set; }
        public virtual OutcomeAnalysisList OutcomeAnalysisList { get; set; }
    }

    public class OutcomeMeasureList : StudyStructureEntity
    {
        public virtual List<OutcomeMeasure> OutcomeMeasure { get; set; }
    }

    public class OutcomeMeasuresModule : StudyStructureEntity
    {
        public virtual OutcomeMeasureList OutcomeMeasureList { get; set; }
    }

  

    public class EventGroup : StudyStructureEntity
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

    public class EventGroupList : StudyStructureEntity
    {
        public virtual List<EventGroup> EventGroup { get; set; }
    }

    public class OtherEventStats : StudyStructureEntity
    {
        public string OtherEventStatsGroupId { get; set; }
        public string OtherEventStatsNumEvents { get; set; }
        public string OtherEventStatsNumAffected { get; set; }
        public string OtherEventStatsNumAtRisk { get; set; }
    }

    public class OtherEventStatsList : StudyStructureEntity
    {
        public virtual List<OtherEventStats> OtherEventStats { get; set; }
    }

    public class OtherEvent : StudyStructureEntity
    {
        public string OtherEventTerm { get; set; }
        public string OtherEventOrganSystem { get; set; }
        public string OtherEventSourceVocabulary { get; set; }
        public string OtherEventAssessmentType { get; set; }
        public string OtherEventNotes { get; set; }
        public virtual OtherEventStatsList OtherEventStatsList { get; set; }
    }

    public class OtherEventList : StudyStructureEntity
    {
        public virtual List<OtherEvent> OtherEvent { get; set; }
    }
   

    public class SeriousEventStats : StudyStructureEntity
    {
        public string SeriousEventStatsGroupId { get; set; }
        public string SeriousEventStatsNumEvents { get; set; }
        public string SeriousEventStatsNumAffected { get; set; }
        public string SeriousEventStatsNumAtRisk { get; set; }
    }

    public class SeriousEventStatsList : StudyStructureEntity
    {
        public virtual List<SeriousEventStats> SeriousEventStats { get; set; }
    }

    public class SeriousEvent : StudyStructureEntity
    {
        public string SeriousEventTerm { get; set; }
        public string SeriousEventOrganSystem { get; set; }
        public string SeriousEventSourceVocabulary { get; set; }
        public string SeriousEventAssessmentType { get; set; }
        public string SeriousEventNotes { get; set; }
        public virtual SeriousEventStatsList SeriousEventStatsList { get; set; }
    }

    public class SeriousEventList : StudyStructureEntity
    {
        public virtual List<SeriousEvent> SeriousEvent { get; set; }
    }
    public class AdverseEventsModule : StudyStructureEntity
    {
        public string EventsFrequencyThreshold { get; set; }
        public string EventsTimeFrame { get; set; }
        public string EventsDescription { get; set; }
        public virtual EventGroupList EventGroupList { get; set; }
        public virtual SeriousEventList SeriousEventList { get; set; }
        public virtual OtherEventList OtherEventList { get; set; }
    }

    public class LimitationsAndCaveats : StudyStructureEntity
    {
        public string dedLink { get; set; }
    }

   
    public class CertainAgreement : StudyStructureEntity
    {
        public string AgreementPISponsorEmployee { get; set; }
        public string AgreementRestrictionType { get; set; }
        public string AgreementRestrictiveAgreement { get; set; }
        public string AgreementOtherDetails { get; set; }
    }

    public class PointOfContact : StudyStructureEntity
    {
        public string PointOfContactTitle { get; set; }
        public string PointOfContactOrganization { get; set; }
        public string PointOfContactEMail { get; set; }
        public string PointOfContactPhone { get; set; }
        public string PointOfContactPhoneExt { get; set; }
    }

    public class MoreInfoModule : StudyStructureEntity
    {
        public virtual LimitationsAndCaveats LimitationsAndCaveats { get; set; }
        public virtual CertainAgreement CertainAgreement { get; set; }
        public virtual PointOfContact PointOfContact { get; set; }
    }

    public class ResultsSection : StudyStructureEntity
    {
        public virtual ParticipantFlowModule ParticipantFlowModule { get; set; }
        public virtual BaselineCharacteristicsModule BaselineCharacteristicsModule { get; set; }
        public virtual OutcomeMeasuresModule OutcomeMeasuresModule { get; set; }
        public virtual AdverseEventsModule AdverseEventsModule { get; set; }
        public virtual MoreInfoModule MoreInfoModule { get; set; }
    }


    public class UnpostedEvent : StudyStructureEntity
    {
        public string UnpostedEventType { get; set; }
        public string UnpostedEventDate { get; set; }
    }

    public class UnpostedEventList : StudyStructureEntity
    {
        public virtual List<UnpostedEvent> UnpostedEvent { get; set; }
    }

    public class UnpostedAnnotation : StudyStructureEntity
    {
        public string UnpostedResponsibleParty { get; set; }
        public virtual UnpostedEventList UnpostedEventList { get; set; }
    }

    public class AnnotationModule : StudyStructureEntity
    {
        public virtual UnpostedAnnotation UnpostedAnnotation { get; set; }
    }

    public class AnnotationSection : StudyStructureEntity
    {
        public virtual AnnotationModule AnnotationModule { get; set; }
    }


    public class LargeDoc : StudyStructureEntity
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

    public class LargeDocList : StudyStructureEntity
    {
        public virtual List<LargeDoc> LargeDoc { get; set; }
    }

    public class LargeDocumentModule : StudyStructureEntity
    {
        public virtual LargeDocList LargeDocList { get; set; }
    }

    public class DocumentSection : StudyStructureEntity
    {
        public virtual LargeDocumentModule LargeDocumentModule { get; set; }
    }

}
