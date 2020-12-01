using ClinicalTrialsWebApp.DTO;
using ExcelDataReader;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Context;
using Newtonsoft.Json;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClinicalTrialsWebApp.Repository
{
    public class StatisticsSearchRepository : RepositoryBase<StatisticsSearch>, IStatisticsSearchRepository
    {
        public StatisticsSearchRepository(ClinicalTrialsContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<StatisticsSearch>> GetAllStatisticsSearchesAsync()
        {
            return await FindAll()
                .OrderBy(s => s.Id)
                .ToListAsync();
        }

        public async Task<StatisticsSearch> GetStatisticsSearchByIdAsync(int Id)
        {
            return await FindByCondition(s => s.Id.Equals(Id))
                 .FirstOrDefaultAsync();
        }

        public string TrialsByYearsStatistics()
        {
            return ExecuteCommand("SELECT * from TRIALS_BY_YEAR_WITH_MESH_TERM ORDER BY NUM DESC FOR JSON AUTO;");
        }

        public string StudyTypeStatistics()
        {
            return ExecuteCommand("SELECT * FROM STUDY_TYPE_NUM_WITH_MESH_TERM ORDER BY NUM DESC FOR JSON AUTO");
        }

        public string StatusStatistics()
        {
            return ExecuteCommand("SELECT * FROM OVERALL_STATUS_WITH_MESH_TERM ORDER BY NUM DESC FOR JSON AUTO;");
        }

        public string PhaseListStatistics()
        {
            return ExecuteCommand("SELECT * FROM PHASE_WITH_MESH_TERM ORDER BY NUM DESC FOR JSON AUTO;");
        }
        public string CountryStatistics(SearchDTO searchDTO)
        {
            //return ExecuteCommand("SELECT * FROM COUNTRY_WITH_MESH_TERM ORDER BY NUM DESC FOR JSON AUTO;");
            return ExecuteCommand("SELECT * FROM [dbo].[GetCountriesForTerm] ('" + searchDTO.Condition + "')  FOR JSON AUTO;");

        }

        public string LocationFromViewStatistics()
        {
            /*var path = Path.Combine(Directory.GetCurrentDirectory(), "..\\allCoordinates.xlsx");
            try
            {
                fillCityCoordinatesTable(path);
                return "ok";
            }catch(Exception e)
            {
                return e.Message;
            }*/
            return ExecuteCommand("SELECT * FROM LOCATION_WITH_MESH_TERM ORDER BY NUM DESC FOR JSON AUTO;");
            
            /*string sql = "SELECT * FROM LOCATION_WITH_MESH_TERM ORDER BY NUM DESC;";

            SqlConnection con = new SqlConnection(RepositoryContext.Database.GetDbConnection().ConnectionString);

            con.Open();

            SqlCommand objCMD = new SqlCommand(sql, con);

            SqlDataAdapter myAdapter = new SqlDataAdapter();
            myAdapter.SelectCommand = objCMD;

            DataSet myDataSet = new DataSet();
            myAdapter.Fill(myDataSet);
            DataTable dt = myDataSet.Tables[0];


            //var path = Path.Combine(Directory.GetCurrentDirectory(), "..\\allCoordinates.xlsx");
            //string backupPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\worldcities.xlsx");

            //dt = ExtractCoordinatesFromFile(dt, path, backupPath);


            return DataTableToJSONWithJSONNet(dt);*/
        }

        public string LocationStatistics(SearchDTO searchDTO)
        {
            
            return ExecuteCommand("SELECT * FROM [dbo].[GetCoordinatesForTerm] ('" + searchDTO.Condition + "')  FOR JSON AUTO;");
           
        }

        public DataTable ExtractCoordinatesFromFile(DataTable dt, string path, string backupPath)
        {
            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx, *.xlsb)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    var result = reader.AsDataSet();
                    // The result of each spreadsheet is in result.Tables

                    DataTable myDataTable = result.Tables[0];
                    myDataTable.Rows[0].Delete();
                    myDataTable.TableName = "CityCoordinates";
                    //add new coordinates column to return dataset value
                   
                    /*DataColumn coordinatesColumn = new DataColumn();
                     string columnName = "Column0";

                    coordinatesColumn.DataType = Type.GetType("System.String");
                    coordinatesColumn.ColumnName = "Coordinates";
                    dt.Columns.Add(coordinatesColumn);*/
                    

                    /*foreach (DataRow row in dt.Rows)
                    {
                        var r = myDataTable.Select(string.Format("{0} LIKE '%{1}%'", columnName, row["LocationCity"]));
                        // if there are more similiar occurences select only one exact
                        if (r.Length > 1)
                        {
                            r = myDataTable.Select(string.Format("{0} = '{1}'", columnName, row["LocationCity"]));
                        }
                        //set the read coordinates value from xlsx file to return dataset value 
                        string locationCity = (string)r[0]["Column0"];

                        double lat = (double)r[0]["Column1"];

                        double lng = (double)r[0]["Column2"];

                        CityCoordinates city = new CityCoordinates();
                        city.LocationCity = locationCity;
                        city.lat = lat;
                        city.lng = lng;
                        //read the coordinates for the given city from xlsx file
                        /*try
                        {
                            var r = myDataTable.Select(string.Format("{0} LIKE '%{1}%'", columnName, row["LocationCity"]));
                            //set the read coordinates value from xlsx file to return dataset value 
                            row["Coordinates"] = r[0]["Column1"];
                        }
                        catch (Exception e)
                        {
                            if (backupPath != null)
                            {
                                using (var stream1 = File.Open(backupPath, FileMode.Open, FileAccess.Read))
                                {
                                    using (var reader1 = ExcelReaderFactory.CreateReader(stream1))
                                    {
                                        try
                                        {

                                            var result1 = reader1.AsDataSet();
                                            DataTable myDataTable1 = result1.Tables[0];
                                            string lat = (from DataRow dr in myDataTable1.Rows
                                                          where (string)dr[columnName] == row["LocationCity"]
                                                          select (string)dr["Column2"]).FirstOrDefault();
                                            string lng = (from DataRow dr in myDataTable1.Rows
                                                          where (string)dr[columnName] == row["LocationCity"]
                                                          select (string)dr["Column3"]).FirstOrDefault();
                                            //var r1 = myDataTable1.Select(string.Format("{0} LIKE '%{1}%'", columnName, row["LocationCity"]));
                                            if (lat == null || lng == null)
                                                continue;
                                            else
                                                row["Coordinates"] = "{" + lat + "," + lng + "}";
                                        } catch (Exception ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                            continue;
                                        }
                                    }
                                }
                            } else
                            {
                                Console.WriteLine($"Something went wrong inside LocationStatistics Repository action: {e.Message}");
                                continue;
                            }
                        }

                    }*/

                    return dt;

                }
            }
        }

        public void fillCityCoordinatesTable(string path)
        {
            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    var result = reader.AsDataSet();

                    DataTable myDataTable = result.Tables[0];
                    myDataTable.Rows[0].Delete();
                    myDataTable.TableName = "CityCoordinates";

                    SqlConnection con = new SqlConnection(RepositoryContext.Database.GetDbConnection().ConnectionString);
                    con.Open();

                    SqlBulkCopy bulkCopy = new SqlBulkCopy(con);
                    bulkCopy.DestinationTableName = myDataTable.TableName;
                    // Set up the column mappings by name.
                    SqlBulkCopyColumnMapping locationCity =
                        new SqlBulkCopyColumnMapping("Column0", "LocationCity");
                    bulkCopy.ColumnMappings.Add(locationCity);

                    SqlBulkCopyColumnMapping mapName =
                        new SqlBulkCopyColumnMapping("Column1", "lat");
                    bulkCopy.ColumnMappings.Add(mapName);

                    SqlBulkCopyColumnMapping lng =
                        new SqlBulkCopyColumnMapping("Column2", "lng");
                    bulkCopy.ColumnMappings.Add(lng);
                    try
                    {
                        bulkCopy.WriteToServer(myDataTable);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    con.Close();

                    Console.WriteLine("inserted dt");
                }
            }
        }

        public string DataTableToJSONWithJSONNet(DataTable table)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }

        public string SponsorStatistics()
        {
            return ExecuteCommand("SELECT * FROM SPONSOR_WITH_MESH_TERM ORDER BY NUM DESC FOR JSON AUTO;");
        }

        public string DurationStatistics()
        {
            return ExecuteCommand("SELECT * FROM DURATION_WITH_MESH_TERM ORDER BY NUM DESC FOR JSON AUTO;");
        }

        public HttpClient client = new HttpClient();

        //method for filling the xlsx file because google geoencoding api limits to only 3000 requests per minute, and one location request for map statistics can have more
        public async Task<string> GetLocationCitiesAsync()
        {
            //return ExecuteCommand("SELECT * FROM LOCATION_CITY ORDER BY [LocationCity] OFFSET 11000 ROWS FETCH NEXT 1000 ROWS ONLY FOR JSON AUTO;");
            
            //Create the data set and table
            DataSet ds = new DataSet("New_DataSet");
            DataTable dt = new DataTable("New_DataTable");

            //Set the locale for each
            ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
            dt.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;

            //Open a DB connection (in this example with OleDB)
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SUEUN9H\SQLEXPRESS;Initial Catalog=ClinicalTrials;Integrated Security=True");
            con.Open();

            //Create a query and fill the data table with the data from the DB
            string sql = "select * from LOCATION_CITY WHERE [LocationCity] IS NOT NULL;";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adptr = new SqlDataAdapter();

            adptr.SelectCommand = cmd;
            adptr.Fill(dt);
            con.Close();

            // Create new DataTable and DataSource objects.
            DataTable table = new DataTable();

            // Declare DataColumn and DataRow variables.
            DataColumn cityColumn;
            DataColumn coordinatesColumn;
            DataRow row;

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.

            cityColumn = new DataColumn();
            cityColumn.DataType = Type.GetType("System.String");
            cityColumn.ColumnName = "LocationCity";
            table.Columns.Add(cityColumn);

            coordinatesColumn = new DataColumn();
            coordinatesColumn.DataType = Type.GetType("System.String");
            coordinatesColumn.ColumnName = "Coordinates";
            table.Columns.Add(coordinatesColumn);

            string apiKey = "AIzaSyBjC5xykhdXPNmyv3ffc7JXWzzrHteQlrA";

            // Create new DataRow objects and add to DataTable.
            for (int i = 9999; i < 11412; i++)
            {
                row = table.NewRow();
                row["LocationCity"] = dt.Rows[i].Field<string>("LocationCity");


                string address = dt.Rows[i].Field<string>("LocationCity");
                string requestUri = string.Format("https://maps.googleapis.com/maps/api/geocode/xml?key={1}&address={0}&sensor=false", Uri.EscapeDataString(address), apiKey);

                WebRequest request = WebRequest.Create(requestUri);
                WebResponse response = request.GetResponse();

                XDocument xdoc = XDocument.Load(response.GetResponseStream());
                try
                {
                    XElement result = xdoc.Element("GeocodeResponse").Element("result");
                    XElement locationElement = result.Element("geometry").Element("location");
                    XElement lat = locationElement.Element("lat");
                    XElement lng = locationElement.Element("lng");
                    Console.WriteLine(i + " " + result.Value.ToString());
               
                    row["Coordinates"] = string.Format(lat.Value.ToString() + "," + lng.Value.ToString());
                    table.Rows.Add(row);
                } catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }

            /*foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine( row["LocationCity"].ToString());
            }*/

            
            

            /*if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Product>();
            }*/

            //Add the table to the data set
            ds.Tables.Add(table);

            //Here's the easy part. Create the Excel worksheet from the data set
            ExcelLibrary.DataSetHelper.CreateWorkbook("MyExcelFile910.xls", ds);
            return "ok";
        }

        public string InterventionalStudiesStatistics()
        {
            return ExecuteCommand("SELECT * from INTERVENTIONAL_STUDIES_YEAR FOR JSON AUTO;");
        }

        public string ExecuteCommand(string sql)
        {
            using (var command = RepositoryContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                RepositoryContext.Database.OpenConnection();
                command.CommandTimeout = 120;
                command.Prepare();

                using (var result = command.ExecuteReader())
                {
                    string retVal = "";
                    while (result.Read())
                    {
                        retVal += result.GetString(0);
                    }

                    return retVal;
                }
            }
        }
    }
}
