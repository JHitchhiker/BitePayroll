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
    public partial class frmPayroll : Form
    {
        public bool editmode { get; set; }
        public frmPayroll()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteRepository repository = new WriteRepository();
            var index = 0;
            if (!editmode)
            { 
                Payroll model = new Payroll { Name = txtName.Text };
                txtPayrollId.Text =  repository.InsertPayroll(model).ToString();
                index = comboBox1.Items.Count;
            }
            else
            {
                repository.UpdatePayroll(txtPayrollId.ToInt(), txtName.Text);
                index = comboBox1.SelectedIndex;
            }

            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            LoadCombos();
            comboBox1.SelectedIndex = index;
        }

        private void frmAddPayrollBeareau_Load(object sender, EventArgs e)
        {
            comboBox1.Visible = editmode;
            label2.Visible = editmode;

            if (editmode)
            {
                LoadCombos();
            }
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
            var items = repository.GetPayrolls().Select(s => new ComboboxItem { Text = s.Name, Value = s.PayrollId.ToString() }).ToList();
            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtPayrollId.Text = comboBox1.SelectedValue.ToString();
                txtName.Text = comboBox1.Text;
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
