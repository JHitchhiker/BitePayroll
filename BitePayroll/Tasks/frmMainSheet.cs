using BitePayroll.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitePayroll
{
    public partial class frmMainSheet : Form
    {
        List<MainSheetQuery> gridItems;
        public ContractDetail contractorDetail;
        ReportViewer report = new ReportViewer();
        
        public frmMainSheet()
        {
            InitializeComponent();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadData()
        {
            ViewRepository repo = new ViewRepository();
            gridItems = repo.MainSheetQuery().Where(e => e.Month == GlobalValues.Instance.CurrentMonth).ToList();
            dataGridView1.DataSource = gridItems;
            dataGridView1.Columns[3].Visible = false;


            dataGridView1.Columns[4].DefaultCellStyle.Format = "#,#0";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,#0";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,#0.00";
            dataGridView1.Columns[7].DefaultCellStyle.Format = "#,#0.00";
            for (int i = 11; i < 17; i++)
            {
                dataGridView1.Columns[i].DefaultCellStyle.Format = "#,#0.00";
            }

            var month = new LookupRepository().GetMonths().Where(e => e.Month_ID == GlobalValues.Instance.CurrentMonth).FirstOrDefault();
            textBox1.Text = month.Name;
            textBox2.Text = month.Year.ToString();
        }

        private void frmMainSheet_Load(object sender, EventArgs e)
        {
            if (GlobalValues.Instance.CurrentMonth == 0)
            {
                Close();
            }
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var gridindex = dataGridView1.SelectedRows[0].Index;

                if (dataGridView1.SelectedRows.Count == 0) return;

                var form = new frmContractorDetails { hdmIndex = gridItems[dataGridView1.SelectedRows[0].Index].HDM };

                form.ShowDialog(this);
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                LoadData();
                dataGridView1.Rows[gridindex].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = gridindex;
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            ProcessInvoices();
        }

        private void ExportToFile(string filename)
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = report.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);

            using (FileStream fs = new FileStream(@"c:\reports\" + filename, FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }

        private void ProcessInvoices()
        {
            progressBar1.Value = 0;
            report.LocalReport.ReportEmbeddedResource = "BitePayroll.Reports.ContractorMonthlyReport.rdlc";

            var result = new ReportRepository().ContractorMonthlyReport(GlobalValues.Instance.CurrentMonth);

            progressBar1.Maximum = result.Rows.Count;

            DataTable temp = new DataTable();
            temp = result.Clone();
            temp.Rows.Clear();
            ReportDataSource rds = new ReportDataSource();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                temp.ImportRow(result.Rows[i]);
                rds.Value = temp;
                rds.Name = "ContractorMonthlyReport";
                report.LocalReport.DataSources.Add(rds);
                this.report.RefreshReport();
                ExportToFile(result.Rows[i]["Name"] + " " + result.Rows[i]["Surname"] + ".pdf");
                temp.Clear();
                progressBar1.Value++;
            }
            panel4.Visible = false;
        }
        private void ProcessInvoicesSelfBilling()
        {
            progressBar1.Value = 0;
            var result = new ReportRepository().ContractorMonthlyReportSelfBilling(GlobalValues.Instance.CurrentMonth,GlobalValues.Instance.CurrentVatRate);
            panel4.Visible = true;
            progressBar1.Maximum = result.Rows.Count;
            report.LocalReport.ReportEmbeddedResource = "BitePayroll.Reports.SelfBilling.rdlc";

            DataTable temp = new DataTable();
            temp = result.Clone();
            temp.Rows.Clear();
            ReportDataSource rds = new ReportDataSource();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                temp.ImportRow(result.Rows[i]);
                rds.Value = temp;
                rds.Name = "SelfBilling";
                report.LocalReport.DataSources.Add(rds);
                this.report.RefreshReport();
                ExportToFile("INVOICE - " + result.Rows[i]["ContractName"] + " " + result.Rows[i]["Surname"] + ".pdf");
                temp.Clear();
                progressBar1.Value++;
            }
            panel4.Visible = false;

            result = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessInvoicesSelfBilling();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = gridItems.Count;
            panel4.Visible = true;
            foreach(var item in gridItems)
            {
                var form = new frmContractorDetails { hdmIndex = item.HDM };
                form.LoadContractor();
                form.Recalulate();
                form.UpdateCurrentRecord();
                form = null;
                progressBar1.Value++;
            }
            panel4.Visible = false;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            LoadData();

        }
    }
}
