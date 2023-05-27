using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharpCourse_NetFrameWork
{
    public partial class Test3_1 : Form
    {
        int i = 0;
        double[] a = new double[5];
        public Test3_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 5)
            {
                a[i++] = Convert.ToDouble(textBox1.Text);
                beforeSort.Text = String.Empty;
                for (int j = 0; j < i; j++)
                {
                    beforeSort.Text += a[j].ToString() + " ";
                }
                if (i >= 5)
                {
                    Array.Sort(a, 0, a.Length);
                    for(int m = 0; m < a.Length; m++)
                    {
                        for(int n = 0; n < a.Length - m - 1; n++)
                        {
                            double temp;
                            if (a[n] > a[n + 1])
                            {
                                temp = a[n];
                                a[n] = a[n + 1];
                                a[n + 1] = temp;
                            }
                        }
                    }
                    afterSort.Text = String.Empty;
                    for (int j = 0; j < i; j++)
                    {
                        afterSort.Text += a[j].ToString() + " ";
                    }
                }
            }
        }
    }
}
