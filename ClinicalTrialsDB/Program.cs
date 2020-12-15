using Microsoft.EntityFrameworkCore;
using Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrialsWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp(); 
        }

        private static void RunApp()
        {
            string input;
            do
            {
                Console.WriteLine("Clear database and insert new data? (y/n)");
                input = Console.ReadLine();
                if (input.Equals("y", StringComparison.OrdinalIgnoreCase))
                    DBPreparation.WriteToDB();
                    //DBPreparation.WriteToDBJSON();
                else if (input.Equals("n", StringComparison.OrdinalIgnoreCase))
                    return;
            } while (!input.Equals("y", StringComparison.OrdinalIgnoreCase) || !input.Equals("n", StringComparison.OrdinalIgnoreCase));

        }
    }
}
