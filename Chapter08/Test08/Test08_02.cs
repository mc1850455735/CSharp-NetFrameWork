using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourse_NetFrameWork
{
    public partial class Test08_02 : Form
    {
        private Boiler boiler;
        public Test08_02()
        {
            InitializeComponent();
            boiler= new Boiler();
            if(boiler.onAlarm == null)
            {
                // 预先向事件类的事件中添加委托
                boiler.onAlarm += new EventHandler<BoilerArgs>(boiler_Alarm);
            }
        }

        private void boiler_Alarm(object sender, BoilerArgs e)  // 警报事件的处理方法
        {
            // 对压力文本框的处理
            if(e.Press > 50 && e.Press < 80) { lblShow.Text = "黄色警告"; lblShow.BackColor = Color.Yellow; }
            else if(e.Press >= 80 && e.Press < 90) { lblShow.Text = "橙色警告"; lblShow.BackColor = Color.Orange; }
            else if(e.Press >= 90 && e.Press < 100) { lblShow.Text = "红色警告"; lblShow.BackColor = Color.Red; }
            else if(e.Press == 100) 
            {
                lblShow.Text = "已经降压...";
                lblShow.BackColor = SystemColors.Control;
                txtPressure.Text = "30";
                boiler.k = 30;
            }
        }

        private void Test08_02_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            autoTimer.Start();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtPressure.Text) > 30)
            {
                lblShow.Text = "已经降压...";
                lblShow.BackColor = SystemColors.Control;
                txtPressure.Text = "30";
                boiler.k = 30;
            }
            else
            {
                lblShow.Text = "无需降压...";
            }
        }

        private void autoTimer_Tick(object sender, EventArgs e)
        {
            boiler.k++;
            txtPressure.Text = boiler.k.ToString();
            boiler.ProcessAlarm();  // 进行事件的处理
        }
    }

    public class BoilerArgs : EventArgs
    {
        private int pressure;
        public BoilerArgs(int n)
        {
            pressure = n;
        }

        public int Press => pressure;

    }

    public class Boiler // 事件类
    {
        public int k;
        public Boiler()
        {
            k = 0;
        }

        public EventHandler<BoilerArgs> onAlarm;   // 事件
        public void ProcessAlarm()
        {
            // 警报事件
            this.onAlarm(this, new BoilerArgs(k));
        }
    }
}
