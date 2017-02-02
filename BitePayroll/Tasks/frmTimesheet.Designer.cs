using System;
using System.Windows.Forms;

namespace BitePayroll
{
    partial class frmTimesheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimesheet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lblyear = new System.Windows.Forms.Label();
            this.lblmonth = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cboMonths = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlBrowse = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOWeek5Rate = new System.Windows.Forms.TextBox();
            this.txtOWeek5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewMonth = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.txtClientExpenses = new System.Windows.Forms.TextBox();
            this.txtExpenses = new System.Windows.Forms.TextBox();
            this.txtOTime = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtOWeek4Rate = new System.Windows.Forms.TextBox();
            this.txtOWeek3Rate = new System.Windows.Forms.TextBox();
            this.txtOWeek2Rate = new System.Windows.Forms.TextBox();
            this.txtOWeek1Rate = new System.Windows.Forms.TextBox();
            this.txtWeek5Rate = new System.Windows.Forms.TextBox();
            this.txtWeek4Rate = new System.Windows.Forms.TextBox();
            this.txtWeek3Rate = new System.Windows.Forms.TextBox();
            this.txtWeek2Rate = new System.Windows.Forms.TextBox();
            this.txtWeek1Rate = new System.Windows.Forms.TextBox();
            this.txtOWeek4 = new System.Windows.Forms.TextBox();
            this.txtOWeek3 = new System.Windows.Forms.TextBox();
            this.txtOWeek2 = new System.Windows.Forms.TextBox();
            this.txtOWeek1 = new System.Windows.Forms.TextBox();
            this.txtWeek5 = new System.Windows.Forms.TextBox();
            this.txtWeek4 = new System.Windows.Forms.TextBox();
            this.txtWeek3 = new System.Windows.Forms.TextBox();
            this.txtWeek2 = new System.Windows.Forms.TextBox();
            this.txtWeek1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTotalHoursWorked = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlBrowse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Controls.Add(this.lblyear);
            this.panel1.Controls.Add(this.lblmonth);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.cboMonths);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.pnlBrowse);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtOWeek5Rate);
            this.panel1.Controls.Add(this.txtOWeek5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNewMonth);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.txtComments);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtAdvance);
            this.panel1.Controls.Add(this.txtClientExpenses);
            this.panel1.Controls.Add(this.txtExpenses);
            this.panel1.Controls.Add(this.txtOTime);
            this.panel1.Controls.Add(this.txtDays);
            this.panel1.Controls.Add(this.txtHours);
            this.panel1.Controls.Add(this.txtOWeek4Rate);
            this.panel1.Controls.Add(this.txtOWeek3Rate);
            this.panel1.Controls.Add(this.txtOWeek2Rate);
            this.panel1.Controls.Add(this.txtOWeek1Rate);
            this.panel1.Controls.Add(this.txtWeek5Rate);
            this.panel1.Controls.Add(this.txtWeek4Rate);
            this.panel1.Controls.Add(this.txtWeek3Rate);
            this.panel1.Controls.Add(this.txtWeek2Rate);
            this.panel1.Controls.Add(this.txtWeek1Rate);
            this.panel1.Controls.Add(this.txtOWeek4);
            this.panel1.Controls.Add(this.txtOWeek3);
            this.panel1.Controls.Add(this.txtOWeek2);
            this.panel1.Controls.Add(this.txtOWeek1);
            this.panel1.Controls.Add(this.txtWeek5);
            this.panel1.Controls.Add(this.txtWeek4);
            this.panel1.Controls.Add(this.txtWeek3);
            this.panel1.Controls.Add(this.txtWeek2);
            this.panel1.Controls.Add(this.txtWeek1);
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 549);
            this.panel1.TabIndex = 0;
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmdSave.Location = new System.Drawing.Point(299, 429);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(113, 33);
            this.cmdSave.TabIndex = 136;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Visible = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblyear.Location = new System.Drawing.Point(181, 77);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(35, 17);
            this.lblyear.TabIndex = 135;
            this.lblyear.Text = "Year";
            // 
            // lblmonth
            // 
            this.lblmonth.AutoSize = true;
            this.lblmonth.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblmonth.Location = new System.Drawing.Point(177, 46);
            this.lblmonth.Name = "lblmonth";
            this.lblmonth.Size = new System.Drawing.Size(87, 17);
            this.lblmonth.TabIndex = 134;
            this.lblmonth.Text = "Select Month";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtYear.Location = new System.Drawing.Point(270, 74);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 24);
            this.txtYear.TabIndex = 133;
            // 
            // cboMonths
            // 
            this.cboMonths.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboMonths.FormattingEnabled = true;
            this.cboMonths.Location = new System.Drawing.Point(270, 43);
            this.cboMonths.Name = "cboMonths";
            this.cboMonths.Size = new System.Drawing.Size(179, 25);
            this.cboMonths.TabIndex = 120;
            this.cboMonths.SelectedIndexChanged += new System.EventHandler(this.cboMonths_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(584, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(301, 132);
            this.dataGridView1.TabIndex = 120;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnCancel.Location = new System.Drawing.Point(180, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 33);
            this.btnCancel.TabIndex = 132;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlBrowse
            // 
            this.pnlBrowse.BackColor = System.Drawing.Color.Transparent;
            this.pnlBrowse.Controls.Add(this.button7);
            this.pnlBrowse.Controls.Add(this.button6);
            this.pnlBrowse.Controls.Add(this.button5);
            this.pnlBrowse.Controls.Add(this.button4);
            this.pnlBrowse.Controls.Add(this.button8);
            this.pnlBrowse.Location = new System.Drawing.Point(119, 465);
            this.pnlBrowse.Name = "pnlBrowse";
            this.pnlBrowse.Size = new System.Drawing.Size(327, 40);
            this.pnlBrowse.TabIndex = 131;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(229, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 31);
            this.button7.TabIndex = 134;
            this.button7.Text = ">*";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(187, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 31);
            this.button6.TabIndex = 133;
            this.button6.Text = ">|";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(145, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 31);
            this.button5.TabIndex = 132;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(103, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 31);
            this.button4.TabIndex = 131;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(61, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 31);
            this.button8.TabIndex = 130;
            this.button8.Text = "|<";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(296, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 53;
            this.label12.Text = "Rate";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label14.Location = new System.Drawing.Point(450, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 17);
            this.label14.TabIndex = 52;
            this.label14.Text = "Comments";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label15.Location = new System.Drawing.Point(450, 315);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 17);
            this.label15.TabIndex = 51;
            this.label15.Text = "Total";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label16.Location = new System.Drawing.Point(450, 287);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 17);
            this.label16.TabIndex = 50;
            this.label16.Text = "Advance";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label18.Location = new System.Drawing.Point(450, 259);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 17);
            this.label18.TabIndex = 49;
            this.label18.Text = "Client Expenses";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label19.Location = new System.Drawing.Point(450, 231);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 17);
            this.label19.TabIndex = 48;
            this.label19.Text = "Total Expenses";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label20.Location = new System.Drawing.Point(450, 203);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 17);
            this.label20.TabIndex = 47;
            this.label20.Text = "Overtime Worked";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label21.Location = new System.Drawing.Point(450, 175);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 17);
            this.label21.TabIndex = 46;
            this.label21.Text = "Days";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label22.Location = new System.Drawing.Point(450, 147);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 17);
            this.label22.TabIndex = 45;
            this.label22.Text = "Hours";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label11.Location = new System.Drawing.Point(27, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "O-Week 5";
            // 
            // txtOWeek5Rate
            // 
            this.txtOWeek5Rate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtOWeek5Rate.Location = new System.Drawing.Point(289, 398);
            this.txtOWeek5Rate.Name = "txtOWeek5Rate";
            this.txtOWeek5Rate.Size = new System.Drawing.Size(100, 24);
            this.txtOWeek5Rate.TabIndex = 43;
            this.txtOWeek5Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtOWeek5
            // 
            this.txtOWeek5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtOWeek5.Location = new System.Drawing.Point(183, 398);
            this.txtOWeek5.Name = "txtOWeek5";
            this.txtOWeek5.Size = new System.Drawing.Size(100, 24);
            this.txtOWeek5.TabIndex = 42;
            this.txtOWeek5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label10.Location = new System.Drawing.Point(27, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "O-Week 4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label9.Location = new System.Drawing.Point(27, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "O-Week 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label8.Location = new System.Drawing.Point(27, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "O-Week 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label7.Location = new System.Drawing.Point(27, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "O-Week 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label5.Location = new System.Drawing.Point(27, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Week 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(27, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Week 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(27, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Week 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(27, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Week 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(27, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Week 1";
            // 
            // btnNewMonth
            // 
            this.btnNewMonth.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnNewMonth.Location = new System.Drawing.Point(703, 441);
            this.btnNewMonth.Name = "btnNewMonth";
            this.btnNewMonth.Size = new System.Drawing.Size(113, 33);
            this.btnNewMonth.TabIndex = 30;
            this.btnNewMonth.Text = "New Month";
            this.btnNewMonth.UseVisualStyleBackColor = true;
            this.btnNewMonth.Click += new System.EventHandler(this.btnNewMonth_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnCalculate.Location = new System.Drawing.Point(584, 441);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(113, 33);
            this.btnCalculate.TabIndex = 29;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtComments
            // 
            this.txtComments.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtComments.Location = new System.Drawing.Point(584, 340);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(392, 95);
            this.txtComments.TabIndex = 28;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTotal.Location = new System.Drawing.Point(584, 312);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(216, 24);
            this.txtTotal.TabIndex = 27;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtAdvance
            // 
            this.txtAdvance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAdvance.Location = new System.Drawing.Point(584, 284);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(216, 24);
            this.txtAdvance.TabIndex = 26;
            this.txtAdvance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtClientExpenses
            // 
            this.txtClientExpenses.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtClientExpenses.Location = new System.Drawing.Point(584, 256);
            this.txtClientExpenses.Name = "txtClientExpenses";
            this.txtClientExpenses.Size = new System.Drawing.Size(216, 24);
            this.txtClientExpenses.TabIndex = 25;
            this.txtClientExpenses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtExpenses
            // 
            this.txtExpenses.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtExpenses.Location = new System.Drawing.Point(584, 228);
            this.txtExpenses.Name = "txtExpenses";
            this.txtExpenses.Size = new System.Drawing.Size(216, 24);
            this.txtExpenses.TabIndex = 24;
            this.txtExpenses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtOTime
            // 
            this.txtOTime.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtOTime.Location = new System.Drawing.Point(584, 200);
            this.txtOTime.Name = "txtOTime";
            this.txtOTime.Size = new System.Drawing.Size(216, 24);
            this.txtOTime.TabIndex = 23;
            this.txtOTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtDays
            // 
            this.txtDays.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDays.Location = new System.Drawing.Point(584, 172);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(216, 24);
            this.txtDays.TabIndex = 22;
            this.txtDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtHours.Location = new System.Drawing.Point(584, 144);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(216, 24);
            this.txtHours.TabIndex = 21;
            this.txtHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtOWeek4Rate
            // 
            this.txtOWeek4Rate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtOWeek4Rate.Location = new System.Drawing.Point(289, 370);
            this.txtOWeek4Rate.Name = "txtOWeek4Rate";
            this.txtOWeek4Rate.Size = new System.Drawing.Size(100, 24);
            this.txtOWeek4Rate.TabIndex = 20;
            this.txtOWeek4Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtOWeek3Rate
            // 
            this.txtOWeek3Rate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtOWeek3Rate.Location = new System.Drawing.Point(289, 342);
            this.txtOWeek3Rate.Name = "txtOWeek3Rate";
            this.txtOWeek3Rate.Size = new System.Drawing.Size(100, 24);
            this.txtOWeek3Rate.TabIndex = 19;
            this.txtOWeek3Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtOWeek2Rate
            // 
            this.txtOWeek2Rate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtOWeek2Rate.Location = new System.Drawing.Point(289, 314);
            this.txtOWeek2Rate.Name = "txtOWeek2Rate";
            this.txtOWeek2Rate.Size = new System.Drawing.Size(100, 24);
            this.txtOWeek2Rate.TabIndex = 18;
            this.txtOWeek2Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtOWeek1Rate
            // 
            this.txtOWeek1Rate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtOWeek1Rate.Location = new System.Drawing.Point(289, 286);
            this.txtOWeek1Rate.Name = "txtOWeek1Rate";
            this.txtOWeek1Rate.Size = new System.Drawing.Size(100, 24);
            this.txtOWeek1Rate.TabIndex = 17;
            this.txtOWeek1Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtWeek5Rate
            // 
            this.txtWeek5Rate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtWeek5Rate.Location = new System.Drawing.Point(289, 256);
            this.txtWeek5Rate.Name = "txtWeek5Rate";
            this.txtWeek5Rate.Size = new System.Drawing.Size(100, 24);
            this.txtWeek5Rate.TabIndex = 15;
            this.txtWeek5Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtWeek4Rate
            // 
            this.txtWeek4Rate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtWeek4Rate.Location = new System.Drawing.Point(289, 228);
            this.txtWeek4Rate.Name = "txtWeek4Rate";
            this.txtWeek4Rate.Size = new System.Drawing.Size(100, 24);
            this.txtWeek4Rate.TabIndex = 14;
            this.txtWeek4Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtWeek3Rate
            // 
            this.txtWeek3Rate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtWeek3Rate.Location = new System.Drawing.Point(289, 200);
            this.txtWeek3Rate.Name = "txtWeek3Rate";
            this.txtWeek3Rate.Size = new System.Drawing.Size(100, 24);
            this.txtWeek3Rate.TabIndex = 13;
            this.txtWeek3Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtWeek2Rate
            // 
            this.txtWeek2Rate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtWeek2Rate.Location = new System.Drawing.Point(289, 172);
            this.txtWeek2Rate.Name = "txtWeek2Rate";
            this.txtWeek2Rate.Size = new System.Drawing.Size(100, 24);
            this.txtWeek2Rate.TabIndex = 12;
            this.txtWeek2Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtWeek1Rate
            // 
            this.txtWeek1Rate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtWeek1Rate.Location = new System.Drawing.Point(289, 144);
            this.txtWeek1Rate.Name = "txtWeek1Rate";
            this.txtWeek1Rate.Size = new System.Drawing.Size(100, 24);
            this.txtWeek1Rate.TabIndex = 11;
            this.txtWeek1Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtOWeek4
            // 
            this.txtOWeek4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtOWeek4.Location = new System.Drawing.Point(183, 370);
            this.txtOWeek4.Name = "txtOWeek4";
            this.txtOWeek4.Size = new System.Drawing.Size(100, 24);
            this.txtOWeek4.TabIndex = 10;
            this.txtOWeek4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtOWeek3
            // 
            this.txtOWeek3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtOWeek3.Location = new System.Drawing.Point(183, 342);
            this.txtOWeek3.Name = "txtOWeek3";
            this.txtOWeek3.Size = new System.Drawing.Size(100, 24);
            this.txtOWeek3.TabIndex = 9;
            this.txtOWeek3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtOWeek2
            // 
            this.txtOWeek2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtOWeek2.Location = new System.Drawing.Point(183, 314);
            this.txtOWeek2.Name = "txtOWeek2";
            this.txtOWeek2.Size = new System.Drawing.Size(100, 24);
            this.txtOWeek2.TabIndex = 8;
            this.txtOWeek2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtOWeek1
            // 
            this.txtOWeek1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOWeek1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtOWeek1.Location = new System.Drawing.Point(183, 286);
            this.txtOWeek1.Name = "txtOWeek1";
            this.txtOWeek1.Size = new System.Drawing.Size(100, 24);
            this.txtOWeek1.TabIndex = 7;
            this.txtOWeek1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtWeek5
            // 
            this.txtWeek5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtWeek5.Location = new System.Drawing.Point(183, 256);
            this.txtWeek5.Name = "txtWeek5";
            this.txtWeek5.Size = new System.Drawing.Size(100, 24);
            this.txtWeek5.TabIndex = 5;
            this.txtWeek5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtWeek4
            // 
            this.txtWeek4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtWeek4.Location = new System.Drawing.Point(183, 228);
            this.txtWeek4.Name = "txtWeek4";
            this.txtWeek4.Size = new System.Drawing.Size(100, 24);
            this.txtWeek4.TabIndex = 4;
            this.txtWeek4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtWeek3
            // 
            this.txtWeek3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtWeek3.Location = new System.Drawing.Point(183, 200);
            this.txtWeek3.Name = "txtWeek3";
            this.txtWeek3.Size = new System.Drawing.Size(100, 24);
            this.txtWeek3.TabIndex = 3;
            this.txtWeek3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtWeek2
            // 
            this.txtWeek2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtWeek2.Location = new System.Drawing.Point(183, 172);
            this.txtWeek2.Name = "txtWeek2";
            this.txtWeek2.Size = new System.Drawing.Size(100, 24);
            this.txtWeek2.TabIndex = 2;
            this.txtWeek2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtWeek1
            // 
            this.txtWeek1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtWeek1.Location = new System.Drawing.Point(183, 144);
            this.txtWeek1.Name = "txtWeek1";
            this.txtWeek1.Size = new System.Drawing.Size(100, 24);
            this.txtWeek1.TabIndex = 1;
            this.txtWeek1.TextChanged += new System.EventHandler(this.txtWeek1_TextChanged);
            this.txtWeek1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(223, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 25);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtTotalHoursWorked
            // 
            this.txtTotalHoursWorked.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTotalHoursWorked.Location = new System.Drawing.Point(408, 63);
            this.txtTotalHoursWorked.Name = "txtTotalHoursWorked";
            this.txtTotalHoursWorked.Size = new System.Drawing.Size(100, 24);
            this.txtTotalHoursWorked.TabIndex = 31;
            this.txtTotalHoursWorked.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnClose.Location = new System.Drawing.Point(223, 93);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 33);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close Form";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 36);
            this.panel2.TabIndex = 117;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1013, 36);
            this.label17.TabIndex = 0;
            this.label17.Text = "Add New Time Sheet";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label6.Location = new System.Drawing.Point(231, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 118;
            this.label6.Text = "Select a Contractor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label13.Location = new System.Drawing.Point(414, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 119;
            this.label13.Text = "Days Worked";
            // 
            // frmTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 650);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTotalHoursWorked);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimesheet";
            this.Text = "frmTimesheet";
            this.Load += new System.EventHandler(this.frmTimesheet_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlBrowse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       



        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOWeek4Rate;
        private System.Windows.Forms.TextBox txtOWeek3Rate;
        private System.Windows.Forms.TextBox txtOWeek2Rate;
        private System.Windows.Forms.TextBox txtOWeek1Rate;
        private System.Windows.Forms.TextBox txtWeek5Rate;
        private System.Windows.Forms.TextBox txtWeek4Rate;
        private System.Windows.Forms.TextBox txtWeek3Rate;
        private System.Windows.Forms.TextBox txtWeek2Rate;
        private System.Windows.Forms.TextBox txtWeek1Rate;
        private System.Windows.Forms.TextBox txtOWeek4;
        private System.Windows.Forms.TextBox txtOWeek3;
        private System.Windows.Forms.TextBox txtOWeek2;
        private System.Windows.Forms.TextBox txtOWeek1;
        private System.Windows.Forms.TextBox txtWeek5;
        private System.Windows.Forms.TextBox txtWeek4;
        private System.Windows.Forms.TextBox txtWeek3;
        private System.Windows.Forms.TextBox txtWeek2;
        private System.Windows.Forms.TextBox txtWeek1;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.TextBox txtClientExpenses;
        private System.Windows.Forms.TextBox txtExpenses;
        private System.Windows.Forms.TextBox txtOTime;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnNewMonth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtTotalHoursWorked;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOWeek5Rate;
        private System.Windows.Forms.TextBox txtOWeek5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlBrowse;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Label lblyear;
        private Label lblmonth;
        private TextBox txtYear;
        private ComboBox cboMonths;
        private Button cmdSave;
    }
}