namespace BTL_Lich
{
    partial class Calender
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calender));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmpPreMonth = new System.Windows.Forms.Button();
            this.cmpNextMonth = new System.Windows.Forms.Button();
            this.cmdThu = new System.Windows.Forms.Button();
            this.cmdSun = new System.Windows.Forms.Button();
            this.cmdSat = new System.Windows.Forms.Button();
            this.cmdFri = new System.Windows.Forms.Button();
            this.cmdWed = new System.Windows.Forms.Button();
            this.cmdTue = new System.Windows.Forms.Button();
            this.cmdMon = new System.Windows.Forms.Button();
            this.pnlMaTrixNgay = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nmNotify = new System.Windows.Forms.NumericUpDown();
            this.ckbTB = new System.Windows.Forms.CheckBox();
            this.cmdToDay = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.tmNotify = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmnJob = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 421);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pnlMaTrixNgay);
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 375);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmpPreMonth);
            this.panel4.Controls.Add(this.cmpNextMonth);
            this.panel4.Controls.Add(this.cmdThu);
            this.panel4.Controls.Add(this.cmdSun);
            this.panel4.Controls.Add(this.cmdSat);
            this.panel4.Controls.Add(this.cmdFri);
            this.panel4.Controls.Add(this.cmdWed);
            this.panel4.Controls.Add(this.cmdTue);
            this.panel4.Controls.Add(this.cmdMon);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(704, 53);
            this.panel4.TabIndex = 2;
            // 
            // cmpPreMonth
            // 
            this.cmpPreMonth.Location = new System.Drawing.Point(3, 3);
            this.cmpPreMonth.Name = "cmpPreMonth";
            this.cmpPreMonth.Size = new System.Drawing.Size(60, 43);
            this.cmpPreMonth.TabIndex = 10;
            this.cmpPreMonth.Text = "<";
            this.cmpPreMonth.UseVisualStyleBackColor = true;
            this.cmpPreMonth.Click += new System.EventHandler(this.cmpPreMonth_Click);
            // 
            // cmpNextMonth
            // 
            this.cmpNextMonth.Location = new System.Drawing.Point(636, 3);
            this.cmpNextMonth.Name = "cmpNextMonth";
            this.cmpNextMonth.Size = new System.Drawing.Size(60, 43);
            this.cmpNextMonth.TabIndex = 9;
            this.cmpNextMonth.Text = ">";
            this.cmpNextMonth.UseVisualStyleBackColor = true;
            this.cmpNextMonth.Click += new System.EventHandler(this.cmpNextMonth_Click);
            // 
            // cmdThu
            // 
            this.cmdThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdThu.Location = new System.Drawing.Point(312, 3);
            this.cmdThu.Name = "cmdThu";
            this.cmdThu.Size = new System.Drawing.Size(75, 43);
            this.cmdThu.TabIndex = 3;
            this.cmdThu.Text = "Thứ 5";
            this.cmdThu.UseVisualStyleBackColor = true;
            // 
            // cmdSun
            // 
            this.cmdSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSun.Location = new System.Drawing.Point(555, 3);
            this.cmdSun.Name = "cmdSun";
            this.cmdSun.Size = new System.Drawing.Size(75, 43);
            this.cmdSun.TabIndex = 6;
            this.cmdSun.Text = "Chủ nhật";
            this.cmdSun.UseVisualStyleBackColor = true;
            // 
            // cmdSat
            // 
            this.cmdSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSat.Location = new System.Drawing.Point(474, 3);
            this.cmdSat.Name = "cmdSat";
            this.cmdSat.Size = new System.Drawing.Size(75, 43);
            this.cmdSat.TabIndex = 5;
            this.cmdSat.Text = "Thứ 7";
            this.cmdSat.UseVisualStyleBackColor = true;
            // 
            // cmdFri
            // 
            this.cmdFri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFri.Location = new System.Drawing.Point(393, 3);
            this.cmdFri.Name = "cmdFri";
            this.cmdFri.Size = new System.Drawing.Size(75, 43);
            this.cmdFri.TabIndex = 4;
            this.cmdFri.Text = "Thứ 6";
            this.cmdFri.UseVisualStyleBackColor = true;
            // 
            // cmdWed
            // 
            this.cmdWed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWed.Location = new System.Drawing.Point(231, 3);
            this.cmdWed.Name = "cmdWed";
            this.cmdWed.Size = new System.Drawing.Size(75, 43);
            this.cmdWed.TabIndex = 2;
            this.cmdWed.Text = "Thứ 4";
            this.cmdWed.UseVisualStyleBackColor = true;
            // 
            // cmdTue
            // 
            this.cmdTue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTue.Location = new System.Drawing.Point(150, 3);
            this.cmdTue.Name = "cmdTue";
            this.cmdTue.Size = new System.Drawing.Size(75, 43);
            this.cmdTue.TabIndex = 1;
            this.cmdTue.Text = "Thứ 3";
            this.cmdTue.UseVisualStyleBackColor = true;
            // 
            // cmdMon
            // 
            this.cmdMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMon.Location = new System.Drawing.Point(69, 3);
            this.cmdMon.Name = "cmdMon";
            this.cmdMon.Size = new System.Drawing.Size(75, 43);
            this.cmdMon.TabIndex = 0;
            this.cmdMon.Text = "Thứ 2";
            this.cmdMon.UseVisualStyleBackColor = true;
            // 
            // pnlMaTrixNgay
            // 
            this.pnlMaTrixNgay.Location = new System.Drawing.Point(72, 62);
            this.pnlMaTrixNgay.Name = "pnlMaTrixNgay";
            this.pnlMaTrixNgay.Size = new System.Drawing.Size(564, 304);
            this.pnlMaTrixNgay.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.cmdToDay);
            this.panel3.Controls.Add(this.dtpkDate);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 37);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.nmNotify);
            this.panel5.Controls.Add(this.ckbTB);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 37);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phút";
            // 
            // nmNotify
            // 
            this.nmNotify.Enabled = false;
            this.nmNotify.Location = new System.Drawing.Point(96, 8);
            this.nmNotify.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNotify.Name = "nmNotify";
            this.nmNotify.Size = new System.Drawing.Size(48, 20);
            this.nmNotify.TabIndex = 1;
            this.nmNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNotify.ValueChanged += new System.EventHandler(this.nmTB_ValueChanged);
            // 
            // ckbTB
            // 
            this.ckbTB.AutoSize = true;
            this.ckbTB.Location = new System.Drawing.Point(12, 11);
            this.ckbTB.Name = "ckbTB";
            this.ckbTB.Size = new System.Drawing.Size(78, 17);
            this.ckbTB.TabIndex = 0;
            this.ckbTB.Text = "Thông báo";
            this.ckbTB.UseVisualStyleBackColor = true;
            this.ckbTB.CheckedChanged += new System.EventHandler(this.ckbTB_CheckedChanged);
            // 
            // cmdToDay
            // 
            this.cmdToDay.Location = new System.Drawing.Point(458, 3);
            this.cmdToDay.Name = "cmdToDay";
            this.cmdToDay.Size = new System.Drawing.Size(75, 23);
            this.cmdToDay.TabIndex = 1;
            this.cmdToDay.Text = "Hôm nay";
            this.cmdToDay.UseVisualStyleBackColor = true;
            this.cmdToDay.Click += new System.EventHandler(this.cmdToDay_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(231, 6);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(202, 20);
            this.dtpkDate.TabIndex = 0;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // tmNotify
            // 
            this.tmNotify.Enabled = true;
            this.tmNotify.Interval = 5000;
            this.tmNotify.Tick += new System.EventHandler(this.tmNotify_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Thông báo";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnJob,
            this.tsmnExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 48);
            // 
            // tsmnJob
            // 
            this.tsmnJob.Name = "tsmnJob";
            this.tsmnJob.Size = new System.Drawing.Size(150, 22);
            this.tsmnJob.Text = "Lịch công việc";
            this.tsmnJob.Click += new System.EventHandler(this.tsmnJob_Click);
            // 
            // tsmnExit
            // 
            this.tsmnExit.Name = "tsmnExit";
            this.tsmnExit.Size = new System.Drawing.Size(150, 22);
            this.tsmnExit.Text = "Thoát";
            this.tsmnExit.Click += new System.EventHandler(this.tsmnExit_Click);
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 436);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Calender_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button cmdThu;
        private System.Windows.Forms.Button cmdSun;
        private System.Windows.Forms.Button cmdSat;
        private System.Windows.Forms.Button cmdFri;
        private System.Windows.Forms.Button cmdWed;
        private System.Windows.Forms.Button cmdTue;
        private System.Windows.Forms.Button cmdMon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown nmNotify;
        private System.Windows.Forms.CheckBox ckbTB;
        private System.Windows.Forms.Button cmdToDay;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Panel pnlMaTrixNgay;
        private System.Windows.Forms.Button cmpNextMonth;
        private System.Windows.Forms.Button btnPreMonth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmpPreMonth;
        private System.Windows.Forms.Timer tmNotify;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmnJob;
        private System.Windows.Forms.ToolStripMenuItem tsmnExit;
        private System.Windows.Forms.Label label1;
    }
}

