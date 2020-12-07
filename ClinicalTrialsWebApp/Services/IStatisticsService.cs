using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Services
{
    public interface IStatisticsService
    {
        string getRegression();
        string RunRScript(string rpath, string scriptpath);
    }
}
