using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitePayroll.Data
{
    public class HDMQuery1
    {
        public int HDM { get; set; }
        public int ContractorId { get; set; }
        public double? Week1 { get; set; }
        public double? Week2 { get; set; }
        public double? Week3 { get; set; }
        public double? Week4 { get; set; }
        public double? Week5 { get; set; }
        public double? OWeek1 { get; set; }
        public double? OWeek2 { get; set; }
        public double? OWeek3 { get; set; }
        public double? OWeek4 { get; set; }
        public double? OWeek5 { get; set; }
        public int Month { get; set; }
        public double? Rate { get; set; }
        public double? Week1Rate { get; set; }
        public double? Week2Rate { get; set; }
        public double? Week3Rate { get; set; }
        public double? Week4rate { get; set; }
        public double? Week5rate { get; set; }
        public double? Oweekrate { get; set; }
        public double? oweek2rate { get; set; }
        public double? oweek3rate { get; set; }
        public double? oweek4rate { get; set; }
        public double? oweek5rate { get; set; }
        public double? OvertimeRate { get; set; }
        public double? Total { get; set; }
        public bool dailyrate1 { get; set; }
        public bool dailyrate2 { get; set; }
        public bool dailyrate3 { get; set; }
        public bool dailyrate4 { get; set; }
        public bool dailyrate5 { get; set; }
        public bool hourlyrate1 { get; set; }
        public bool hourlyrate2 { get; set; }
        public bool hourlyrate3 { get; set; }
        public bool hourlyrate4 { get; set; }
        public bool hourlyrate5 { get; set; }
        public bool Dailyrate { get; set; }
        public bool Hourlyrate { get; set; }
        public double? daysworked { get; set; }
        public double? hoursworked { get; set; }
        public bool CalculateHDM { get; set; }
        public double? Overtimeworked { get; set; }
        public string CommentsHDM { get; set; }
        public int Year { get; set; }
        public double? Week1PayRate { get; set; }
        public double? Week2PayRate { get; set; }
        public double? Week3PayRate { get; set; }
        public double? Week4PayRate { get; set; }
        public double? Week5PayRate { get; set; }
        public double? OWeek1PayRate { get; set; }
        public double? OWeek2PayRate { get; set; }
        public double? OWeek3PayRate { get; set; }
        public double? OWeek4PayRate { get; set; }
        public double? OWeek5PayRate { get; set; }
        public double? Standardmargin { get; set; }
        public double? overtimeMargin { get; set; }
        public double? TotalExpenses { get; set; }
        public double? ClientExpenses { get; set; }
        public double? Holdmargin { get; set; }
        public double? Advance { get; set; }
    }
}
