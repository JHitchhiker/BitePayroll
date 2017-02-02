using BitePayroll.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitePayroll
{
    public partial class frmMenu : Form
    {
        bool loading;
        
        public frmMenu()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(new frmAddContractor());
        }

        private void ShowForm(Form formToShow)
        {
            formToShow.StartPosition = FormStartPosition.CenterScreen;
            formToShow.MdiParent = this.MdiParent;
            formToShow.ControlBox = false;
            formToShow.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(new frmEditContractor());
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(new frmPayroll { editmode = false });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(new frmPayroll { editmode = true });
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(new frmOverseasCompany { editmode = false });
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(new frmVATAdmin());
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(new frmTimesheet());
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(new frmMonthSheet { nextForm = "frmMainSheet" });
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(new frmOverseasCompany { editmode = true });
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(new frmMonthSheet { nextForm = "frmMissingTimeSheet"});
        }
       
        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            loading = true;
            LoadCombos();
            loading = false;
            comboBox2.SelectedIndex = comboBox2.Items.Count - 1;
        }

        private void LoadCombos()
        {
            LookupRepository repository = new LookupRepository();
            var items = repository.GetMonths().Select(e => new ComboboxItem { Text = e.Name + " \t " + e.Year, Value = e.Month_ID.ToString() }).ToList();
            comboBox1.DataSource = items;

            items = repository.GetVatRates().Select(e => new ComboboxItem { Text = e.RateName, Value = e.ID.ToString() }).ToList();
            comboBox2.DataSource = items;

            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            comboBox2.DisplayMember = "Text";
            comboBox2.ValueMember = "Value";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            textBox1.Text = comboBox1.Text.Substring(comboBox1.Text.IndexOf("\t ") + 1);

            var item = (ComboboxItem)comboBox1.SelectedItem;
            GlobalValues.Instance.CurrentMonth = Convert.ToInt16(item.Value);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            var item = (ComboboxItem)comboBox2.SelectedItem;
            GlobalValues.Instance.CurrentVatRate = Convert.ToInt16(item.Value);
        }

        private  void gradientthis(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle BaseRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            Brush Gradient_Brush = new LinearGradientBrush(BaseRectangle,  Color.White, Color.FromArgb(8, 197, 112), LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(Gradient_Brush, BaseRectangle);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frmReportViewer report = new frmReportViewer { ReportView = ReportSelector.AssociateReport };
            report.ShowDialog();
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExcelReports.CXCReport();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReportViewer report = new frmReportViewer { ReportView = ReportSelector.TotalReport };
            report.ShowDialog();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContractorSelect form = new ContractorSelect();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();   
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReportViewer report = new frmReportViewer { ReportView = ReportSelector.PayrollRates };
            report.ShowDialog();
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReportViewer report = new frmReportViewer { ReportView = ReportSelector.EmployeeHours };
            report.ShowDialog();
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBitePayrollMonthSelect monthForm = new frmBitePayrollMonthSelect();
            monthForm.StartPosition = FormStartPosition.CenterScreen;
            monthForm.ShowDialog();
        }
    }
}
