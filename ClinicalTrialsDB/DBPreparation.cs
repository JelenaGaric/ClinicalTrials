using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model;
using Model.Context;
using Newtonsoft.Json;
using Syroot.Windows.IO;
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
using System.Text;

namespace ClinicalTrialsWeb
{
    class DBPreparation
    {
        static String destinationFolder = "../../JSON";
        //static String zipPath = new KnownFolder(KnownFolderType.Downloads).Path + "/AllAPIJSON.zip";
        static string zipPath = @"C:\Downloads\AllAPIJSON.zip";
        static int numFiles = 1000;
        static int commitCount = 100;
        static string ConnectionString = "";
        public IConfiguration Configuration { get; }

        public static void SetConnectionString()
        {
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings["ClinicalTrialsConnection"];

            if (settings != null)
                ConnectionString = settings.ConnectionString;

            Console.WriteLine("Using connection string: " + ConnectionString);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
        public static ClinicalTrialsContext AddToContext(ClinicalTrialsContext context, Root entity, int count, int commitCount, bool recreateContext)
        {
            context.Set<Root>().Add(entity);
           
            if (count % commitCount == 0)
            {
                try
                {
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.InnerException);

                }
                //context.SaveChanges();
                if (recreateContext)
                {
                    context.Dispose();
                    context = new ClinicalTrialsContext();

                    context.ChangeTracker.AutoDetectChangesEnabled = false;
                }
            }

            return context;
        }

