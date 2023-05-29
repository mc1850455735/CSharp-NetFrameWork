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
    public partial class Practice3_12 : Form
    {
        public Practice3_12()
        {
            InitializeComponent();
        }

        private void Practice3_12_Load(object sender, EventArgs e)
        {
            double a = 2, b = 1;
            double sum = 0;
            for(int i = 0; i < 20; i++)
            {
                sum += a / b;
                a += b;
                b++;
            }
            label1.Text = sum.ToString();
        }
    }
}
