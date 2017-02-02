namespace BitePayroll.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HDM")]
    public partial class HDM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HDM()
        {
        }

        [Key]
        [Column("HDM")]
        public int HDM1 { get; set; }

        public int? ContractorId { get; set; }

        public double? Week1 { get; set; }

        public double? Week2 { get; set; }

        public double? Week3 { get; set; }

        public double? Week4 { get; set; }

        public double? Week5 { get; set; }

        [Column("O-Week1")]
        public double? O_Week1 { get; set; }

        [Column("O-Week2")]
        public double? O_Week2 { get; set; }

        [Column("O-Week3")]
        public double? O_Week3 { get; set; }

        [Column("O-Week4")]
        public double? O_Week4 { get; set; }

        [Column("O-Week5")]
        public double? O_Week5 { get; set; }

        public int? Month { get; set; }

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

        public double? Total { get; set; }

        public bool? dailyrate1 { get; set; }

        public bool? dailyrate2 { get; set; }

        public bool? dailyrate3 { get; set; }

        public bool? dailyrate4 { get; set; }

        public bool? dailyrate5 { get; set; }

        public bool? hourlyrate1 { get; set; }

        public bool? hourlyrate2 { get; set; }

        public bool? hourlyrate3 { get; set; }

        public bool? hourlyrate4 { get; set; }

        public bool? hourlyrate5 { get; set; }

        public double? daysworked { get; set; }

        public double? hoursworked { get; set; }

        [Column("Calculate HDM")]
        public bool? Calculate_HDM { get; set; }

        public double? Overtimeworked { get; set; }

        public double? ExtraPayment { get; set; }

        public double? InvoiceNet { get; set; }

        public bool? Charity { get; set; }

        public double? Vat { get; set; }

        [Column("2%Fin")]
        public double? C2_Fin { get; set; }

        public double? GrossMargin { get; set; }

        public double? Consultmargin { get; set; }

        public bool? Overide { get; set; }

        [StringLength(70)]
        public string Info { get; set; }

        public double? Xtramargin { get; set; }

        public double? Holdmargin { get; set; }

        [Column("Comments-HDM")]
        [StringLength(50)]
        public string Comments_HDM { get; set; }

        [Column("Calculate Main")]
        public bool? Calculate_Main { get; set; }

        public double? NIpaid { get; set; }

        [Column("Total Expenses")]
        public double? Total_Expenses { get; set; }

        public double? BasicPay { get; set; }

        public double? Dividence { get; set; }

        public double? CorporationTax { get; set; }

        public double? AdminBonus { get; set; }

        public double? Bonus { get; set; }

        public int? Subs { get; set; }

        [Column("Sub Repayment")]
        public int? Sub_Repayment { get; set; }

        public bool? Report { get; set; }

        public int? Year { get; set; }

        public double? Week1PayRate { get; set; }

        public double? Week2PayRate { get; set; }

        public double? Week3PayRate { get; set; }

        public double? Week4PayRate { get; set; }

        public double? Week5PayRate { get; set; }

        [Column("0Week1PayRate")]
        public double? C0Week1PayRate { get; set; }

        [Column("0Week2PayRate")]
        public double? C0Week2PayRate { get; set; }

        [Column("0Week3PayRate")]
        public double? C0Week3PayRate { get; set; }

        [Column("0Week4PayRate")]
        public double? C0Week4PayRate { get; set; }

        [Column("0Week5PayRate")]
        public double? C0Week5PayRate { get; set; }

        public double? ClientExpenses { get; set; }

        public double? BasicPayNew { get; set; }

        public double? Advance { get; set; }

        public virtual Contractor Contractor { get; set; }

        public virtual Month Month1 { get; set; }

    }
}
