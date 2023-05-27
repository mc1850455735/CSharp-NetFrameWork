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
    public partial class Practice3_11 : Form
    {
        public Practice3_11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b1, b2, b3;
            b1 = a / 100;
            b2 = a % 100 / 10;
            b3 = a % 10;
            if (b1 * b1 * b1 + b2 * b2 * b2 + b3 * b3 * b3 == a)
                label1.Text = "是";
            else
                label1.Text = "否";
        }
    }
}
