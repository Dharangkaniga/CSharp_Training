using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge__4.Code_2
{
    public class ReportFactory
    {
        public static IReportGenerator GetReport(string type)
        {
            if (type == "chart")
                return new ChartReport();

            else if (type == "tabular")
                return new TabularReport();

            else if (type == "summary")
                return new SummaryReport();

            else
                return null;
        }

    }
}
