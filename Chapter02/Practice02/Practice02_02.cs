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
    public partial class Practice2_2 : Form
    {
        int n;
        int i = 0;
        string[] a = new string[100];

        public Practice2_2()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            if(i < n)
                a[i++] = source.Text;
            for(int j = 0; j < n; j++)
            {
                Display.Text += a[j] + '\n';
            }
        }

        private void command1_Click(object sender, EventArgs e)
        {
            n = int.Parse(number.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int target = int.Parse(textBox1.Text);
            if (target >= 0 && target < n)
                label3.Text = "奖励为" + a[target];
            else
                label3.Text = "没有对应的奖品";
        }
    }
}
