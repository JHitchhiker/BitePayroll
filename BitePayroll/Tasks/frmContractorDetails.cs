using BitePayroll.Data;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace BitePayroll
{
    public partial class frmContractorDetails : Form
    {
        public int hdmIndex { get; set; }
        ContractDetail currentRecord;
        Contractor contractor;
        public frmContractorDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void onPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle BaseRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            Brush Gradient_Brush = new LinearGradientBrush(BaseRectangle, Color.White, Color.FromArgb(8, 197, 112), LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(Gradient_Brush, BaseRectangle);
        }
        private void frmContractorDetails_Load(object sender, EventArgs e)
        {
            LoadContractor();
        }

        public void LoadContractor()
        {
            ViewRepository repo = new ViewRepository();

            currentRecord = repo.ContractorDetails().Where(e => e.HDM == hdmIndex).FirstOrDefault();

            contractor = new LookupRepository().GetContractors().Where(e => e.ID == currentRecord.ID).FirstOrDefault();

            txtid.Text = currentRecord.ID.ToString();
            txtname.Text = currentRecord.Name;
            txtsurname.Text = currentRecord.Surname;
            txtWeek1.Text = currentRecord.Week1.ToString();
            txtweek2.Text = currentRecord.Week2.ToString();
            txtweek3.Text = currentRecord.Week3.ToString();
            txtweek4.Text = currentRecord.Week4.ToString();
            txtweek5.Text = currentRecord.Week5.ToString();
            txtoweek1.Text = currentRecord.OWeek1.ToString();
            txtoweek2.Text = currentRecord.OWeek2.ToString();
            txtoweek3.Text = currentRecord.OWeek3.ToString();
            txtoweek4.Text = currentRecord.OWeek4.ToString();
            txtoweek5.Text = currentRecord.OWeek5.ToString();
            txtWeek1Rate.Text = currentRecord.Week1Rate.ToString();
            txtweek2rate.Text = currentRecord.Week2Rate.ToString();
            txtweek3rate.Text = currentRecord.Week3Rate.ToString();
            txtweek4rate.Text = currentRecord.Week4rate.ToString();
            txtoweek1rate.Text = currentRecord.Oweekrate.ToString();
            txtoweek2rate.Text = currentRecord.oweek2rate.ToString();
            txtoweek3rate.Text = currentRecord.oweek3rate.ToString();
            txtoweek4rate.Text = currentRecord.oweek4rate.ToString();
            txtoweek5rate.Text = currentRecord.oweek5rate.ToString();
            chkdailyrate1.Checked = currentRecord.dailyrate1;
            chkdailyrate2.Checked = currentRecord.dailyrate2;
            chkdailyrate3.Checked = currentRecord.dailyrate3;
            chkdailyrate4.Checked = currentRecord.dailyrate4;
            chkdailyrate5.Checked = currentRecord.dailyrate5;
            chkhourlyrate1.Checked = currentRecord.hourlyrate1;
            chkhourlyrate2.Checked = currentRecord.hourlyrate2;
            chkhourlyrate3.Checked = currentRecord.hourlyrate3;
            chkhourlyrate4.Checked = currentRecord.hourlyrate4;
            txtdaysworked.Text = currentRecord.days_worked.ToString();
            txthoursworked.Text = currentRecord.hoursworked.ToString();
            txttotal.Text = currentRecord.Total.ToString();
            txthdm.Text = currentRecord.HDM.ToString();
            txtweek5rate.Text = currentRecord.Week5rate.ToString();
            chkhourlyrate5.Checked = currentRecord.hourlyrate5;
        }
        public void UpdateCurrentRecord()
        {
            var hdm = new LookupRepository().GetHDM(hdmIndex);

            hdm.Week1 = txtWeek1.ToDouble();
            hdm.Week2 = txtweek2.ToDouble();
            hdm.Week3 = txtweek3.ToDouble();
            hdm.Week4 = txtweek4.ToDouble();
            hdm.Week5 = txtweek5.ToDouble();
            hdm.O_Week1 = txtoweek1.ToDouble();
            hdm.O_Week2 = txtoweek2.ToDouble();
            hdm.O_Week3 = txtoweek3.ToDouble();
            hdm.O_Week4 = txtoweek4.ToDouble();
            hdm.O_Week5 = txtoweek5.ToDouble();
            hdm.Week1Rate = txtWeek1Rate.ToDouble();
            hdm.Week2Rate = txtweek2rate.ToDouble();
            hdm.Week3Rate = txtweek3rate.ToDouble();
            hdm.Week4rate = txtweek4rate.ToDouble();
            hdm.Oweekrate = txtoweek1rate.ToDouble();
            hdm.oweek2rate = txtoweek2rate.ToDouble();
            hdm.oweek3rate = txtoweek3rate.ToDouble();
            hdm.oweek4rate = txtoweek4rate.ToDouble();
            hdm.oweek5rate = txtoweek5rate.ToDouble();
            hdm.dailyrate1 = chkdailyrate1.Checked;
            hdm.dailyrate2 = chkdailyrate2.Checked;
            hdm.dailyrate3 = chkdailyrate3.Checked;
            hdm.dailyrate4 = chkdailyrate4.Checked;
            hdm.dailyrate5 = chkdailyrate5.Checked;
            hdm.hourlyrate1 = chkhourlyrate1.Checked;
            hdm.hourlyrate2 = chkhourlyrate2.Checked;
            hdm.hourlyrate3 = chkhourlyrate3.Checked;
            hdm.hourlyrate4 = chkhourlyrate4.Checked;
            hdm.daysworked = txtdaysworked.ToDouble();
            hdm.hoursworked = txthoursworked.ToDouble();
            hdm.Total = txttotal.ToDouble();
            hdm.Week5rate = txtweek5rate.ToDouble();
            hdm.hourlyrate5 = chkhourlyrate5.Checked;

            hdm.Holdmargin = new LookupRepository().GetContractors().Where(e => e.ID == hdm.ContractorId).FirstOrDefault().Standard_margin;
            hdm.InvoiceNet = (hdm.Week1 * hdm.Week1Rate) + (hdm.Week2 * hdm.Week2Rate) + (hdm.Week3 * hdm.Week3Rate) + (hdm.Week4 * hdm.Week4rate) + (hdm.Week5 * hdm.Week5rate) + (hdm.O_Week1 * hdm.Oweekrate) + (hdm.O_Week2 * hdm.oweek2rate) + (hdm.O_Week3 * hdm.oweek3rate) + (hdm.O_Week4 * hdm.oweek4rate) + (hdm.O_Week5 * hdm.oweek5rate);
            if (hdm.ExtraPayment == null) hdm.ExtraPayment = 0;
            var vat = 0.00;
                vat = (double)new LookupRepository().GetVatRates().Where(e => e.ID == GlobalValues.Instance.CurrentVatRate).FirstOrDefault().Rate/100;
            hdm.Vat = (hdm.InvoiceNet+hdm.ExtraPayment)* (vat/100);
            hdm.Total = hdm.InvoiceNet + hdm.Vat + (hdm.ExtraPayment==null?0:hdm.ExtraPayment);
            hdm.C2_Fin = hdm.InvoiceNet * 0.02;

            hdm.GrossMargin = (hdm.Holdmargin * hdm.hoursworked) + (hdm.Holdmargin * hdm.daysworked) +(hdm.Overtimeworked*contractor.overtimeMargin)+ (hdm.Xtramargin==null?0:hdm.Xtramargin);

            var company = new LookupRepository().GetCompanies().Where(e => e.Company1 == contractor.Company).FirstOrDefault();
            hdm.Consultmargin = ((hdm.GrossMargin - hdm.C2_Fin) / 100 * company.Margin);
            hdm.AdminBonus = hdm.Total_Expenses * 0.12;
            
            WriteRepository repo = new WriteRepository();
            repo.UpdateHDM(hdm);
            repo = null;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateCurrentRecord();
            frmMainSheet parent = (frmMainSheet)this.Owner.ActiveMdiChild;
            parent.contractorDetail = currentRecord;
            Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Recalulate();
        }

        private void numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = GlobalValues.Instance.numeric_KeyPress(sender, e);
        }

        public void Recalulate()
        {
            var total = 0.00;
            var days = 0.00;
            var hours = 0.00;
            total += txtweek5.ToDouble() * txtweek5rate.ToDouble();
            total += txtweek4.ToDouble() * txtweek4rate.ToDouble();
            total += txtweek3.ToDouble() * txtweek3rate.ToDouble();
            total += txtweek2.ToDouble() * txtweek2rate.ToDouble();
            total += txtWeek1.ToDouble() * txtWeek1Rate.ToDouble();
            total += txtoweek5.ToDouble() * txtoweek5rate.ToDouble();
            total += txtoweek4.ToDouble() * txtoweek4rate.ToDouble();
            total += txtoweek3.ToDouble() * txtoweek3rate.ToDouble();
            total += txtoweek2.ToDouble() * txtoweek2rate.ToDouble();
            total += txtoweek1.ToDouble() * txtoweek1rate.ToDouble();

            if (chkdailyrate1.Checked) days += txtWeek1.ToDouble() + txtoweek1.ToDouble();
            if (chkdailyrate2.Checked) days += txtweek2.ToDouble() + txtoweek2.ToDouble();
            if (chkdailyrate3.Checked) days += txtweek3.ToDouble() + txtoweek3.ToDouble();
            if (chkdailyrate4.Checked) days += txtweek4.ToDouble() + txtoweek4.ToDouble();
            if (chkdailyrate5.Checked) days += txtweek5.ToDouble() + txtoweek5.ToDouble();

            if (chkhourlyrate1.Checked) hours += txtWeek1.ToDouble() + txtoweek1.ToDouble();
            if (chkhourlyrate2.Checked) hours += txtweek2.ToDouble() + txtoweek2.ToDouble();
            if (chkhourlyrate3.Checked) hours += txtweek3.ToDouble() + txtoweek3.ToDouble();
            if (chkhourlyrate4.Checked) hours += txtweek4.ToDouble() + txtoweek4.ToDouble();
            if (chkhourlyrate5.Checked) hours += txtweek5.ToDouble() + txtoweek5.ToDouble();

            txttotal.Text = total.ToString("#,##.00");
            txthoursworked.Text = hours.ToString();
            txtdaysworked.Text = days.ToString();

           
        }

     
    }
}
