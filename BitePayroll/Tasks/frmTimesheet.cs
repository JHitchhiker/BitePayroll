using BitePayroll.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace BitePayroll
{
    public partial class frmTimesheet : Form
    {
        bool loading;
        List<HDMQuery1> queryResult;
        Contractor currentContractor;

        int currentMonth = 0;
        public frmTimesheet()
        {
            InitializeComponent();
        }

        private void frmTimesheet_Load(object sender, EventArgs e)
        {
            loading = true;
            cboMonths.Visible = false;
            txtYear.Visible = false;
            lblmonth.Visible = false;
            lblyear.Visible = false;
            LoadCombos();
            loading = false;
            comboBox1.SelectedIndex = 0;
            PrepareContractor();
            Populate();
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
            LookupRepository _repository = new LookupRepository();
            var items = _repository.GetContractors().Select(s => new ComboboxItem { Text = s.Name + " " + s.Surname, Value = s.ID.ToString() }).ToList();
            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";

            items = _repository.GetMonths().Select(s => new ComboboxItem { Text = s.Name + " \t " + s.Year, Value = s.Month_ID.ToString() }).ToList();
            cboMonths.DataSource = items;
            cboMonths.DisplayMember = "Text";
            cboMonths.ValueMember = "Value";
            cboMonths.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            currentMonth = 0;
            PrepareContractor();
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetMonth();
            currentMonth = dataGridView1.SelectedRows[0].Index;
            Populate();
        }
        private void DataGridView1_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            GetMonth();
            currentMonth = dataGridView1.SelectedRows[0].Index;
            Populate();
        }
        private void GetMonth()
        {
            ViewRepository repo = new ViewRepository();
            if (dataGridView1.SelectedRows.Count == 0) return;
            var record = repo.HDMQuery1().Where(x => x.ContractorId == Convert.ToInt16(comboBox1.SelectedValue)
                                                && x.Month == Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[1].Value)).FirstOrDefault();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetMonth();
            currentMonth = dataGridView1.SelectedRows[0].Index;
            Populate();

            loading = true;
            SetMonth();
            loading = false;
        }

        private void PrepareContractor()
        {
            ViewRepository repo = new ViewRepository();
            var total = repo.ContractorTotalHours()
                            .Where(s => s.Id == Convert.ToInt16(comboBox1.SelectedValue))
                            .FirstOrDefault().Total;
            txtTotalHoursWorked.Text = total.ToString();


            var items = repo.ContractTimeSheetMonths()
                            .Where(s => s.ContractorId == Convert.ToInt16(comboBox1.SelectedValue)).ToList();

            dataGridView1.DataSource = items;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            GetMonth();

            queryResult = repo.HDMQuery1().Where(x => x.ContractorId == Convert.ToInt16(comboBox1.SelectedValue)).ToList();

            currentContractor = new LookupRepository().GetContractors().FirstOrDefault(e => e.ID == Convert.ToInt16(comboBox1.SelectedValue));
            Populate();
        }
        private void Populate()
        {
            if (queryResult == null || comboBox1.SelectedIndex < 0) return;
            if (currentMonth < 0 || currentMonth >= queryResult.Count) return;
            dataGridView1.Rows[currentMonth].Selected = true;
            var current = queryResult[currentMonth];
            txtWeek1.Text = current.Week1.ToString();

            txtWeek2.Text = current.Week2.ToString();
            txtWeek3.Text = current.Week3.ToString();
            txtWeek4.Text = current.Week4.ToString();
            txtWeek5.Text = current.Week5.ToString();
            txtOWeek1.Text = current.OWeek1.ToString();
            txtOWeek2.Text = current.OWeek2.ToString();
            txtOWeek3.Text = current.OWeek3.ToString();
            txtOWeek4.Text = current.OWeek4.ToString();
            txtOWeek5.Text = current.OWeek5.ToString();

            txtWeek1Rate.Text = current.Week1Rate.ToString();
            txtWeek2Rate.Text = current.Week2Rate.ToString();
            txtWeek3Rate.Text = current.Week3Rate.ToString();
            txtWeek4Rate.Text = current.Week4rate.ToString();
            txtWeek5Rate.Text = current.Week5rate.ToString();
            txtOWeek1Rate.Text = current.Oweekrate.ToString();
            txtOWeek2Rate.Text = current.oweek2rate.ToString();
            txtOWeek3Rate.Text = current.oweek3rate.ToString();
            txtOWeek4Rate.Text = current.oweek4rate.ToString();
            txtOWeek5Rate.Text = current.oweek5rate.ToString();

            txtHours.Text = current.hoursworked.ToString();
            txtOTime.Text = current.Overtimeworked.ToString();
            txtDays.Text = current.daysworked.ToString();
            txtExpenses.Text = current.TotalExpenses.ToString();
            txtClientExpenses.Text = current.ClientExpenses.ToString();
            txtAdvance.Text = current.Advance.ToString();
            txtTotal.Text = current.Total.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            currentMonth = 0;
            Populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentMonth--;
            Populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentMonth++;
            Populate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (queryResult == null) return;
            currentMonth = queryResult.Count - 1;
            Populate();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            NewTimeSheet();
        }

        private void Clear()
        {
            foreach (var control in panel1.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "0";
                }
            }
            txtComments.Text = "";
            cboMonths.Visible = true;
            txtYear.Visible = true;
            lblmonth.Visible = true;
            lblyear.Visible = true;
        }

        private void btnNewMonth_Click(object sender, EventArgs e)
        {
            NewTimeSheet();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Populate();
            btnCancel.Visible = false;
            cmdSave.Visible = false;
            pnlBrowse.Visible = true;
            cboMonths.Visible = false;
            txtYear.Visible = false;
            lblmonth.Visible = false;
            lblyear.Visible = false;
            comboBox1.Enabled = true;
            dataGridView1.Enabled = true;
        }
        private void numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = GlobalValues.Instance.numeric_KeyPress(sender, e);
        }

        private void cboMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtYear.Text = cboMonths.Text.Substring(cboMonths.Text.IndexOf(" \t ") + 3);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var total = 0.00;
            var worked = 0.00;
            var overtime = 0.00;
            worked += txtWeek1.ToDouble();
            worked += txtWeek2.ToDouble();
            worked += txtWeek3.ToDouble();
            worked += txtWeek4.ToDouble();
            worked += txtWeek5.ToDouble();

            overtime += txtOWeek1.ToDouble();
            overtime += txtOWeek2.ToDouble();
            overtime += txtOWeek3.ToDouble();
            overtime += txtOWeek4.ToDouble();
            overtime += txtOWeek5.ToDouble();

            total += txtWeek1.ToDouble() * txtWeek1Rate.ToDouble();
            total += txtWeek2.ToDouble() * txtWeek2Rate.ToDouble();
            total += txtWeek3.ToDouble() * txtWeek3Rate.ToDouble();
            total += txtWeek4.ToDouble() * txtWeek4Rate.ToDouble();
            total += txtWeek5.ToDouble() * txtWeek5Rate.ToDouble();
            total += txtOWeek1.ToDouble() * txtOWeek1Rate.ToDouble();
            total += txtOWeek2.ToDouble() * txtOWeek2Rate.ToDouble();
            total += txtOWeek3.ToDouble() * txtOWeek3Rate.ToDouble();
            total += txtOWeek4.ToDouble() * txtOWeek4Rate.ToDouble();
            total += txtOWeek5.ToDouble() * txtOWeek5Rate.ToDouble();

            txtTotal.Text = total.ToString();
            txtOTime.Text = overtime.ToString();

            if ((bool)currentContractor.Daily_rate)
            {
                txtDays.Text = worked.ToString();
                txtHours.Text = "0";
            }
            else
            {
                txtHours.Text = worked.ToString();
                txtDays.Text = "0";
            }

            if (!cmdSave.Visible)
            {
                Save(!cmdSave.Visible);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Save(false);
            btnCancel.Visible = false;
            cmdSave.Visible = false;
            pnlBrowse.Visible = true;
            cboMonths.Visible = false;
            txtYear.Visible = false;
            lblmonth.Visible = false;
            lblyear.Visible = false;
            comboBox1.Enabled = true;
            dataGridView1.Enabled = true;

        }

        private void Save(bool update)
        {
            if (txtYear.Text == "0" || txtYear.Text == "") return;
            HDM record;
            if (update)
            {
                record = new LookupRepository().GetHDM(queryResult[currentMonth].HDM);
            }
            else
            {
                record = new HDM();
            }
            record.ContractorId = Convert.ToInt16(comboBox1.SelectedValue);
            record.Month = Convert.ToInt16(cboMonths.SelectedValue);

            record.hourlyrate1 = record.hourlyrate2 
                = record.hourlyrate3 = record.hourlyrate4 
                = record.hourlyrate5 = currentContractor.Hourly_rate;

            record.dailyrate1 = record.dailyrate2 = record.dailyrate3 = 
                record.dailyrate4 = record.dailyrate5 = currentContractor.Daily_rate;

            record.Week1PayRate = currentContractor.Rate - currentContractor.Standard_margin;

            record.Week2PayRate = record.Week3PayRate =
                record.Week4PayRate = record.Week5PayRate = record.Week1PayRate;

            record.C0Week1PayRate = record.C0Week2PayRate 
                = record.C0Week3PayRate = record.C0Week4PayRate 
                = record.C0Week5PayRate 
                = currentContractor.Overtime_Rate - currentContractor.Overtime_Rate;

            record.Holdmargin = currentContractor.Standard_margin;

            record.Week1 = txtWeek1.ToDouble();
            record.Week2 = txtWeek2.ToDouble();
            record.Week3 = txtWeek3.ToDouble();
            record.Week4 = txtWeek4.ToDouble();
            record.Week5 = txtWeek5.ToDouble();
            record.O_Week1 = txtOWeek1.ToDouble();
            record.O_Week2 = txtOWeek2.ToDouble();
            record.O_Week3 = txtOWeek3.ToDouble();
            record.O_Week4 = txtOWeek4.ToDouble();
            record.O_Week5 = txtOWeek5.ToDouble();

            record.Week1Rate = txtWeek1Rate.ToDouble();
            record.Week2Rate = txtWeek2Rate.ToDouble();
            record.Week3Rate = txtWeek3Rate.ToDouble();
            record.Week4rate = txtWeek4Rate.ToDouble();
            record.Week5rate = txtWeek5Rate.ToDouble();
            record.Oweekrate = txtOWeek1Rate.ToDouble();
            record.oweek2rate = txtOWeek2Rate.ToDouble();
            record.oweek3rate= txtOWeek3Rate.ToDouble();
            record.oweek4rate= txtOWeek4Rate.ToDouble();
            record.oweek5rate= txtOWeek5Rate.ToDouble();

            record.hoursworked = txtHours.ToDouble();
            record.Overtimeworked = txtOTime.ToDouble();
            record.daysworked = txtDays.ToDouble();
            record.Total_Expenses = txtExpenses.ToDouble();
            record.ClientExpenses = txtClientExpenses.ToDouble();
            record.Advance = txtAdvance.ToDouble();
            record.Total = txtTotal.ToDouble();

           
            WriteRepository repo = new WriteRepository();
            if (update)
            {
                repo.UpdateHDM(record);
            }
            else
            {
                repo.InsertHDM(record);
                currentMonth = 0;
            }
            PrepareContractor();
            Populate();
        }
        private void SetMonth()
        {
            var month = queryResult[currentMonth].Month;
            foreach (ComboboxItem item in cboMonths.Items)
            {
                if (Convert.ToInt16(item.Value) == month)
                {
                    cboMonths.SelectedItem = item;
                }
            }
        }

        private void NewTimeSheet()
        {
            Clear();
            pnlBrowse.Visible = false;
            btnCancel.Visible = true;
            cmdSave.Visible = true;
            cboMonths.Visible = true;
            txtYear.Visible = true;
            lblmonth.Visible = true;
            lblyear.Visible = true;
            comboBox1.Enabled = false;
            dataGridView1.Enabled = false;

            txtWeek1Rate.Text = currentContractor.Rate.ToString();
            txtWeek2Rate.Text = currentContractor.Rate.ToString();
            txtWeek3Rate.Text = currentContractor.Rate.ToString();
            txtWeek4Rate.Text = currentContractor.Rate.ToString();
            txtWeek5Rate.Text = currentContractor.Rate.ToString();

            txtOWeek1Rate.Text = currentContractor.Overtime_Rate.ToString();
            txtOWeek2Rate.Text = currentContractor.Overtime_Rate.ToString();
            txtOWeek3Rate.Text = currentContractor.Overtime_Rate.ToString();
            txtOWeek4Rate.Text = currentContractor.Overtime_Rate.ToString();
            txtOWeek5Rate.Text = currentContractor.Overtime_Rate.ToString();

            txtWeek1.Focus();
        }
        private void txtWeek1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
