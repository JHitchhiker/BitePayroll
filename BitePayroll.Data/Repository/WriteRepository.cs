using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitePayroll.Data
{
    public class WriteRepository
    {
        BiteConsulting _context;
        public WriteRepository()
        {
            _context = new BiteConsulting();
        }
        public int InsertPayroll(Payroll model)
        {
            _context.Payrolls.Add(model);
            _context.SaveChanges();
             return model.PayrollId;
        }

        public void UpdatePayroll(int id, string name)
        {
            var model = _context.Payrolls.FirstOrDefault(e => e.PayrollId == id);
            _context.Entry(model).State = EntityState.Modified;
            model.Name = name;
            _context.SaveChanges();
        }

        public int InsertCompany(Company model)
        {
            _context.Companies.Add(model);
            _context.SaveChanges();
            return model.Company1;
        }

        public void UpdateCompany(Company model)
        {
            var company = _context.Companies.FirstOrDefault(e => e.Company1 == model.Company1);
            company.Name = model.Name;
            company.Description = model.Description;
            company.Margin = model.Margin;

            _context.Entry(company).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public int InsertVatRate(VatRate model)
        {
            _context.VatRates.Add(model);
            _context.SaveChanges();
            return model.ID;
        }

        public void UpdateVatRate(VatRate model)
        {
            var vatrate = _context.VatRates.FirstOrDefault(e => e.ID == model.ID);
            vatrate.Rate = model.Rate;
            vatrate.RateName = model.RateName;
            vatrate.StartDate = model.StartDate;
            vatrate.EndDate = model.EndDate;
            _context.Entry(vatrate).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public int InsertContractor(Contractor model)
        {
            _context.Contractors.Add(model);
            _context.SaveChanges();
            return model.ID;
        }

        public void UpdateContractor(Contractor model)
        {
            var contractor = _context.Contractors.FirstOrDefault(e => e.ID == model.ID);

            contractor.Name = model.Name;
            contractor.Surname = model.Surname;
            contractor.Rate = model.Rate;
            contractor.Overtime_Rate = model.Overtime_Rate;
            contractor.Agency = model.Agency;
            contractor.Agency2 = model.Agency2;
            contractor.Number = model.Number;
            contractor.Info = model.Info;
            contractor.Time_sheet_submitted = model.Time_sheet_submitted;
            contractor.Companyname = model.Companyname;
            contractor.Company_Number = model.Company_Number;
            contractor.Address1 = model.Address1;
            contractor.Address2 = model.Address2;
            contractor.Address3 = model.Address3;
            contractor.Address4 = model.Address4;
            contractor.Email = model.Email;
            contractor.Standard_margin = model.Standard_margin;
            contractor.overtimeMargin = model.overtimeMargin;
            contractor.Work_Permit = model.Work_Permit;
            contractor.charity = model.charity;
            contractor.Daily_rate = model.Daily_rate;
            contractor.Hourly_rate = model.Hourly_rate;
            contractor.selfbilling = model.selfbilling;
            contractor.Bite_Employee = model.Bite_Employee;
            contractor.InvoiceID = model.InvoiceID;
            contractor.ContractorTypeID = model.ContractorTypeID;
            contractor.Company = model.Company;
            contractor.Payroll = model.Payroll;

            _context.Entry(contractor).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void InsertHDM(HDM record)
        {
            _context.HDMs.Add(record);
            _context.SaveChanges();
        }

        public void UpdateHDM(HDM record)
        {
            var hdm = _context.HDMs.Where(e => e.HDM1 == record.HDM1).FirstOrDefault();

            hdm.Week1 = record.Week1;
            hdm.Week2 = record.Week2;
            hdm.Week3 = record.Week3;
            hdm.Week4 = record.Week4;
            hdm.Week5 = record.Week5;
            hdm.O_Week1 = record.O_Week1;
            hdm.O_Week2 = record.O_Week2;
            hdm.O_Week3 = record.O_Week3;
            hdm.O_Week4 = record.O_Week4;
            hdm.O_Week5 = record.O_Week5;
            hdm.Week1Rate = record.Week1Rate;
            hdm.Week2Rate = record.Week2Rate;
            hdm.Week3Rate = record.Week3Rate;
            hdm.Week4rate = record.Week4rate;
            hdm.Oweekrate = record.Oweekrate;
            hdm.oweek2rate = record.oweek2rate;
            hdm.oweek3rate = record.oweek3rate;
            hdm.oweek4rate = record.oweek4rate;
            hdm.oweek5rate = record.oweek5rate;
            hdm.dailyrate1 = record.dailyrate1;
            hdm.dailyrate2 = record.dailyrate2;
            hdm.dailyrate3 = record.dailyrate3;
            hdm.dailyrate4 = record.dailyrate4;
            hdm.dailyrate5 = record.dailyrate5;
            hdm.hourlyrate1 = record.hourlyrate1;
            hdm.hourlyrate2 = record.hourlyrate2;
            hdm.hourlyrate3 = record.hourlyrate3;
            hdm.hourlyrate4 = record.hourlyrate4;
            hdm.daysworked = record.daysworked;
            hdm.hoursworked = record.hoursworked;
            hdm.Overtimeworked = record.Overtimeworked;
            hdm.Total = record.Total;
            hdm.Week5rate = record.Week5rate;
            hdm.hourlyrate5 = record.hourlyrate5;

            hdm.InvoiceNet = record.InvoiceNet;
            hdm.Vat = record.Vat;
            hdm.C2_Fin = record.C2_Fin;

            hdm.Xtramargin = record.Xtramargin;
            hdm.Holdmargin = record.Holdmargin;
            hdm.GrossMargin = record.GrossMargin;
            hdm.Consultmargin = record.Consultmargin;
            hdm.AdminBonus = record.AdminBonus;

            _context.Entry(hdm).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }

   
}
