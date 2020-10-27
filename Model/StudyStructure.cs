using Model.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

    public class ExpandedAccessInfo : StudyStructureEntity
    {
        public string HasExpandedAccess { get; set; }
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
    }

    public class LeadSponsor : StudyStructureEntity
    {
        public string LeadSponsorName { get; set; }
        public string LeadSponsorClass { get; set; }
    }

    public class SponsorCollaboratorsModule : StudyStructureEntity
    {
        public virtual LeadSponsor LeadSponsor { get; set; }
    }

    public class DescriptionModule : StudyStructureEntity
    {
        public string BriefSummary { get; set; }
        public string DetailedDescription { get; set; }
    }

    public class ConditionList : StudyStructureEntity
    {
        public List<string> Condition { get; set; }
    }

    public class ConditionsModule : StudyStructureEntity
    {
        public virtual ConditionList ConditionList { get; set; }
    }

    public class PhaseList : StudyStructureEntity
    {
        public List<string> Phase { get; set; }
    }

    public class DesignMaskingInfo : StudyStructureEntity
    {
        public string DesignMasking { get; set; }
    }

    public class DesignInfo : StudyStructureEntity
    {
        public string DesignInterventionModel { get; set; }
        public string DesignPrimaryPurpose { get; set; }
        public virtual DesignMaskingInfo DesignMaskingInfo { get; set; }
    }

    public class DesignModule : StudyStructureEntity
    {
        public string StudyType { get; set; }
        public virtual PhaseList PhaseList { get; set; }
        public virtual DesignInfo DesignInfo { get; set; }
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

    public class ArmsInterventionsModule : StudyStructureEntity
    {
        public virtual InterventionList InterventionList { get; set; }
    }

    public class StdAgeList : StudyStructureEntity
    {
        public List<string> StdAge { get; set; }
    }

    public class EligibilityModule : StudyStructureEntity
    {
        public string EligibilityCriteria { get; set; }
        public string HealthyVolunteers { get; set; }
        public string Gender { get; set; }
        public string MinimumAge { get; set; }
        public string MaximumAge { get; set; }
        public virtual StdAgeList StdAgeList { get; set; }
    }

    public class Location : StudyStructureEntity
    {
        public string LocationFacility { get; set; }
        public string LocationCity { get; set; }
        public string LocationState { get; set; }
        [StringLength(70)]
        public string LocationCountry { get; set; }
    }

    public class LocationList : StudyStructureEntity
    {
        public virtual List<Location> Location { get; set; }
    }

    public class ContactsLocationsModule : StudyStructureEntity
    {
        public virtual LocationList LocationList { get; set; }
    }

    public class ProtocolSection : StudyStructureEntity
    {
        public virtual IdentificationModule IdentificationModule { get; set; }
        public virtual StatusModule StatusModule { get; set; }
        public virtual SponsorCollaboratorsModule SponsorCollaboratorsModule { get; set; }
        public virtual DescriptionModule DescriptionModule { get; set; }
        public virtual ConditionsModule ConditionsModule { get; set; }
        public virtual DesignModule DesignModule { get; set; }
        public virtual ArmsInterventionsModule ArmsInterventionsModule { get; set; }
        public virtual EligibilityModule EligibilityModule { get; set; }
        public virtual ContactsLocationsModule ContactsLocationsModule { get; set; }
    }

    public class MiscInfoModule : StudyStructureEntity
    {
        public string VersionHolder { get; set; }
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
