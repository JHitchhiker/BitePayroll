namespace BitePayroll.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GabemTemp")]
    public partial class GabemTemp
    {
        [Key]
        public int GabemID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        public int? Number { get; set; }

        public int? ContractorID { get; set; }

        public double? Hours { get; set; }

        public double? Rate { get; set; }

        public double? Expenses { get; set; }
    }
}
