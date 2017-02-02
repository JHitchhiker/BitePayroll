namespace BitePayroll.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contractor")]
    public partial class Contractor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contractor()
        {
            HDMs = new HashSet<HDM>();
            InvoiceTables = new HashSet<InvoiceTable>();
        }

        public int ID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Surname { get; set; }

        public double? Rate { get; set; }

        [Column("Basic Rate")]
        public double? Basic_Rate { get; set; }

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

        public int? Payroll { get; set; }

        [Column("Work Permit")]
        public bool? Work_Permit { get; set; }

        [Column("Daily rate")]
        public bool? Daily_rate { get; set; }

        [Column("Hourly rate")]
        public bool? Hourly_rate { get; set; }

        [Column("Standard margin")]
        public double? Standard_margin { get; set; }

        public double? overtimeMargin { get; set; }

        public bool? charity { get; set; }

        public double? InvoiceID { get; set; }

        [Column("Bite Employee")]
        public bool? Bite_Employee { get; set; }

        public bool? Working { get; set; }

        public bool? selfbilling { get; set; }

        public double? VATNUMBER { get; set; }

        [Column("Company Number")]
        public int? Company_Number { get; set; }

        [StringLength(50)]
        public string Address1 { get; set; }

        [StringLength(50)]
        public string Address2 { get; set; }

        [StringLength(50)]
        public string Address3 { get; set; }

        [StringLength(50)]
        public string Address4 { get; set; }

        [StringLength(50)]
        public string Companyname { get; set; }

        public int? ContractorTypeID { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public double? HolidayPay { get; set; }

        public virtual Company Company1 { get; set; }

        public virtual ContractorType ContractorType { get; set; }

        public virtual Payroll Payroll1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HDM> HDMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceTable> InvoiceTables { get; set; }
    }
}