        public static void DeleteOldDb()
        {
            ClinicalTrialsContext db = new ClinicalTrialsContext();
            using (db)
            {
                db.Database.ExecuteSqlCommand("delete from [Studies]"); 
                db.Database.ExecuteSqlCommand("delete from [FullStudy]");
                db.Database.ExecuteSqlCommand("delete from [Study]");
                db.Database.ExecuteSqlCommand("delete from [ProtocolSection]");
                db.Database.ExecuteSqlCommand("delete from[DerivedSection]");
                db.Database.ExecuteSqlCommand("delete from[IdentificationModule]");
                db.Database.ExecuteSqlCommand("delete from[SecondaryIdInfo]");
                db.Database.ExecuteSqlCommand("delete from[StatusModule]");
                db.Database.ExecuteSqlCommand("delete from[MiscInfoModule]");
                db.Database.ExecuteSqlCommand("delete from[ConditionsModule]");
                db.Database.ExecuteSqlCommand("delete from[DescriptionModule]");
                Console.WriteLine("deleting from conditions..");
                db.Database.ExecuteSqlCommand("delete from[ConditionBrowseModule]");
                db.Database.ExecuteSqlCommand("delete from[ArmsInterventionsModule]");
                db.Database.ExecuteSqlCommand("delete from[DescriptionModule]");
                db.Database.ExecuteSqlCommand("delete from[Intervention]");
                db.Database.ExecuteSqlCommand("delete from[InterventionList]");
                db.Database.ExecuteSqlCommand("delete from[InterventionBrowseModule]");
                db.Database.ExecuteSqlCommand("delete from[InterventionMesh]");
                db.Database.ExecuteSqlCommand("delete from[DesignModule]");
                db.Database.ExecuteSqlCommand("delete from[DesignInfo]");
                db.Database.ExecuteSqlCommand("delete from[DesignObservationalModelList]");
                db.Database.ExecuteSqlCommand("delete from[DesignTimePerspectiveList]");

                db.Database.ExecuteSqlCommand("delete from[InterventionBrowseBranch]");
                db.Database.ExecuteSqlCommand("delete from[InterventionBrowseBranch]");
                db.Database.ExecuteSqlCommand("delete from[ConditionMesh]");
                db.Database.ExecuteSqlCommand("delete from[ConditionList]");
                db.Database.ExecuteSqlCommand("delete from[InterventionMeshList]");
                db.Database.ExecuteSqlCommand("delete from[KeywordList]");
                db.Database.ExecuteSqlCommand("delete from[PhaseList]");
                Console.WriteLine("deleting from phase list..");
                db.Database.ExecuteSqlCommand("delete from[InterventionAncestor]");
                db.Database.ExecuteSqlCommand("delete from[InterventionAncestorList]");
                db.Database.ExecuteSqlCommand("delete from[OrgStudyIdInfo]");
                db.Database.ExecuteSqlCommand("delete from[Organization]");
                db.Database.ExecuteSqlCommand("delete from[Location]");
                db.Database.ExecuteSqlCommand("delete from[LocationContact]");
                db.Database.ExecuteSqlCommand("delete from[LocationContactList]");
                db.Database.ExecuteSqlCommand("delete from[DesignMaskingInfo]");
                db.Database.ExecuteSqlCommand("delete from[BioSpec]");
                db.Database.ExecuteSqlCommand("delete from[EnrollmentInfo]");
                db.Database.ExecuteSqlCommand("delete from[ExpandedAccessTypes]");
                db.Database.ExecuteSqlCommand("delete from[ExpandedAccessInfo]");
                db.Database.ExecuteSqlCommand("delete from[DesignWhoMaskedList]");
                db.Database.ExecuteSqlCommand("delete from[EligibilityModule]");
                db.Database.ExecuteSqlCommand("delete from[ConditionBrowseLeaf]");
                db.Database.ExecuteSqlCommand("delete from[ConditionBrowseLeafList]");
                db.Database.ExecuteSqlCommand("delete from[InterventionBrowseLeaf]");
                db.Database.ExecuteSqlCommand("delete from[InterventionBrowseBranchList]");
                db.Database.ExecuteSqlCommand("delete from[ContactsLocationsModule]");
                db.Database.ExecuteSqlCommand("delete from[SponsorCollaboratorsModule]");
                db.Database.ExecuteSqlCommand("delete from[LeadSponsor]");
                db.Database.ExecuteSqlCommand("delete from[ConditionAncestor]");
                db.Database.ExecuteSqlCommand("delete from[ConditionAncestorList]");
                db.Database.ExecuteSqlCommand("delete from[ConditionMeshList]");
                db.Database.ExecuteSqlCommand("delete from[ConditionBrowseBranch]");
                db.Database.ExecuteSqlCommand("delete from[LocationList]");
                db.Database.ExecuteSqlCommand("delete from[OverallOfficial]");
                db.Database.ExecuteSqlCommand("delete from[OverallOfficialList]");
                db.Database.ExecuteSqlCommand("delete from[CentralContact]");
                db.Database.ExecuteSqlCommand("delete from[CentralContactList]");
                db.Database.ExecuteSqlCommand("delete from[InterventionBrowseLeafList]");
                db.Database.ExecuteSqlCommand("delete from[SecondaryIdInfoList]");
                db.Database.ExecuteSqlCommand("delete from[StdAgeList]"); 
                db.Database.ExecuteSqlCommand("delete from[StudyFirstPostDateStruct]");
                db.Database.ExecuteSqlCommand("delete from[LastUpdatePostDateStruct]");
                db.Database.ExecuteSqlCommand("delete from[ConditionBrowseBranchList]");
                db.Database.ExecuteSqlCommand("delete from[Collaborator]");
                db.Database.ExecuteSqlCommand("delete from[CollaboratorList]");
                db.Database.ExecuteSqlCommand("delete from[ResponsibleParty]");
                db.Database.ExecuteSqlCommand("delete from[CompletionDateStruct]");
                db.Database.ExecuteSqlCommand("delete from[NCTIdAliasList]");
                db.Database.ExecuteSqlCommand("delete from[ResultsFirstPostDateStruct]");
                db.Database.ExecuteSqlCommand("delete from[PrimaryCompletionDateStruct]");
                db.Database.ExecuteSqlCommand("delete from[StartDateStruct]");
                db.Database.ExecuteSqlCommand("delete from[SecondaryIdInfo]");
                db.Database.ExecuteSqlCommand("delete from[SecondaryIdInfoList]");
                db.Database.ExecuteSqlCommand("delete from[CompletionDateStruct]");
                db.Database.ExecuteSqlCommand("delete from[DispFirstPostDateStruct]");
                db.Database.ExecuteSqlCommand("delete from[RemovedCountryList]");


                Console.WriteLine("deleting from references module..");
                db.Database.ExecuteSqlCommand("delete from[ReferencesModule]");
                db.Database.ExecuteSqlCommand("delete from[Reference]");
                db.Database.ExecuteSqlCommand("delete from[ReferenceList]");
                db.Database.ExecuteSqlCommand("delete from[SeeAlsoLink]");
                db.Database.ExecuteSqlCommand("delete from[SeeAlsoLinkList]");
                db.Database.ExecuteSqlCommand("delete from[AvailIPD]");
                db.Database.ExecuteSqlCommand("delete from[AvailIPDList]");

                Console.WriteLine("deleting from outcomes module..");
                db.Database.ExecuteSqlCommand("delete from[OutcomesModule]");
                db.Database.ExecuteSqlCommand("delete from[PrimaryOutcome]");
                db.Database.ExecuteSqlCommand("delete from[PrimaryOutcomeList]");
                db.Database.ExecuteSqlCommand("delete from[SecondaryOutcome]");
                db.Database.ExecuteSqlCommand("delete from[SecondaryOutcomeList]");
                db.Database.ExecuteSqlCommand("delete from[OtherOutcome]");
                db.Database.ExecuteSqlCommand("delete from[OtherOutcomeList]");

                Console.WriteLine("deleting from oversight module..");
                db.Database.ExecuteSqlCommand("delete from[OversightModule]");

                Console.WriteLine("deleting from annotation module..");
                db.Database.ExecuteSqlCommand("delete from[AnnotationSection]");
                db.Database.ExecuteSqlCommand("delete from[AnnotationModule]");
                db.Database.ExecuteSqlCommand("delete from[UnpostedAnnotation]");
                db.Database.ExecuteSqlCommand("delete from[UnpostedEvent]");
                db.Database.ExecuteSqlCommand("delete from[UnpostedEventList]");

                Console.WriteLine("deleting from arms..");
                db.Database.ExecuteSqlCommand("delete from[ArmGroup]");
                db.Database.ExecuteSqlCommand("delete from[ArmGroupList]");
                db.Database.ExecuteSqlCommand("delete from[ArmGroupInterventionList]");
                db.Database.ExecuteSqlCommand("delete from[ArmsInterventionsModule]");

                Console.WriteLine("deleting from large document module..");
                db.Database.ExecuteSqlCommand("delete from[DocumentSection]");
                db.Database.ExecuteSqlCommand("delete from[LargeDocumentModule]");
                db.Database.ExecuteSqlCommand("delete from[LargeDoc]");
                db.Database.ExecuteSqlCommand("delete from[LargeDocList]");
                
                Console.WriteLine("deleting from ipd module..");
                db.Database.ExecuteSqlCommand("delete from[IPDSharingStatementModule]");
                db.Database.ExecuteSqlCommand("delete from[IPDSharingInfoTypeList]");

                Console.WriteLine("deleting from results section..");
                db.Database.ExecuteSqlCommand("delete from[ResultsSection]");

                db.Database.ExecuteSqlCommand("delete from[MoreInfoModule]");
                db.Database.ExecuteSqlCommand("delete from[CertainAgreement]");
                db.Database.ExecuteSqlCommand("delete from[LimitationsAndCaveats]");
                db.Database.ExecuteSqlCommand("delete from[PointOfContact]");
                db.Database.ExecuteSqlCommand("delete from[FlowGroup]");
                db.Database.ExecuteSqlCommand("delete from[FlowAchievement]");
                db.Database.ExecuteSqlCommand("delete from[FlowMilestone]");
                db.Database.ExecuteSqlCommand("delete from[FlowReason]");
                db.Database.ExecuteSqlCommand("delete from[FlowDropWithdraw]");
                db.Database.ExecuteSqlCommand("delete from[FlowPeriod]");
                db.Database.ExecuteSqlCommand("delete from[ParticipantFlowModule]");
                db.Database.ExecuteSqlCommand("delete from[FlowGroupList]");
                db.Database.ExecuteSqlCommand("delete from[FlowPeriodList]");
                db.Database.ExecuteSqlCommand("delete from[FlowDropWithdrawList]");
                db.Database.ExecuteSqlCommand("delete from[FlowReasonList]");
                db.Database.ExecuteSqlCommand("delete from[FlowMilestoneList]");
                db.Database.ExecuteSqlCommand("delete from[FlowAchievementList]");


                db.Database.ExecuteSqlCommand("delete from[OutcomeMeasuresModule]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeCategory]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeAnalysis]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeAnalysisGroupIdList]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeClass]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeClassDenom]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeDenom]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeDenomCount]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeClassDenomCount]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeGroup]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeMeasure]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeMeasurement]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeMeasurementList]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeCategoryList]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeAnalysisList]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeDenomCountList]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeClassDenomCountList]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeGroupList]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeClassDenomList]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeDenomList]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeClassList]");
                db.Database.ExecuteSqlCommand("delete from[OutcomeMeasureList]");

                Console.WriteLine("deleting from adverse module..");
                db.Database.ExecuteSqlCommand("delete from[AdverseEventsModule]");
                db.Database.ExecuteSqlCommand("delete from[EventGroup]");
                db.Database.ExecuteSqlCommand("delete from[EventGroupList]");
                db.Database.ExecuteSqlCommand("delete from[SeriousEvent]");
                db.Database.ExecuteSqlCommand("delete from[SeriousEventStats]");
                db.Database.ExecuteSqlCommand("delete from[SeriousEventStatsList]");
                db.Database.ExecuteSqlCommand("delete from[SeriousEventList]");
                db.Database.ExecuteSqlCommand("delete from[OtherEvent]");
                db.Database.ExecuteSqlCommand("delete from[OtherEventStats]");
                db.Database.ExecuteSqlCommand("delete from[OtherEventStatsList]");
                db.Database.ExecuteSqlCommand("delete from[OtherEventList]");


                Console.WriteLine("deleting from baseline characteristics module..");
                db.Database.ExecuteSqlCommand("delete from[BaselineCharacteristicsModule]");
                db.Database.ExecuteSqlCommand("delete from[BaselineGroup]");
                db.Database.ExecuteSqlCommand("delete from[BaselineDenomCount]");
                db.Database.ExecuteSqlCommand("delete from[BaselineDenom]");
                db.Database.ExecuteSqlCommand("delete from[BaselineMeasure]");
                db.Database.ExecuteSqlCommand("delete from[BaselineMeasureDenom]");
                db.Database.ExecuteSqlCommand("delete from[BaselineMeasureDenomCount]");
                db.Database.ExecuteSqlCommand("delete from[BaselineClass]");
                db.Database.ExecuteSqlCommand("delete from[BaselineCategory]");
                db.Database.ExecuteSqlCommand("delete from[BaselineClassDenom]");
                db.Database.ExecuteSqlCommand("delete from[BaselineClassDenomCount]");
                db.Database.ExecuteSqlCommand("delete from[BaselineMeasureList]");
                db.Database.ExecuteSqlCommand("delete from[BaselineMeasurement]");
                db.Database.ExecuteSqlCommand("delete from[BaselineDenomCountList]");
                db.Database.ExecuteSqlCommand("delete from[BaselineMeasureDenomCountList]");
                db.Database.ExecuteSqlCommand("delete from[BaselineClassDenomCountList]");
                db.Database.ExecuteSqlCommand("delete from[BaselineMeasureDenomList]");
                db.Database.ExecuteSqlCommand("delete from[BaselineDenomList]");
                db.Database.ExecuteSqlCommand("delete from[BaselineGroupList]");
                db.Database.ExecuteSqlCommand("delete from[BaselineClassDenomList]");
                db.Database.ExecuteSqlCommand("delete from[BaselineClassList]");
                db.Database.ExecuteSqlCommand("delete from[BaselineCategoryList]");
                db.Database.ExecuteSqlCommand("delete from[BaselineMeasurementList]");

                db.Database.ExecuteSqlCommand("delete from[Retraction]");
                db.Database.ExecuteSqlCommand("delete from[RetractionList]");

                var modelNames = db.Model.GetEntityTypes();
                foreach (var modelName in modelNames)
                {
                    string tableName = modelName.Name.Split('.')[1];
                    if (tableName.Equals("Root"))
                    {
                        tableName = "Studies";
                    }
                    else if (tableName.Equals("CityCoordinates") || tableName.Equals("Tag") || tableName.Equals("TagList") || tableName.Equals("__EFMigrationsHistory") || tableName.Equals("StatisticsSearch"))
                    {
                        continue;
                    }
                    //db.Database.ExecuteSqlCommand("delete from[" + tableName +"]");
                    db.Database.ExecuteSqlCommand("DBCC CHECKIDENT([" + tableName + "], RESEED, 1)");
                }
                /*

                int count = 50;
                while (count < db.Studies.OrderByDescending(s => s.Id).FirstOrDefault().Id)
                {
                    Console.WriteLine("Deleting ..." + count);

                    var list = db.Studies.Where(s => s.Id <= count).ToList();
                    db.Studies.RemoveRange(list);
                    db.SaveChanges();
                    count += 50;

                }

                */

            }
        }


