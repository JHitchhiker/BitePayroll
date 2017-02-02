using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitePayroll.Data
{
    public class LookupRepository
    {
        BiteConsulting _context;

        public LookupRepository()
        {
            _context = new BiteConsulting();
        }

        public List<Company> GetCompanies()
        {
            return _context.Companies.ToList();
        }

        public List<Invoice> GetInvoices()
        {
            return _context.Invoices.ToList();
        }

        public List<Payroll> GetPayrolls()
        {
            return _context.Payrolls.ToList();
        }

        public List<VatRate> GetVatRates()
        {
            return _context.VatRates.ToList();
        }
        public List<ContractorType> GetContractorTypes()
        {
            return _context.ContractorTypes.ToList();
        }
        public List<Contractor> GetContractors()
        {
            return _context.Contractors.ToList();
        }

        public List<Month> GetMonths()
        {
            return _context.Months.ToList();
        }

        public HDM GetHDM(int index)
        {
            return _context.HDMs.Where(e => e.HDM1 == index).FirstOrDefault();
        }
    }
}
