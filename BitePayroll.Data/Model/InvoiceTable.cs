namespace BitePayroll.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceTable")]
    public partial class InvoiceTable
    {
        [Key]
        public int InvoiceID { get; set; }

        public int? ContractorID { get; set; }

        public DateTime? Date { get; set; }

        public double? Unit { get; set; }

        [StringLength(50)]
        public string Rate { get; set; }

        public int? Amount { get; set; }

        public double? Vat { get; set; }

        public double? Invoicetotal { get; set; }

        public double? ClientExpenses { get; set; }

        public int? DateID { get; set; }

        public int? Ounit { get; set; }

        public double? Orate { get; set; }

        public virtual Contractor Contractor { get; set; }

        public virtual Month Month { get; set; }
    }
}
