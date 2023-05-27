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
    public partial class Test07_0102030405 : Form
    {
        public Test07_0102030405()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string[] sources = txtSequence.Text.Split(',');
            int[] a = new int[sources.Length];
            try
            {
                for (int i = 0; i < sources.Length; i++)
                {
                    a[i] = Convert.ToInt32(sources[i]);
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); return; }

            for(int i = 0; i < a.Length - 1; i++)
            {
                for(int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j + 1] < a[j])
                    {
                        int t = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = t;
                    }
                }
            }

            lblResult.Text = "排序结果为: ";
            for(int i = 0; i < a.Length;i++)
            {
                lblResult.Text += a[i] + " ";
            }
        }
    }
}
