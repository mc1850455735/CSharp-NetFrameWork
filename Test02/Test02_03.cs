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
    public partial class Test2_3 : Form
    {
        int i = 0;
        double[] a = new double[5];
        public Test2_3()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if(i < 5) {
                a[i++] = Convert.ToDouble(textBox1.Text);
                beforeSort.Text = String.Empty;
                for (int j = 0; j < i; j++)
                {
                    beforeSort.Text += a[j].ToString() + " ";
                }
                if (i >= 5)
                {
                    Array.Sort(a, 0, a.Length);
                    for (int j = 0; j < i; j++)
                    {
                        afterSort.Text += a[j].ToString() + " ";
                    }
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            i = 0;
            beforeSort.Text = String.Empty;
            afterSort.Text = String.Empty;  
        }
    }
}
