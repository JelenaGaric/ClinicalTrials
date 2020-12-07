using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R
{
    class Program
    {
        static void Main(string[] args)
        {
            var rpath = @"C:\Program Files\R\R-4.0.3\bin\Rscript.exe";
            var scriptpath = @"C:\Users\Dedo iz Njemačke\Source\Repos\ClinicalTrials\R\a.R";
            var output = RunRScript(rpath, scriptpath);

            Console.WriteLine(output);
            Console.ReadLine();
          
        }

        private static string RunRScript(string rpath, string scriptpath)
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
