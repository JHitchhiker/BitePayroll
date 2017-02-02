using BitePayroll.Data;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace BitePayroll
{
    public partial class frmMonthSheet : Form
    {
        bool loading;
        public string nextForm { get; set; }
        public frmMonthSheet()
        {
            InitializeComponent();
        }

        private void frmMonthSheet_Load(object sender, EventArgs e)
        {
            loading = true;
            LoadCombo();
            loading = false;

            for (int i=0;i<comboBox1.Items.Count;i++)
            {
                var item = (ComboboxItem)comboBox1.Items[i];
                if (Convert.ToInt16(item.Value)==GlobalValues.Instance.CurrentMonth)
                {
                    comboBox1.SelectedIndex = i;
                    break;
                }
            }
            ButtonSelector();
            
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
            textBox1.Text = comboBox1.Text.Substring(comboBox1.Text.IndexOf("\t ")+1);

            GlobalValues.Instance.CurrentMonth = Convert.ToInt16(comboBox1.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMissingTimeSheet form = new frmMissingTimeSheet { fiveweek = false };
            form.MdiParent = this.MdiParent;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMissingTimeSheet form = new frmMissingTimeSheet { fiveweek = true };
            form.MdiParent = this.MdiParent;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void ButtonSelector()
        {
            switch (nextForm)
            { 
                case "frmMissingTimeSheet":
                    {
                        btnMainSheet.Visible = false;
                        break;
                    }
                case "frmMainSheet":
                    {
                        btnFourWeek.Visible = false;
                        btnFiveWeek.Visible = false;
                        btnMainSheet.Top = btnFourWeek.Top;
                        btnMainSheet.Left = btnFourWeek.Left;
                        btnMainSheet.Visible = true;
                        break;
                    }
            }
        }

        private void btnMainSheet_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "") return;
            frmMainSheet form = new frmMainSheet();
            form.MdiParent = this.MdiParent;
            form.ControlBox = false;
            
            form.Show();

        }
    }
}
