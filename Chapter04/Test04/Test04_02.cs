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
    public partial class Test4_2 : Form
    {
        public Test4_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Time time = new Time(int.Parse(tbHour.Text), int.Parse(tbMin.Text), int.Parse(tbSecond.Text));
            time.AddSecond();
            tbSecond.Text = time._second.ToString();
            tbMin.Text = time._minute.ToString();
            tbHour.Text = time._hour.ToString();
        }

        public class Time
        {
            private int hour;
            private int minute;
            private int second;

            public int _hour => hour;
            public int _minute => minute;
            public int _second => second;


            public Time(int hour, int minute, int second)
            {
                this.hour = hour;
                this.minute = minute;
                this.second = second;
            }

            public Time()
            {
                hour = System.DateTime.Now.Hour;
                minute = System.DateTime.Now.Minute;
                second = System.DateTime.Now.Second;
            }

            public void AddSecond()
            {
                this.second++;
                if(this.second >= 60)
                {
                    this.second = 0;
                    this.minute++;
                }
                if(this.minute >= 60)
                {
                    this.minute = 0;
                    this.hour++;
                }
            }
        }
    }
}
