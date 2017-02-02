using BitePayroll.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitePayroll
{
    public enum ReportSelector
    {
        AssociateReport,
        TotalReport,
        ContractorHoursWorked,
        PayrollRates,
        EmployeeHours,
        ContractorMonthlyReport,
        ContractorMonthlyReportSelfBilling,
        BitePayroll,
        BitePayrollExport
    }
    public partial class frmReportViewer : Form
    {
        public ReportSelector ReportView { get; set; }
        public bool Export { get; set; }

        public frmReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            SelectReport();
        }

        private void SelectReport()
        {
            ReportDataSource rds = new ReportDataSource();
            switch (ReportView)
            {
                case ReportSelector.AssociateReport:
                    {
                        var result = new ReportRepository().MainReport(GlobalValues.Instance.CurrentMonth);
                        reportViewer2.LocalReport.ReportEmbeddedResource = "BitePayroll.Reports.AssociateReport.rdlc";

                        rds.Value = result;
                        rds.Name = "MainReport";

                        break;
                    }
                case ReportSelector.TotalReport:
                    {
                        var result = new ReportRepository().TotalReport(GlobalValues.Instance.CurrentMonth);
                        reportViewer2.LocalReport.ReportEmbeddedResource = "BitePayroll.Reports.TotalReport.rdlc";

                        rds.Value = result;
                        rds.Name = "TotalHours";

                        break;
                    }
                case ReportSelector.ContractorHoursWorked:
                    {
                        var result = new ReportRepository().ContractorHoursWorked(GlobalValues.Instance.CurrentContractor);
                        reportViewer2.LocalReport.ReportEmbeddedResource = "BitePayroll.Reports.ContractorHoursWorked.rdlc";

                        rds.Value = result;
                        rds.Name = "ContractorHoursWorked";

                        break;
                    }
                case ReportSelector.PayrollRates:
                    {
                        var result = new ReportRepository().PayrollRates();
                        reportViewer2.LocalReport.ReportEmbeddedResource = "BitePayroll.Reports.PayrollRates.rdlc";

                        reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("Payroll", result.Tables["Payroll"]));
                        rds.Value = result.Tables["SelfBilling"];
                        rds.Name = "SelfBilling";

                        break;
                    }
                case ReportSelector.EmployeeHours:
                    {
                        var result = new ReportRepository().EmployeeHours(GlobalValues.Instance.CurrentMonth);
                        reportViewer2.LocalReport.ReportEmbeddedResource = "BitePayroll.Reports.EmployeeHours.rdlc";

                        rds.Value = result;
                        rds.Name = "EmployeeHours";

                        break;
                    }
                case ReportSelector.ContractorMonthlyReport:
                    {
                        ProcessInvoices();
                        break;
                    }
                case ReportSelector.ContractorMonthlyReportSelfBilling:
                    {
                        ProcessInvoicesSelfBilling();
                        break;
                    }
                case ReportSelector.BitePayroll:
                    {
                        var result = new ReportRepository().BitePayroll(GlobalValues.Instance.CurrentMonth);
                        reportViewer2.LocalReport.ReportEmbeddedResource = "BitePayroll.Reports.BitePayroll.rdlc";

                        rds.Value = result;
                        rds.Name = "BitePayroll";

                        break;
                    }
            }
            reportViewer2.LocalReport.DataSources.Add(rds);
            this.reportViewer2.RefreshReport();
        }

        private void ExportToFile(string filename)
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = reportViewer2.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);

            using (FileStream fs = new FileStream(@"c:\reports\"+filename, FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }

        private void ProcessInvoices()
        {
            reportViewer2.LocalReport.ReportEmbeddedResource = "BitePayroll.Reports.ContractorMonthlyReport.rdlc";

            var result = new ReportRepository().ContractorMonthlyReport(165);
            DataTable temp=new DataTable();
            temp = result.Clone();
            temp.Rows.Clear();
            ReportDataSource rds = new ReportDataSource();
            for (int i=0;i< result.Rows.Count;i++)
            {
                temp.ImportRow(result.Rows[i]);
                rds.Value = temp;
                rds.Name = "ContractorMonthlyReport";
                reportViewer2.LocalReport.DataSources.Add(rds);
                this.reportViewer2.RefreshReport();
                ExportToFile(result.Rows[i]["Name"]+" "+result.Rows[i]["Surname"] +".pdf");
                temp.Clear();
            }
        }

        private void ProcessInvoicesSelfBilling()
        {
            reportViewer2.LocalReport.ReportEmbeddedResource = "BitePayroll.Reports.SelfBilling.rdlc";

            var result = new ReportRepository().ContractorMonthlyReportSelfBilling(165,3);
            DataTable temp = new DataTable();
            temp = result.Clone();
            temp.Rows.Clear();
            ReportDataSource rds = new ReportDataSource();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                temp.ImportRow(result.Rows[i]);
                rds.Value = temp;
                rds.Name = "SelfBilling";
                reportViewer2.LocalReport.DataSources.Add(rds);
                this.reportViewer2.RefreshReport();
                ExportToFile("INVOICE - "+result.Rows[i]["ContractName"] + " " + result.Rows[i]["Surname"] + ".pdf");
                temp.Clear();
            }
        }
    }
}
