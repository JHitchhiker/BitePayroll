namespace BitePayroll.Data
{
    using System.Data.Entity;

    public partial class BiteConsulting : DbContext
    {
        public BiteConsulting()
            : base("name=BiteConsulting")
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Contractor> Contractors { get; set; }
        public virtual DbSet<Contractor2> Contractor2 { get; set; }
        public virtual DbSet<ContractorTemp> ContractorTemps { get; set; }
        public virtual DbSet<ContractorType> ContractorTypes { get; set; }
        public virtual DbSet<GabemReport> GabemReports { get; set; }
        public virtual DbSet<GabemTemp> GabemTemps { get; set; }
        public virtual DbSet<HDM> HDMs { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceTable> InvoiceTables { get; set; }
        public virtual DbSet<Month> Months { get; set; }
        public virtual DbSet<MonthsTable> MonthsTables { get; set; }
        public virtual DbSet<Payroll> Payrolls { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<VatRate> VatRates { get; set; }
        public virtual DbSet<Invoicetemp> Invoicetemps { get; set; }

        public virtual DbSet<Not_Working> NotWorkings { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasMany(e => e.Contractors)
                .WithOptional(e => e.Company1)
                .HasForeignKey(e => e.Company);
            
            modelBuilder.Entity<Month>()
                .HasMany(e => e.HDMs)
                .WithOptional(e => e.Month1)
                .HasForeignKey(e => e.Month);

            modelBuilder.Entity<Month>()
                .HasMany(e => e.InvoiceTables)
                .WithOptional(e => e.Month)
                .HasForeignKey(e => e.DateID);

            modelBuilder.Entity<Payroll>()
                .HasMany(e => e.Contractors)
                .WithOptional(e => e.Payroll1)
                .HasForeignKey(e => e.Payroll);

            AddViewKeys(modelBuilder);
        }

        private void AddViewKeys(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Not_Working>().HasKey(x => new { x.Name, x.Surname, x.Month});
        }
    }
}
