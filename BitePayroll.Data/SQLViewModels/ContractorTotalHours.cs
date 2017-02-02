using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitePayroll.Data
{
    public class ContractorTotalHours
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double HoursWorked {get;set;}
        public double DaysWorked { get; set; }
        public double Total { get; set; }
    }
}
