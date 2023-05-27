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
    public partial class Practice3_13 : Form
    {
        public Practice3_13()
        {
            InitializeComponent();
        }

        private void Practice3_13_Load(object sender, EventArgs e)
        {
            int[] a = new int[10];
            int[] temp = new int[10];
            for (int i = 0; i < 10; i++)
            {
                temp[0] = 1;
                temp[i] = 1;
                for(int j = 1; j < i; j++)
                {
                    temp[j] = a[j] + a[j - 1];
                }
                Array.Copy(temp, a, i + 1);
                for(int j = 0; j < i + 1; j++)
                {
                    label1.Text += a[j].ToString() + " ";
                }
                label1.Text += "\n";
            }
        }
    }
}
