using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Services
{
    public class StatisticsService : IStatisticsService
    {
        public string getRegression()
        {
            var rpath = @"C:\Program Files\R\R-4.0.3\bin\Rscript.exe";
            var scriptpath = Path.Combine(Directory.GetCurrentDirectory(), "studyTypeRegression.R");
            //var scriptpath1 = @"C:\Users\Dedo iz Njemačke\Source\Repos\ClinicalTrials\ClinicalTrialsWebApp\studyTypeRegression.R";
            var output = RunRScript(rpath, scriptpath);
            return "ok";
        }
        public string RunRScript(string rpath, string scriptpath)
        {
            try
            {
                var info = new ProcessStartInfo
                {
                    FileName = rpath,
                    WorkingDirectory = Path.GetDirectoryName(scriptpath),
                    Arguments = Path.GetFileName(scriptpath),
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                };

                using (var proc = new Process { StartInfo = info })
                {
                    proc.Start();
                    return proc.StandardOutput.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return string.Empty;
        }

       
    }
}
