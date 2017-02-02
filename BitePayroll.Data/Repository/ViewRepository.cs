using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitePayroll.Data
{
    public class ViewRepository
    {
        BiteConsulting _context;

        public ViewRepository()
        {
            _context = new BiteConsulting();
        }

        public List<Not_Working> GetNotWorking()
        {
            return _context.Database
                           .SqlQuery<Not_Working>("sp_NotWorking")
                           .ToList();
            
        }
        public List<ContractorTotalHours> ContractorTotalHours()
        {
            return _context.Database
                           .SqlQuery<ContractorTotalHours>("sp_Contractor_Total_Hours")
                           .ToList();

        }
        public List<ContractorTimeSheetMonths> ContractTimeSheetMonths()
        {
            return _context.Database
                           .SqlQuery<ContractorTimeSheetMonths>("sp_ContractorTimeSheetMonths")
                           .ToList();

        }

        public List<HDMQuery1> HDMQuery1()
        {
            return _context.Database
                           .SqlQuery<HDMQuery1>("sp_HDMQuery1")
                           .ToList();

        }

        public List<MainSheetQuery> MainSheetQuery()
        {
            return _context.Database
                           .SqlQuery<MainSheetQuery>("sp_MainSheetQuery")
                           .ToList();
        }
        public List<ContractDetail> ContractorDetails()
        {
            return _context.Database
                           .SqlQuery<ContractDetail>("sp_ContractorDetails")
                           .ToList();
        }
    }
}
