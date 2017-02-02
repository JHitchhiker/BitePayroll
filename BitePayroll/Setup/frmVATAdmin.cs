using BitePayroll.Data;
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
    public partial class frmVATAdmin : Form
    {
        List<VatRate> vatRates;
        int index;
        public frmVATAdmin()
        {
            InitializeComponent();
        }

        private void frmVATAdmin_Load(object sender, EventArgs e)
        {
            LoadVatRates();
            index = 0;
            ShowVatRate();
        }
        private void onPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle BaseRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            Brush Gradient_Brush = new LinearGradientBrush(BaseRectangle, Color.White, Color.FromArgb(8, 197, 112), LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(Gradient_Brush, BaseRectangle);
        }
        public void LoadVatRates()
        {
            vatRates = new List<VatRate>();
            LookupRepository repository = new LookupRepository();
            vatRates = repository.GetVatRates();
        }
        public void ShowVatRate()
        {
            if (index <= 0)
            {
                index = 0;
            }
            else if(index>=vatRates.Count )
            {
                index = vatRates.Count - 1;
            }
            txtRateName.Text = vatRates[index].RateName;
            txtRate.Text = vatRates[index].Rate.ToString();
            dteStartDate.Value = (DateTime)vatRates[index].StartDate;
            dteEndDate.Value = (DateTime)vatRates[index].EndDate;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = 0;
            ShowVatRate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index--;
            ShowVatRate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            index++;
            ShowVatRate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            index = vatRates.Count - 1;
            ShowVatRate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtRateName.Text = "";
            txtRate.Text = "0";
            dteStartDate.Value = DateTime.Today;
            dteEndDate.Value = DateTime.Today;
            txtRateName.Focus();
            panel1.Enabled = false;
            btnSave.Left = ((btnClose.Left - 10) - btnCancel.Width) - btnSave.Width - 10;
            btnCancel.Top = btnSave.Top;
            btnCancel.Left = btnClose.Left - btnCancel.Width - 10;
            btnCancel.Visible = true;
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            btnCancel.Visible = false;
            btnSave.Left = btnClose.Left - btnSave.Width - 10;
            ShowVatRate();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            var model = new VatRate {
                                Rate = txtRate.ToInt(),
                                RateName = txtRateName.Text,
                                StartDate = dteStartDate.Value,
                                EndDate = dteEndDate.Value
                            };
            WriteRepository repository = new WriteRepository();

            if (panel1.Enabled)
            {
                model.ID = vatRates[index].ID;
                repository.UpdateVatRate(model);
            }          
            else
            {
                repository.InsertVatRate(model);
                panel1.Enabled = true;
                btnCancel.Visible = false;
                btnSave.Left = btnClose.Left - btnSave.Width - 10;
                index = vatRates.Count;
                panel1.Enabled = true;
            }
            LoadVatRates();
            ShowVatRate();
        }
    }
}
