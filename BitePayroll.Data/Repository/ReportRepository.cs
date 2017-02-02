using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitePayroll.Data
{
    public class ReportRepository
    {
        BiteConsulting _context = new BiteConsulting();
        public DataTable MainReport(int month)
        {

            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(_context.Database.Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_MainReport", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@Month", month));
                    adapter.Fill(ds);
                }
            }
            return ds.Tables[0];
        }

        public DataTable TotalReport(int month)
        {

            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(_context.Database.Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TotalReport", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@Month", month));
                    adapter.Fill(ds);
                }
            }
            return ds.Tables[0];
        }

        public DataTable ContractorHoursWorked(int contractor)
        {

            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(_context.Database.Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ContractorHoursWorked", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@Contractor", contractor));
                    adapter.Fill(ds);
                }
            }
            return ds.Tables[0];
        }

        public DataSet PayrollRates()
        {
            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(_context.Database.Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_PayrollRates", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.Fill(ds,"Payroll");
                    cmd.CommandText = "sp_PayrollRates_SelfBilling";
                    adapter.Fill(ds, "SelfBilling");
                }
            }
            return ds;
        }

        public DataTable EmployeeHours(int month)
        {
            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(_context.Database.Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_EmployeeHours", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@Month", month));
                    adapter.Fill(ds);
                }
            }
            return ds.Tables[0];
        }
        public DataTable ContractorMonthlyReport(int month)
        {
            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(_context.Database.Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ContractorMonthlyReports", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@Month", month));
                    adapter.Fill(ds);
                }
            }
            return ds.Tables[0];
        }
        public DataTable ContractorMonthlyReportSelfBilling(int month,int vatrate)
        {
            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(_context.Database.Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ContractorMonthlyReports_SelfBilling", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@Month", month));
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@Vat", vatrate));
                    adapter.Fill(ds);
                }
            }
            return ds.Tables[0];
        }

        public DataTable CXCReport(int month)
        {
            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(_context.Database.Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_CXCReport", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@Month", month));
                    adapter.Fill(ds);
                }
            }
            return ds.Tables[0];
        }

        public DataTable BitePayroll(int month)
        {
            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(_context.Database.Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_BitePayroll", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@Month", month));
                    adapter.Fill(ds);
                }
            }
            return ds.Tables[0];
        }
    }
}
