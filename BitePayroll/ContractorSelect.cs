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
    public partial class ContractorSelect : Form
    {
        bool loading;
        public ContractorSelect()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReportViewer report = new frmReportViewer { ReportView = ReportSelector.ContractorHoursWorked };
            report.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            GlobalValues.Instance.CurrentContractor = Convert.ToInt16(comboBox1.SelectedValue);
        }

        private void LoadCombo()
        {
            LookupRepository _repository = new LookupRepository();
            var items = _repository.GetContractors().Select(s => new ComboboxItem { Text = s.Name + " " + s.Surname, Value = s.ID.ToString() }).ToList();
            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
        }
        private void onPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle BaseRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            Brush Gradient_Brush = new LinearGradientBrush(BaseRectangle, Color.White, Color.FromArgb(8, 197, 112), LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(Gradient_Brush, BaseRectangle);
        }

        private void ContractorSelect_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(onPaint);
            loading = true;
            LoadCombo();
            loading = false;
        }
    }
}
