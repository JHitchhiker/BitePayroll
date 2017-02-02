using BitePayroll.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace BitePayroll
{
    public partial class frmEditContractor : Form

    {
        public frmEditContractor()
        {
            InitializeComponent();
            LoadCombo();

        }

        private void LoadCombo()
        {
            LookupRepository _repository = new LookupRepository();
            var items = _repository.GetContractors().Select(s => new ComboboxItem { Text = s.Name + " " + s.Surname, Value = s.ID.ToString() }).ToList();
            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";

            items = _repository.GetCompanies().Select(s => new ComboboxItem { Text = s.Name, Value = s.Company1.ToString() }).ToList();
            cboCompany.DataSource = items;
            cboCompany.DisplayMember = "Text";
            cboCompany.ValueMember = "Value";

            items = _repository.GetInvoices().Select(s => new ComboboxItem { Text = s.Invoiced, Value = s.ID.ToString() }).ToList();
            cboInvoiced.DataSource = items;
            cboInvoiced.DisplayMember = "Text";
            cboInvoiced.ValueMember = "Value";

            items = _repository.GetPayrolls().Select(s => new ComboboxItem { Text = s.Name, Value = s.PayrollId.ToString() }).ToList();
            cboPayroll.DataSource = items;
            cboPayroll.DisplayMember = "Text";
            cboPayroll.ValueMember = "Value";

            items = _repository.GetContractorTypes().Select(s => new ComboboxItem { Text = s.ContractorType1, Value = s.ContractorTypeID.ToString() }).ToList();
            cboContractorType.DataSource = items;
            cboContractorType.DisplayMember = "Text";
            cboContractorType.ValueMember = "Value";
            _repository = null;
        }

        private void LoadContractor()
        {

            LookupRepository readrepo = new LookupRepository();
            try
            {
                var model = readrepo.GetContractors().FirstOrDefault(e => e.ID == Convert.ToInt16(comboBox1.SelectedValue));

                txtId.Text = model.ID.ToString();
                txtName.Text = model.Name;
                txtSurname.Text = model.Surname;
                txtRate.Text = model.Rate.ToString();
                txtOvertimeRate.Text = model.Overtime_Rate.ToString();
                txtAgency.Text = model.Agency;
                txtAgency2.Text = model.Agency2;
                txtNumber.Text = model.Number.ToString();
                txtInfo.Text = model.Info;
                txtTimeSheetSubmitted.Text = model.Time_sheet_submitted;
                txtCompanyName.Text = model.Companyname;
                txtCompanyNumber.Text = model.Company_Number.ToString();
                txtAddress1.Text = model.Address1;
                txtAddress2.Text = model.Address2;
                txtAddress3.Text = model.Address3;
                txtAddress4.Text = model.Address4;
                txtEmail.Text = model.Email;
                txtStandardMargin.Text = model.Standard_margin.ToString();
                txtOvertimeMargin.Text = model.overtimeMargin.ToString();

                chkWorkPermit.Checked = (bool)model.Work_Permit;
                chkCharity.Checked = (bool)model.charity;
                chkDaily.Checked = (bool)model.Daily_rate;
                chkHourly.Checked = (bool)model.Hourly_rate;
                chkSelfBilling.Checked = (bool)model.selfbilling;
                chkBiteEmployee.Checked = (bool)model.Bite_Employee;

                cboInvoiced.SelectedIndex = -1;
                foreach (var item in cboInvoiced.Items)
                {
                    var comboitem = (ComboboxItem)item;
                    if (comboitem.Value == model.InvoiceID.ToString())
                    {
                        cboInvoiced.SelectedItem = item;
                    }
                }
                cboContractorType.SelectedIndex = -1;
                foreach (var item in cboContractorType.Items)
                {
                    var comboitem = (ComboboxItem)item;
                    if (comboitem.Value == model.ContractorTypeID.ToString())
                    {
                        cboContractorType.SelectedItem = item;
                    }
                }
                cboCompany.SelectedIndex = -1;
                foreach (var item in cboCompany.Items)
                {
                    var comboitem = (ComboboxItem)item;
                    if (comboitem.Value == model.Company.ToString())
                    {
                        cboCompany.SelectedItem = item;
                    }
                }
                cboPayroll.SelectedIndex = -1;
                foreach (var item in cboPayroll.Items)
                {
                    var comboitem = (ComboboxItem)item;
                    if (comboitem.Value == model.Payroll.ToString())
                    {
                        cboPayroll.SelectedItem = item;
                    }
                }
            }
            catch { }
        }
        private void onPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle BaseRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            Brush Gradient_Brush = new LinearGradientBrush(BaseRectangle, Color.White, Color.FromArgb(8, 197, 112), LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(Gradient_Brush, BaseRectangle);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadContractor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var model = new Contractor();

            model.ID = txtId.ToInt();
            model.Name = txtName.Text;
            model.Surname = txtSurname.Text;
            if (txtRate.Text!="") model.Rate = txtRate.ToDouble();
            if (txtOvertimeRate.Text != "") model.Overtime_Rate = txtOvertimeRate.ToDouble();
            model.Agency = txtAgency.Text;
            model.Agency2 = txtAgency2.Text;
            if (txtNumber.Text != "") model.Number = txtNumber.ToDouble();
            model.Info = txtInfo.Text;
            model.Time_sheet_submitted = txtTimeSheetSubmitted.Text;
            model.Companyname = txtCompanyName.Text;
            if (txtCompanyNumber.Text!= "") model.Company_Number = txtCompanyNumber.ToInt();
            
            model.Address1 = txtAddress1.Text;
            model.Address2 = txtAddress2.Text;
            model.Address3 = txtAddress3.Text;
            model.Address4 = txtAddress4.Text;
            model.Email = txtEmail.Text;
            if (txtStandardMargin.Text != "") model.Standard_margin = txtStandardMargin.ToDouble();
            if (txtOvertimeMargin.Text != "") model.overtimeMargin = txtOvertimeMargin.ToInt();

            model.Work_Permit = chkWorkPermit.Checked;
            model.charity = chkCharity.Checked;
            model.Daily_rate = chkDaily.Checked;
            model.Hourly_rate = chkHourly.Checked;
            model.selfbilling = chkSelfBilling.Checked;
            model.Bite_Employee = chkBiteEmployee.Checked;

            model.InvoiceID = Convert.ToInt16(cboInvoiced.SelectedValue);

            model.ContractorTypeID = Convert.ToInt16(cboContractorType.SelectedValue);

            model.Company = Convert.ToInt16(cboCompany.SelectedValue);
            model.Payroll = Convert.ToInt16(cboPayroll.SelectedValue);



            WriteRepository repository = new WriteRepository();
            repository.UpdateContractor(model);
            repository = null;
        }
        private void numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = GlobalValues.Instance.numeric_KeyPress(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditContractor_Load(object sender, EventArgs e)
        {

        }
    }
    
}
