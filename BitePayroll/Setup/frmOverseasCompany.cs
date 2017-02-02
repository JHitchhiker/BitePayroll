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
    public partial class frmOverseasCompany : Form
    {
        public bool editmode { get; set; }
        public frmOverseasCompany()
        {
            InitializeComponent();
        }

       
        private void frmAddOverseasCompany_Load(object sender, EventArgs e)
        {
            label4.Visible = editmode;
            comboBox1.Visible = editmode;
            if (editmode) { LoadCombo(); this.Text = "Edit Associate Company"; }
        }
        private void onPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle BaseRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            Brush Gradient_Brush = new LinearGradientBrush(BaseRectangle, Color.White, Color.FromArgb(8, 197, 112), LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(Gradient_Brush, BaseRectangle);
        }
        public void LoadCombo()
        {
            LookupRepository repository = new LookupRepository();
            var items = repository.GetCompanies().Select(s => new ComboboxItem { Text = s.Name, Value = s.Company1.ToString() }).ToList();
            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
        }

        private Company GetCompany(int id)
        {
            LookupRepository repository = new LookupRepository();
            return repository.GetCompanies().FirstOrDefault(e => e.Company1 == id);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteRepository repository = new WriteRepository();
            var index = 0;
            if (!editmode)
            {
                Company model = new Company { Name = txtName.Text,
                                              Description = txtDescription.Text,
                                              Margin = txtMargin.ToDouble()
                                            };
                txtCompany1.Text = repository.InsertCompany(model).ToString();
                index = comboBox1.Items.Count;
            }
            else
            {
                Company model = new Company
                {
                    Company1 = txtCompany1.ToInt(),
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Margin = txtMargin.ToDouble()
                };
                repository.UpdateCompany(model);
                index = comboBox1.SelectedIndex;
            }

            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            LoadCombo();
            comboBox1.SelectedIndex = index;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
            var company = GetCompany(Convert.ToInt16(comboBox1.SelectedValue));
            txtCompany1.Text = company.Company1.ToString();
            txtName.Text = company.Name;
            txtDescription.Text = company.Description;
            txtMargin.Text = company.Margin.ToString();
            }
            catch{ }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