        public static void WriteToDB()
        {
            //SetConnectionString();
           
            ClinicalTrialsContext context = null;
            try
            {
                context = new ClinicalTrialsContext();

                 try
                 {
                     foreach (string m in context.Database.GetMigrations())
                         Console.WriteLine(m);
                         context.Database.Migrate();
                 } catch(Exception e)
                 {
                     Console.WriteLine(e.Message);
                 }

                DeleteOldDb();

                context.ChangeTracker.AutoDetectChangesEnabled = false;

                int count = 0;


                using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Read))
                {
                    Console.WriteLine("Reading from zip in progress...");

                    //int countZip = 0;

                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        //if (countZip <= numFiles){
                        if (entry.FullName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                        {

                            using (StreamReader reader = new StreamReader(entry.Open()))
                            {
                                String json = reader.ReadToEnd();
                                Root item = JsonConvert.DeserializeObject<Root>(json);
                                ++count;
                                context = AddToContext(context, item, count, commitCount, true);

                            }
                            Console.WriteLine(entry.FullName + " - " + count);

                            //countZip++;
                        }
                    }
                }
                context.SaveChanges();
            }
            finally
            {
                if (context != null)
                    context.Dispose();
            }
            
            Console.WriteLine("Writing complete.");
            Console.ReadLine();
        }

        public static void ExtractFilesOld()
        {

            try
            {
                if (!Directory.Exists(destinationFolder))
                {
                    DirectoryInfo di = Directory.CreateDirectory(destinationFolder);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }

            using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Read))
            {
                Console.WriteLine("Reading from zip in progress...");

                int count = 0;

                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (count <= numFiles)
                    {

                        if (entry.FullName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                        {
                            string destinationPath = Path.GetFullPath(Path.Combine(destinationFolder, entry.FullName));

                            if (destinationPath.StartsWith(Path.GetFullPath(destinationFolder), StringComparison.Ordinal))
                                try
                                {
                                    entry.ExtractToFile(destinationPath, true);
                                }
                                catch (DirectoryNotFoundException e)
                                {
                                    Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));
                                    entry.ExtractToFile(destinationPath, true);
                                }

                            count++;
                            Console.WriteLine(entry.FullName + " - " + count);
                            Console.ReadLine();

                        }

                    }
                    else
                    {
                        break;
                    }

                }
                Console.WriteLine("Extraction complete.");
            }
        }

        public static void BulkInsertStudies(List<Root> reads)
        {
            List<string> columns = new List<string>();
            columns.Add("FullStudyId");

            BulkInsert(columns, "Studies", reads.AsDataTable());
        }

        private static void BulkInsert(List<string> columns, string tableName, DataTable data, bool shouldTryOneMoreTime = true)
        {
            using (var connection = new SqlConnection("Data Source=DESKTOP-202D1BU;Initial Catalog=ClinicalTrials;MultipleActiveResultSets=true;Integrated Security=True"))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                using (var bulkCopy = new SqlBulkCopy(connection, SqlBulkCopyOptions.Default, transaction))
                {
                    bulkCopy.BatchSize = 10000;
                    bulkCopy.DestinationTableName = tableName;
                    try
                    {
                        foreach (var column in columns)
                        {
                            bulkCopy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(column, column));
                        }
                        bulkCopy.WriteToServer(data);
                        transaction.Commit();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.InnerException);
                        transaction.Rollback();
                        connection.Close();
                        if (shouldTryOneMoreTime)
                        {
                            BulkInsert(columns, tableName, data, false);
                        }
                    }
                }
            }
        }

    }

    public static class IEnumerableExtensions
    {
        public static DataTable AsDataTable<T>(this IEnumerable<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            var table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    if (prop.Name != "ID")
                    {
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    }
                }
                table.Rows.Add(row);
            }
            return table;
        }



    }
}
