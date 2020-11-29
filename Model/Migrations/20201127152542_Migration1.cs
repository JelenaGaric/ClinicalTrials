using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArmGroupInterventionList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArmGroupInterventionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmGroupInterventionList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArmGroupList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmGroupList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AvailIPDList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailIPDList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaselineCategoryList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineCategoryList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaselineClassDenomCountList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineClassDenomCountList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaselineClassDenomList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineClassDenomList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaselineClassList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineClassList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaselineDenomCountList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineDenomCountList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaselineDenomList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineDenomList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaselineGroupList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineGroupList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaselineMeasureDenomCountList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineMeasureDenomCountList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaselineMeasureDenomList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineMeasureDenomList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaselineMeasureList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineMeasureList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaselineMeasurementList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineMeasurementList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BioSpec",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BioSpecRetention = table.Column<string>(nullable: true),
                    BioSpecDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BioSpec", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CentralContactList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentralContactList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CertainAgreement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgreementPISponsorEmployee = table.Column<string>(nullable: true),
                    AgreementRestrictionType = table.Column<string>(nullable: true),
                    AgreementRestrictiveAgreement = table.Column<string>(nullable: true),
                    AgreementOtherDetails = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertainAgreement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CityCoordinates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationCity = table.Column<string>(maxLength: 100, nullable: true),
                    lat = table.Column<string>(nullable: true),
                    lng = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityCoordinates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CollaboratorList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollaboratorList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompletionDateStruct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompletionDate = table.Column<string>(nullable: true),
                    CompletionDateType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletionDateStruct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConditionAncestorList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionAncestorList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConditionBrowseBranchList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionBrowseBranchList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConditionBrowseLeafList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionBrowseLeafList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConditionList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Condition = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConditionMeshList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionMeshList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DescriptionModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BriefSummary = table.Column<string>(nullable: true),
                    DetailedDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescriptionModule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DesignObservationalModelList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignObservationalModel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignObservationalModelList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DesignTimePerspectiveList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignTimePerspective = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignTimePerspectiveList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DesignWhoMaskedList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignWhoMasked = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignWhoMaskedList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DispFirstPostDateStruct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DispFirstPostDate = table.Column<string>(nullable: true),
                    DispFirstPostDateType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispFirstPostDateStruct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnrollmentInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnrollmentCount = table.Column<string>(nullable: true),
                    EnrollmentType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnrollmentInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventGroupList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventGroupList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpandedAccessInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HasExpandedAccess = table.Column<string>(nullable: true),
                    ExpandedAccessNCTId = table.Column<string>(nullable: true),
                    ExpandedAccessStatusForNCTId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpandedAccessInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpandedAccessTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpAccTypeIndividual = table.Column<string>(nullable: true),
                    ExpAccTypeIntermediate = table.Column<string>(nullable: true),
                    ExpAccTypeTreatment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpandedAccessTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlowAchievementList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowAchievementList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlowDropWithdrawList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowDropWithdrawList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlowGroupList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowGroupList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlowMilestoneList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowMilestoneList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlowPeriodList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowPeriodList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlowReasonList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowReasonList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterventionAncestorList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionAncestorList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterventionBrowseBranchList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionBrowseBranchList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterventionBrowseLeafList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionBrowseLeafList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterventionList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterventionMeshList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionMeshList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IPDSharingInfoTypeList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IPDSharingInfoType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPDSharingInfoTypeList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KeywordList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Keyword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeywordList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LargeDocList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LargeDocList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LastUpdatePostDateStruct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastUpdatePostDate = table.Column<string>(nullable: true),
                    LastUpdatePostDateType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastUpdatePostDateStruct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadSponsor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadSponsorName = table.Column<string>(nullable: true),
                    LeadSponsorClass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadSponsor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LimitationsAndCaveats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dedLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LimitationsAndCaveats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationContactList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationContactList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NCTIdAliasList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NCTIdAlias = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NCTIdAliasList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgFullName = table.Column<string>(maxLength: 200, nullable: true),
                    OrgClass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrgStudyIdInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgStudyId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgStudyIdInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OtherEventList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherEventList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OtherEventStatsList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherEventStatsList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OtherOutcomeList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherOutcomeList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeAnalysisGroupIdList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutcomeAnalysisGroupId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeAnalysisGroupIdList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeAnalysisList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeAnalysisList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeCategoryList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeCategoryList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeClassDenomCountList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeClassDenomCountList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeClassDenomList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeClassDenomList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeClassList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeClassList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeDenomCountList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeDenomCountList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeDenomList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeDenomList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeGroupList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeGroupList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeMeasureList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeMeasureList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeMeasurementList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeMeasurementList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OverallOfficialList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverallOfficialList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OversightModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OversightHasDMC = table.Column<string>(nullable: true),
                    IsFDARegulatedDrug = table.Column<string>(nullable: true),
                    IsFDARegulatedDevice = table.Column<string>(nullable: true),
                    IsUnapprovedDevice = table.Column<string>(nullable: true),
                    IsPPSD = table.Column<string>(nullable: true),
                    IsUSExport = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OversightModule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhaseList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhaseList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PointOfContact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PointOfContactTitle = table.Column<string>(nullable: true),
                    PointOfContactOrganization = table.Column<string>(nullable: true),
                    PointOfContactEMail = table.Column<string>(nullable: true),
                    PointOfContactPhone = table.Column<string>(nullable: true),
                    PointOfContactPhoneExt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointOfContact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryCompletionDateStruct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimaryCompletionDate = table.Column<string>(nullable: true),
                    PrimaryCompletionDateType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryCompletionDateStruct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryOutcomeList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryOutcomeList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferenceList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RemovedCountryList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RemovedCountry = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemovedCountryList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResponsibleParty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResponsiblePartyType = table.Column<string>(nullable: true),
                    ResponsiblePartyInvestigatorFullName = table.Column<string>(nullable: true),
                    ResponsiblePartyInvestigatorTitle = table.Column<string>(nullable: true),
                    ResponsiblePartyInvestigatorAffiliation = table.Column<string>(nullable: true),
                    ResponsiblePartyOldNameTitle = table.Column<string>(nullable: true),
                    ResponsiblePartyOldOrganization = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsibleParty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResultsFirstPostDateStruct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultsFirstPostDate = table.Column<string>(nullable: true),
                    ResultsFirstPostDateType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultsFirstPostDateStruct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RetractionList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetractionList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecondaryIdInfoList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryIdInfoList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecondaryOutcomeList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryOutcomeList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeeAlsoLinkList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeeAlsoLinkList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeriousEventList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriousEventList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeriousEventStatsList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriousEventStatsList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StartDateStruct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<string>(nullable: true),
                    StartDateType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartDateStruct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatisticsSearches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Condition = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatisticsSearches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StdAgeList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StdAge = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StdAgeList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudyFirstPostDateStruct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudyFirstPostDate = table.Column<string>(nullable: true),
                    StudyFirstPostDateType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyFirstPostDateStruct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TagLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NCTId = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnpostedEventList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnpostedEventList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArmGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArmGroupLabel = table.Column<string>(nullable: true),
                    ArmGroupType = table.Column<string>(nullable: true),
                    ArmGroupDescription = table.Column<string>(nullable: true),
                    ArmGroupInterventionListId = table.Column<int>(nullable: true),
                    ArmGroupListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArmGroup_ArmGroupInterventionList_ArmGroupInterventionListId",
                        column: x => x.ArmGroupInterventionListId,
                        principalTable: "ArmGroupInterventionList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArmGroup_ArmGroupList_ArmGroupListId",
                        column: x => x.ArmGroupListId,
                        principalTable: "ArmGroupList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AvailIPD",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailIPDId = table.Column<string>(nullable: true),
                    AvailIPDType = table.Column<string>(nullable: true),
                    AvailIPDURL = table.Column<string>(nullable: true),
                    AvailIPDComment = table.Column<string>(nullable: true),
                    AvailIPDListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailIPD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvailIPD_AvailIPDList_AvailIPDListId",
                        column: x => x.AvailIPDListId,
                        principalTable: "AvailIPDList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaselineClassDenomCount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaselineClassDenomCountGroupId = table.Column<string>(nullable: true),
                    BaselineClassDenomCountValue = table.Column<string>(nullable: true),
                    BaselineClassDenomCountListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineClassDenomCount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaselineClassDenomCount_BaselineClassDenomCountList_BaselineClassDenomCountListId",
                        column: x => x.BaselineClassDenomCountListId,
                        principalTable: "BaselineClassDenomCountList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaselineClassDenom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaselineClassDenomUnits = table.Column<string>(nullable: true),
                    BaselineClassDenomCountListId = table.Column<int>(nullable: true),
                    BaselineClassDenomListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineClassDenom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaselineClassDenom_BaselineClassDenomCountList_BaselineClassDenomCountListId",
                        column: x => x.BaselineClassDenomCountListId,
                        principalTable: "BaselineClassDenomCountList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaselineClassDenom_BaselineClassDenomList_BaselineClassDenomListId",
                        column: x => x.BaselineClassDenomListId,
                        principalTable: "BaselineClassDenomList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaselineClass",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaselineClassTitle = table.Column<string>(nullable: true),
                    BaselineClassDenomListId = table.Column<int>(nullable: true),
                    BaselineCategoryListId = table.Column<int>(nullable: true),
                    BaselineClassListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaselineClass_BaselineCategoryList_BaselineCategoryListId",
                        column: x => x.BaselineCategoryListId,
                        principalTable: "BaselineCategoryList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaselineClass_BaselineClassDenomList_BaselineClassDenomListId",
                        column: x => x.BaselineClassDenomListId,
                        principalTable: "BaselineClassDenomList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaselineClass_BaselineClassList_BaselineClassListId",
                        column: x => x.BaselineClassListId,
                        principalTable: "BaselineClassList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaselineDenomCount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaselineDenomCountGroupId = table.Column<string>(nullable: true),
                    BaselineDenomCountValue = table.Column<string>(nullable: true),
                    BaselineDenomCountListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineDenomCount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaselineDenomCount_BaselineDenomCountList_BaselineDenomCountListId",
                        column: x => x.BaselineDenomCountListId,
                        principalTable: "BaselineDenomCountList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaselineDenom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaselineDenomUnits = table.Column<string>(nullable: true),
                    BaselineDenomCountListId = table.Column<int>(nullable: true),
                    BaselineDenomListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineDenom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaselineDenom_BaselineDenomCountList_BaselineDenomCountListId",
                        column: x => x.BaselineDenomCountListId,
                        principalTable: "BaselineDenomCountList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaselineDenom_BaselineDenomList_BaselineDenomListId",
                        column: x => x.BaselineDenomListId,
                        principalTable: "BaselineDenomList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaselineGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaselineGroupId = table.Column<string>(nullable: true),
                    BaselineGroupTitle = table.Column<string>(nullable: true),
                    BaselineGroupDescription = table.Column<string>(nullable: true),
                    BaselineGroupListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaselineGroup_BaselineGroupList_BaselineGroupListId",
                        column: x => x.BaselineGroupListId,
                        principalTable: "BaselineGroupList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaselineMeasureDenomCount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaselineMeasureDenomCountGroupId = table.Column<string>(nullable: true),
                    BaselineMeasureDenomCountValue = table.Column<string>(nullable: true),
                    BaselineMeasureDenomCountListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineMeasureDenomCount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaselineMeasureDenomCount_BaselineMeasureDenomCountList_BaselineMeasureDenomCountListId",
                        column: x => x.BaselineMeasureDenomCountListId,
                        principalTable: "BaselineMeasureDenomCountList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaselineMeasureDenom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaselineMeasureDenomUnits = table.Column<string>(nullable: true),
                    BaselineMeasureDenomCountListId = table.Column<int>(nullable: true),
                    BaselineMeasureDenomListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineMeasureDenom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaselineMeasureDenom_BaselineMeasureDenomCountList_BaselineMeasureDenomCountListId",
                        column: x => x.BaselineMeasureDenomCountListId,
                        principalTable: "BaselineMeasureDenomCountList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaselineMeasureDenom_BaselineMeasureDenomList_BaselineMeasureDenomListId",
                        column: x => x.BaselineMeasureDenomListId,
                        principalTable: "BaselineMeasureDenomList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaselineCharacteristicsModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaselinePopulationDescription = table.Column<string>(nullable: true),
                    BaselineTypeUnitsAnalyzed = table.Column<string>(nullable: true),
                    BaselineGroupListId = table.Column<int>(nullable: true),
                    BaselineDenomListId = table.Column<int>(nullable: true),
                    BaselineMeasureListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineCharacteristicsModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaselineCharacteristicsModule_BaselineDenomList_BaselineDenomListId",
                        column: x => x.BaselineDenomListId,
                        principalTable: "BaselineDenomList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaselineCharacteristicsModule_BaselineGroupList_BaselineGroupListId",
                        column: x => x.BaselineGroupListId,
                        principalTable: "BaselineGroupList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaselineCharacteristicsModule_BaselineMeasureList_BaselineMeasureListId",
                        column: x => x.BaselineMeasureListId,
                        principalTable: "BaselineMeasureList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaselineMeasure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaselineMeasureTitle = table.Column<string>(nullable: true),
                    BaselineMeasureDescription = table.Column<string>(nullable: true),
                    BaselineMeasurePopulationDescription = table.Column<string>(nullable: true),
                    BaselineMeasureParamType = table.Column<string>(nullable: true),
                    BaselineMeasureDispersionType = table.Column<string>(nullable: true),
                    BaselineMeasureUnitOfMeasure = table.Column<string>(nullable: true),
                    BaselineMeasureCalculatePct = table.Column<string>(nullable: true),
                    BaselineMeasureDenomUnitsSelected = table.Column<string>(nullable: true),
                    BaselineMeasureDenomListId = table.Column<int>(nullable: true),
                    BaselineClassListId = table.Column<int>(nullable: true),
                    BaselineMeasureListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineMeasure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaselineMeasure_BaselineClassList_BaselineClassListId",
                        column: x => x.BaselineClassListId,
                        principalTable: "BaselineClassList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaselineMeasure_BaselineMeasureDenomList_BaselineMeasureDenomListId",
                        column: x => x.BaselineMeasureDenomListId,
                        principalTable: "BaselineMeasureDenomList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaselineMeasure_BaselineMeasureList_BaselineMeasureListId",
                        column: x => x.BaselineMeasureListId,
                        principalTable: "BaselineMeasureList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaselineCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaselineCategoryTitle = table.Column<string>(nullable: true),
                    BaselineMeasurementListId = table.Column<int>(nullable: true),
                    BaselineCategoryListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaselineCategory_BaselineCategoryList_BaselineCategoryListId",
                        column: x => x.BaselineCategoryListId,
                        principalTable: "BaselineCategoryList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaselineCategory_BaselineMeasurementList_BaselineMeasurementListId",
                        column: x => x.BaselineMeasurementListId,
                        principalTable: "BaselineMeasurementList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaselineMeasurement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaselineMeasurementGroupId = table.Column<string>(nullable: true),
                    BaselineMeasurementValue = table.Column<string>(nullable: true),
                    BaselineMeasurementSpread = table.Column<string>(nullable: true),
                    BaselineMeasurementLowerLimit = table.Column<string>(nullable: true),
                    BaselineMeasurementUpperLimit = table.Column<string>(nullable: true),
                    BaselineMeasurementComment = table.Column<string>(nullable: true),
                    BaselineMeasurementListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineMeasurement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaselineMeasurement_BaselineMeasurementList_BaselineMeasurementListId",
                        column: x => x.BaselineMeasurementListId,
                        principalTable: "BaselineMeasurementList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CentralContact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CentralContactName = table.Column<string>(nullable: true),
                    CentralContactRole = table.Column<string>(nullable: true),
                    CentralContactPhone = table.Column<string>(nullable: true),
                    CentralContactPhoneExt = table.Column<string>(nullable: true),
                    CentralContactEMail = table.Column<string>(nullable: true),
                    CentralContactListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentralContact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CentralContact_CentralContactList_CentralContactListId",
                        column: x => x.CentralContactListId,
                        principalTable: "CentralContactList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Collaborator",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollaboratorName = table.Column<string>(nullable: true),
                    CollaboratorClass = table.Column<string>(nullable: true),
                    CollaboratorListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collaborator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Collaborator_CollaboratorList_CollaboratorListId",
                        column: x => x.CollaboratorListId,
                        principalTable: "CollaboratorList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConditionAncestor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionAncestorId = table.Column<string>(nullable: true),
                    ConditionAncestorTerm = table.Column<string>(nullable: true),
                    ConditionAncestorListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionAncestor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConditionAncestor_ConditionAncestorList_ConditionAncestorListId",
                        column: x => x.ConditionAncestorListId,
                        principalTable: "ConditionAncestorList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConditionBrowseBranch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionBrowseBranchAbbrev = table.Column<string>(nullable: true),
                    ConditionBrowseBranchName = table.Column<string>(nullable: true),
                    ConditionBrowseBranchListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionBrowseBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConditionBrowseBranch_ConditionBrowseBranchList_ConditionBrowseBranchListId",
                        column: x => x.ConditionBrowseBranchListId,
                        principalTable: "ConditionBrowseBranchList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConditionBrowseLeaf",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionBrowseLeafId = table.Column<string>(nullable: true),
                    ConditionBrowseLeafName = table.Column<string>(nullable: true),
                    ConditionBrowseLeafAsFound = table.Column<string>(nullable: true),
                    ConditionBrowseLeafRelevance = table.Column<string>(nullable: true),
                    ConditionBrowseLeafListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionBrowseLeaf", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConditionBrowseLeaf_ConditionBrowseLeafList_ConditionBrowseLeafListId",
                        column: x => x.ConditionBrowseLeafListId,
                        principalTable: "ConditionBrowseLeafList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConditionBrowseModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionMeshListId = table.Column<int>(nullable: true),
                    ConditionAncestorListId = table.Column<int>(nullable: true),
                    ConditionBrowseLeafListId = table.Column<int>(nullable: true),
                    ConditionBrowseBranchListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionBrowseModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConditionBrowseModule_ConditionAncestorList_ConditionAncestorListId",
                        column: x => x.ConditionAncestorListId,
                        principalTable: "ConditionAncestorList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConditionBrowseModule_ConditionBrowseBranchList_ConditionBrowseBranchListId",
                        column: x => x.ConditionBrowseBranchListId,
                        principalTable: "ConditionBrowseBranchList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConditionBrowseModule_ConditionBrowseLeafList_ConditionBrowseLeafListId",
                        column: x => x.ConditionBrowseLeafListId,
                        principalTable: "ConditionBrowseLeafList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConditionBrowseModule_ConditionMeshList_ConditionMeshListId",
                        column: x => x.ConditionMeshListId,
                        principalTable: "ConditionMeshList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConditionMesh",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionMeshId = table.Column<string>(nullable: true),
                    ConditionMeshTerm = table.Column<string>(maxLength: 120, nullable: true),
                    ConditionMeshListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionMesh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConditionMesh_ConditionMeshList_ConditionMeshListId",
                        column: x => x.ConditionMeshListId,
                        principalTable: "ConditionMeshList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DesignMaskingInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignMasking = table.Column<string>(nullable: true),
                    DesignMaskingDescription = table.Column<string>(nullable: true),
                    DesignWhoMaskedListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignMaskingInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesignMaskingInfo_DesignWhoMaskedList_DesignWhoMaskedListId",
                        column: x => x.DesignWhoMaskedListId,
                        principalTable: "DesignWhoMaskedList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventGroupId = table.Column<string>(nullable: true),
                    EventGroupTitle = table.Column<string>(nullable: true),
                    EventGroupDescription = table.Column<string>(nullable: true),
                    EventGroupDeathsNumAffected = table.Column<string>(nullable: true),
                    EventGroupDeathsNumAtRisk = table.Column<string>(nullable: true),
                    EventGroupSeriousNumAffected = table.Column<string>(nullable: true),
                    EventGroupSeriousNumAtRisk = table.Column<string>(nullable: true),
                    EventGroupOtherNumAffected = table.Column<string>(nullable: true),
                    EventGroupOtherNumAtRisk = table.Column<string>(nullable: true),
                    EventGroupListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventGroup_EventGroupList_EventGroupListId",
                        column: x => x.EventGroupListId,
                        principalTable: "EventGroupList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FlowAchievement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlowAchievementGroupId = table.Column<string>(nullable: true),
                    FlowAchievementComment = table.Column<string>(nullable: true),
                    FlowAchievementNumSubjects = table.Column<string>(nullable: true),
                    FlowAchievementNumUnits = table.Column<string>(nullable: true),
                    FlowAchievementListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowAchievement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlowAchievement_FlowAchievementList_FlowAchievementListId",
                        column: x => x.FlowAchievementListId,
                        principalTable: "FlowAchievementList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FlowGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlowGroupId = table.Column<string>(nullable: true),
                    FlowGroupTitle = table.Column<string>(nullable: true),
                    FlowGroupDescription = table.Column<string>(nullable: true),
                    FlowGroupListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlowGroup_FlowGroupList_FlowGroupListId",
                        column: x => x.FlowGroupListId,
                        principalTable: "FlowGroupList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FlowMilestone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlowMilestoneType = table.Column<string>(nullable: true),
                    FlowMilestoneComment = table.Column<string>(nullable: true),
                    FlowAchievementListId = table.Column<int>(nullable: true),
                    FlowMilestoneListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowMilestone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlowMilestone_FlowAchievementList_FlowAchievementListId",
                        column: x => x.FlowAchievementListId,
                        principalTable: "FlowAchievementList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FlowMilestone_FlowMilestoneList_FlowMilestoneListId",
                        column: x => x.FlowMilestoneListId,
                        principalTable: "FlowMilestoneList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FlowPeriod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlowPeriodTitle = table.Column<string>(nullable: true),
                    FlowMilestoneListId = table.Column<int>(nullable: true),
                    FlowDropWithdrawListId = table.Column<int>(nullable: true),
                    FlowPeriodListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowPeriod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlowPeriod_FlowDropWithdrawList_FlowDropWithdrawListId",
                        column: x => x.FlowDropWithdrawListId,
                        principalTable: "FlowDropWithdrawList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FlowPeriod_FlowMilestoneList_FlowMilestoneListId",
                        column: x => x.FlowMilestoneListId,
                        principalTable: "FlowMilestoneList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FlowPeriod_FlowPeriodList_FlowPeriodListId",
                        column: x => x.FlowPeriodListId,
                        principalTable: "FlowPeriodList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantFlowModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlowPreAssignmentDetails = table.Column<string>(nullable: true),
                    FlowRecruitmentDetails = table.Column<string>(nullable: true),
                    FlowTypeUnitsAnalyzed = table.Column<string>(nullable: true),
                    FlowGroupListId = table.Column<int>(nullable: true),
                    FlowPeriodListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantFlowModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParticipantFlowModule_FlowGroupList_FlowGroupListId",
                        column: x => x.FlowGroupListId,
                        principalTable: "FlowGroupList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParticipantFlowModule_FlowPeriodList_FlowPeriodListId",
                        column: x => x.FlowPeriodListId,
                        principalTable: "FlowPeriodList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FlowDropWithdraw",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlowDropWithdrawType = table.Column<string>(nullable: true),
                    FlowDropWithdrawComment = table.Column<string>(nullable: true),
                    FlowReasonListId = table.Column<int>(nullable: true),
                    FlowDropWithdrawListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowDropWithdraw", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlowDropWithdraw_FlowDropWithdrawList_FlowDropWithdrawListId",
                        column: x => x.FlowDropWithdrawListId,
                        principalTable: "FlowDropWithdrawList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FlowDropWithdraw_FlowReasonList_FlowReasonListId",
                        column: x => x.FlowReasonListId,
                        principalTable: "FlowReasonList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FlowReason",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlowReasonGroupId = table.Column<string>(nullable: true),
                    FlowReasonComment = table.Column<string>(nullable: true),
                    FlowReasonNumSubjects = table.Column<string>(nullable: true),
                    FlowReasonNumUnits = table.Column<string>(nullable: true),
                    FlowReasonListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowReason", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlowReason_FlowReasonList_FlowReasonListId",
                        column: x => x.FlowReasonListId,
                        principalTable: "FlowReasonList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InterventionAncestor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterventionAncestorId = table.Column<string>(nullable: true),
                    InterventionAncestorTerm = table.Column<string>(nullable: true),
                    InterventionAncestorListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionAncestor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterventionAncestor_InterventionAncestorList_InterventionAncestorListId",
                        column: x => x.InterventionAncestorListId,
                        principalTable: "InterventionAncestorList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InterventionBrowseBranch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterventionBrowseBranchAbbrev = table.Column<string>(nullable: true),
                    InterventionBrowseBranchName = table.Column<string>(nullable: true),
                    InterventionBrowseBranchListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionBrowseBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterventionBrowseBranch_InterventionBrowseBranchList_InterventionBrowseBranchListId",
                        column: x => x.InterventionBrowseBranchListId,
                        principalTable: "InterventionBrowseBranchList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InterventionBrowseLeaf",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterventionBrowseLeafId = table.Column<string>(nullable: true),
                    InterventionBrowseLeafName = table.Column<string>(nullable: true),
                    InterventionBrowseLeafRelevance = table.Column<string>(nullable: true),
                    InterventionBrowseLeafAsFound = table.Column<string>(nullable: true),
                    InterventionBrowseLeafListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionBrowseLeaf", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterventionBrowseLeaf_InterventionBrowseLeafList_InterventionBrowseLeafListId",
                        column: x => x.InterventionBrowseLeafListId,
                        principalTable: "InterventionBrowseLeafList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArmsInterventionsModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterventionListId = table.Column<int>(nullable: true),
                    ArmGroupListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmsInterventionsModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArmsInterventionsModule_ArmGroupList_ArmGroupListId",
                        column: x => x.ArmGroupListId,
                        principalTable: "ArmGroupList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArmsInterventionsModule_InterventionList_InterventionListId",
                        column: x => x.InterventionListId,
                        principalTable: "InterventionList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Intervention",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterventionType = table.Column<string>(nullable: true),
                    InterventionName = table.Column<string>(nullable: true),
                    InterventionListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intervention", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Intervention_InterventionList_InterventionListId",
                        column: x => x.InterventionListId,
                        principalTable: "InterventionList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InterventionBrowseModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterventionMeshListId = table.Column<int>(nullable: true),
                    InterventionAncestorListId = table.Column<int>(nullable: true),
                    InterventionBrowseLeafListId = table.Column<int>(nullable: true),
                    InterventionBrowseBranchListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionBrowseModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterventionBrowseModule_InterventionAncestorList_InterventionAncestorListId",
                        column: x => x.InterventionAncestorListId,
                        principalTable: "InterventionAncestorList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InterventionBrowseModule_InterventionBrowseBranchList_InterventionBrowseBranchListId",
                        column: x => x.InterventionBrowseBranchListId,
                        principalTable: "InterventionBrowseBranchList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InterventionBrowseModule_InterventionBrowseLeafList_InterventionBrowseLeafListId",
                        column: x => x.InterventionBrowseLeafListId,
                        principalTable: "InterventionBrowseLeafList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InterventionBrowseModule_InterventionMeshList_InterventionMeshListId",
                        column: x => x.InterventionMeshListId,
                        principalTable: "InterventionMeshList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InterventionMesh",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterventionMeshId = table.Column<string>(nullable: true),
                    InterventionMeshTerm = table.Column<string>(nullable: true),
                    InterventionMeshListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionMesh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterventionMesh_InterventionMeshList_InterventionMeshListId",
                        column: x => x.InterventionMeshListId,
                        principalTable: "InterventionMeshList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IPDSharingStatementModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IPDSharing = table.Column<string>(nullable: true),
                    IPDSharingDescription = table.Column<string>(nullable: true),
                    IPDSharingInfoTypeListId = table.Column<int>(nullable: true),
                    IPDSharingTimeFrame = table.Column<string>(nullable: true),
                    IPDSharingAccessCriteria = table.Column<string>(nullable: true),
                    IPDSharingURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPDSharingStatementModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IPDSharingStatementModule_IPDSharingInfoTypeList_IPDSharingInfoTypeListId",
                        column: x => x.IPDSharingInfoTypeListId,
                        principalTable: "IPDSharingInfoTypeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConditionsModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionListId = table.Column<int>(nullable: true),
                    KeywordListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionsModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConditionsModule_ConditionList_ConditionListId",
                        column: x => x.ConditionListId,
                        principalTable: "ConditionList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConditionsModule_KeywordList_KeywordListId",
                        column: x => x.KeywordListId,
                        principalTable: "KeywordList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LargeDoc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LargeDocTypeAbbrev = table.Column<string>(nullable: true),
                    LargeDocHasProtocol = table.Column<string>(nullable: true),
                    LargeDocHasSAP = table.Column<string>(nullable: true),
                    LargeDocHasICF = table.Column<string>(nullable: true),
                    LargeDocLabel = table.Column<string>(nullable: true),
                    LargeDocDate = table.Column<string>(nullable: true),
                    LargeDocUploadDate = table.Column<string>(nullable: true),
                    LargeDocFilename = table.Column<string>(nullable: true),
                    LargeDocListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LargeDoc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LargeDoc_LargeDocList_LargeDocListId",
                        column: x => x.LargeDocListId,
                        principalTable: "LargeDocList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LargeDocumentModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LargeDocListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LargeDocumentModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LargeDocumentModule_LargeDocList_LargeDocListId",
                        column: x => x.LargeDocListId,
                        principalTable: "LargeDocList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationContact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationContactName = table.Column<string>(nullable: true),
                    LocationContactRole = table.Column<string>(nullable: true),
                    LocationContactPhone = table.Column<string>(nullable: true),
                    LocationContactPhoneExt = table.Column<string>(nullable: true),
                    LocationContactEMail = table.Column<string>(nullable: true),
                    LocationContactListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationContact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationContact_LocationContactList_LocationContactListId",
                        column: x => x.LocationContactListId,
                        principalTable: "LocationContactList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationFacility = table.Column<string>(nullable: true),
                    LocationCity = table.Column<string>(maxLength: 100, nullable: true),
                    LocationState = table.Column<string>(nullable: true),
                    LocationCountry = table.Column<string>(maxLength: 70, nullable: true),
                    LocationZip = table.Column<string>(nullable: true),
                    LocationStatus = table.Column<string>(nullable: true),
                    LocationContactListId = table.Column<int>(nullable: true),
                    LocationListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_LocationContactList_LocationContactListId",
                        column: x => x.LocationContactListId,
                        principalTable: "LocationContactList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Location_LocationList_LocationListId",
                        column: x => x.LocationListId,
                        principalTable: "LocationList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OtherEvent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtherEventTerm = table.Column<string>(nullable: true),
                    OtherEventOrganSystem = table.Column<string>(nullable: true),
                    OtherEventSourceVocabulary = table.Column<string>(nullable: true),
                    OtherEventAssessmentType = table.Column<string>(nullable: true),
                    OtherEventNotes = table.Column<string>(nullable: true),
                    OtherEventStatsListId = table.Column<int>(nullable: true),
                    OtherEventListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherEvent_OtherEventList_OtherEventListId",
                        column: x => x.OtherEventListId,
                        principalTable: "OtherEventList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OtherEvent_OtherEventStatsList_OtherEventStatsListId",
                        column: x => x.OtherEventStatsListId,
                        principalTable: "OtherEventStatsList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OtherEventStats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtherEventStatsGroupId = table.Column<string>(nullable: true),
                    OtherEventStatsNumEvents = table.Column<string>(nullable: true),
                    OtherEventStatsNumAffected = table.Column<string>(nullable: true),
                    OtherEventStatsNumAtRisk = table.Column<string>(nullable: true),
                    OtherEventStatsListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherEventStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherEventStats_OtherEventStatsList_OtherEventStatsListId",
                        column: x => x.OtherEventStatsListId,
                        principalTable: "OtherEventStatsList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OtherOutcome",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtherOutcomeMeasure = table.Column<string>(nullable: true),
                    OtherOutcomeDescription = table.Column<string>(nullable: true),
                    OtherOutcomeTimeFrame = table.Column<string>(nullable: true),
                    OtherOutcomeListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherOutcome", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherOutcome_OtherOutcomeList_OtherOutcomeListId",
                        column: x => x.OtherOutcomeListId,
                        principalTable: "OtherOutcomeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeAnalysis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutcomeAnalysisGroupIdListId = table.Column<int>(nullable: true),
                    OutcomeAnalysisGroupDescription = table.Column<string>(nullable: true),
                    OutcomeAnalysisTestedNonInferiority = table.Column<string>(nullable: true),
                    OutcomeAnalysisNonInferiorityType = table.Column<string>(nullable: true),
                    OutcomeAnalysisNonInferiorityComment = table.Column<string>(nullable: true),
                    OutcomeAnalysisPValue = table.Column<string>(nullable: true),
                    OutcomeAnalysisPValueComment = table.Column<string>(nullable: true),
                    OutcomeAnalysisStatisticalMethod = table.Column<string>(nullable: true),
                    OutcomeAnalysisStatisticalComment = table.Column<string>(nullable: true),
                    OutcomeAnalysisParamType = table.Column<string>(nullable: true),
                    OutcomeAnalysisParamValue = table.Column<string>(nullable: true),
                    OutcomeAnalysisCIPctValue = table.Column<string>(nullable: true),
                    OutcomeAnalysisCINumSides = table.Column<string>(nullable: true),
                    OutcomeAnalysisCILowerLimit = table.Column<string>(nullable: true),
                    OutcomeAnalysisCIUpperLimit = table.Column<string>(nullable: true),
                    OutcomeAnalysisCILowerLimitComment = table.Column<string>(nullable: true),
                    OutcomeAnalysisCIUpperLimitComment = table.Column<string>(nullable: true),
                    OutcomeAnalysisDispersionType = table.Column<string>(nullable: true),
                    OutcomeAnalysisDispersionValue = table.Column<string>(nullable: true),
                    OutcomeAnalysisEstimateComment = table.Column<string>(nullable: true),
                    OutcomeAnalysisOtherAnalysisDescription = table.Column<string>(nullable: true),
                    OutcomeAnalysisListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeAnalysis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutcomeAnalysis_OutcomeAnalysisGroupIdList_OutcomeAnalysisGroupIdListId",
                        column: x => x.OutcomeAnalysisGroupIdListId,
                        principalTable: "OutcomeAnalysisGroupIdList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutcomeAnalysis_OutcomeAnalysisList_OutcomeAnalysisListId",
                        column: x => x.OutcomeAnalysisListId,
                        principalTable: "OutcomeAnalysisList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeClassDenomCount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutcomeClassDenomCountGroupId = table.Column<string>(nullable: true),
                    OutcomeClassDenomCountValue = table.Column<string>(nullable: true),
                    OutcomeClassDenomCountListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeClassDenomCount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutcomeClassDenomCount_OutcomeClassDenomCountList_OutcomeClassDenomCountListId",
                        column: x => x.OutcomeClassDenomCountListId,
                        principalTable: "OutcomeClassDenomCountList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeClassDenom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutcomeClassDenomUnits = table.Column<string>(nullable: true),
                    OutcomeClassDenomCountListId = table.Column<int>(nullable: true),
                    OutcomeClassDenomListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeClassDenom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutcomeClassDenom_OutcomeClassDenomCountList_OutcomeClassDenomCountListId",
                        column: x => x.OutcomeClassDenomCountListId,
                        principalTable: "OutcomeClassDenomCountList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutcomeClassDenom_OutcomeClassDenomList_OutcomeClassDenomListId",
                        column: x => x.OutcomeClassDenomListId,
                        principalTable: "OutcomeClassDenomList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeClass",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutcomeClassTitle = table.Column<string>(nullable: true),
                    OutcomeClassDenomListId = table.Column<int>(nullable: true),
                    OutcomeCategoryListId = table.Column<int>(nullable: true),
                    OutcomeClassListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutcomeClass_OutcomeCategoryList_OutcomeCategoryListId",
                        column: x => x.OutcomeCategoryListId,
                        principalTable: "OutcomeCategoryList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutcomeClass_OutcomeClassDenomList_OutcomeClassDenomListId",
                        column: x => x.OutcomeClassDenomListId,
                        principalTable: "OutcomeClassDenomList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutcomeClass_OutcomeClassList_OutcomeClassListId",
                        column: x => x.OutcomeClassListId,
                        principalTable: "OutcomeClassList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeDenomCount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(nullable: true),
                    OutcomeDenomCountGroupId = table.Column<string>(nullable: true),
                    OutcomeDenomCountValue = table.Column<string>(nullable: true),
                    OutcomeDenomCountListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeDenomCount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutcomeDenomCount_OutcomeDenomCountList_OutcomeDenomCountListId",
                        column: x => x.OutcomeDenomCountListId,
                        principalTable: "OutcomeDenomCountList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeDenom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutcomeDenomUnits = table.Column<string>(nullable: true),
                    OutcomeDenomCountListId = table.Column<int>(nullable: true),
                    OutcomeDenomListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeDenom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutcomeDenom_OutcomeDenomCountList_OutcomeDenomCountListId",
                        column: x => x.OutcomeDenomCountListId,
                        principalTable: "OutcomeDenomCountList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutcomeDenom_OutcomeDenomList_OutcomeDenomListId",
                        column: x => x.OutcomeDenomListId,
                        principalTable: "OutcomeDenomList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutcomeGroupId = table.Column<string>(nullable: true),
                    OutcomeGroupTitle = table.Column<string>(nullable: true),
                    OutcomeGroupDescription = table.Column<string>(nullable: true),
                    OutcomeGroupListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutcomeGroup_OutcomeGroupList_OutcomeGroupListId",
                        column: x => x.OutcomeGroupListId,
                        principalTable: "OutcomeGroupList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeMeasure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutcomeMeasureType = table.Column<string>(nullable: true),
                    OutcomeMeasureTitle = table.Column<string>(nullable: true),
                    OutcomeMeasureDescription = table.Column<string>(nullable: true),
                    OutcomeMeasurePopulationDescription = table.Column<string>(nullable: true),
                    OutcomeMeasureReportingStatus = table.Column<string>(nullable: true),
                    OutcomeMeasureAnticipatedPostingDate = table.Column<string>(nullable: true),
                    OutcomeMeasureParamType = table.Column<string>(nullable: true),
                    OutcomeMeasureDispersionType = table.Column<string>(nullable: true),
                    OutcomeMeasureUnitOfMeasure = table.Column<string>(nullable: true),
                    OutcomeMeasureCalculatePct = table.Column<string>(nullable: true),
                    OutcomeMeasureTimeFrame = table.Column<string>(nullable: true),
                    OutcomeMeasureTypeUnitsAnalyzed = table.Column<string>(nullable: true),
                    OutcomeMeasureDenomUnitsSelected = table.Column<string>(nullable: true),
                    OutcomeGroupListId = table.Column<int>(nullable: true),
                    OutcomeDenomListId = table.Column<int>(nullable: true),
                    OutcomeClassListId = table.Column<int>(nullable: true),
                    OutcomeAnalysisListId = table.Column<int>(nullable: true),
                    OutcomeMeasureListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeMeasure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutcomeMeasure_OutcomeAnalysisList_OutcomeAnalysisListId",
                        column: x => x.OutcomeAnalysisListId,
                        principalTable: "OutcomeAnalysisList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutcomeMeasure_OutcomeClassList_OutcomeClassListId",
                        column: x => x.OutcomeClassListId,
                        principalTable: "OutcomeClassList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutcomeMeasure_OutcomeDenomList_OutcomeDenomListId",
                        column: x => x.OutcomeDenomListId,
                        principalTable: "OutcomeDenomList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutcomeMeasure_OutcomeGroupList_OutcomeGroupListId",
                        column: x => x.OutcomeGroupListId,
                        principalTable: "OutcomeGroupList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutcomeMeasure_OutcomeMeasureList_OutcomeMeasureListId",
                        column: x => x.OutcomeMeasureListId,
                        principalTable: "OutcomeMeasureList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeMeasuresModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutcomeMeasureListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeMeasuresModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutcomeMeasuresModule_OutcomeMeasureList_OutcomeMeasureListId",
                        column: x => x.OutcomeMeasureListId,
                        principalTable: "OutcomeMeasureList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutcomeCategoryTitle = table.Column<string>(nullable: true),
                    OutcomeMeasurementListId = table.Column<int>(nullable: true),
                    OutcomeCategoryListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutcomeCategory_OutcomeCategoryList_OutcomeCategoryListId",
                        column: x => x.OutcomeCategoryListId,
                        principalTable: "OutcomeCategoryList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutcomeCategory_OutcomeMeasurementList_OutcomeMeasurementListId",
                        column: x => x.OutcomeMeasurementListId,
                        principalTable: "OutcomeMeasurementList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutcomeMeasurement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutcomeMeasurementGroupId = table.Column<string>(nullable: true),
                    OutcomeMeasurementValue = table.Column<string>(nullable: true),
                    OutcomeMeasurementSpread = table.Column<string>(nullable: true),
                    OutcomeMeasurementLowerLimit = table.Column<string>(nullable: true),
                    OutcomeMeasurementUpperLimit = table.Column<string>(nullable: true),
                    OutcomeMeasurementComment = table.Column<string>(nullable: true),
                    OutcomeMeasurementListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeMeasurement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutcomeMeasurement_OutcomeMeasurementList_OutcomeMeasurementListId",
                        column: x => x.OutcomeMeasurementListId,
                        principalTable: "OutcomeMeasurementList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactsLocationsModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationListId = table.Column<int>(nullable: true),
                    CentralContactListId = table.Column<int>(nullable: true),
                    OverallOfficialListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactsLocationsModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactsLocationsModule_CentralContactList_CentralContactListId",
                        column: x => x.CentralContactListId,
                        principalTable: "CentralContactList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContactsLocationsModule_LocationList_LocationListId",
                        column: x => x.LocationListId,
                        principalTable: "LocationList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContactsLocationsModule_OverallOfficialList_OverallOfficialListId",
                        column: x => x.OverallOfficialListId,
                        principalTable: "OverallOfficialList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OverallOfficial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OverallOfficialName = table.Column<string>(nullable: true),
                    OverallOfficialAffiliation = table.Column<string>(nullable: true),
                    OverallOfficialRole = table.Column<string>(nullable: true),
                    OverallOfficialListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverallOfficial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OverallOfficial_OverallOfficialList_OverallOfficialListId",
                        column: x => x.OverallOfficialListId,
                        principalTable: "OverallOfficialList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MoreInfoModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LimitationsAndCaveatsId = table.Column<int>(nullable: true),
                    CertainAgreementId = table.Column<int>(nullable: true),
                    PointOfContactId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoreInfoModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoreInfoModule_CertainAgreement_CertainAgreementId",
                        column: x => x.CertainAgreementId,
                        principalTable: "CertainAgreement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MoreInfoModule_LimitationsAndCaveats_LimitationsAndCaveatsId",
                        column: x => x.LimitationsAndCaveatsId,
                        principalTable: "LimitationsAndCaveats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MoreInfoModule_PointOfContact_PointOfContactId",
                        column: x => x.PointOfContactId,
                        principalTable: "PointOfContact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryOutcome",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimaryOutcomeMeasure = table.Column<string>(nullable: true),
                    PrimaryOutcomeDescription = table.Column<string>(nullable: true),
                    PrimaryOutcomeTimeFrame = table.Column<string>(nullable: true),
                    PrimaryOutcomeListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryOutcome", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrimaryOutcome_PrimaryOutcomeList_PrimaryOutcomeListId",
                        column: x => x.PrimaryOutcomeListId,
                        principalTable: "PrimaryOutcomeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MiscInfoModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionHolder = table.Column<string>(nullable: true),
                    RemovedCountryListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiscInfoModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MiscInfoModule_RemovedCountryList_RemovedCountryListId",
                        column: x => x.RemovedCountryListId,
                        principalTable: "RemovedCountryList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SponsorCollaboratorsModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResponsiblePartyId = table.Column<int>(nullable: true),
                    LeadSponsorId = table.Column<int>(nullable: true),
                    CollaboratorListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorCollaboratorsModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SponsorCollaboratorsModule_CollaboratorList_CollaboratorListId",
                        column: x => x.CollaboratorListId,
                        principalTable: "CollaboratorList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SponsorCollaboratorsModule_LeadSponsor_LeadSponsorId",
                        column: x => x.LeadSponsorId,
                        principalTable: "LeadSponsor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SponsorCollaboratorsModule_ResponsibleParty_ResponsiblePartyId",
                        column: x => x.ResponsiblePartyId,
                        principalTable: "ResponsibleParty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reference",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferencePMID = table.Column<string>(nullable: true),
                    ReferenceType = table.Column<string>(nullable: true),
                    ReferenceCitation = table.Column<string>(nullable: true),
                    RetractionListId = table.Column<int>(nullable: true),
                    ReferenceListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reference_ReferenceList_ReferenceListId",
                        column: x => x.ReferenceListId,
                        principalTable: "ReferenceList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reference_RetractionList_RetractionListId",
                        column: x => x.RetractionListId,
                        principalTable: "RetractionList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Retraction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RetractionPMID = table.Column<string>(nullable: true),
                    RetractionSource = table.Column<string>(nullable: true),
                    RetractionListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retraction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Retraction_RetractionList_RetractionListId",
                        column: x => x.RetractionListId,
                        principalTable: "RetractionList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IdentificationModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NCTId = table.Column<string>(nullable: true),
                    OrgStudyIdInfoId = table.Column<int>(nullable: true),
                    SecondaryIdInfoListId = table.Column<int>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: true),
                    BriefTitle = table.Column<string>(nullable: true),
                    OfficialTitle = table.Column<string>(nullable: true),
                    Acronym = table.Column<string>(nullable: true),
                    NCTIdAliasListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentificationModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentificationModule_NCTIdAliasList_NCTIdAliasListId",
                        column: x => x.NCTIdAliasListId,
                        principalTable: "NCTIdAliasList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IdentificationModule_OrgStudyIdInfo_OrgStudyIdInfoId",
                        column: x => x.OrgStudyIdInfoId,
                        principalTable: "OrgStudyIdInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IdentificationModule_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IdentificationModule_SecondaryIdInfoList_SecondaryIdInfoListId",
                        column: x => x.SecondaryIdInfoListId,
                        principalTable: "SecondaryIdInfoList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SecondaryIdInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecondaryId = table.Column<string>(nullable: true),
                    SecondaryIdType = table.Column<string>(nullable: true),
                    SecondaryIdLink = table.Column<string>(nullable: true),
                    SecondaryIdInfoListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryIdInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecondaryIdInfo_SecondaryIdInfoList_SecondaryIdInfoListId",
                        column: x => x.SecondaryIdInfoListId,
                        principalTable: "SecondaryIdInfoList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutcomesModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimaryOutcomeListId = table.Column<int>(nullable: true),
                    SecondaryOutcomeListId = table.Column<int>(nullable: true),
                    OtherOutcomeListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomesModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutcomesModule_OtherOutcomeList_OtherOutcomeListId",
                        column: x => x.OtherOutcomeListId,
                        principalTable: "OtherOutcomeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutcomesModule_PrimaryOutcomeList_PrimaryOutcomeListId",
                        column: x => x.PrimaryOutcomeListId,
                        principalTable: "PrimaryOutcomeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutcomesModule_SecondaryOutcomeList_SecondaryOutcomeListId",
                        column: x => x.SecondaryOutcomeListId,
                        principalTable: "SecondaryOutcomeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SecondaryOutcome",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecondaryOutcomeMeasure = table.Column<string>(nullable: true),
                    SecondaryOutcomeDescription = table.Column<string>(nullable: true),
                    SecondaryOutcomeTimeFrame = table.Column<string>(nullable: true),
                    SecondaryOutcomeListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryOutcome", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecondaryOutcome_SecondaryOutcomeList_SecondaryOutcomeListId",
                        column: x => x.SecondaryOutcomeListId,
                        principalTable: "SecondaryOutcomeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReferencesModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceListId = table.Column<int>(nullable: true),
                    SeeAlsoLinkListId = table.Column<int>(nullable: true),
                    AvailIPDListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferencesModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReferencesModule_AvailIPDList_AvailIPDListId",
                        column: x => x.AvailIPDListId,
                        principalTable: "AvailIPDList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReferencesModule_ReferenceList_ReferenceListId",
                        column: x => x.ReferenceListId,
                        principalTable: "ReferenceList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReferencesModule_SeeAlsoLinkList_SeeAlsoLinkListId",
                        column: x => x.SeeAlsoLinkListId,
                        principalTable: "SeeAlsoLinkList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeeAlsoLink",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeeAlsoLinkLabel = table.Column<string>(nullable: true),
                    SeeAlsoLinkURL = table.Column<string>(nullable: true),
                    SeeAlsoLinkListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeeAlsoLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeeAlsoLink_SeeAlsoLinkList_SeeAlsoLinkListId",
                        column: x => x.SeeAlsoLinkListId,
                        principalTable: "SeeAlsoLinkList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdverseEventsModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventsFrequencyThreshold = table.Column<string>(nullable: true),
                    EventsTimeFrame = table.Column<string>(nullable: true),
                    EventsDescription = table.Column<string>(nullable: true),
                    EventGroupListId = table.Column<int>(nullable: true),
                    SeriousEventListId = table.Column<int>(nullable: true),
                    OtherEventListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdverseEventsModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdverseEventsModule_EventGroupList_EventGroupListId",
                        column: x => x.EventGroupListId,
                        principalTable: "EventGroupList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdverseEventsModule_OtherEventList_OtherEventListId",
                        column: x => x.OtherEventListId,
                        principalTable: "OtherEventList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdverseEventsModule_SeriousEventList_SeriousEventListId",
                        column: x => x.SeriousEventListId,
                        principalTable: "SeriousEventList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeriousEvent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriousEventTerm = table.Column<string>(nullable: true),
                    SeriousEventOrganSystem = table.Column<string>(nullable: true),
                    SeriousEventSourceVocabulary = table.Column<string>(nullable: true),
                    SeriousEventAssessmentType = table.Column<string>(nullable: true),
                    SeriousEventNotes = table.Column<string>(nullable: true),
                    SeriousEventStatsListId = table.Column<int>(nullable: true),
                    SeriousEventListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriousEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeriousEvent_SeriousEventList_SeriousEventListId",
                        column: x => x.SeriousEventListId,
                        principalTable: "SeriousEventList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SeriousEvent_SeriousEventStatsList_SeriousEventStatsListId",
                        column: x => x.SeriousEventStatsListId,
                        principalTable: "SeriousEventStatsList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeriousEventStats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriousEventStatsGroupId = table.Column<string>(nullable: true),
                    SeriousEventStatsNumEvents = table.Column<string>(nullable: true),
                    SeriousEventStatsNumAffected = table.Column<string>(nullable: true),
                    SeriousEventStatsNumAtRisk = table.Column<string>(nullable: true),
                    SeriousEventStatsListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriousEventStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeriousEventStats_SeriousEventStatsList_SeriousEventStatsListId",
                        column: x => x.SeriousEventStatsListId,
                        principalTable: "SeriousEventStatsList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EligibilityModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EligibilityCriteria = table.Column<string>(nullable: true),
                    HealthyVolunteers = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    MinimumAge = table.Column<string>(nullable: true),
                    MaximumAge = table.Column<string>(nullable: true),
                    StdAgeListId = table.Column<int>(nullable: true),
                    GenderBased = table.Column<string>(nullable: true),
                    GenderDescription = table.Column<string>(nullable: true),
                    StudyPopulation = table.Column<string>(nullable: true),
                    SamplingMethod = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EligibilityModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EligibilityModule_StdAgeList_StdAgeListId",
                        column: x => x.StdAgeListId,
                        principalTable: "StdAgeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StatusModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusVerifiedDate = table.Column<string>(nullable: true),
                    OverallStatus = table.Column<string>(nullable: true),
                    ExpandedAccessInfoId = table.Column<int>(nullable: true),
                    StudyFirstSubmitDate = table.Column<DateTime>(nullable: true),
                    StudyFirstSubmitQCDate = table.Column<string>(nullable: true),
                    StudyFirstPostDateStructId = table.Column<int>(nullable: true),
                    LastUpdateSubmitDate = table.Column<DateTime>(nullable: true),
                    LastUpdatePostDateStructId = table.Column<int>(nullable: true),
                    LastKnownStatus = table.Column<string>(nullable: true),
                    DelayedPosting = table.Column<string>(nullable: true),
                    WhyStopped = table.Column<string>(nullable: true),
                    StartDateStructId = table.Column<int>(nullable: true),
                    PrimaryCompletionDateStructId = table.Column<int>(nullable: true),
                    CompletionDateStructId = table.Column<int>(nullable: true),
                    DispFirstSubmitDate = table.Column<string>(nullable: true),
                    DispFirstSubmitQCDate = table.Column<string>(nullable: true),
                    DispFirstPostDateStructId = table.Column<int>(nullable: true),
                    ResultsFirstSubmitDate = table.Column<DateTime>(nullable: true),
                    ResultsFirstSubmitQCDate = table.Column<string>(nullable: true),
                    ResultsFirstPostDateStructId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatusModule_CompletionDateStruct_CompletionDateStructId",
                        column: x => x.CompletionDateStructId,
                        principalTable: "CompletionDateStruct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StatusModule_DispFirstPostDateStruct_DispFirstPostDateStructId",
                        column: x => x.DispFirstPostDateStructId,
                        principalTable: "DispFirstPostDateStruct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StatusModule_ExpandedAccessInfo_ExpandedAccessInfoId",
                        column: x => x.ExpandedAccessInfoId,
                        principalTable: "ExpandedAccessInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StatusModule_LastUpdatePostDateStruct_LastUpdatePostDateStructId",
                        column: x => x.LastUpdatePostDateStructId,
                        principalTable: "LastUpdatePostDateStruct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StatusModule_PrimaryCompletionDateStruct_PrimaryCompletionDateStructId",
                        column: x => x.PrimaryCompletionDateStructId,
                        principalTable: "PrimaryCompletionDateStruct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StatusModule_ResultsFirstPostDateStruct_ResultsFirstPostDateStructId",
                        column: x => x.ResultsFirstPostDateStructId,
                        principalTable: "ResultsFirstPostDateStruct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StatusModule_StartDateStruct_StartDateStructId",
                        column: x => x.StartDateStructId,
                        principalTable: "StartDateStruct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StatusModule_StudyFirstPostDateStruct_StudyFirstPostDateStructId",
                        column: x => x.StudyFirstPostDateStructId,
                        principalTable: "StudyFirstPostDateStruct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnpostedAnnotation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnpostedResponsibleParty = table.Column<string>(nullable: true),
                    UnpostedEventListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnpostedAnnotation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnpostedAnnotation_UnpostedEventList_UnpostedEventListId",
                        column: x => x.UnpostedEventListId,
                        principalTable: "UnpostedEventList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnpostedEvent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnpostedEventType = table.Column<string>(nullable: true),
                    UnpostedEventDate = table.Column<string>(nullable: true),
                    UnpostedEventListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnpostedEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnpostedEvent_UnpostedEventList_UnpostedEventListId",
                        column: x => x.UnpostedEventListId,
                        principalTable: "UnpostedEventList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DesignInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignAllocation = table.Column<string>(nullable: true),
                    DesignInterventionModel = table.Column<string>(nullable: true),
                    DesignInterventionModelDescription = table.Column<string>(nullable: true),
                    DesignPrimaryPurpose = table.Column<string>(nullable: true),
                    DesignObservationalModelListId = table.Column<int>(nullable: true),
                    DesignTimePerspectiveListId = table.Column<int>(nullable: true),
                    DesignMaskingInfoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesignInfo_DesignMaskingInfo_DesignMaskingInfoId",
                        column: x => x.DesignMaskingInfoId,
                        principalTable: "DesignMaskingInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DesignInfo_DesignObservationalModelList_DesignObservationalModelListId",
                        column: x => x.DesignObservationalModelListId,
                        principalTable: "DesignObservationalModelList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DesignInfo_DesignTimePerspectiveList_DesignTimePerspectiveListId",
                        column: x => x.DesignTimePerspectiveListId,
                        principalTable: "DesignTimePerspectiveList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentSection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LargeDocumentModuleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentSection_LargeDocumentModule_LargeDocumentModuleId",
                        column: x => x.LargeDocumentModuleId,
                        principalTable: "LargeDocumentModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DerivedSection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MiscInfoModuleId = table.Column<int>(nullable: true),
                    InterventionBrowseModuleId = table.Column<int>(nullable: true),
                    ConditionBrowseModuleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DerivedSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DerivedSection_ConditionBrowseModule_ConditionBrowseModuleId",
                        column: x => x.ConditionBrowseModuleId,
                        principalTable: "ConditionBrowseModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DerivedSection_InterventionBrowseModule_InterventionBrowseModuleId",
                        column: x => x.InterventionBrowseModuleId,
                        principalTable: "InterventionBrowseModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DerivedSection_MiscInfoModule_MiscInfoModuleId",
                        column: x => x.MiscInfoModuleId,
                        principalTable: "MiscInfoModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResultsSection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParticipantFlowModuleId = table.Column<int>(nullable: true),
                    BaselineCharacteristicsModuleId = table.Column<int>(nullable: true),
                    OutcomeMeasuresModuleId = table.Column<int>(nullable: true),
                    AdverseEventsModuleId = table.Column<int>(nullable: true),
                    MoreInfoModuleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultsSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultsSection_AdverseEventsModule_AdverseEventsModuleId",
                        column: x => x.AdverseEventsModuleId,
                        principalTable: "AdverseEventsModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResultsSection_BaselineCharacteristicsModule_BaselineCharacteristicsModuleId",
                        column: x => x.BaselineCharacteristicsModuleId,
                        principalTable: "BaselineCharacteristicsModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResultsSection_MoreInfoModule_MoreInfoModuleId",
                        column: x => x.MoreInfoModuleId,
                        principalTable: "MoreInfoModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResultsSection_OutcomeMeasuresModule_OutcomeMeasuresModuleId",
                        column: x => x.OutcomeMeasuresModuleId,
                        principalTable: "OutcomeMeasuresModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResultsSection_ParticipantFlowModule_ParticipantFlowModuleId",
                        column: x => x.ParticipantFlowModuleId,
                        principalTable: "ParticipantFlowModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnnotationModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnpostedAnnotationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnotationModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnnotationModule_UnpostedAnnotation_UnpostedAnnotationId",
                        column: x => x.UnpostedAnnotationId,
                        principalTable: "UnpostedAnnotation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DesignModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudyType = table.Column<string>(nullable: true),
                    PhaseListId = table.Column<int>(nullable: true),
                    DesignInfoId = table.Column<int>(nullable: true),
                    PatientRegistry = table.Column<string>(nullable: true),
                    TargetDuration = table.Column<string>(nullable: true),
                    BioSpecId = table.Column<int>(nullable: true),
                    EnrollmentInfoId = table.Column<int>(nullable: true),
                    ExpandedAccessTypesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesignModule_BioSpec_BioSpecId",
                        column: x => x.BioSpecId,
                        principalTable: "BioSpec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DesignModule_DesignInfo_DesignInfoId",
                        column: x => x.DesignInfoId,
                        principalTable: "DesignInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DesignModule_EnrollmentInfo_EnrollmentInfoId",
                        column: x => x.EnrollmentInfoId,
                        principalTable: "EnrollmentInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DesignModule_ExpandedAccessTypes_ExpandedAccessTypesId",
                        column: x => x.ExpandedAccessTypesId,
                        principalTable: "ExpandedAccessTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DesignModule_PhaseList_PhaseListId",
                        column: x => x.PhaseListId,
                        principalTable: "PhaseList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnnotationSection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnotationModuleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnotationSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnnotationSection_AnnotationModule_AnnotationModuleId",
                        column: x => x.AnnotationModuleId,
                        principalTable: "AnnotationModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProtocolSection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificationModuleId = table.Column<int>(nullable: true),
                    StatusModuleId = table.Column<int>(nullable: true),
                    SponsorCollaboratorsModuleId = table.Column<int>(nullable: true),
                    OversightModuleId = table.Column<int>(nullable: true),
                    DescriptionModuleId = table.Column<int>(nullable: true),
                    ConditionsModuleId = table.Column<int>(nullable: true),
                    DesignModuleId = table.Column<int>(nullable: true),
                    ArmsInterventionsModuleId = table.Column<int>(nullable: true),
                    OutcomesModuleId = table.Column<int>(nullable: true),
                    EligibilityModuleId = table.Column<int>(nullable: true),
                    ContactsLocationsModuleId = table.Column<int>(nullable: true),
                    ReferencesModuleId = table.Column<int>(nullable: true),
                    IPDSharingStatementModuleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtocolSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProtocolSection_ArmsInterventionsModule_ArmsInterventionsModuleId",
                        column: x => x.ArmsInterventionsModuleId,
                        principalTable: "ArmsInterventionsModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProtocolSection_ConditionsModule_ConditionsModuleId",
                        column: x => x.ConditionsModuleId,
                        principalTable: "ConditionsModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProtocolSection_ContactsLocationsModule_ContactsLocationsModuleId",
                        column: x => x.ContactsLocationsModuleId,
                        principalTable: "ContactsLocationsModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProtocolSection_DescriptionModule_DescriptionModuleId",
                        column: x => x.DescriptionModuleId,
                        principalTable: "DescriptionModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProtocolSection_DesignModule_DesignModuleId",
                        column: x => x.DesignModuleId,
                        principalTable: "DesignModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProtocolSection_EligibilityModule_EligibilityModuleId",
                        column: x => x.EligibilityModuleId,
                        principalTable: "EligibilityModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProtocolSection_IPDSharingStatementModule_IPDSharingStatementModuleId",
                        column: x => x.IPDSharingStatementModuleId,
                        principalTable: "IPDSharingStatementModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProtocolSection_IdentificationModule_IdentificationModuleId",
                        column: x => x.IdentificationModuleId,
                        principalTable: "IdentificationModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProtocolSection_OutcomesModule_OutcomesModuleId",
                        column: x => x.OutcomesModuleId,
                        principalTable: "OutcomesModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProtocolSection_OversightModule_OversightModuleId",
                        column: x => x.OversightModuleId,
                        principalTable: "OversightModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProtocolSection_ReferencesModule_ReferencesModuleId",
                        column: x => x.ReferencesModuleId,
                        principalTable: "ReferencesModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProtocolSection_SponsorCollaboratorsModule_SponsorCollaboratorsModuleId",
                        column: x => x.SponsorCollaboratorsModuleId,
                        principalTable: "SponsorCollaboratorsModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProtocolSection_StatusModule_StatusModuleId",
                        column: x => x.StatusModuleId,
                        principalTable: "StatusModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Study",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProtocolSectionId = table.Column<int>(nullable: true),
                    ResultsSectionId = table.Column<int>(nullable: true),
                    AnnotationSectionId = table.Column<int>(nullable: true),
                    DocumentSectionId = table.Column<int>(nullable: true),
                    DerivedSectionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Study", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Study_AnnotationSection_AnnotationSectionId",
                        column: x => x.AnnotationSectionId,
                        principalTable: "AnnotationSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Study_DerivedSection_DerivedSectionId",
                        column: x => x.DerivedSectionId,
                        principalTable: "DerivedSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Study_DocumentSection_DocumentSectionId",
                        column: x => x.DocumentSectionId,
                        principalTable: "DocumentSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Study_ProtocolSection_ProtocolSectionId",
                        column: x => x.ProtocolSectionId,
                        principalTable: "ProtocolSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Study_ResultsSection_ResultsSectionId",
                        column: x => x.ResultsSectionId,
                        principalTable: "ResultsSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FullStudy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rank = table.Column<int>(nullable: false),
                    StudyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullStudy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FullStudy_Study_StudyId",
                        column: x => x.StudyId,
                        principalTable: "Study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Studies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullStudyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Studies_FullStudy_FullStudyId",
                        column: x => x.FullStudyId,
                        principalTable: "FullStudy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdverseEventsModule_EventGroupListId",
                table: "AdverseEventsModule",
                column: "EventGroupListId");

            migrationBuilder.CreateIndex(
                name: "IX_AdverseEventsModule_OtherEventListId",
                table: "AdverseEventsModule",
                column: "OtherEventListId");

            migrationBuilder.CreateIndex(
                name: "IX_AdverseEventsModule_SeriousEventListId",
                table: "AdverseEventsModule",
                column: "SeriousEventListId");

            migrationBuilder.CreateIndex(
                name: "IX_AnnotationModule_UnpostedAnnotationId",
                table: "AnnotationModule",
                column: "UnpostedAnnotationId");

            migrationBuilder.CreateIndex(
                name: "IX_AnnotationSection_AnnotationModuleId",
                table: "AnnotationSection",
                column: "AnnotationModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArmGroup_ArmGroupInterventionListId",
                table: "ArmGroup",
                column: "ArmGroupInterventionListId");

            migrationBuilder.CreateIndex(
                name: "IX_ArmGroup_ArmGroupListId",
                table: "ArmGroup",
                column: "ArmGroupListId");

            migrationBuilder.CreateIndex(
                name: "IX_ArmsInterventionsModule_ArmGroupListId",
                table: "ArmsInterventionsModule",
                column: "ArmGroupListId");

            migrationBuilder.CreateIndex(
                name: "IX_ArmsInterventionsModule_InterventionListId",
                table: "ArmsInterventionsModule",
                column: "InterventionListId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailIPD_AvailIPDListId",
                table: "AvailIPD",
                column: "AvailIPDListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineCategory_BaselineCategoryListId",
                table: "BaselineCategory",
                column: "BaselineCategoryListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineCategory_BaselineMeasurementListId",
                table: "BaselineCategory",
                column: "BaselineMeasurementListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineCharacteristicsModule_BaselineDenomListId",
                table: "BaselineCharacteristicsModule",
                column: "BaselineDenomListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineCharacteristicsModule_BaselineGroupListId",
                table: "BaselineCharacteristicsModule",
                column: "BaselineGroupListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineCharacteristicsModule_BaselineMeasureListId",
                table: "BaselineCharacteristicsModule",
                column: "BaselineMeasureListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineClass_BaselineCategoryListId",
                table: "BaselineClass",
                column: "BaselineCategoryListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineClass_BaselineClassDenomListId",
                table: "BaselineClass",
                column: "BaselineClassDenomListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineClass_BaselineClassListId",
                table: "BaselineClass",
                column: "BaselineClassListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineClassDenom_BaselineClassDenomCountListId",
                table: "BaselineClassDenom",
                column: "BaselineClassDenomCountListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineClassDenom_BaselineClassDenomListId",
                table: "BaselineClassDenom",
                column: "BaselineClassDenomListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineClassDenomCount_BaselineClassDenomCountListId",
                table: "BaselineClassDenomCount",
                column: "BaselineClassDenomCountListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineDenom_BaselineDenomCountListId",
                table: "BaselineDenom",
                column: "BaselineDenomCountListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineDenom_BaselineDenomListId",
                table: "BaselineDenom",
                column: "BaselineDenomListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineDenomCount_BaselineDenomCountListId",
                table: "BaselineDenomCount",
                column: "BaselineDenomCountListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineGroup_BaselineGroupListId",
                table: "BaselineGroup",
                column: "BaselineGroupListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineMeasure_BaselineClassListId",
                table: "BaselineMeasure",
                column: "BaselineClassListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineMeasure_BaselineMeasureDenomListId",
                table: "BaselineMeasure",
                column: "BaselineMeasureDenomListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineMeasure_BaselineMeasureListId",
                table: "BaselineMeasure",
                column: "BaselineMeasureListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineMeasureDenom_BaselineMeasureDenomCountListId",
                table: "BaselineMeasureDenom",
                column: "BaselineMeasureDenomCountListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineMeasureDenom_BaselineMeasureDenomListId",
                table: "BaselineMeasureDenom",
                column: "BaselineMeasureDenomListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineMeasureDenomCount_BaselineMeasureDenomCountListId",
                table: "BaselineMeasureDenomCount",
                column: "BaselineMeasureDenomCountListId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineMeasurement_BaselineMeasurementListId",
                table: "BaselineMeasurement",
                column: "BaselineMeasurementListId");

            migrationBuilder.CreateIndex(
                name: "IX_CentralContact_CentralContactListId",
                table: "CentralContact",
                column: "CentralContactListId");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborator_CollaboratorListId",
                table: "Collaborator",
                column: "CollaboratorListId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionAncestor_ConditionAncestorListId",
                table: "ConditionAncestor",
                column: "ConditionAncestorListId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionBrowseBranch_ConditionBrowseBranchListId",
                table: "ConditionBrowseBranch",
                column: "ConditionBrowseBranchListId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionBrowseLeaf_ConditionBrowseLeafListId",
                table: "ConditionBrowseLeaf",
                column: "ConditionBrowseLeafListId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionBrowseModule_ConditionAncestorListId",
                table: "ConditionBrowseModule",
                column: "ConditionAncestorListId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionBrowseModule_ConditionBrowseBranchListId",
                table: "ConditionBrowseModule",
                column: "ConditionBrowseBranchListId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionBrowseModule_ConditionBrowseLeafListId",
                table: "ConditionBrowseModule",
                column: "ConditionBrowseLeafListId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionBrowseModule_ConditionMeshListId",
                table: "ConditionBrowseModule",
                column: "ConditionMeshListId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionMesh_ConditionMeshListId",
                table: "ConditionMesh",
                column: "ConditionMeshListId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionsModule_ConditionListId",
                table: "ConditionsModule",
                column: "ConditionListId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionsModule_KeywordListId",
                table: "ConditionsModule",
                column: "KeywordListId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactsLocationsModule_CentralContactListId",
                table: "ContactsLocationsModule",
                column: "CentralContactListId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactsLocationsModule_LocationListId",
                table: "ContactsLocationsModule",
                column: "LocationListId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactsLocationsModule_OverallOfficialListId",
                table: "ContactsLocationsModule",
                column: "OverallOfficialListId");

            migrationBuilder.CreateIndex(
                name: "IX_DerivedSection_ConditionBrowseModuleId",
                table: "DerivedSection",
                column: "ConditionBrowseModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_DerivedSection_InterventionBrowseModuleId",
                table: "DerivedSection",
                column: "InterventionBrowseModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_DerivedSection_MiscInfoModuleId",
                table: "DerivedSection",
                column: "MiscInfoModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignInfo_DesignMaskingInfoId",
                table: "DesignInfo",
                column: "DesignMaskingInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignInfo_DesignObservationalModelListId",
                table: "DesignInfo",
                column: "DesignObservationalModelListId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignInfo_DesignTimePerspectiveListId",
                table: "DesignInfo",
                column: "DesignTimePerspectiveListId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignMaskingInfo_DesignWhoMaskedListId",
                table: "DesignMaskingInfo",
                column: "DesignWhoMaskedListId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignModule_BioSpecId",
                table: "DesignModule",
                column: "BioSpecId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignModule_DesignInfoId",
                table: "DesignModule",
                column: "DesignInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignModule_EnrollmentInfoId",
                table: "DesignModule",
                column: "EnrollmentInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignModule_ExpandedAccessTypesId",
                table: "DesignModule",
                column: "ExpandedAccessTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignModule_PhaseListId",
                table: "DesignModule",
                column: "PhaseListId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentSection_LargeDocumentModuleId",
                table: "DocumentSection",
                column: "LargeDocumentModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_EligibilityModule_StdAgeListId",
                table: "EligibilityModule",
                column: "StdAgeListId");

            migrationBuilder.CreateIndex(
                name: "IX_EventGroup_EventGroupListId",
                table: "EventGroup",
                column: "EventGroupListId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowAchievement_FlowAchievementListId",
                table: "FlowAchievement",
                column: "FlowAchievementListId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowDropWithdraw_FlowDropWithdrawListId",
                table: "FlowDropWithdraw",
                column: "FlowDropWithdrawListId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowDropWithdraw_FlowReasonListId",
                table: "FlowDropWithdraw",
                column: "FlowReasonListId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowGroup_FlowGroupListId",
                table: "FlowGroup",
                column: "FlowGroupListId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowMilestone_FlowAchievementListId",
                table: "FlowMilestone",
                column: "FlowAchievementListId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowMilestone_FlowMilestoneListId",
                table: "FlowMilestone",
                column: "FlowMilestoneListId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowPeriod_FlowDropWithdrawListId",
                table: "FlowPeriod",
                column: "FlowDropWithdrawListId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowPeriod_FlowMilestoneListId",
                table: "FlowPeriod",
                column: "FlowMilestoneListId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowPeriod_FlowPeriodListId",
                table: "FlowPeriod",
                column: "FlowPeriodListId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowReason_FlowReasonListId",
                table: "FlowReason",
                column: "FlowReasonListId");

            migrationBuilder.CreateIndex(
                name: "IX_FullStudy_StudyId",
                table: "FullStudy",
                column: "StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentificationModule_NCTIdAliasListId",
                table: "IdentificationModule",
                column: "NCTIdAliasListId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentificationModule_OrgStudyIdInfoId",
                table: "IdentificationModule",
                column: "OrgStudyIdInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentificationModule_OrganizationId",
                table: "IdentificationModule",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentificationModule_SecondaryIdInfoListId",
                table: "IdentificationModule",
                column: "SecondaryIdInfoListId");

            migrationBuilder.CreateIndex(
                name: "IX_Intervention_InterventionListId",
                table: "Intervention",
                column: "InterventionListId");

            migrationBuilder.CreateIndex(
                name: "IX_InterventionAncestor_InterventionAncestorListId",
                table: "InterventionAncestor",
                column: "InterventionAncestorListId");

            migrationBuilder.CreateIndex(
                name: "IX_InterventionBrowseBranch_InterventionBrowseBranchListId",
                table: "InterventionBrowseBranch",
                column: "InterventionBrowseBranchListId");

            migrationBuilder.CreateIndex(
                name: "IX_InterventionBrowseLeaf_InterventionBrowseLeafListId",
                table: "InterventionBrowseLeaf",
                column: "InterventionBrowseLeafListId");

            migrationBuilder.CreateIndex(
                name: "IX_InterventionBrowseModule_InterventionAncestorListId",
                table: "InterventionBrowseModule",
                column: "InterventionAncestorListId");

            migrationBuilder.CreateIndex(
                name: "IX_InterventionBrowseModule_InterventionBrowseBranchListId",
                table: "InterventionBrowseModule",
                column: "InterventionBrowseBranchListId");

            migrationBuilder.CreateIndex(
                name: "IX_InterventionBrowseModule_InterventionBrowseLeafListId",
                table: "InterventionBrowseModule",
                column: "InterventionBrowseLeafListId");

            migrationBuilder.CreateIndex(
                name: "IX_InterventionBrowseModule_InterventionMeshListId",
                table: "InterventionBrowseModule",
                column: "InterventionMeshListId");

            migrationBuilder.CreateIndex(
                name: "IX_InterventionMesh_InterventionMeshListId",
                table: "InterventionMesh",
                column: "InterventionMeshListId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDSharingStatementModule_IPDSharingInfoTypeListId",
                table: "IPDSharingStatementModule",
                column: "IPDSharingInfoTypeListId");

            migrationBuilder.CreateIndex(
                name: "IX_LargeDoc_LargeDocListId",
                table: "LargeDoc",
                column: "LargeDocListId");

            migrationBuilder.CreateIndex(
                name: "IX_LargeDocumentModule_LargeDocListId",
                table: "LargeDocumentModule",
                column: "LargeDocListId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_LocationContactListId",
                table: "Location",
                column: "LocationContactListId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_LocationListId",
                table: "Location",
                column: "LocationListId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationContact_LocationContactListId",
                table: "LocationContact",
                column: "LocationContactListId");

            migrationBuilder.CreateIndex(
                name: "IX_MiscInfoModule_RemovedCountryListId",
                table: "MiscInfoModule",
                column: "RemovedCountryListId");

            migrationBuilder.CreateIndex(
                name: "IX_MoreInfoModule_CertainAgreementId",
                table: "MoreInfoModule",
                column: "CertainAgreementId");

            migrationBuilder.CreateIndex(
                name: "IX_MoreInfoModule_LimitationsAndCaveatsId",
                table: "MoreInfoModule",
                column: "LimitationsAndCaveatsId");

            migrationBuilder.CreateIndex(
                name: "IX_MoreInfoModule_PointOfContactId",
                table: "MoreInfoModule",
                column: "PointOfContactId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherEvent_OtherEventListId",
                table: "OtherEvent",
                column: "OtherEventListId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherEvent_OtherEventStatsListId",
                table: "OtherEvent",
                column: "OtherEventStatsListId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherEventStats_OtherEventStatsListId",
                table: "OtherEventStats",
                column: "OtherEventStatsListId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherOutcome_OtherOutcomeListId",
                table: "OtherOutcome",
                column: "OtherOutcomeListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeAnalysis_OutcomeAnalysisGroupIdListId",
                table: "OutcomeAnalysis",
                column: "OutcomeAnalysisGroupIdListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeAnalysis_OutcomeAnalysisListId",
                table: "OutcomeAnalysis",
                column: "OutcomeAnalysisListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeCategory_OutcomeCategoryListId",
                table: "OutcomeCategory",
                column: "OutcomeCategoryListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeCategory_OutcomeMeasurementListId",
                table: "OutcomeCategory",
                column: "OutcomeMeasurementListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeClass_OutcomeCategoryListId",
                table: "OutcomeClass",
                column: "OutcomeCategoryListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeClass_OutcomeClassDenomListId",
                table: "OutcomeClass",
                column: "OutcomeClassDenomListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeClass_OutcomeClassListId",
                table: "OutcomeClass",
                column: "OutcomeClassListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeClassDenom_OutcomeClassDenomCountListId",
                table: "OutcomeClassDenom",
                column: "OutcomeClassDenomCountListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeClassDenom_OutcomeClassDenomListId",
                table: "OutcomeClassDenom",
                column: "OutcomeClassDenomListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeClassDenomCount_OutcomeClassDenomCountListId",
                table: "OutcomeClassDenomCount",
                column: "OutcomeClassDenomCountListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeDenom_OutcomeDenomCountListId",
                table: "OutcomeDenom",
                column: "OutcomeDenomCountListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeDenom_OutcomeDenomListId",
                table: "OutcomeDenom",
                column: "OutcomeDenomListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeDenomCount_OutcomeDenomCountListId",
                table: "OutcomeDenomCount",
                column: "OutcomeDenomCountListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeGroup_OutcomeGroupListId",
                table: "OutcomeGroup",
                column: "OutcomeGroupListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeMeasure_OutcomeAnalysisListId",
                table: "OutcomeMeasure",
                column: "OutcomeAnalysisListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeMeasure_OutcomeClassListId",
                table: "OutcomeMeasure",
                column: "OutcomeClassListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeMeasure_OutcomeDenomListId",
                table: "OutcomeMeasure",
                column: "OutcomeDenomListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeMeasure_OutcomeGroupListId",
                table: "OutcomeMeasure",
                column: "OutcomeGroupListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeMeasure_OutcomeMeasureListId",
                table: "OutcomeMeasure",
                column: "OutcomeMeasureListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeMeasurement_OutcomeMeasurementListId",
                table: "OutcomeMeasurement",
                column: "OutcomeMeasurementListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeMeasuresModule_OutcomeMeasureListId",
                table: "OutcomeMeasuresModule",
                column: "OutcomeMeasureListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomesModule_OtherOutcomeListId",
                table: "OutcomesModule",
                column: "OtherOutcomeListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomesModule_PrimaryOutcomeListId",
                table: "OutcomesModule",
                column: "PrimaryOutcomeListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomesModule_SecondaryOutcomeListId",
                table: "OutcomesModule",
                column: "SecondaryOutcomeListId");

            migrationBuilder.CreateIndex(
                name: "IX_OverallOfficial_OverallOfficialListId",
                table: "OverallOfficial",
                column: "OverallOfficialListId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantFlowModule_FlowGroupListId",
                table: "ParticipantFlowModule",
                column: "FlowGroupListId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantFlowModule_FlowPeriodListId",
                table: "ParticipantFlowModule",
                column: "FlowPeriodListId");

            migrationBuilder.CreateIndex(
                name: "IX_PrimaryOutcome_PrimaryOutcomeListId",
                table: "PrimaryOutcome",
                column: "PrimaryOutcomeListId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSection_ArmsInterventionsModuleId",
                table: "ProtocolSection",
                column: "ArmsInterventionsModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSection_ConditionsModuleId",
                table: "ProtocolSection",
                column: "ConditionsModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSection_ContactsLocationsModuleId",
                table: "ProtocolSection",
                column: "ContactsLocationsModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSection_DescriptionModuleId",
                table: "ProtocolSection",
                column: "DescriptionModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSection_DesignModuleId",
                table: "ProtocolSection",
                column: "DesignModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSection_EligibilityModuleId",
                table: "ProtocolSection",
                column: "EligibilityModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSection_IPDSharingStatementModuleId",
                table: "ProtocolSection",
                column: "IPDSharingStatementModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSection_IdentificationModuleId",
                table: "ProtocolSection",
                column: "IdentificationModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSection_OutcomesModuleId",
                table: "ProtocolSection",
                column: "OutcomesModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSection_OversightModuleId",
                table: "ProtocolSection",
                column: "OversightModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSection_ReferencesModuleId",
                table: "ProtocolSection",
                column: "ReferencesModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSection_SponsorCollaboratorsModuleId",
                table: "ProtocolSection",
                column: "SponsorCollaboratorsModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSection_StatusModuleId",
                table: "ProtocolSection",
                column: "StatusModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Reference_ReferenceListId",
                table: "Reference",
                column: "ReferenceListId");

            migrationBuilder.CreateIndex(
                name: "IX_Reference_RetractionListId",
                table: "Reference",
                column: "RetractionListId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferencesModule_AvailIPDListId",
                table: "ReferencesModule",
                column: "AvailIPDListId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferencesModule_ReferenceListId",
                table: "ReferencesModule",
                column: "ReferenceListId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferencesModule_SeeAlsoLinkListId",
                table: "ReferencesModule",
                column: "SeeAlsoLinkListId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultsSection_AdverseEventsModuleId",
                table: "ResultsSection",
                column: "AdverseEventsModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultsSection_BaselineCharacteristicsModuleId",
                table: "ResultsSection",
                column: "BaselineCharacteristicsModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultsSection_MoreInfoModuleId",
                table: "ResultsSection",
                column: "MoreInfoModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultsSection_OutcomeMeasuresModuleId",
                table: "ResultsSection",
                column: "OutcomeMeasuresModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultsSection_ParticipantFlowModuleId",
                table: "ResultsSection",
                column: "ParticipantFlowModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Retraction_RetractionListId",
                table: "Retraction",
                column: "RetractionListId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondaryIdInfo_SecondaryIdInfoListId",
                table: "SecondaryIdInfo",
                column: "SecondaryIdInfoListId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondaryOutcome_SecondaryOutcomeListId",
                table: "SecondaryOutcome",
                column: "SecondaryOutcomeListId");

            migrationBuilder.CreateIndex(
                name: "IX_SeeAlsoLink_SeeAlsoLinkListId",
                table: "SeeAlsoLink",
                column: "SeeAlsoLinkListId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriousEvent_SeriousEventListId",
                table: "SeriousEvent",
                column: "SeriousEventListId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriousEvent_SeriousEventStatsListId",
                table: "SeriousEvent",
                column: "SeriousEventStatsListId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriousEventStats_SeriousEventStatsListId",
                table: "SeriousEventStats",
                column: "SeriousEventStatsListId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorCollaboratorsModule_CollaboratorListId",
                table: "SponsorCollaboratorsModule",
                column: "CollaboratorListId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorCollaboratorsModule_LeadSponsorId",
                table: "SponsorCollaboratorsModule",
                column: "LeadSponsorId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorCollaboratorsModule_ResponsiblePartyId",
                table: "SponsorCollaboratorsModule",
                column: "ResponsiblePartyId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusModule_CompletionDateStructId",
                table: "StatusModule",
                column: "CompletionDateStructId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusModule_DispFirstPostDateStructId",
                table: "StatusModule",
                column: "DispFirstPostDateStructId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusModule_ExpandedAccessInfoId",
                table: "StatusModule",
                column: "ExpandedAccessInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusModule_LastUpdatePostDateStructId",
                table: "StatusModule",
                column: "LastUpdatePostDateStructId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusModule_PrimaryCompletionDateStructId",
                table: "StatusModule",
                column: "PrimaryCompletionDateStructId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusModule_ResultsFirstPostDateStructId",
                table: "StatusModule",
                column: "ResultsFirstPostDateStructId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusModule_StartDateStructId",
                table: "StatusModule",
                column: "StartDateStructId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusModule_StudyFirstPostDateStructId",
                table: "StatusModule",
                column: "StudyFirstPostDateStructId");

            migrationBuilder.CreateIndex(
                name: "IX_Studies_FullStudyId",
                table: "Studies",
                column: "FullStudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Study_AnnotationSectionId",
                table: "Study",
                column: "AnnotationSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Study_DerivedSectionId",
                table: "Study",
                column: "DerivedSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Study_DocumentSectionId",
                table: "Study",
                column: "DocumentSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Study_ProtocolSectionId",
                table: "Study",
                column: "ProtocolSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Study_ResultsSectionId",
                table: "Study",
                column: "ResultsSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_UnpostedAnnotation_UnpostedEventListId",
                table: "UnpostedAnnotation",
                column: "UnpostedEventListId");

            migrationBuilder.CreateIndex(
                name: "IX_UnpostedEvent_UnpostedEventListId",
                table: "UnpostedEvent",
                column: "UnpostedEventListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArmGroup");

            migrationBuilder.DropTable(
                name: "AvailIPD");

            migrationBuilder.DropTable(
                name: "BaselineCategory");

            migrationBuilder.DropTable(
                name: "BaselineClass");

            migrationBuilder.DropTable(
                name: "BaselineClassDenom");

            migrationBuilder.DropTable(
                name: "BaselineClassDenomCount");

            migrationBuilder.DropTable(
                name: "BaselineDenom");

            migrationBuilder.DropTable(
                name: "BaselineDenomCount");

            migrationBuilder.DropTable(
                name: "BaselineGroup");

            migrationBuilder.DropTable(
                name: "BaselineMeasure");

            migrationBuilder.DropTable(
                name: "BaselineMeasureDenom");

            migrationBuilder.DropTable(
                name: "BaselineMeasureDenomCount");

            migrationBuilder.DropTable(
                name: "BaselineMeasurement");

            migrationBuilder.DropTable(
                name: "CentralContact");

            migrationBuilder.DropTable(
                name: "CityCoordinates");

            migrationBuilder.DropTable(
                name: "Collaborator");

            migrationBuilder.DropTable(
                name: "ConditionAncestor");

            migrationBuilder.DropTable(
                name: "ConditionBrowseBranch");

            migrationBuilder.DropTable(
                name: "ConditionBrowseLeaf");

            migrationBuilder.DropTable(
                name: "ConditionMesh");

            migrationBuilder.DropTable(
                name: "EventGroup");

            migrationBuilder.DropTable(
                name: "FlowAchievement");

            migrationBuilder.DropTable(
                name: "FlowDropWithdraw");

            migrationBuilder.DropTable(
                name: "FlowGroup");

            migrationBuilder.DropTable(
                name: "FlowMilestone");

            migrationBuilder.DropTable(
                name: "FlowPeriod");

            migrationBuilder.DropTable(
                name: "FlowReason");

            migrationBuilder.DropTable(
                name: "Intervention");

            migrationBuilder.DropTable(
                name: "InterventionAncestor");

            migrationBuilder.DropTable(
                name: "InterventionBrowseBranch");

            migrationBuilder.DropTable(
                name: "InterventionBrowseLeaf");

            migrationBuilder.DropTable(
                name: "InterventionMesh");

            migrationBuilder.DropTable(
                name: "LargeDoc");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "LocationContact");

            migrationBuilder.DropTable(
                name: "OtherEvent");

            migrationBuilder.DropTable(
                name: "OtherEventStats");

            migrationBuilder.DropTable(
                name: "OtherOutcome");

            migrationBuilder.DropTable(
                name: "OutcomeAnalysis");

            migrationBuilder.DropTable(
                name: "OutcomeCategory");

            migrationBuilder.DropTable(
                name: "OutcomeClass");

            migrationBuilder.DropTable(
                name: "OutcomeClassDenom");

            migrationBuilder.DropTable(
                name: "OutcomeClassDenomCount");

            migrationBuilder.DropTable(
                name: "OutcomeDenom");

            migrationBuilder.DropTable(
                name: "OutcomeDenomCount");

            migrationBuilder.DropTable(
                name: "OutcomeGroup");

            migrationBuilder.DropTable(
                name: "OutcomeMeasure");

            migrationBuilder.DropTable(
                name: "OutcomeMeasurement");

            migrationBuilder.DropTable(
                name: "OverallOfficial");

            migrationBuilder.DropTable(
                name: "PrimaryOutcome");

            migrationBuilder.DropTable(
                name: "Reference");

            migrationBuilder.DropTable(
                name: "Retraction");

            migrationBuilder.DropTable(
                name: "SecondaryIdInfo");

            migrationBuilder.DropTable(
                name: "SecondaryOutcome");

            migrationBuilder.DropTable(
                name: "SeeAlsoLink");

            migrationBuilder.DropTable(
                name: "SeriousEvent");

            migrationBuilder.DropTable(
                name: "SeriousEventStats");

            migrationBuilder.DropTable(
                name: "StatisticsSearches");

            migrationBuilder.DropTable(
                name: "Studies");

            migrationBuilder.DropTable(
                name: "TagLists");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "UnpostedEvent");

            migrationBuilder.DropTable(
                name: "ArmGroupInterventionList");

            migrationBuilder.DropTable(
                name: "BaselineCategoryList");

            migrationBuilder.DropTable(
                name: "BaselineClassDenomList");

            migrationBuilder.DropTable(
                name: "BaselineClassDenomCountList");

            migrationBuilder.DropTable(
                name: "BaselineDenomCountList");

            migrationBuilder.DropTable(
                name: "BaselineClassList");

            migrationBuilder.DropTable(
                name: "BaselineMeasureDenomList");

            migrationBuilder.DropTable(
                name: "BaselineMeasureDenomCountList");

            migrationBuilder.DropTable(
                name: "BaselineMeasurementList");

            migrationBuilder.DropTable(
                name: "FlowAchievementList");

            migrationBuilder.DropTable(
                name: "FlowDropWithdrawList");

            migrationBuilder.DropTable(
                name: "FlowMilestoneList");

            migrationBuilder.DropTable(
                name: "FlowReasonList");

            migrationBuilder.DropTable(
                name: "LocationContactList");

            migrationBuilder.DropTable(
                name: "OtherEventStatsList");

            migrationBuilder.DropTable(
                name: "OutcomeAnalysisGroupIdList");

            migrationBuilder.DropTable(
                name: "OutcomeCategoryList");

            migrationBuilder.DropTable(
                name: "OutcomeClassDenomList");

            migrationBuilder.DropTable(
                name: "OutcomeClassDenomCountList");

            migrationBuilder.DropTable(
                name: "OutcomeDenomCountList");

            migrationBuilder.DropTable(
                name: "OutcomeAnalysisList");

            migrationBuilder.DropTable(
                name: "OutcomeClassList");

            migrationBuilder.DropTable(
                name: "OutcomeDenomList");

            migrationBuilder.DropTable(
                name: "OutcomeGroupList");

            migrationBuilder.DropTable(
                name: "OutcomeMeasurementList");

            migrationBuilder.DropTable(
                name: "RetractionList");

            migrationBuilder.DropTable(
                name: "SeriousEventStatsList");

            migrationBuilder.DropTable(
                name: "FullStudy");

            migrationBuilder.DropTable(
                name: "Study");

            migrationBuilder.DropTable(
                name: "AnnotationSection");

            migrationBuilder.DropTable(
                name: "DerivedSection");

            migrationBuilder.DropTable(
                name: "DocumentSection");

            migrationBuilder.DropTable(
                name: "ProtocolSection");

            migrationBuilder.DropTable(
                name: "ResultsSection");

            migrationBuilder.DropTable(
                name: "AnnotationModule");

            migrationBuilder.DropTable(
                name: "ConditionBrowseModule");

            migrationBuilder.DropTable(
                name: "InterventionBrowseModule");

            migrationBuilder.DropTable(
                name: "MiscInfoModule");

            migrationBuilder.DropTable(
                name: "LargeDocumentModule");

            migrationBuilder.DropTable(
                name: "ArmsInterventionsModule");

            migrationBuilder.DropTable(
                name: "ConditionsModule");

            migrationBuilder.DropTable(
                name: "ContactsLocationsModule");

            migrationBuilder.DropTable(
                name: "DescriptionModule");

            migrationBuilder.DropTable(
                name: "DesignModule");

            migrationBuilder.DropTable(
                name: "EligibilityModule");

            migrationBuilder.DropTable(
                name: "IPDSharingStatementModule");

            migrationBuilder.DropTable(
                name: "IdentificationModule");

            migrationBuilder.DropTable(
                name: "OutcomesModule");

            migrationBuilder.DropTable(
                name: "OversightModule");

            migrationBuilder.DropTable(
                name: "ReferencesModule");

            migrationBuilder.DropTable(
                name: "SponsorCollaboratorsModule");

            migrationBuilder.DropTable(
                name: "StatusModule");

            migrationBuilder.DropTable(
                name: "AdverseEventsModule");

            migrationBuilder.DropTable(
                name: "BaselineCharacteristicsModule");

            migrationBuilder.DropTable(
                name: "MoreInfoModule");

            migrationBuilder.DropTable(
                name: "OutcomeMeasuresModule");

            migrationBuilder.DropTable(
                name: "ParticipantFlowModule");

            migrationBuilder.DropTable(
                name: "UnpostedAnnotation");

            migrationBuilder.DropTable(
                name: "ConditionAncestorList");

            migrationBuilder.DropTable(
                name: "ConditionBrowseBranchList");

            migrationBuilder.DropTable(
                name: "ConditionBrowseLeafList");

            migrationBuilder.DropTable(
                name: "ConditionMeshList");

            migrationBuilder.DropTable(
                name: "InterventionAncestorList");

            migrationBuilder.DropTable(
                name: "InterventionBrowseBranchList");

            migrationBuilder.DropTable(
                name: "InterventionBrowseLeafList");

            migrationBuilder.DropTable(
                name: "InterventionMeshList");

            migrationBuilder.DropTable(
                name: "RemovedCountryList");

            migrationBuilder.DropTable(
                name: "LargeDocList");

            migrationBuilder.DropTable(
                name: "ArmGroupList");

            migrationBuilder.DropTable(
                name: "InterventionList");

            migrationBuilder.DropTable(
                name: "ConditionList");

            migrationBuilder.DropTable(
                name: "KeywordList");

            migrationBuilder.DropTable(
                name: "CentralContactList");

            migrationBuilder.DropTable(
                name: "LocationList");

            migrationBuilder.DropTable(
                name: "OverallOfficialList");

            migrationBuilder.DropTable(
                name: "BioSpec");

            migrationBuilder.DropTable(
                name: "DesignInfo");

            migrationBuilder.DropTable(
                name: "EnrollmentInfo");

            migrationBuilder.DropTable(
                name: "ExpandedAccessTypes");

            migrationBuilder.DropTable(
                name: "PhaseList");

            migrationBuilder.DropTable(
                name: "StdAgeList");

            migrationBuilder.DropTable(
                name: "IPDSharingInfoTypeList");

            migrationBuilder.DropTable(
                name: "NCTIdAliasList");

            migrationBuilder.DropTable(
                name: "OrgStudyIdInfo");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "SecondaryIdInfoList");

            migrationBuilder.DropTable(
                name: "OtherOutcomeList");

            migrationBuilder.DropTable(
                name: "PrimaryOutcomeList");

            migrationBuilder.DropTable(
                name: "SecondaryOutcomeList");

            migrationBuilder.DropTable(
                name: "AvailIPDList");

            migrationBuilder.DropTable(
                name: "ReferenceList");

            migrationBuilder.DropTable(
                name: "SeeAlsoLinkList");

            migrationBuilder.DropTable(
                name: "CollaboratorList");

            migrationBuilder.DropTable(
                name: "LeadSponsor");

            migrationBuilder.DropTable(
                name: "ResponsibleParty");

            migrationBuilder.DropTable(
                name: "CompletionDateStruct");

            migrationBuilder.DropTable(
                name: "DispFirstPostDateStruct");

            migrationBuilder.DropTable(
                name: "ExpandedAccessInfo");

            migrationBuilder.DropTable(
                name: "LastUpdatePostDateStruct");

            migrationBuilder.DropTable(
                name: "PrimaryCompletionDateStruct");

            migrationBuilder.DropTable(
                name: "ResultsFirstPostDateStruct");

            migrationBuilder.DropTable(
                name: "StartDateStruct");

            migrationBuilder.DropTable(
                name: "StudyFirstPostDateStruct");

            migrationBuilder.DropTable(
                name: "EventGroupList");

            migrationBuilder.DropTable(
                name: "OtherEventList");

            migrationBuilder.DropTable(
                name: "SeriousEventList");

            migrationBuilder.DropTable(
                name: "BaselineDenomList");

            migrationBuilder.DropTable(
                name: "BaselineGroupList");

            migrationBuilder.DropTable(
                name: "BaselineMeasureList");

            migrationBuilder.DropTable(
                name: "CertainAgreement");

            migrationBuilder.DropTable(
                name: "LimitationsAndCaveats");

            migrationBuilder.DropTable(
                name: "PointOfContact");

            migrationBuilder.DropTable(
                name: "OutcomeMeasureList");

            migrationBuilder.DropTable(
                name: "FlowGroupList");

            migrationBuilder.DropTable(
                name: "FlowPeriodList");

            migrationBuilder.DropTable(
                name: "UnpostedEventList");

            migrationBuilder.DropTable(
                name: "DesignMaskingInfo");

            migrationBuilder.DropTable(
                name: "DesignObservationalModelList");

            migrationBuilder.DropTable(
                name: "DesignTimePerspectiveList");

            migrationBuilder.DropTable(
                name: "DesignWhoMaskedList");
        }
    }
}
