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
    public partial class Practice3_10 : Form
    {
        public Practice3_10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = 0;
            if (x >= 0 && x < 10)
                y = 1 - 2 * x;
            else if (x >= 10 && x < 20)
                y = x;
            else if(x >= 20 && x < 30)
                y =  1 + 2 * x;
            label1.Text = y.ToString();
        }
    }
}
