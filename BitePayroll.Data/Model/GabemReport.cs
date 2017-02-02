namespace BitePayroll.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GabemReport")]
    public partial class GabemReport
    {
        [Key]
        [Column(Order = 0)]
        public int GabemID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContractorID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        public double? Hrs1 { get; set; }

        public double? Rate1 { get; set; }

        public double? Hrs2 { get; set; }

        public double? Rate2 { get; set; }

        public double? Hrs3 { get; set; }

        public double? Rate3 { get; set; }

        public double? Hrs4 { get; set; }

        public double? Rate4 { get; set; }

        public double? Hrs5 { get; set; }

        public double? Rate5 { get; set; }

        public double? Deductions { get; set; }

        public double? Expenses { get; set; }

        public double? Totalhours { get; set; }

        public double? Worktotal { get; set; }

        public double? VAT { get; set; }

        public double? Invoicetotal { get; set; }
    }
}
