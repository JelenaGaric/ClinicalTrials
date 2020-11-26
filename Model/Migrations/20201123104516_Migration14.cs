using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class Migration14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnnotationSectionId",
                table: "Study",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocumentSectionId",
                table: "Study",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResultsSectionId",
                table: "Study",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompletionDateStructId",
                table: "StatusModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DelayedPosting",
                table: "StatusModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DispFirstPostDateStructId",
                table: "StatusModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DispFirstSubmitDate",
                table: "StatusModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DispFirstSubmitQCDate",
                table: "StatusModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastKnownStatus",
                table: "StatusModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryCompletionDateStructId",
                table: "StatusModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResultsFirstPostDateStructId",
                table: "StatusModule",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResultsFirstSubmitDate",
                table: "StatusModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResultsFirstSubmitQCDate",
                table: "StatusModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StartDateStructId",
                table: "StatusModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhyStopped",
                table: "StatusModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CollaboratorListId",
                table: "SponsorCollaboratorsModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResponsiblePartyId",
                table: "SponsorCollaboratorsModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IPDSharingStatementModuleId",
                table: "ProtocolSection",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OutcomesModuleId",
                table: "ProtocolSection",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OversightModuleId",
                table: "ProtocolSection",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReferencesModuleId",
                table: "ProtocolSection",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RemovedCountryListId",
                table: "MiscInfoModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationContactListId",
                table: "Location",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationStatus",
                table: "Location",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationZip",
                table: "Location",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Acronym",
                table: "IdentificationModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NCTIdAliasListId",
                table: "IdentificationModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficialTitle",
                table: "IdentificationModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpandedAccessNCTId",
                table: "ExpandedAccessInfo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpandedAccessStatusForNCTId",
                table: "ExpandedAccessInfo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GenderBased",
                table: "EligibilityModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GenderDescription",
                table: "EligibilityModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SamplingMethod",
                table: "EligibilityModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudyPopulation",
                table: "EligibilityModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BioSpecId",
                table: "DesignModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnrollmentInfoId",
                table: "DesignModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExpandedAccessTypesId",
                table: "DesignModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientRegistry",
                table: "DesignModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TargetDuration",
                table: "DesignModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DesignMaskingDescription",
                table: "DesignMaskingInfo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DesignWhoMaskedListId",
                table: "DesignMaskingInfo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DesignAllocation",
                table: "DesignInfo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DesignInterventionModelDescription",
                table: "DesignInfo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DesignObservationalModelListId",
                table: "DesignInfo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DesignTimePerspectiveListId",
                table: "DesignInfo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CentralContactListId",
                table: "ContactsLocationsModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OverallOfficialListId",
                table: "ContactsLocationsModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KeywordListId",
                table: "ConditionsModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArmGroupListId",
                table: "ArmsInterventionsModule",
                nullable: true);

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
                name: "IPDSharingInfoTypeList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
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

            migrationBuilder.CreateIndex(
                name: "IX_Study_AnnotationSectionId",
                table: "Study",
                column: "AnnotationSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Study_DocumentSectionId",
                table: "Study",
                column: "DocumentSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Study_ResultsSectionId",
                table: "Study",
                column: "ResultsSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusModule_CompletionDateStructId",
                table: "StatusModule",
                column: "CompletionDateStructId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusModule_DispFirstPostDateStructId",
                table: "StatusModule",
                column: "DispFirstPostDateStructId");

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
                name: "IX_SponsorCollaboratorsModule_CollaboratorListId",
                table: "SponsorCollaboratorsModule",
                column: "CollaboratorListId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorCollaboratorsModule_ResponsiblePartyId",
                table: "SponsorCollaboratorsModule",
                column: "ResponsiblePartyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSection_IPDSharingStatementModuleId",
                table: "ProtocolSection",
                column: "IPDSharingStatementModuleId");

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
                name: "IX_MiscInfoModule_RemovedCountryListId",
                table: "MiscInfoModule",
                column: "RemovedCountryListId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_LocationContactListId",
                table: "Location",
                column: "LocationContactListId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentificationModule_NCTIdAliasListId",
                table: "IdentificationModule",
                column: "NCTIdAliasListId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignModule_BioSpecId",
                table: "DesignModule",
                column: "BioSpecId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignModule_EnrollmentInfoId",
                table: "DesignModule",
                column: "EnrollmentInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignModule_ExpandedAccessTypesId",
                table: "DesignModule",
                column: "ExpandedAccessTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignMaskingInfo_DesignWhoMaskedListId",
                table: "DesignMaskingInfo",
                column: "DesignWhoMaskedListId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignInfo_DesignObservationalModelListId",
                table: "DesignInfo",
                column: "DesignObservationalModelListId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignInfo_DesignTimePerspectiveListId",
                table: "DesignInfo",
                column: "DesignTimePerspectiveListId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactsLocationsModule_CentralContactListId",
                table: "ContactsLocationsModule",
                column: "CentralContactListId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactsLocationsModule_OverallOfficialListId",
                table: "ContactsLocationsModule",
                column: "OverallOfficialListId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionsModule_KeywordListId",
                table: "ConditionsModule",
                column: "KeywordListId");

            migrationBuilder.CreateIndex(
                name: "IX_ArmsInterventionsModule_ArmGroupListId",
                table: "ArmsInterventionsModule",
                column: "ArmGroupListId");

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
                name: "IX_DocumentSection_LargeDocumentModuleId",
                table: "DocumentSection",
                column: "LargeDocumentModuleId");

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
                name: "IX_LocationContact_LocationContactListId",
                table: "LocationContact",
                column: "LocationContactListId");

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
                name: "IX_UnpostedAnnotation_UnpostedEventListId",
                table: "UnpostedAnnotation",
                column: "UnpostedEventListId");

            migrationBuilder.CreateIndex(
                name: "IX_UnpostedEvent_UnpostedEventListId",
                table: "UnpostedEvent",
                column: "UnpostedEventListId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArmsInterventionsModule_ArmGroupList_ArmGroupListId",
                table: "ArmsInterventionsModule",
                column: "ArmGroupListId",
                principalTable: "ArmGroupList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionsModule_KeywordList_KeywordListId",
                table: "ConditionsModule",
                column: "KeywordListId",
                principalTable: "KeywordList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactsLocationsModule_CentralContactList_CentralContactListId",
                table: "ContactsLocationsModule",
                column: "CentralContactListId",
                principalTable: "CentralContactList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactsLocationsModule_OverallOfficialList_OverallOfficialListId",
                table: "ContactsLocationsModule",
                column: "OverallOfficialListId",
                principalTable: "OverallOfficialList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DesignInfo_DesignObservationalModelList_DesignObservationalModelListId",
                table: "DesignInfo",
                column: "DesignObservationalModelListId",
                principalTable: "DesignObservationalModelList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DesignInfo_DesignTimePerspectiveList_DesignTimePerspectiveListId",
                table: "DesignInfo",
                column: "DesignTimePerspectiveListId",
                principalTable: "DesignTimePerspectiveList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DesignMaskingInfo_DesignWhoMaskedList_DesignWhoMaskedListId",
                table: "DesignMaskingInfo",
                column: "DesignWhoMaskedListId",
                principalTable: "DesignWhoMaskedList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DesignModule_BioSpec_BioSpecId",
                table: "DesignModule",
                column: "BioSpecId",
                principalTable: "BioSpec",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DesignModule_EnrollmentInfo_EnrollmentInfoId",
                table: "DesignModule",
                column: "EnrollmentInfoId",
                principalTable: "EnrollmentInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DesignModule_ExpandedAccessTypes_ExpandedAccessTypesId",
                table: "DesignModule",
                column: "ExpandedAccessTypesId",
                principalTable: "ExpandedAccessTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentificationModule_NCTIdAliasList_NCTIdAliasListId",
                table: "IdentificationModule",
                column: "NCTIdAliasListId",
                principalTable: "NCTIdAliasList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_LocationContactList_LocationContactListId",
                table: "Location",
                column: "LocationContactListId",
                principalTable: "LocationContactList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MiscInfoModule_RemovedCountryList_RemovedCountryListId",
                table: "MiscInfoModule",
                column: "RemovedCountryListId",
                principalTable: "RemovedCountryList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProtocolSection_IPDSharingStatementModule_IPDSharingStatementModuleId",
                table: "ProtocolSection",
                column: "IPDSharingStatementModuleId",
                principalTable: "IPDSharingStatementModule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProtocolSection_OutcomesModule_OutcomesModuleId",
                table: "ProtocolSection",
                column: "OutcomesModuleId",
                principalTable: "OutcomesModule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProtocolSection_OversightModule_OversightModuleId",
                table: "ProtocolSection",
                column: "OversightModuleId",
                principalTable: "OversightModule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProtocolSection_ReferencesModule_ReferencesModuleId",
                table: "ProtocolSection",
                column: "ReferencesModuleId",
                principalTable: "ReferencesModule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SponsorCollaboratorsModule_CollaboratorList_CollaboratorListId",
                table: "SponsorCollaboratorsModule",
                column: "CollaboratorListId",
                principalTable: "CollaboratorList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SponsorCollaboratorsModule_ResponsibleParty_ResponsiblePartyId",
                table: "SponsorCollaboratorsModule",
                column: "ResponsiblePartyId",
                principalTable: "ResponsibleParty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusModule_CompletionDateStruct_CompletionDateStructId",
                table: "StatusModule",
                column: "CompletionDateStructId",
                principalTable: "CompletionDateStruct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusModule_DispFirstPostDateStruct_DispFirstPostDateStructId",
                table: "StatusModule",
                column: "DispFirstPostDateStructId",
                principalTable: "DispFirstPostDateStruct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusModule_PrimaryCompletionDateStruct_PrimaryCompletionDateStructId",
                table: "StatusModule",
                column: "PrimaryCompletionDateStructId",
                principalTable: "PrimaryCompletionDateStruct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusModule_ResultsFirstPostDateStruct_ResultsFirstPostDateStructId",
                table: "StatusModule",
                column: "ResultsFirstPostDateStructId",
                principalTable: "ResultsFirstPostDateStruct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusModule_StartDateStruct_StartDateStructId",
                table: "StatusModule",
                column: "StartDateStructId",
                principalTable: "StartDateStruct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Study_AnnotationSection_AnnotationSectionId",
                table: "Study",
                column: "AnnotationSectionId",
                principalTable: "AnnotationSection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Study_DocumentSection_DocumentSectionId",
                table: "Study",
                column: "DocumentSectionId",
                principalTable: "DocumentSection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Study_ResultsSection_ResultsSectionId",
                table: "Study",
                column: "ResultsSectionId",
                principalTable: "ResultsSection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArmsInterventionsModule_ArmGroupList_ArmGroupListId",
                table: "ArmsInterventionsModule");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionsModule_KeywordList_KeywordListId",
                table: "ConditionsModule");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactsLocationsModule_CentralContactList_CentralContactListId",
                table: "ContactsLocationsModule");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactsLocationsModule_OverallOfficialList_OverallOfficialListId",
                table: "ContactsLocationsModule");

            migrationBuilder.DropForeignKey(
                name: "FK_DesignInfo_DesignObservationalModelList_DesignObservationalModelListId",
                table: "DesignInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DesignInfo_DesignTimePerspectiveList_DesignTimePerspectiveListId",
                table: "DesignInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DesignMaskingInfo_DesignWhoMaskedList_DesignWhoMaskedListId",
                table: "DesignMaskingInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DesignModule_BioSpec_BioSpecId",
                table: "DesignModule");

            migrationBuilder.DropForeignKey(
                name: "FK_DesignModule_EnrollmentInfo_EnrollmentInfoId",
                table: "DesignModule");

            migrationBuilder.DropForeignKey(
                name: "FK_DesignModule_ExpandedAccessTypes_ExpandedAccessTypesId",
                table: "DesignModule");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentificationModule_NCTIdAliasList_NCTIdAliasListId",
                table: "IdentificationModule");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_LocationContactList_LocationContactListId",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_MiscInfoModule_RemovedCountryList_RemovedCountryListId",
                table: "MiscInfoModule");

            migrationBuilder.DropForeignKey(
                name: "FK_ProtocolSection_IPDSharingStatementModule_IPDSharingStatementModuleId",
                table: "ProtocolSection");

            migrationBuilder.DropForeignKey(
                name: "FK_ProtocolSection_OutcomesModule_OutcomesModuleId",
                table: "ProtocolSection");

            migrationBuilder.DropForeignKey(
                name: "FK_ProtocolSection_OversightModule_OversightModuleId",
                table: "ProtocolSection");

            migrationBuilder.DropForeignKey(
                name: "FK_ProtocolSection_ReferencesModule_ReferencesModuleId",
                table: "ProtocolSection");

            migrationBuilder.DropForeignKey(
                name: "FK_SponsorCollaboratorsModule_CollaboratorList_CollaboratorListId",
                table: "SponsorCollaboratorsModule");

            migrationBuilder.DropForeignKey(
                name: "FK_SponsorCollaboratorsModule_ResponsibleParty_ResponsiblePartyId",
                table: "SponsorCollaboratorsModule");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusModule_CompletionDateStruct_CompletionDateStructId",
                table: "StatusModule");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusModule_DispFirstPostDateStruct_DispFirstPostDateStructId",
                table: "StatusModule");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusModule_PrimaryCompletionDateStruct_PrimaryCompletionDateStructId",
                table: "StatusModule");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusModule_ResultsFirstPostDateStruct_ResultsFirstPostDateStructId",
                table: "StatusModule");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusModule_StartDateStruct_StartDateStructId",
                table: "StatusModule");

            migrationBuilder.DropForeignKey(
                name: "FK_Study_AnnotationSection_AnnotationSectionId",
                table: "Study");

            migrationBuilder.DropForeignKey(
                name: "FK_Study_DocumentSection_DocumentSectionId",
                table: "Study");

            migrationBuilder.DropForeignKey(
                name: "FK_Study_ResultsSection_ResultsSectionId",
                table: "Study");

            migrationBuilder.DropTable(
                name: "AnnotationSection");

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
                name: "BioSpec");

            migrationBuilder.DropTable(
                name: "CentralContact");

            migrationBuilder.DropTable(
                name: "Collaborator");

            migrationBuilder.DropTable(
                name: "CompletionDateStruct");

            migrationBuilder.DropTable(
                name: "DesignObservationalModelList");

            migrationBuilder.DropTable(
                name: "DesignTimePerspectiveList");

            migrationBuilder.DropTable(
                name: "DesignWhoMaskedList");

            migrationBuilder.DropTable(
                name: "DispFirstPostDateStruct");

            migrationBuilder.DropTable(
                name: "DocumentSection");

            migrationBuilder.DropTable(
                name: "EnrollmentInfo");

            migrationBuilder.DropTable(
                name: "EventGroup");

            migrationBuilder.DropTable(
                name: "ExpandedAccessTypes");

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
                name: "IPDSharingStatementModule");

            migrationBuilder.DropTable(
                name: "KeywordList");

            migrationBuilder.DropTable(
                name: "LargeDoc");

            migrationBuilder.DropTable(
                name: "LocationContact");

            migrationBuilder.DropTable(
                name: "NCTIdAliasList");

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
                name: "OutcomesModule");

            migrationBuilder.DropTable(
                name: "OverallOfficial");

            migrationBuilder.DropTable(
                name: "OversightModule");

            migrationBuilder.DropTable(
                name: "PrimaryCompletionDateStruct");

            migrationBuilder.DropTable(
                name: "PrimaryOutcome");

            migrationBuilder.DropTable(
                name: "Reference");

            migrationBuilder.DropTable(
                name: "ReferencesModule");

            migrationBuilder.DropTable(
                name: "RemovedCountryList");

            migrationBuilder.DropTable(
                name: "ResponsibleParty");

            migrationBuilder.DropTable(
                name: "ResultsFirstPostDateStruct");

            migrationBuilder.DropTable(
                name: "ResultsSection");

            migrationBuilder.DropTable(
                name: "Retraction");

            migrationBuilder.DropTable(
                name: "SecondaryOutcome");

            migrationBuilder.DropTable(
                name: "SeeAlsoLink");

            migrationBuilder.DropTable(
                name: "SeriousEvent");

            migrationBuilder.DropTable(
                name: "SeriousEventStats");

            migrationBuilder.DropTable(
                name: "StartDateStruct");

            migrationBuilder.DropTable(
                name: "UnpostedEvent");

            migrationBuilder.DropTable(
                name: "AnnotationModule");

            migrationBuilder.DropTable(
                name: "ArmGroupInterventionList");

            migrationBuilder.DropTable(
                name: "ArmGroupList");

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
                name: "CentralContactList");

            migrationBuilder.DropTable(
                name: "CollaboratorList");

            migrationBuilder.DropTable(
                name: "LargeDocumentModule");

            migrationBuilder.DropTable(
                name: "FlowAchievementList");

            migrationBuilder.DropTable(
                name: "FlowDropWithdrawList");

            migrationBuilder.DropTable(
                name: "FlowMilestoneList");

            migrationBuilder.DropTable(
                name: "FlowReasonList");

            migrationBuilder.DropTable(
                name: "IPDSharingInfoTypeList");

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
                name: "OtherOutcomeList");

            migrationBuilder.DropTable(
                name: "OverallOfficialList");

            migrationBuilder.DropTable(
                name: "PrimaryOutcomeList");

            migrationBuilder.DropTable(
                name: "AvailIPDList");

            migrationBuilder.DropTable(
                name: "ReferenceList");

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
                name: "RetractionList");

            migrationBuilder.DropTable(
                name: "SecondaryOutcomeList");

            migrationBuilder.DropTable(
                name: "SeeAlsoLinkList");

            migrationBuilder.DropTable(
                name: "SeriousEventStatsList");

            migrationBuilder.DropTable(
                name: "UnpostedAnnotation");

            migrationBuilder.DropTable(
                name: "LargeDocList");

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

            migrationBuilder.DropIndex(
                name: "IX_Study_AnnotationSectionId",
                table: "Study");

            migrationBuilder.DropIndex(
                name: "IX_Study_DocumentSectionId",
                table: "Study");

            migrationBuilder.DropIndex(
                name: "IX_Study_ResultsSectionId",
                table: "Study");

            migrationBuilder.DropIndex(
                name: "IX_StatusModule_CompletionDateStructId",
                table: "StatusModule");

            migrationBuilder.DropIndex(
                name: "IX_StatusModule_DispFirstPostDateStructId",
                table: "StatusModule");

            migrationBuilder.DropIndex(
                name: "IX_StatusModule_PrimaryCompletionDateStructId",
                table: "StatusModule");

            migrationBuilder.DropIndex(
                name: "IX_StatusModule_ResultsFirstPostDateStructId",
                table: "StatusModule");

            migrationBuilder.DropIndex(
                name: "IX_StatusModule_StartDateStructId",
                table: "StatusModule");

            migrationBuilder.DropIndex(
                name: "IX_SponsorCollaboratorsModule_CollaboratorListId",
                table: "SponsorCollaboratorsModule");

            migrationBuilder.DropIndex(
                name: "IX_SponsorCollaboratorsModule_ResponsiblePartyId",
                table: "SponsorCollaboratorsModule");

            migrationBuilder.DropIndex(
                name: "IX_ProtocolSection_IPDSharingStatementModuleId",
                table: "ProtocolSection");

            migrationBuilder.DropIndex(
                name: "IX_ProtocolSection_OutcomesModuleId",
                table: "ProtocolSection");

            migrationBuilder.DropIndex(
                name: "IX_ProtocolSection_OversightModuleId",
                table: "ProtocolSection");

            migrationBuilder.DropIndex(
                name: "IX_ProtocolSection_ReferencesModuleId",
                table: "ProtocolSection");

            migrationBuilder.DropIndex(
                name: "IX_MiscInfoModule_RemovedCountryListId",
                table: "MiscInfoModule");

            migrationBuilder.DropIndex(
                name: "IX_Location_LocationContactListId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_IdentificationModule_NCTIdAliasListId",
                table: "IdentificationModule");

            migrationBuilder.DropIndex(
                name: "IX_DesignModule_BioSpecId",
                table: "DesignModule");

            migrationBuilder.DropIndex(
                name: "IX_DesignModule_EnrollmentInfoId",
                table: "DesignModule");

            migrationBuilder.DropIndex(
                name: "IX_DesignModule_ExpandedAccessTypesId",
                table: "DesignModule");

            migrationBuilder.DropIndex(
                name: "IX_DesignMaskingInfo_DesignWhoMaskedListId",
                table: "DesignMaskingInfo");

            migrationBuilder.DropIndex(
                name: "IX_DesignInfo_DesignObservationalModelListId",
                table: "DesignInfo");

            migrationBuilder.DropIndex(
                name: "IX_DesignInfo_DesignTimePerspectiveListId",
                table: "DesignInfo");

            migrationBuilder.DropIndex(
                name: "IX_ContactsLocationsModule_CentralContactListId",
                table: "ContactsLocationsModule");

            migrationBuilder.DropIndex(
                name: "IX_ContactsLocationsModule_OverallOfficialListId",
                table: "ContactsLocationsModule");

            migrationBuilder.DropIndex(
                name: "IX_ConditionsModule_KeywordListId",
                table: "ConditionsModule");

            migrationBuilder.DropIndex(
                name: "IX_ArmsInterventionsModule_ArmGroupListId",
                table: "ArmsInterventionsModule");

            migrationBuilder.DropColumn(
                name: "AnnotationSectionId",
                table: "Study");

            migrationBuilder.DropColumn(
                name: "DocumentSectionId",
                table: "Study");

            migrationBuilder.DropColumn(
                name: "ResultsSectionId",
                table: "Study");

            migrationBuilder.DropColumn(
                name: "CompletionDateStructId",
                table: "StatusModule");

            migrationBuilder.DropColumn(
                name: "DelayedPosting",
                table: "StatusModule");

            migrationBuilder.DropColumn(
                name: "DispFirstPostDateStructId",
                table: "StatusModule");

            migrationBuilder.DropColumn(
                name: "DispFirstSubmitDate",
                table: "StatusModule");

            migrationBuilder.DropColumn(
                name: "DispFirstSubmitQCDate",
                table: "StatusModule");

            migrationBuilder.DropColumn(
                name: "LastKnownStatus",
                table: "StatusModule");

            migrationBuilder.DropColumn(
                name: "PrimaryCompletionDateStructId",
                table: "StatusModule");

            migrationBuilder.DropColumn(
                name: "ResultsFirstPostDateStructId",
                table: "StatusModule");

            migrationBuilder.DropColumn(
                name: "ResultsFirstSubmitDate",
                table: "StatusModule");

            migrationBuilder.DropColumn(
                name: "ResultsFirstSubmitQCDate",
                table: "StatusModule");

            migrationBuilder.DropColumn(
                name: "StartDateStructId",
                table: "StatusModule");

            migrationBuilder.DropColumn(
                name: "WhyStopped",
                table: "StatusModule");

            migrationBuilder.DropColumn(
                name: "CollaboratorListId",
                table: "SponsorCollaboratorsModule");

            migrationBuilder.DropColumn(
                name: "ResponsiblePartyId",
                table: "SponsorCollaboratorsModule");

            migrationBuilder.DropColumn(
                name: "IPDSharingStatementModuleId",
                table: "ProtocolSection");

            migrationBuilder.DropColumn(
                name: "OutcomesModuleId",
                table: "ProtocolSection");

            migrationBuilder.DropColumn(
                name: "OversightModuleId",
                table: "ProtocolSection");

            migrationBuilder.DropColumn(
                name: "ReferencesModuleId",
                table: "ProtocolSection");

            migrationBuilder.DropColumn(
                name: "RemovedCountryListId",
                table: "MiscInfoModule");

            migrationBuilder.DropColumn(
                name: "LocationContactListId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "LocationStatus",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "LocationZip",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Acronym",
                table: "IdentificationModule");

            migrationBuilder.DropColumn(
                name: "NCTIdAliasListId",
                table: "IdentificationModule");

            migrationBuilder.DropColumn(
                name: "OfficialTitle",
                table: "IdentificationModule");

            migrationBuilder.DropColumn(
                name: "ExpandedAccessNCTId",
                table: "ExpandedAccessInfo");

            migrationBuilder.DropColumn(
                name: "ExpandedAccessStatusForNCTId",
                table: "ExpandedAccessInfo");

            migrationBuilder.DropColumn(
                name: "GenderBased",
                table: "EligibilityModule");

            migrationBuilder.DropColumn(
                name: "GenderDescription",
                table: "EligibilityModule");

            migrationBuilder.DropColumn(
                name: "SamplingMethod",
                table: "EligibilityModule");

            migrationBuilder.DropColumn(
                name: "StudyPopulation",
                table: "EligibilityModule");

            migrationBuilder.DropColumn(
                name: "BioSpecId",
                table: "DesignModule");

            migrationBuilder.DropColumn(
                name: "EnrollmentInfoId",
                table: "DesignModule");

            migrationBuilder.DropColumn(
                name: "ExpandedAccessTypesId",
                table: "DesignModule");

            migrationBuilder.DropColumn(
                name: "PatientRegistry",
                table: "DesignModule");

            migrationBuilder.DropColumn(
                name: "TargetDuration",
                table: "DesignModule");

            migrationBuilder.DropColumn(
                name: "DesignMaskingDescription",
                table: "DesignMaskingInfo");

            migrationBuilder.DropColumn(
                name: "DesignWhoMaskedListId",
                table: "DesignMaskingInfo");

            migrationBuilder.DropColumn(
                name: "DesignAllocation",
                table: "DesignInfo");

            migrationBuilder.DropColumn(
                name: "DesignInterventionModelDescription",
                table: "DesignInfo");

            migrationBuilder.DropColumn(
                name: "DesignObservationalModelListId",
                table: "DesignInfo");

            migrationBuilder.DropColumn(
                name: "DesignTimePerspectiveListId",
                table: "DesignInfo");

            migrationBuilder.DropColumn(
                name: "CentralContactListId",
                table: "ContactsLocationsModule");

            migrationBuilder.DropColumn(
                name: "OverallOfficialListId",
                table: "ContactsLocationsModule");

            migrationBuilder.DropColumn(
                name: "KeywordListId",
                table: "ConditionsModule");

            migrationBuilder.DropColumn(
                name: "ArmGroupListId",
                table: "ArmsInterventionsModule");
        }
    }
}
