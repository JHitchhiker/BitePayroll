using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitePayroll.Data
{
    public class ContractDetail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Week1 { get; set; }
        public double Week2 { get; set; }
        public double Week3 { get; set; }
        public double Week4 { get; set; }
        public double Week5 { get; set; }
        public double OWeek1 { get; set; }
        public double OWeek2 { get; set; }
        public double OWeek3 { get; set; }
        public double OWeek4 { get; set; }
        public double OWeek5 { get; set; }
        public int Month { get; set; }
        public double Week1Rate { get; set; }
        public double Week2Rate { get; set; }
        public double Week3Rate { get; set; }
        public double Week4rate { get; set; }
        public double Oweekrate { get; set; }
        public double oweek2rate { get; set; }
        public double oweek3rate { get; set; }
        public double oweek4rate { get; set; }
        public double oweek5rate { get; set; }
        public bool dailyrate1 { get; set; }
        public bool dailyrate2 { get; set; }
        public bool dailyrate3 { get; set; }
        public bool dailyrate4 { get; set; }
        public bool dailyrate5 { get; set; }
        public bool hourlyrate1 { get; set; }
        public bool hourlyrate2 { get; set; }
        public bool hourlyrate3 { get; set; }
        public bool hourlyrate4 { get; set; }
        public double daysworked { get; set; }
        public double days_worked { get; set; }
        public double hoursworked { get; set; }
        public double Total { get; set; }
        public int HDM { get; set; }
        public double Week5rate { get; set; }
        public bool hourlyrate5 { get; set; }

    }
}
