using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "DesignMaskingInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignMasking = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignMaskingInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpandedAccessInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HasExpandedAccess = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpandedAccessInfo", x => x.Id);
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
                name: "MiscInfoModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionHolder = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiscInfoModule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgFullName = table.Column<string>(nullable: true),
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
                name: "ConditionsModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionListId = table.Column<int>(nullable: true)
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
                    ConditionMeshTerm = table.Column<string>(nullable: true),
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
                name: "DesignInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignInterventionModel = table.Column<string>(nullable: true),
                    DesignPrimaryPurpose = table.Column<string>(nullable: true),
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
                    InterventionListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmsInterventionsModule", x => x.Id);
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
                name: "SponsorCollaboratorsModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadSponsorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorCollaboratorsModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SponsorCollaboratorsModule_LeadSponsor_LeadSponsorId",
                        column: x => x.LeadSponsorId,
                        principalTable: "LeadSponsor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactsLocationsModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactsLocationsModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactsLocationsModule_LocationList_LocationListId",
                        column: x => x.LocationListId,
                        principalTable: "LocationList",
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
                    LocationCity = table.Column<string>(nullable: true),
                    LocationState = table.Column<string>(nullable: true),
                    LocationCountry = table.Column<string>(nullable: true),
                    LocationListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_LocationList_LocationListId",
                        column: x => x.LocationListId,
                        principalTable: "LocationList",
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
                    BriefTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentificationModule", x => x.Id);
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
                    StdAgeListId = table.Column<int>(nullable: true)
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
                    LastUpdatePostDateStructId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusModule", x => x.Id);
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
                        name: "FK_StatusModule_StudyFirstPostDateStruct_StudyFirstPostDateStructId",
                        column: x => x.StudyFirstPostDateStructId,
                        principalTable: "StudyFirstPostDateStruct",
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
                    DesignInfoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesignModule_DesignInfo_DesignInfoId",
                        column: x => x.DesignInfoId,
                        principalTable: "DesignInfo",
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
                name: "ProtocolSection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificationModuleId = table.Column<int>(nullable: true),
                    StatusModuleId = table.Column<int>(nullable: true),
                    SponsorCollaboratorsModuleId = table.Column<int>(nullable: true),
                    DescriptionModuleId = table.Column<int>(nullable: true),
                    ConditionsModuleId = table.Column<int>(nullable: true),
                    DesignModuleId = table.Column<int>(nullable: true),
                    ArmsInterventionsModuleId = table.Column<int>(nullable: true),
                    EligibilityModuleId = table.Column<int>(nullable: true),
                    ContactsLocationsModuleId = table.Column<int>(nullable: true)
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
                        name: "FK_ProtocolSection_IdentificationModule_IdentificationModuleId",
                        column: x => x.IdentificationModuleId,
                        principalTable: "IdentificationModule",
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
                    DerivedSectionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Study", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Study_DerivedSection_DerivedSectionId",
                        column: x => x.DerivedSectionId,
                        principalTable: "DerivedSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Study_ProtocolSection_ProtocolSectionId",
                        column: x => x.ProtocolSectionId,
                        principalTable: "ProtocolSection",
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
                name: "IX_ArmsInterventionsModule_InterventionListId",
                table: "ArmsInterventionsModule",
                column: "InterventionListId");

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
                name: "IX_ContactsLocationsModule_LocationListId",
                table: "ContactsLocationsModule",
                column: "LocationListId");

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
                name: "IX_DesignModule_DesignInfoId",
                table: "DesignModule",
                column: "DesignInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignModule_PhaseListId",
                table: "DesignModule",
                column: "PhaseListId");

            migrationBuilder.CreateIndex(
                name: "IX_EligibilityModule_StdAgeListId",
                table: "EligibilityModule",
                column: "StdAgeListId");

            migrationBuilder.CreateIndex(
                name: "IX_FullStudy_StudyId",
                table: "FullStudy",
                column: "StudyId");

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
                name: "IX_Location_LocationListId",
                table: "Location",
                column: "LocationListId");

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
                name: "IX_ProtocolSection_IdentificationModuleId",
                table: "ProtocolSection",
                column: "IdentificationModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSection_SponsorCollaboratorsModuleId",
                table: "ProtocolSection",
                column: "SponsorCollaboratorsModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSection_StatusModuleId",
                table: "ProtocolSection",
                column: "StatusModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondaryIdInfo_SecondaryIdInfoListId",
                table: "SecondaryIdInfo",
                column: "SecondaryIdInfoListId");

            migrationBuilder.CreateIndex(
                name: "IX_SponsorCollaboratorsModule_LeadSponsorId",
                table: "SponsorCollaboratorsModule",
                column: "LeadSponsorId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusModule_ExpandedAccessInfoId",
                table: "StatusModule",
                column: "ExpandedAccessInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusModule_LastUpdatePostDateStructId",
                table: "StatusModule",
                column: "LastUpdatePostDateStructId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusModule_StudyFirstPostDateStructId",
                table: "StatusModule",
                column: "StudyFirstPostDateStructId");

            migrationBuilder.CreateIndex(
                name: "IX_Studies_FullStudyId",
                table: "Studies",
                column: "FullStudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Study_DerivedSectionId",
                table: "Study",
                column: "DerivedSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Study_ProtocolSectionId",
                table: "Study",
                column: "ProtocolSectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConditionAncestor");

            migrationBuilder.DropTable(
                name: "ConditionBrowseBranch");

            migrationBuilder.DropTable(
                name: "ConditionBrowseLeaf");

            migrationBuilder.DropTable(
                name: "ConditionMesh");

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
                name: "Location");

            migrationBuilder.DropTable(
                name: "SecondaryIdInfo");

            migrationBuilder.DropTable(
                name: "Studies");

            migrationBuilder.DropTable(
                name: "FullStudy");

            migrationBuilder.DropTable(
                name: "Study");

            migrationBuilder.DropTable(
                name: "DerivedSection");

            migrationBuilder.DropTable(
                name: "ProtocolSection");

            migrationBuilder.DropTable(
                name: "ConditionBrowseModule");

            migrationBuilder.DropTable(
                name: "InterventionBrowseModule");

            migrationBuilder.DropTable(
                name: "MiscInfoModule");

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
                name: "IdentificationModule");

            migrationBuilder.DropTable(
                name: "SponsorCollaboratorsModule");

            migrationBuilder.DropTable(
                name: "StatusModule");

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
                name: "InterventionList");

            migrationBuilder.DropTable(
                name: "ConditionList");

            migrationBuilder.DropTable(
                name: "LocationList");

            migrationBuilder.DropTable(
                name: "DesignInfo");

            migrationBuilder.DropTable(
                name: "PhaseList");

            migrationBuilder.DropTable(
                name: "StdAgeList");

            migrationBuilder.DropTable(
                name: "OrgStudyIdInfo");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "SecondaryIdInfoList");

            migrationBuilder.DropTable(
                name: "LeadSponsor");

            migrationBuilder.DropTable(
                name: "ExpandedAccessInfo");

            migrationBuilder.DropTable(
                name: "LastUpdatePostDateStruct");

            migrationBuilder.DropTable(
                name: "StudyFirstPostDateStruct");

            migrationBuilder.DropTable(
                name: "DesignMaskingInfo");
        }
    }
}
