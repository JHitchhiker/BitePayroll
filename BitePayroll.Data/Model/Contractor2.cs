namespace BitePayroll.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contractor2
    {
        [Key]
        public int ID1 { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [Column("Company Rate")]
        public double? Company_Rate { get; set; }

        public double? OvertimeRate { get; set; }

        public double? Company { get; set; }

        [StringLength(255)]
        public string Agency { get; set; }

        [Column("Agency 2")]
        [StringLength(255)]
        public string Agency_2 { get; set; }

        [Column("Pay No")]
        public double? Pay_No { get; set; }

        [StringLength(255)]
        public string Info { get; set; }

        [Column("timesheet submitted")]
        [StringLength(255)]
        public string timesheet_submitted { get; set; }

        public double? Payroll { get; set; }

        [Column("Work Permit")]
        public bool? Work_Permit { get; set; }

        [Column("Daily rate")]
        public bool? Daily_rate { get; set; }

        [Column("Hourly rate")]
        public bool? Hourly_rate { get; set; }

        [Column("Standard margin")]
        public double? Standard_margin { get; set; }

        [Column("overtime margine")]
        public double? overtime_margine { get; set; }

        public bool? charity { get; set; }
    }
}
