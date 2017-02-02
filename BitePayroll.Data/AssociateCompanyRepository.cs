using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitePayroll.Data
{
    public class AssociateCompanyRepository
    {
        BiteConsulting _context;

        public AssociateCompanyRepository()
        {
            _context = new BiteConsulting();
        }

        public List<Company> Get()
        {
            return _context.Companies.ToList();
        }

        public Company GetById(int id)
        {
            return _context.Companies
                           .Where(e => e.Company1 == id)
                           .FirstOrDefault();
        }
    }
}
