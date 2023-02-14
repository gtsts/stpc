namespace smpc
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lpctime = new System.Windows.Forms.Label();
            this.pctime = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dc = new System.Windows.Forms.CheckBox();
            this.dateP = new System.Windows.Forms.DateTimePicker();
            this.TimeP = new System.Windows.Forms.DateTimePicker();
            this.jc = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pc = new System.Windows.Forms.CheckBox();
            this.pl = new System.Windows.Forms.Label();
            this.pt = new System.Windows.Forms.TextBox();
            this.jtimer = new System.Windows.Forms.Timer(this.components);
            this.cb = new System.Windows.Forms.ComboBox();
            this.ptn = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.nfi = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ht = new System.Windows.Forms.NumericUpDown();
            this.st = new System.Windows.Forms.NumericUpDown();
            this.mt = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.st)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "电脑时间";
            // 
            // lpctime
            // 
            this.lpctime.AutoSize = true;
            this.lpctime.Font = new System.Drawing.Font("宋体", 14F);
            this.lpctime.Location = new System.Drawing.Point(103, 9);
            this.lpctime.Name = "lpctime";
            this.lpctime.Size = new System.Drawing.Size(0, 19);
            this.lpctime.TabIndex = 1;
            // 
            // pctime
            // 
            this.pctime.Interval = 1000;
            this.pctime.Tick += new System.EventHandler(this.Pctime_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10F);
            this.button1.Location = new System.Drawing.Point(296, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dc
            // 
            this.dc.AutoSize = true;
            this.dc.Font = new System.Drawing.Font("宋体", 10F);
            this.dc.Location = new System.Drawing.Point(16, 49);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(82, 18);
            this.dc.TabIndex = 3;
            this.dc.Text = "定时计划";
            this.dc.UseVisualStyleBackColor = true;
            this.dc.CheckedChanged += new System.EventHandler(this.Dc_CheckedChanged);
            // 
            // dateP
            // 
            this.dateP.CalendarFont = new System.Drawing.Font("宋体", 10F);
            this.dateP.Location = new System.Drawing.Point(113, 48);
            this.dateP.Name = "dateP";
            this.dateP.Size = new System.Drawing.Size(127, 21);
            this.dateP.TabIndex = 6;
            // 
            // TimeP
            // 
            this.TimeP.CustomFormat = "HH:mm:ss";
            this.TimeP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeP.Location = new System.Drawing.Point(251, 48);
            this.TimeP.Name = "TimeP";
            this.TimeP.ShowUpDown = true;
            this.TimeP.Size = new System.Drawing.Size(85, 21);
            this.TimeP.TabIndex = 7;
            // 
            // jc
            // 
            this.jc.AutoSize = true;
            this.jc.Font = new System.Drawing.Font("宋体", 10F);
            this.jc.Location = new System.Drawing.Point(15, 78);
            this.jc.Name = "jc";
            this.jc.Size = new System.Drawing.Size(82, 18);
            this.jc.TabIndex = 8;
            this.jc.Text = "计时计划";
            this.jc.UseVisualStyleBackColor = true;
            this.jc.CheckedChanged += new System.EventHandler(this.Jc_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(161, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "时";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(315, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "秒";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F);
            this.label4.Location = new System.Drawing.Point(236, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "分";
            // 
            // pc
            // 
            this.pc.AutoSize = true;
            this.pc.Font = new System.Drawing.Font("宋体", 10F);
            this.pc.Location = new System.Drawing.Point(16, 105);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(82, 18);
            this.pc.TabIndex = 15;
            this.pc.Text = "进程计划";
            this.pc.UseVisualStyleBackColor = true;
            // 
            // pl
            // 
            this.pl.AutoSize = true;
            this.pl.Font = new System.Drawing.Font("宋体", 10F);
            this.pl.Location = new System.Drawing.Point(110, 107);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(63, 14);
            this.pl.TabIndex = 16;
            this.pl.Text = "无此进程";
            // 
            // pt
            // 
            this.pt.Location = new System.Drawing.Point(188, 102);
            this.pt.Name = "pt";
            this.pt.Size = new System.Drawing.Size(148, 21);
            this.pt.TabIndex = 17;
            // 
            // jtimer
            // 
            this.jtimer.Interval = 5000;
            this.jtimer.Tick += new System.EventHandler(this.Jtimer_Tick);
            // 
            // cb
            // 
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.Font = new System.Drawing.Font("宋体", 10F);
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "关机",
            "重启",
            "注销",
            "休眠",
            "锁定",
            "关闭程序",
            "启动程序"});
            this.cb.Location = new System.Drawing.Point(15, 176);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(85, 21);
            this.cb.TabIndex = 23;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.Cb_SelectedIndexChanged);
            // 
            // ptn
            // 
            this.ptn.Font = new System.Drawing.Font("宋体", 10F);
            this.ptn.Location = new System.Drawing.Point(110, 175);
            this.ptn.Name = "ptn";
            this.ptn.Size = new System.Drawing.Size(180, 23);
            this.ptn.TabIndex = 24;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.UseAnimation = false;
            // 
            // nfi
            // 
            this.nfi.Text = "1551";
            this.nfi.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(0, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 6);
            this.label5.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(0, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(356, 6);
            this.label7.TabIndex = 26;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.checkBox1.Location = new System.Drawing.Point(16, 132);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 18);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "文件计划";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 21);
            this.textBox1.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10F);
            this.label8.Location = new System.Drawing.Point(110, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 29;
            this.label8.Text = "无此文件";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "所有文件|*.*";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(317, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 17);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // ht
            // 
            this.ht.Font = new System.Drawing.Font("宋体", 10F);
            this.ht.Location = new System.Drawing.Point(113, 73);
            this.ht.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.ht.Name = "ht";
            this.ht.Size = new System.Drawing.Size(42, 23);
            this.ht.TabIndex = 31;
            // 
            // st
            // 
            this.st.Font = new System.Drawing.Font("宋体", 10F);
            this.st.Location = new System.Drawing.Point(263, 73);
            this.st.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(42, 23);
            this.st.TabIndex = 32;
            this.st.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // mt
            // 
            this.mt.Font = new System.Drawing.Font("宋体", 10F);
            this.mt.Location = new System.Drawing.Point(188, 74);
            this.mt.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.mt.Name = "mt";
            this.mt.Size = new System.Drawing.Size(42, 23);
            this.mt.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 10F);
            this.label6.Location = new System.Drawing.Point(3, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 59);
            this.label6.TabIndex = 34;
            this.label6.Text = "计时未启动";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 266);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mt);
            this.Controls.Add(this.st);
            this.Controls.Add(this.ht);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ptn);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.pt);
            this.Controls.Add(this.pl);
            this.Controls.Add(this.pc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jc);
            this.Controls.Add(this.TimeP);
            this.Controls.Add(this.dateP);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lpctime);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(366, 305);
            this.MinimumSize = new System.Drawing.Size(366, 305);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "定时计划";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.st)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lpctime;
        private System.Windows.Forms.Timer pctime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox dc;
        private System.Windows.Forms.DateTimePicker dateP;
        private System.Windows.Forms.DateTimePicker TimeP;
        private System.Windows.Forms.CheckBox jc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox pc;
        private System.Windows.Forms.Label pl;
        private System.Windows.Forms.TextBox pt;
        private System.Windows.Forms.Timer jtimer;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.TextBox ptn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon nfi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NumericUpDown ht;
        private System.Windows.Forms.NumericUpDown st;
        private System.Windows.Forms.NumericUpDown mt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer3;
    }
}

