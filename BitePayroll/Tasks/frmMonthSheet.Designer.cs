namespace BitePayroll
{
    partial class frmMonthSheet
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFourWeek = new System.Windows.Forms.Button();
            this.btnFiveWeek = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMainSheet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnFourWeek
            // 
            this.btnFourWeek.Location = new System.Drawing.Point(119, 133);
            this.btnFourWeek.Name = "btnFourWeek";
            this.btnFourWeek.Size = new System.Drawing.Size(113, 33);
            this.btnFourWeek.TabIndex = 2;
            this.btnFourWeek.Text = "4 week month";
            this.btnFourWeek.UseVisualStyleBackColor = true;
            this.btnFourWeek.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFiveWeek
            // 
            this.btnFiveWeek.Location = new System.Drawing.Point(238, 133);
            this.btnFiveWeek.Name = "btnFiveWeek";
            this.btnFiveWeek.Size = new System.Drawing.Size(113, 33);
            this.btnFiveWeek.TabIndex = 3;
            this.btnFiveWeek.Text = "5 week month";
            this.btnFiveWeek.UseVisualStyleBackColor = true;
            this.btnFiveWeek.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(119, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "Close Form";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Year";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 36);
            this.panel1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Month";
            // 
            // btnMainSheet
            // 
            this.btnMainSheet.Location = new System.Drawing.Point(238, 172);
            this.btnMainSheet.Name = "btnMainSheet";
            this.btnMainSheet.Size = new System.Drawing.Size(113, 33);
            this.btnMainSheet.TabIndex = 28;
            this.btnMainSheet.Text = "Open Form";
            this.btnMainSheet.UseVisualStyleBackColor = true;
            this.btnMainSheet.Click += new System.EventHandler(this.btnMainSheet_Click);
            // 
            // frmMonthSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 253);
            this.Controls.Add(this.btnMainSheet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnFiveWeek);
            this.Controls.Add(this.btnFourWeek);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMonthSheet";
            this.Text = "Select Month";
            this.Load += new System.EventHandler(this.frmMonthSheet_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFourWeek;
        private System.Windows.Forms.Button btnFiveWeek;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMainSheet;
    }
}