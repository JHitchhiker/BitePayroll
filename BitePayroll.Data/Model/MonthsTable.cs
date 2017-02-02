namespace BitePayroll.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonthsTable")]
    public partial class MonthsTable
    {
        [Key]
        public int Monthid { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
