using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitePayroll.Data
{
    public class MainSheetQuery
    {
        public int HDM { get; set; }
        public string ContractorName { get; set; }
        public string Surname { get; set; }
        public int Month { get; set; }
        public double daysworked { get; set; }
        public double hoursworked { get; set; }
        public double Overtimeworked { get; set; }
        public double Total { get; set; }
        public double Days_Worked { get; set; }
        public double Hours_Worked { get; set; }
        public double Overtime_Worked { get; set; }
        public double ExtraPayment { get; set; }
        public double InvoiceNet { get; set; }
        public double Vat { get; set; }
        public double Fin { get; set; }
        public double GrossMargin { get; set; }
        public double Consultmargin { get; set; }
        public bool Overide { get; set; }
        public string MonthName { get; set; }
        public double Standardmargin { get; set; }
        public double overtimeMargin { get; set; }
        public bool charity { get; set; }
        public string Info { get; set; }
        public double Xtramargin { get; set; }
        public double Margin { get; set; }
        public double Holdmargin { get; set; }
        public bool CalculateMain { get; set; }
        public int Subs { get; set; }
        public int SubRepayment { get; set; }
        
        public bool Report { get; set; }
        public double TotalExpenses { get; set; }
        public int ContractorTypeID { get; set; }
        public int ContractorId { get; set; }

    }
}
