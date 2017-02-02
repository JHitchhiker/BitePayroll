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
    public partial class frmBitePayrollMonthSelect : Form
    {
        bool loading;
        public frmBitePayrollMonthSelect()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(onPaint);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBitePayrollMonthSelect_Load(object sender, EventArgs e)
        {
            loading = true;
            LoadCombo();
            loading = false;
        }

        private void onPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle BaseRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            Brush Gradient_Brush = new LinearGradientBrush(BaseRectangle, Color.White, Color.FromArgb(8, 197, 112), LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(Gradient_Brush, BaseRectangle);
            this.BackColor = Color.White;
        }
        private void LoadCombo()
        {
            LookupRepository repository = new LookupRepository();
            var items = repository.GetMonths().Select(s => new ComboboxItem { Text = s.Name + " \t " + s.Year, Value = s.Month_ID.ToString() }).ToList();
            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            textBox1.Text = comboBox1.Text.Substring(comboBox1.Text.IndexOf("\t ") + 1);

            GlobalValues.Instance.CurrentMonth = Convert.ToInt16(comboBox1.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReportViewer report = new frmReportViewer { ReportView = ReportSelector.BitePayroll };
            report.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelReports.BitePayroll();
            MessageBox.Show(@"File exported to c:\Reports\BitePayroll.xls");
        }
    }
}
