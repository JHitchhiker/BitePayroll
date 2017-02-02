using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitePayroll.Data
{
    public class ContractorRepository
    {
        BiteConsulting _context;

        public ContractorRepository()
        {
            _context = new BiteConsulting();
        }

        public List<Contractor> Get()
        {
            return _context.Contractors.ToList();
        }
            
        public Contractor GetById(int id)
        {
            return _context.Contractors
                           .Where(e => e.ID == id)
                           .FirstOrDefault();
        }
        public void Create(Contractor model)
        {
            _context.Contractors.Add(model);
            _context.SaveChanges();
        }
    }
}
