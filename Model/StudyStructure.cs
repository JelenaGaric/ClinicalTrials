using Model.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    
    public class OrgStudyIdInfo : StudyStructureEntity
    {
        public string OrgStudyId { get; set; }
    }

    public class SecondaryIdInfo : StudyStructureEntity
    {
        public string SecondaryId { get; set; }
        public string SecondaryIdType { get; set; }
        public string SecondaryIdLink { get; set; }
    }

    public class SecondaryIdInfoList : StudyStructureEntity
    {
        public virtual List<SecondaryIdInfo> SecondaryIdInfo { get; set; }
    }

    public class Organization : StudyStructureEntity
    {
        [StringLength(200)]
        public string OrgFullName { get; set; }
        public string OrgClass { get; set; }
    }

    public class IdentificationModule : StudyStructureEntity
    {
        public string NCTId { get; set; }
        public virtual OrgStudyIdInfo OrgStudyIdInfo { get; set; }
        public virtual SecondaryIdInfoList SecondaryIdInfoList { get; set; }
        public virtual Organization Organization { get; set; }
        public string BriefTitle { get; set; }
        public string OfficialTitle { get; set; }
        public string Acronym { get; set; }
        public virtual NCTIdAliasList NCTIdAliasList { get; set; }

    }
    public class NCTIdAliasList : StudyStructureEntity
    {
        public virtual List<string> NCTIdAlias { get; set; }
    }
    public class ExpandedAccessInfo : StudyStructureEntity
    {
        public string HasExpandedAccess { get; set; }
        public string ExpandedAccessNCTId { get; set; }
        public string ExpandedAccessStatusForNCTId { get; set; }
    }

    public class StudyFirstPostDateStruct : StudyStructureEntity
    {
        public string StudyFirstPostDate { get; set; }
        public string StudyFirstPostDateType { get; set; }
    }

    public class LastUpdatePostDateStruct : StudyStructureEntity
    {
        public string LastUpdatePostDate { get; set; }
        public string LastUpdatePostDateType { get; set; }
    }

    public class StatusModule : StudyStructureEntity
    {
        public string StatusVerifiedDate { get; set; }
        public string OverallStatus { get; set; }
        public virtual ExpandedAccessInfo ExpandedAccessInfo { get; set; }
        [JsonConverter(typeof(MyDateTimeConverter))]
        public DateTime? StudyFirstSubmitDate { get; set; }
        public string StudyFirstSubmitQCDate { get; set; }
        public virtual StudyFirstPostDateStruct StudyFirstPostDateStruct { get; set; }
        [JsonConverter(typeof(MyDateTimeConverter))]
        public DateTime? LastUpdateSubmitDate { get; set; }
        public virtual LastUpdatePostDateStruct LastUpdatePostDateStruct { get; set; }

        public string LastKnownStatus { get; set; }
        public string DelayedPosting { get; set; }
        public string WhyStopped { get; set; }
        public virtual StartDateStruct StartDateStruct { get; set; }
        public virtual PrimaryCompletionDateStruct PrimaryCompletionDateStruct { get; set; }
        public virtual CompletionDateStruct CompletionDateStruct { get; set; }
        public string DispFirstSubmitDate { get; set; }
        public string DispFirstSubmitQCDate { get; set; }
        public virtual DispFirstPostDateStruct DispFirstPostDateStruct { get; set; }
        [JsonConverter(typeof(MyDateTimeConverter))]
        public DateTime? ResultsFirstSubmitDate { get; set; }
        public string ResultsFirstSubmitQCDate { get; set; }
        public virtual ResultsFirstPostDateStruct ResultsFirstPostDateStruct { get; set; }

    }

    public class LeadSponsor : StudyStructureEntity
    {
        public string LeadSponsorName { get; set; }
        public string LeadSponsorClass { get; set; }
    }

    public class DescriptionModule : StudyStructureEntity
    {
        public string BriefSummary { get; set; }
        public string DetailedDescription { get; set; }
    }

    public class ConditionList : StudyStructureEntity
    {
        public virtual List<string> Condition { get; set; }
    }

    public class ConditionsModule : StudyStructureEntity
    {
        public virtual ConditionList ConditionList { get; set; }
        public virtual KeywordList KeywordList { get; set; }

    }

    public class PhaseList : StudyStructureEntity
    {
        public virtual List<string> Phase { get; set; }
    }

    public class DesignWhoMaskedList : StudyStructureEntity
    {
        public virtual List<string> DesignWhoMasked { get; set; }
    }

    public class DesignMaskingInfo : StudyStructureEntity
    {
        public string DesignMasking { get; set; }
        public string DesignMaskingDescription { get; set; }
        public virtual DesignWhoMaskedList DesignWhoMaskedList { get; set; }
    }

    public class DesignInfo : StudyStructureEntity
    {
        public string DesignAllocation { get; set; }
        public string DesignInterventionModel { get; set; }
        public string DesignInterventionModelDescription { get; set; }
        public string DesignPrimaryPurpose { get; set; }
        public virtual DesignObservationalModelList DesignObservationalModelList { get; set; }
        public virtual DesignTimePerspectiveList DesignTimePerspectiveList { get; set; }
        public virtual DesignMaskingInfo DesignMaskingInfo { get; set; }
    }

    public class DesignModule : StudyStructureEntity
    {
        public string StudyType { get; set; }
        public virtual PhaseList PhaseList { get; set; }
        public virtual DesignInfo DesignInfo { get; set; }
        public string PatientRegistry { get; set; }
        public string TargetDuration { get; set; }
        public virtual BioSpec BioSpec { get; set; }
        public virtual EnrollmentInfo EnrollmentInfo { get; set; }
        public virtual ExpandedAccessTypes ExpandedAccessTypes { get; set; }


    }

    public class Intervention : StudyStructureEntity
    {
        public string InterventionType { get; set; }
        public string InterventionName { get; set; }
    }

    public class InterventionList : StudyStructureEntity
    {
        public virtual List<Intervention> Intervention { get; set; }
    }
    public class ArmGroupList : StudyStructureEntity
    {
        public virtual List<ArmGroup> ArmGroup { get; set; }
    }

    public class ArmsInterventionsModule : StudyStructureEntity
    {
        public virtual InterventionList InterventionList { get; set; }
        public virtual ArmGroupList ArmGroupList { get; set; }

    }

    public class StdAgeList : StudyStructureEntity
    {
        public virtual List<string> StdAge { get; set; }
    }

    public class EligibilityModule : StudyStructureEntity
    {
        public string EligibilityCriteria { get; set; }
        public string HealthyVolunteers { get; set; }
        public string Gender { get; set; }
        public string MinimumAge { get; set; }
        public string MaximumAge { get; set; }
        public virtual StdAgeList StdAgeList { get; set; }
        public string GenderBased { get; set; }
        public string GenderDescription { get; set; }
        public string StudyPopulation { get; set; }
        public string SamplingMethod { get; set; }
    }
    public class LocationContactList : StudyStructureEntity
    {
        public virtual List<LocationContact> LocationContact { get; set; }
    }

    public class Location : StudyStructureEntity
    {
        public string LocationFacility { get; set; }
        [StringLength(100)]
        public string LocationCity { get; set; }
        public string LocationState { get; set; }
        [StringLength(70)]
        public string LocationCountry { get; set; }
        public string LocationZip { get; set; }
        public string LocationStatus { get; set; }
        public virtual LocationContactList LocationContactList { get; set; }

    }

    public class LocationList : StudyStructureEntity
    {
        public virtual List<Location> Location { get; set; }
    }

    public class ContactsLocationsModule : StudyStructureEntity
    {
        public virtual LocationList LocationList { get; set; }
        public virtual CentralContactList CentralContactList { get; set; }
        public virtual OverallOfficialList OverallOfficialList { get; set; }
    }

    public class ProtocolSection : StudyStructureEntity
    {
        public virtual IdentificationModule IdentificationModule { get; set; }
        public virtual StatusModule StatusModule { get; set; }
        public virtual SponsorCollaboratorsModule SponsorCollaboratorsModule { get; set; }
        public virtual OversightModule OversightModule { get; set; }
        public virtual DescriptionModule DescriptionModule { get; set; }
        public virtual ConditionsModule ConditionsModule { get; set; }
        public virtual DesignModule DesignModule { get; set; }
        public virtual ArmsInterventionsModule ArmsInterventionsModule { get; set; }
        public virtual OutcomesModule OutcomesModule { get; set; }
        public virtual EligibilityModule EligibilityModule { get; set; }
        public virtual ContactsLocationsModule ContactsLocationsModule { get; set; }
        public virtual ReferencesModule ReferencesModule { get; set; }
        public virtual IPDSharingStatementModule IPDSharingStatementModule { get; set; }
        
    }

    public class RemovedCountryList : StudyStructureEntity
    {
        public virtual List<string> RemovedCountry { get; set; }
    }

    public class MiscInfoModule : StudyStructureEntity
    {
        public string VersionHolder { get; set; }
        public virtual RemovedCountryList RemovedCountryList { get; set; }

    }

    public class InterventionMesh : StudyStructureEntity
    {
        public string InterventionMeshId { get; set; }
        public string InterventionMeshTerm { get; set; }
    }

    public class InterventionMeshList : StudyStructureEntity
    {
        public virtual List<InterventionMesh> InterventionMesh { get; set; }
    }

    public class InterventionAncestor : StudyStructureEntity
    {
        public string InterventionAncestorId { get; set; }
        public string InterventionAncestorTerm { get; set; }
    }

    public class InterventionAncestorList : StudyStructureEntity
    {
        public virtual List<InterventionAncestor> InterventionAncestor { get; set; }
    }

    public class InterventionBrowseLeaf : StudyStructureEntity
    {
        public string InterventionBrowseLeafId { get; set; }
        public string InterventionBrowseLeafName { get; set; }
        public string InterventionBrowseLeafRelevance { get; set; }
        public string InterventionBrowseLeafAsFound { get; set; }
    }

    public class InterventionBrowseLeafList : StudyStructureEntity
    {
        public virtual List<InterventionBrowseLeaf> InterventionBrowseLeaf { get; set; }
    }

    public class InterventionBrowseBranch : StudyStructureEntity
    {
        public string InterventionBrowseBranchAbbrev { get; set; }
        public string InterventionBrowseBranchName { get; set; }
    }

    public class InterventionBrowseBranchList : StudyStructureEntity
    {
        public virtual List<InterventionBrowseBranch> InterventionBrowseBranch { get; set; }
    }

    public class InterventionBrowseModule : StudyStructureEntity
    {
        public virtual InterventionMeshList InterventionMeshList { get; set; }
        public virtual InterventionAncestorList InterventionAncestorList { get; set; }
        public virtual InterventionBrowseLeafList InterventionBrowseLeafList { get; set; }
        public virtual InterventionBrowseBranchList InterventionBrowseBranchList { get; set; }
    }

    public class ConditionMesh : StudyStructureEntity
    {
        public string ConditionMeshId { get; set; }
        [StringLength(120)]
        public string ConditionMeshTerm { get; set; }
    }

    public class ConditionMeshList : StudyStructureEntity
    {
        public virtual List<ConditionMesh> ConditionMesh { get; set; }
    }

    public class ConditionAncestor : StudyStructureEntity
    {
        public string ConditionAncestorId { get; set; }
        public string ConditionAncestorTerm { get; set; }
    }

    public class ConditionAncestorList : StudyStructureEntity
    {
        public virtual List<ConditionAncestor> ConditionAncestor { get; set; }
    }

    public class ConditionBrowseLeaf : StudyStructureEntity
    {
        public string ConditionBrowseLeafId { get; set; }
        public string ConditionBrowseLeafName { get; set; }
        public string ConditionBrowseLeafAsFound { get; set; }
        public string ConditionBrowseLeafRelevance { get; set; }
    }

    public class ConditionBrowseLeafList : StudyStructureEntity
    {
        public virtual List<ConditionBrowseLeaf> ConditionBrowseLeaf { get; set; }
    }

    public class ConditionBrowseBranch : StudyStructureEntity
    {
        public string ConditionBrowseBranchAbbrev { get; set; }
        public string ConditionBrowseBranchName { get; set; }
    }

    public class ConditionBrowseBranchList : StudyStructureEntity
    {
        public virtual List<ConditionBrowseBranch> ConditionBrowseBranch { get; set; }
    }

    public class ConditionBrowseModule : StudyStructureEntity
    {
        public virtual ConditionMeshList ConditionMeshList { get; set; }
        public virtual ConditionAncestorList ConditionAncestorList { get; set; }
        public virtual ConditionBrowseLeafList ConditionBrowseLeafList { get; set; }
        public virtual ConditionBrowseBranchList ConditionBrowseBranchList { get; set; }
    }

    public class DerivedSection : StudyStructureEntity
    {
        public virtual MiscInfoModule MiscInfoModule { get; set; }
        public virtual InterventionBrowseModule InterventionBrowseModule { get; set; }
        public virtual ConditionBrowseModule ConditionBrowseModule { get; set; }
    }

    public class Study : StudyStructureEntity
    {
        public virtual ProtocolSection ProtocolSection { get; set; }
        public virtual ResultsSection ResultsSection { get; set; }
        public virtual AnnotationSection AnnotationSection { get; set; }
        public virtual DocumentSection DocumentSection { get; set; }
        public virtual DerivedSection DerivedSection { get; set; }
    }

    public class FullStudy : StudyStructureEntity
    {
        public int Rank { get; set; }
        public virtual Study Study { get; set; }
    }

    public class Root : StudyStructureEntity
    {
        public virtual FullStudy FullStudy { get; set; }
    }
    
}
