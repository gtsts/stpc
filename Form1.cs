using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace smpc
{

    public partial class Form1 : Form
    {
        protected DateTime mintime;
        protected int iconum = 1;
        protected int moveme = -1;
        protected bool ismove = true;
        protected int bkwidth;//窗体边框宽度
        protected int caheight;//船体标题高度
        string tipstr = "";
        protected int sizea = 50;//出现时大小变化
        protected int nfitip = 0;//控制tip提示，让其3秒更新一次
        string[] Args;
        public Form1(string[] args)
        {
            this.Args = args;
            InitializeComponent();
            this.Shown += new EventHandler(Form1_Shown);
            ht.KeyPress += new KeyPressEventHandler(Numcheck);
            mt.KeyPress += new KeyPressEventHandler(Numcheck);
            st.KeyPress += new KeyPressEventHandler(Numcheck);
            pc.CheckedChanged += new EventHandler(pc_CheckedChanged);
            pl.MouseClick += new MouseEventHandler(pl_MouseClick);
            this.SizeChanged += new EventHandler(Form1_ResizeEnd);
            this.Disposed += new EventHandler(Form1_Disposed);
            nfi.Click += new EventHandler(nfi_Click);
            nfi.MouseMove += new MouseEventHandler(nfi_MouseMove);
            this.FormClosing += new FormClosingEventHandler(Fomr_FormClosing);
        }

        private void Fomr_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (label6.Text != "计时未启动")
            {
                if (MessageBox.Show("关闭后将停止计划项,是否最小化", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.WindowState = FormWindowState.Minimized;
                    e.Cancel = true;

                }

            }
        }
        private void nfi_MouseMove(object sender, MouseEventArgs e)
        {
            // csp.Show(MousePosition);
        }

        private void nfi_Click(object sender, EventArgs e)
        {
            if (button1.Text == "结束" && timer1.Enabled)
            {
                Button1_Click(null, null);
                nfi.BalloonTipText = "计划已结束";
                nfi.ShowBalloonTip(500);
            }
            this.TopMost = true;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.TopMost = false;
            this.Show();

        }
        private void Form1_Disposed(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pl_MouseClick(object sender, MouseEventArgs e)
        {
            if (pl.Text == "无此进程")
            {
                pl.Text = "有此进程";
            }
            else
            {

                pl.Text = "无此进程";
            }

        }

        private void pc_CheckedChanged(object sender, EventArgs e)

        {
            pt.Enabled = false;
            pl.Enabled = false;
            if (pc.Checked)
            {
                pt.Enabled = true;
                pl.Enabled = true;
            }
        }
        private void Numcheck(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar != 8)
            {
                if (e.KeyChar < 48 || e.KeyChar > 57)
                {
                    e.Handled = true;
                }
            }

        }
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                nfi.BalloonTipText = "我在这里";
                nfi.ShowBalloonTip(500);
            }

        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            Cb_SelectedIndexChanged(null, null);
            CheckBox1_CheckedChanged(null, null);
            pc_CheckedChanged(null, null);
            pctime.Enabled = true;
            cb.SelectedIndex = 4;
            dateP.MinDate = DateTime.Now;
            TimeP.Value = DateTime.Now.AddSeconds(30);
            pt.Enabled = false;
            toolTip1.ForeColor = Color.Red;
            toolTip1.SetToolTip(pl, "点我 点我 点我");
            toolTip1.SetToolTip(pc, "启动此项,将不能计算出准确的计划结束时间");
            toolTip1.SetToolTip(label8, "点我 点我 点我");
            toolTip1.SetToolTip(checkBox1, "启动此项,将不能计算出准确的计划结束时间");
            toolTip1.SetToolTip(label5, "分割线");
            toolTip1.SetToolTip(label7, "这个也是分割线");
            toolTip1.ForeColor = Color.Red;
            nfi.Text = "";
            bkwidth = (this.Width - ClientSize.Width) / 2;
            caheight = (this.Height - ClientSize.Height - 2 * bkwidth);
            string dateti;
            string datestr;
            string timestr;
            if (Args.Length > 0)
            {
                switch (Args[0])
                {
                    case "-1":
                        dateti = Args[0];
                        datestr = Args[1] + " 23:59:59";
                        timestr = Args[1] + " " + Args[2];
                        dateP.Value = DateTime.Parse(datestr);
                        TimeP.Value = DateTime.Parse(timestr);
                        dc.Checked = true;
                        Button1_Click(null, null);
                        this.WindowState = FormWindowState.Minimized;
                        break;
                }
            }

        }

        private void Pctime_Tick(object sender, EventArgs e)
        {

            lpctime.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
            toolTip1.SetToolTip(lpctime, DateTime.Now.ToString("yyyy年MM月dd日 ddd HH:mm:ss"));
            int mx = MousePosition.X;
            int my = MousePosition.Y;
            ismove = false;
            if (!(mx >= (this.Left + bkwidth + label6.Left) && mx <= (this.Left + bkwidth + label6.Left + label6.Width) && my >= (this.Top + caheight + bkwidth + label6.Top) && my <= (this.Top + caheight + bkwidth + label6.Top + label6.Height)))
            {
                ismove = true;
                moveme = -1;
            }

            if (!ismove)
            {
                Random rnd = new Random();
                moveme++;
                //if (moveme % 3 == 0)
                //{
                //    int tipnum = rnd.Next(1, 8);
                //    switch (tipnum)
                //    {
                //        case 1:
                //            tipstr = "把你的鼠标移开";
                //            break;
                //        case 2:
                //            tipstr = "鼠标什么的最讨厌了";
                //            break;
                //        case 3:
                //            tipstr = "快把鼠标移开啦";
                //            break;
                //        case 4:
                //            tipstr = "你的鼠标是不是出问题了";
                //            break;
                //        case 5:
                //            tipstr = "什么破鼠标,快走开";
                //            break;
                //        case 6:
                //            tipstr = "再不把鼠标移开,我生气了哦";
                //            break;
                //        default:
                //            tipstr = "buling~buling~ 我闪";
                //            timer2.Interval = 2000;
                //            timer2.Enabled = true;
                //            break;
                //    }
                //    toolTip1.SetToolTip(label6, tipstr);
                //}
            }
            if (label6.Text == "计时未启动")
            {
                nfi.Text = label6.Text;
            }
            else
            {
                nfi.Text = label6.Text + "\n" + cb.SelectedItem;
                if (cb.SelectedIndex >= 5)
                {
                    nfi.Text = label6.Text + "\n" + cb.SelectedItem + "\n" + ptn.Text;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime dtime = DateTime.Now, jtime = DateTime.Now;
            iconum = 1;
            if (dc.Checked || jc.Checked || pc.Checked || checkBox1.Checked)
            {
                if (button1.Text == "开始")
                {
                    if (dc.Checked)
                    {
                        dtime = DateTime.Parse(dateP.Value.ToString("yyyy年MM月dd日") + " " + TimeP.Value.ToString("HH:mm:ss"));
                        mintime = dtime;
                    }
                    if (jc.Checked)
                    {
                        jtime = DateTime.Now.AddHours((int)ht.Value);
                        jtime = jtime.AddMinutes((int)mt.Value);
                        jtime = jtime.AddSeconds((int)st.Value);
                        if (dc.Checked)
                        {
                            if (dtime > jtime)
                            {
                                mintime = jtime;
                            }
                        }
                        else
                        {
                            mintime = jtime;
                        }

                    }

                    if (dc.Checked || jc.Checked)
                    {
                        if (mintime <= DateTime.Now)
                        {
                            if (MessageBox.Show("计划时间小于等于当前时间,计划将立即执行,是否立即执行?", "提示", MessageBoxButtons.YesNo) == DialogResult.No)
                            {
                                return;
                            }
                        }

                        label6.Text = "计划将于 " + mintime.ToString("yyyy年MM月dd日 ddd HH:mm:ss") + " 开始执行";
                    }
                    if (pc.Checked)
                    {
                        if (pt.Text == "")
                        {
                            MessageBox.Show("进程不可为空!!!");
                            return;
                        }

                        label6.Text = "计划将于 " + pl.Text + "(" + pt.Text + ") 开始执行";
                    }
                    if (checkBox1.Checked)
                    {
                        label6.Text = "计划将于 " + label8.Text + "(" + textBox1.Text + ") 开始执行";
                        if (pc.Checked)
                        {
                            label6.Text = "计划将于 " + pl.Text + "(" + pt.Text + ") 开始执行\n或者\n" + label6.Text;
                        }
                    }
                    jtimer.Interval = 100;
                    jtimer.Enabled = true;
                    button1.Text = "结束";
                    foreach (Control allc in this.Controls)
                    {
                        if (allc.Name != this.button1.Name && allc.Name != "label1" && allc.Name != "label6" && allc.Name != "lpctime")
                        {
                            allc.Enabled = false;
                        }
                    }
                }
                else
                {
                    button1.Text = "开始";
                    jtimer.Enabled = false;
                    timer1.Enabled = false;
                    nfi.Icon = smpc.Properties.Resources._1;
                    label6.Text = "计时未启动";
                    foreach (Control allc in this.Controls)
                    {
                        allc.Enabled = true;

                    }
                    Cb_SelectedIndexChanged(null, null);
                    CheckBox1_CheckedChanged(null, null);
                    pc_CheckedChanged(null, null);
                }
            }
        }

        private void startpro()
        {

            Button1_Click(null, null);
            string windir = System.Environment.GetEnvironmentVariable("windir");
            switch (cb.SelectedIndex)
            {

                case 0: //关机
                    Process.Start(windir + "\\system32\\shutdown.exe", "-s -t 0 -f");
                    break;
                case 1:  //重启
                    Process.Start(windir + "\\system32\\shutdown.exe", "-r -t 0 -f");
                    break;
                case 2:  //注销
                    Process.Start(windir + "\\system32\\shutdown.exe", "-l -t 0 -f");
                    break;
                case 3: //休眠
                    Process.Start(windir + "\\system32\\shutdown.exe", "-h  -f");
                    break;
                case 4: //锁定
                    Process.Start(windir + "\\System32\\rundll32.exe", " user32.dll, LockWorkStation");
                    break;
                case 5: //关闭程序
                    foreach (Process prc in Process.GetProcessesByName(ptn.Text))
                    {
                        prc.Kill();
                    }
                    break;
                case 6:  //启动程序
                    Process.Start(ptn.Text);
                    break;
            }


        }


        private void Jtimer_Tick(object sender, EventArgs e)
        {
            if (dc.Checked || jc.Checked)
            {
                if (mintime.AddSeconds(-30) < DateTime.Now)
                {
                    timer1.Enabled = true;
                }
            }
            if (pc.Checked)
            {
                if (pl.Text == "无此进程")
                {
                    int wprc = 0;
                    foreach (Process prc in Process.GetProcesses())
                    {
                        if (prc.ProcessName.ToLower() == pt.Text.ToLower())
                        {
                            wprc = 1;
                            break;
                        }
                    }
                    if (wprc == 0)
                    {
                        mintime = DateTime.Now.AddSeconds(30);
                        timer1.Enabled = true;
                        return;
                    }
                }
                else
                {
                    foreach (Process prc in Process.GetProcesses())
                    {
                        if (prc.ProcessName.ToLower() == pt.Text.ToLower())
                        {
                            mintime = DateTime.Now.AddSeconds(30);
                            timer1.Enabled = true;
                            return;
                        }
                    }

                }
            }
            if (checkBox1.Checked)
            {
                if (label8.Text == "无此文件")
                {
                    if (!File.Exists(textBox1.Text))
                    {
                        mintime = DateTime.Now.AddSeconds(30);
                        timer1.Enabled = true;
                        return;
                    }

                }
                else
                {
                    if (File.Exists(textBox1.Text))
                    {
                        mintime = DateTime.Now.AddSeconds(30);
                        timer1.Enabled = true;
                        return;
                    }
                }

            }
            jtimer.Interval = 5000;
        }

        private void Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ptn.Enabled = false;

            if (cb.SelectedIndex >= 5)
            {
                ptn.Enabled = true;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = smpc.Properties.Resources._1;
            nfi.Icon = smpc.Properties.Resources._1;
            textBox1.Enabled = false;
            button2.Enabled = false;
            pctime.Interval = 1000;
            lpctime.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
            toolTip1.SetToolTip(lpctime, DateTime.Now.ToString("yyyy年MM月dd日 ddd HH:mm:ss"));


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            jtimer.Enabled = false;

            if (iconum == 1)
            {
                nfi.Icon = smpc.Properties.Resources._1;
            }
            if (iconum == 2)
            {
                nfi.Icon = smpc.Properties.Resources._2;
            }
            if (iconum == 3)
            {
                nfi.Icon = smpc.Properties.Resources._3;
            }
            if (iconum == 4)
            {
                nfi.Icon = smpc.Properties.Resources._4;
            }

            iconum++;
            if (iconum > 4)
            {
                iconum = 1;
            }

            if (nfitip == 0)
            {
                nfi.BalloonTipText = "还有 " + ((int)(mintime - DateTime.Now).TotalSeconds).ToString() + " 秒,执行操作 " + cb.SelectedItem + "\n点我结束计划";
                nfi.ShowBalloonTip(5000);
            }
            nfitip++;
            if (nfitip > 10)
            {
                nfitip = 0;
            }

            if (mintime <= DateTime.Now)
            {
                startpro();
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            button2.Enabled = false;
            label8.Enabled = false;
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
                button2.Enabled = true;
                label8.Enabled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void Dc_CheckedChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(dc, "");
            toolTip1.SetToolTip(jc, "");
            if (dc.Checked && jc.Checked)
            {
                toolTip1.SetToolTip(jc, "与定时计划同时选择,将按照较早的执行计划");
                toolTip1.SetToolTip(dc, "与计时计划同时选择,将按照较早的执行计划");
            }
        }

        private void Jc_CheckedChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(dc, "");
            toolTip1.SetToolTip(jc, "");
            if (dc.Checked && jc.Checked)
            {
                toolTip1.SetToolTip(jc, "与定时计划同时选择,将按照较早的执行计划");
                toolTip1.SetToolTip(dc, "与计时计划同时选择,将按照较早的执行计划");
            }
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            if (label8.Text == "无此文件")
            {
                label8.Text = "有此文件";
            }
            else
            {
                label8.Text = "无此文件";
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            this.Visible = false;
            int sx = rd.Next(1, Screen.PrimaryScreen.Bounds.Width - this.Width);
            int sy = rd.Next(0, Screen.PrimaryScreen.Bounds.Height - this.Height);
            Thread.Sleep(5000);
            this.Top = sy;
            this.Left = sx;
            this.MaximumSize = new Size(0, 0);
            this.MinimumSize = new Size(0, 0);
            this.Size = new Size(366 / 2, 305 / 2);
            this.Visible = true;
            timer3.Interval = 30;
            timer3.Enabled = true;
            ismove = true;
            moveme = -1;
            toolTip1.SetToolTip(label6, "");
            this.TopMost = true;
            this.TopMost = false;
            timer2.Enabled = false;

        }

        private void Timer3_Tick(object sender, EventArgs e)
        {

            this.MaximumSize = new Size(366 * sizea / 100, 305 * sizea / 100);
            this.MinimumSize = new Size(366 * sizea / 100, 305 * sizea / 100);
            sizea++;
            if (this.Width >= 366)
            {
                timer3.Enabled = false;
                sizea = 50;
            }



        }

    }
}
