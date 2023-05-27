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
    public partial class Test2_1 : Form
    {
        enum WeekDay {星期天, 星期一, 星期二, 星期三, 星期四, 星期五, 星期六};
        public Test2_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(textBox1.Text);
            WeekDay wd = (WeekDay)dt.DayOfWeek;
            display.Text = "这一天是" + wd.ToString();
        }
    }
}
