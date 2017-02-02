namespace BitePayroll.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContractorTemp")]
    public partial class ContractorTemp
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Surname { get; set; }

        public double? Rate { get; set; }

        [Column("Overtime Rate")]
        public double? Overtime_Rate { get; set; }

        public int? Company { get; set; }

        [StringLength(255)]
        public string Agency { get; set; }

        [StringLength(255)]
        public string Agency2 { get; set; }

        public double? Number { get; set; }

        [StringLength(255)]
        public string Info { get; set; }

        [Column("Time sheet submitted")]
        [StringLength(255)]
        public string Time_sheet_submitted { get; set; }

        [Column("Contract End")]
        [StringLength(255)]
        public string Contract_End { get; set; }

        public int? Payroll { get; set; }

        [Column("Work Permit")]
        public bool? Work_Permit { get; set; }

        [Column("Daily Rate")]
        public bool? Daily_Rate { get; set; }

        [Column("Hourly Rate")]
        public bool? Hourly_Rate { get; set; }

        [Column("Standard Margin")]
        public double? Standard_Margin { get; set; }

        public double? OvertimeMargin { get; set; }

        public bool? Charity { get; set; }

        public int? InvoiceID { get; set; }
    }
}
