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

            Console.WriteLine("Using connection string: " + ConnectionString);
            Console.WriteLine("Press enter to continue.");
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
                db.Database.ExecuteSqlCommand("delete from[InterventionBrowseBranch]");
                db.Database.ExecuteSqlCommand("delete from[InterventionBrowseBranch]");
                db.Database.ExecuteSqlCommand("delete from[ConditionMesh]");
                db.Database.ExecuteSqlCommand("delete from[ConditionList]");
                db.Database.ExecuteSqlCommand("delete from[InterventionMeshList]");
                db.Database.ExecuteSqlCommand("delete from[PhaseList]");
                Console.WriteLine("deleting from phase list..");
                db.Database.ExecuteSqlCommand("delete from[InterventionAncestor]");
                db.Database.ExecuteSqlCommand("delete from[InterventionAncestorList]");
                db.Database.ExecuteSqlCommand("delete from[OrgStudyIdInfo]");
                db.Database.ExecuteSqlCommand("delete from[Organization]");
                db.Database.ExecuteSqlCommand("delete from[Location]");
                db.Database.ExecuteSqlCommand("delete from[DesignMaskingInfo]");
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
                db.Database.ExecuteSqlCommand("delete from[ExpandedAccessInfo]");
                db.Database.ExecuteSqlCommand("delete from[InterventionBrowseLeafList]");
                db.Database.ExecuteSqlCommand("delete from[SecondaryIdInfoList]");
                db.Database.ExecuteSqlCommand("delete from[StdAgeList]");
                Console.WriteLine("deleting from post date..");
                db.Database.ExecuteSqlCommand("delete from[StudyFirstPostDateStruct]");
                db.Database.ExecuteSqlCommand("delete from[LastUpdatePostDateStruct]");
                db.Database.ExecuteSqlCommand("delete from[ConditionBrowseBranchList]");

                var modelNames = db.Model.GetEntityTypes();
                foreach (var modelName in modelNames)
                {
                    string tableName = modelName.Name.Split('.')[1];
                    if (tableName.Equals("Root"))
                    {
                        tableName = "Studies";
                    }
                    else if (tableName.Equals("Tag") || tableName.Equals("TagList") || tableName.Equals("__EFMigrationsHistory") || tableName.Equals("StatisticsSearch"))
                    {
                        continue;
                    }
                    //db.Database.ExecuteSqlCommand("delete from[" + tableName +"]");
                    db.Database.ExecuteSqlCommand("DBCC CHECKIDENT([" + tableName + "], RESEED, 0)");
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

                /*DeleteOldDb();

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
                context.SaveChanges();*/
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
