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
    public partial class frmMissingTimeSheet : Form
    {
        public bool fiveweek { get; set; }
        public frmMissingTimeSheet()
        {
            InitializeComponent();
        }

        private void frmMissingTimeSheet_Load(object sender, EventArgs e)
        {
            LoadGrid();
            GridSize();
        }
        
        private void onPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle BaseRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            Brush Gradient_Brush = new LinearGradientBrush(BaseRectangle, Color.White, Color.FromArgb(8, 197, 112), LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(Gradient_Brush, BaseRectangle);
        }

        private void LoadGrid()
        {
            ViewRepository repository = new ViewRepository();
            var gridItems = repository.GetNotWorking().Where(e=> e.Month == GlobalValues.Instance.CurrentMonth).ToList();

            dataGridView1.DataSource = gridItems;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[7].Visible = fiveweek;

            for (int i = 0; i < gridItems.Count; i++)
            {
                if (gridItems[i].Week1 == 0) dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Red;
                if (gridItems[i].Week2 == 0) dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Red;
                if (gridItems[i].Week3 == 0) dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Red;
                if (gridItems[i].Week4 == 0) dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.Red;
                if (gridItems[i].Week5 == 0) dataGridView1.Rows[i].Cells[7].Style.BackColor = Color.Red;
            }
        }
        private void frmMissingTimeSheet_Resize(object sender, EventArgs e)
        {
            GridSize();
        }

        private void GridSize()
        {
            dataGridView1.Width = this.Width - 50;
            dataGridView1.Height = this.Height - dataGridView1.Top - 50;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
