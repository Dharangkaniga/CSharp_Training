using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge__4.Code_2
{
    /* Report Generators. Let’s assume we have an analytics application allowing users to generate reports in different formats: 
     * Chart, Tabular, or Summary. Using the Factory Method pattern, 
     * instantiate the appropriate report generator based on the user’s selection*/
    public class InputFactory
    {
        static void Main(string[] args)
        {
            Console.Write("Enter report type : ");
            string choice = Console.ReadLine().ToLower();

            IReportGenerator report = ReportFactory.GetReport(choice); 
            if (report != null)
            {
                string result=report.Generate();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("!!! INVALID REPORT TYPE !!!");
            }

            Console.ReadLine();
        }

    }
}
