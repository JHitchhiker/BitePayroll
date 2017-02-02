using BitePayroll.Data;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace BitePayroll
{
    public partial class frmAddContractor : Form
    {
        public frmAddContractor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contractor contractor = new Contractor
                                        {
                                            
                                            Name= txtName.Text,
                                            Surname = txtSurname.Text,
                                            Rate = txtRate.ToDouble(),
                                            Overtime_Rate = txtOvertimeRate.ToDouble(),
                                            Company = Convert.ToInt32(cboAssociateCompany.SelectedValue),
                                            Agency = txtAgency.Text,
                                            Agency2 = txtAgency2.Text,
                                            Number = txtNumber.ToDouble(),
                                            Info = txtInfo.Text,
                                            Time_sheet_submitted = txtTimesheet.Text,
                                            InvoiceID = Convert.ToInt16(cboInvoiced.SelectedValue),
                                            Standard_margin = txtStandardMargin.ToDouble(),
                                            overtimeMargin = txtOvertimeMargin.ToDouble(),
                                            Work_Permit = chkWorkPermit.Checked,
                                            charity = chkCharity.Checked,
                                            Daily_rate = chkDaily.Checked,
                                            Hourly_rate = chkHourly.Checked
                                        };
            ContractorRepository repository = new ContractorRepository();
            repository.Create(contractor);
            
        }
        private void onPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle BaseRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            Brush Gradient_Brush = new LinearGradientBrush(BaseRectangle, Color.White, Color.FromArgb(8, 197, 112), LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(Gradient_Brush, BaseRectangle);
        }

        private void LoadCombos()
        {
            LookupRepository repository = new LookupRepository();
            
            var items = repository.GetCompanies().Select(s => new ComboboxItem { Text = s.Name, Value = s.Company1.ToString() }).ToList();
            cboAssociateCompany.DataSource = items;
            cboAssociateCompany.DisplayMember = "Text";
            cboAssociateCompany.ValueMember = "Value";

            items = repository.GetInvoices().Select(s => new ComboboxItem { Text = s.Invoiced, Value = s.ID.ToString() }).ToList();
            cboInvoiced.DataSource = items;
            cboInvoiced.DisplayMember = "Text";
            cboInvoiced.ValueMember = "Value";

            items = repository.GetPayrolls().Select(s => new ComboboxItem { Text = s.Name, Value = s.PayrollId.ToString() }).ToList();
            cboPayroll.DataSource = items;
            cboPayroll.DisplayMember = "Text";
            cboPayroll.ValueMember = "Value";
        }

        private void frmAddContractor_Load(object sender, EventArgs e)
        {
            LoadCombos();
            this.ControlBox = false;
        }

        private void numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = GlobalValues.Instance.numeric_KeyPress(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
