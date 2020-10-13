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

namespace ClinicalTrialsWeb
{
    class DBPreparation
    {
        static String destinationFolder = "../../JSON";
        static String zipPath = new KnownFolder(KnownFolderType.Downloads).Path + "/AllAPIJSON.zip";
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

            Console.WriteLine(ConnectionString);
            Console.ReadLine();
        }
        public static ClinicalTrialsContext AddToContext(ClinicalTrialsContext context, Root entity, int count, int commitCount, bool recreateContext)
        {
            context.Set<Root>().Add(entity);

            if (count % commitCount == 0)
            {
                context.SaveChanges();
                if (recreateContext)
                {
                    context.Dispose();
                    context = new ClinicalTrialsContext(ConnectionString);

                    context.ChangeTracker.AutoDetectChangesEnabled = false;
                }
            }

            return context;
        }

        public static void DeleteOldDb()
        {

            using (var db = new ClinicalTrialsContext(ConnectionString))
            {
                db.Database.ExecuteSqlCommand("DELETE FROM [Studies] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [FullStudy] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [Study] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [ProtocolSection] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [DerivedSection] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [IdentificationModule] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [SecondaryIdInfo] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [StatusModule] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [MiscInfoModule] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [ConditionsModule] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [DescriptionModule] WHERE id > 0");
                Console.WriteLine("deleting from conditions..");
                db.Database.ExecuteSqlCommand("DELETE FROM [ConditionBrowseModule] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [ArmsInterventionsModule] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [DescriptionModule] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [Intervention] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [InterventionList] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [InterventionBrowseModule] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [InterventionMesh] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [DesignModule] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [DesignInfo] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [InterventionBrowseBranch] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [InterventionBrowseBranch] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [ConditionMesh] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [ConditionList] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [InterventionMeshList] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [PhaseList] WHERE id > 0");
                Console.WriteLine("deleting from phase list..");
                db.Database.ExecuteSqlCommand("DELETE FROM [InterventionAncestor] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [InterventionAncestorList] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [OrgStudyIdInfo] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [Organization] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [Location] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [DesignMaskingInfo] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [EligibilityModule] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [ConditionBrowseLeaf] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [ConditionBrowseLeafList] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [InterventionBrowseLeaf] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [InterventionBrowseBranchList] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [ContactsLocationsModule] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [SponsorCollaboratorsModule] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [LeadSponsor] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [ConditionAncestor] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [ConditionAncestorList] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [ConditionMeshList] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [ConditionBrowseBranch] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [LocationList] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [ExpandedAccessInfo] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [InterventionBrowseLeafList] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [SecondaryIdInfoList] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [StdAgeList] WHERE id > 0");
                Console.WriteLine("deleting from post date..");
                db.Database.ExecuteSqlCommand("DELETE FROM [StudyFirstPostDateStruct] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [LastUpdatePostDateStruct] WHERE id > 0");
                db.Database.ExecuteSqlCommand("DELETE FROM [ConditionBrowseBranchList] WHERE id > 0");

                var modelNames = db.Model.GetEntityTypes();
                foreach (var modelName in modelNames)
                {
                    string tableName = modelName.Name.Split('.')[1];
                    Console.WriteLine(tableName);
                    if (tableName.Equals("Root"))
                    {
                        tableName = "Studies";
                    }
                    else if (tableName.Equals("Tag") || tableName.Equals("TagList") || tableName.Equals("__EFMigrationsHistory"))
                    {
                        continue;
                    }
                    //db.Database.ExecuteSqlCommand("DELETE FROM [" + tableName +"] WHERE id > 0");
                    db.Database.ExecuteSqlCommand("DBCC CHECKIDENT([" + tableName + "], RESEED, 0)");
                }
            }
        }

        public static void WriteToDB()
        {
            SetConnectionString();
            
            DeleteOldDb();

            ClinicalTrialsContext context = null;
            try
            {
                context = new ClinicalTrialsContext(ConnectionString);
                context.ChangeTracker.AutoDetectChangesEnabled = false;

                int count = 0;


                using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Read))
                {
                    Console.WriteLine("Reading from zip in progress...");

                    int countZip = 0;

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
                                //Console.WriteLine(item.FullStudy.Study.ProtocolSection.IdentificationModule.NCTId);

                            }
                            Console.WriteLine(entry.FullName + " - " + count);

                            countZip++;
                        }
                    }
                }
                //context.SaveChanges();
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
