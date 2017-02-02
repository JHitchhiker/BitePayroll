using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitePayroll.Data
{
    public class ContractorTimeSheetMonths
    {
        public int ContractorId { get; set; }
        public int Month { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
}
