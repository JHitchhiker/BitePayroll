using System;
using System.Windows.Forms;

namespace BitePayroll
{
    partial class frmAddContractor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddContractor));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtOvertimeRate = new System.Windows.Forms.TextBox();
            this.txtAgency2 = new System.Windows.Forms.TextBox();
            this.txtContractEnd = new System.Windows.Forms.TextBox();
            this.txtStandardMargin = new System.Windows.Forms.TextBox();
            this.txtAgency = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtTimesheet = new System.Windows.Forms.TextBox();
            this.txtOvertimeMargin = new System.Windows.Forms.TextBox();
            this.chkDaily = new System.Windows.Forms.CheckBox();
            this.chkHourly = new System.Windows.Forms.CheckBox();
            this.cboAssociateCompany = new System.Windows.Forms.ComboBox();
            this.cboInvoiced = new System.Windows.Forms.ComboBox();
            this.cboPayroll = new System.Windows.Forms.ComboBox();
            this.chkWorkPermit = new System.Windows.Forms.CheckBox();
            this.chkCharity = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(560, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtName.Location = new System.Drawing.Point(560, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(255, 24);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSurname.Location = new System.Drawing.Point(560, 110);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(255, 24);
            this.txtSurname.TabIndex = 2;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtRate.Location = new System.Drawing.Point(560, 138);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 24);
            this.txtRate.TabIndex = 3;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtOvertimeRate
            // 
            this.txtOvertimeRate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtOvertimeRate.Location = new System.Drawing.Point(560, 166);
            this.txtOvertimeRate.Name = "txtOvertimeRate";
            this.txtOvertimeRate.Size = new System.Drawing.Size(100, 24);
            this.txtOvertimeRate.TabIndex = 4;
            this.txtOvertimeRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtAgency2
            // 
            this.txtAgency2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAgency2.Location = new System.Drawing.Point(560, 252);
            this.txtAgency2.Name = "txtAgency2";
            this.txtAgency2.Size = new System.Drawing.Size(100, 24);
            this.txtAgency2.TabIndex = 5;
            // 
            // txtContractEnd
            // 
            this.txtContractEnd.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtContractEnd.Location = new System.Drawing.Point(560, 414);
            this.txtContractEnd.Name = "txtContractEnd";
            this.txtContractEnd.Size = new System.Drawing.Size(100, 24);
            this.txtContractEnd.TabIndex = 6;
            // 
            // txtStandardMargin
            // 
            this.txtStandardMargin.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStandardMargin.Location = new System.Drawing.Point(886, 414);
            this.txtStandardMargin.Name = "txtStandardMargin";
            this.txtStandardMargin.Size = new System.Drawing.Size(145, 24);
            this.txtStandardMargin.TabIndex = 7;
            this.txtStandardMargin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtAgency
            // 
            this.txtAgency.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAgency.Location = new System.Drawing.Point(560, 224);
            this.txtAgency.Name = "txtAgency";
            this.txtAgency.Size = new System.Drawing.Size(100, 24);
            this.txtAgency.TabIndex = 8;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtNumber.Location = new System.Drawing.Point(560, 280);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 24);
            this.txtNumber.TabIndex = 9;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtInfo.Location = new System.Drawing.Point(560, 308);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(255, 72);
            this.txtInfo.TabIndex = 10;
            // 
            // txtTimesheet
            // 
            this.txtTimesheet.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTimesheet.Location = new System.Drawing.Point(560, 386);
            this.txtTimesheet.Name = "txtTimesheet";
            this.txtTimesheet.Size = new System.Drawing.Size(100, 24);
            this.txtTimesheet.TabIndex = 11;
            // 
            // txtOvertimeMargin
            // 
            this.txtOvertimeMargin.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtOvertimeMargin.Location = new System.Drawing.Point(886, 442);
            this.txtOvertimeMargin.Name = "txtOvertimeMargin";
            this.txtOvertimeMargin.Size = new System.Drawing.Size(145, 24);
            this.txtOvertimeMargin.TabIndex = 12;
            this.txtOvertimeMargin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // chkDaily
            // 
            this.chkDaily.AutoSize = true;
            this.chkDaily.BackColor = System.Drawing.Color.Transparent;
            this.chkDaily.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.chkDaily.Location = new System.Drawing.Point(678, 138);
            this.chkDaily.Name = "chkDaily";
            this.chkDaily.Size = new System.Drawing.Size(91, 21);
            this.chkDaily.TabIndex = 13;
            this.chkDaily.Text = "Daily Rate";
            this.chkDaily.UseVisualStyleBackColor = false;
            // 
            // chkHourly
            // 
            this.chkHourly.AutoSize = true;
            this.chkHourly.BackColor = System.Drawing.Color.Transparent;
            this.chkHourly.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.chkHourly.Location = new System.Drawing.Point(789, 138);
            this.chkHourly.Name = "chkHourly";
            this.chkHourly.Size = new System.Drawing.Size(102, 21);
            this.chkHourly.TabIndex = 14;
            this.chkHourly.Text = "Hourly Rate";
            this.chkHourly.UseVisualStyleBackColor = false;
            // 
            // cboAssociateCompany
            // 
            this.cboAssociateCompany.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboAssociateCompany.FormattingEnabled = true;
            this.cboAssociateCompany.Location = new System.Drawing.Point(560, 194);
            this.cboAssociateCompany.Name = "cboAssociateCompany";
            this.cboAssociateCompany.Size = new System.Drawing.Size(255, 25);
            this.cboAssociateCompany.TabIndex = 15;
            // 
            // cboInvoiced
            // 
            this.cboInvoiced.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboInvoiced.FormattingEnabled = true;
            this.cboInvoiced.Location = new System.Drawing.Point(886, 386);
            this.cboInvoiced.Name = "cboInvoiced";
            this.cboInvoiced.Size = new System.Drawing.Size(145, 25);
            this.cboInvoiced.TabIndex = 16;
            // 
            // cboPayroll
            // 
            this.cboPayroll.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboPayroll.FormattingEnabled = true;
            this.cboPayroll.Location = new System.Drawing.Point(560, 442);
            this.cboPayroll.Name = "cboPayroll";
            this.cboPayroll.Size = new System.Drawing.Size(145, 25);
            this.cboPayroll.TabIndex = 17;
            // 
            // chkWorkPermit
            // 
            this.chkWorkPermit.AutoSize = true;
            this.chkWorkPermit.BackColor = System.Drawing.Color.Transparent;
            this.chkWorkPermit.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.chkWorkPermit.Location = new System.Drawing.Point(470, 472);
            this.chkWorkPermit.Name = "chkWorkPermit";
            this.chkWorkPermit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkWorkPermit.Size = new System.Drawing.Size(107, 21);
            this.chkWorkPermit.TabIndex = 18;
            this.chkWorkPermit.Text = "Work Permit";
            this.chkWorkPermit.UseVisualStyleBackColor = false;
            // 
            // chkCharity
            // 
            this.chkCharity.AutoSize = true;
            this.chkCharity.BackColor = System.Drawing.Color.Transparent;
            this.chkCharity.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.chkCharity.Location = new System.Drawing.Point(503, 499);
            this.chkCharity.Name = "chkCharity";
            this.chkCharity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCharity.Size = new System.Drawing.Size(74, 21);
            this.chkCharity.TabIndex = 19;
            this.chkCharity.Text = "Charity";
            this.chkCharity.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(408, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(408, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Overtime Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(408, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(408, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label5.Location = new System.Drawing.Point(408, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label6.Location = new System.Drawing.Point(408, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Associate Company";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label7.Location = new System.Drawing.Point(408, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Agency";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label8.Location = new System.Drawing.Point(408, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Agency 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label9.Location = new System.Drawing.Point(408, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label10.Location = new System.Drawing.Point(408, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Info";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label11.Location = new System.Drawing.Point(408, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Time Sheet Submitted";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label12.Location = new System.Drawing.Point(408, 419);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Contract End";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label13.Location = new System.Drawing.Point(408, 447);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Payroll";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label14.Location = new System.Drawing.Point(755, 389);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "Invoiced";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label15.Location = new System.Drawing.Point(755, 417);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 17);
            this.label15.TabIndex = 34;
            this.label15.Text = "Standard Margin";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label16.Location = new System.Drawing.Point(755, 445);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "Overtime Margin";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.button1.Location = new System.Drawing.Point(776, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 33);
            this.button1.TabIndex = 36;
            this.button1.Text = "Add Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.button2.Location = new System.Drawing.Point(900, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 32);
            this.button2.TabIndex = 37;
            this.button2.Text = "Close Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 36);
            this.panel1.TabIndex = 116;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1081, 36);
            this.label17.TabIndex = 0;
            this.label17.Text = "Add New Contractor";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddContractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkCharity);
            this.Controls.Add(this.chkWorkPermit);
            this.Controls.Add(this.cboPayroll);
            this.Controls.Add(this.cboInvoiced);
            this.Controls.Add(this.cboAssociateCompany);
            this.Controls.Add(this.chkHourly);
            this.Controls.Add(this.chkDaily);
            this.Controls.Add(this.txtOvertimeMargin);
            this.Controls.Add(this.txtTimesheet);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtAgency);
            this.Controls.Add(this.txtStandardMargin);
            this.Controls.Add(this.txtContractEnd);
            this.Controls.Add(this.txtAgency2);
            this.Controls.Add(this.txtOvertimeRate);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddContractor";
            this.Text = "Add New Contractor";
            this.Load += new System.EventHandler(this.frmAddContractor_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      
        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtOvertimeRate;
        private System.Windows.Forms.TextBox txtAgency2;
        private System.Windows.Forms.TextBox txtContractEnd;
        private System.Windows.Forms.TextBox txtStandardMargin;
        private System.Windows.Forms.TextBox txtAgency;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtTimesheet;
        private System.Windows.Forms.TextBox txtOvertimeMargin;
        private System.Windows.Forms.CheckBox chkDaily;
        private System.Windows.Forms.CheckBox chkHourly;
        private System.Windows.Forms.ComboBox cboAssociateCompany;
        private System.Windows.Forms.ComboBox cboInvoiced;
        private System.Windows.Forms.ComboBox cboPayroll;
        private System.Windows.Forms.CheckBox chkWorkPermit;
        private System.Windows.Forms.CheckBox chkCharity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Panel panel1;
        private Label label17;
    }
}

