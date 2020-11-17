using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Context;
using Newtonsoft.Json;
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
using System.Globalization;

namespace CsvExporter
{
    class Program
    {
        static List<Root> studies = new List<Root>();

        static void Main(string[] args)
        {
            string[] directories = Directory.GetDirectories(@"C:\GitCode\ClinicalTrials\Data2");

            foreach (string dir in directories)
            {
                string[] fileEntries = Directory.GetFiles(dir);
                foreach (string fileName in fileEntries)
                {
                    Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(File.ReadAllText(fileName));
                    studies.Add(myDeserializedClass);
                }
            }
            Console.WriteLine("as");

            List<StudyCsv> csvs = new List<StudyCsv>();
            foreach (Root r in studies)
            {
                StudyCsv csv = new StudyCsv();
                csv.Id = "" + r.FullStudy?.Study?.ProtocolSection?.IdentificationModule?.NCTId;
                csv.Date1 = "" + r.FullStudy?.Study?.ProtocolSection?.OversightModule?.IsFDARegulatedDevice;
                csv.Name = "" + r.FullStudy?.Study?.ProtocolSection?.IdentificationModule?.NCTId;
                csvs.Add(csv);
            }

            using (var writer = new StreamWriter(@"C:\GitCode\ClinicalTirialsOut\test.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(csvs);
            }
        }
    }


    public class StudyCsv
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Date1 { get; set; }
        

    }
}
