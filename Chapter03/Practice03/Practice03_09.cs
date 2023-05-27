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
    public partial class Practice3_9 : Form
    {
        public Practice3_9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            switch((int)(a/10))
            {
                case 10:
                case 9:
                    result.Text = "优";
                    break;
                case 8:
                    result.Text = "良";
                    break;
                case 7:
                    result.Text = "中";
                    break; 
                case 6:
                    result.Text = "及格";
                    break;
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    result.Text = "不及格";
                    break;
                default:
                    result.Text = "错误";
                    break;
            }
        }
    }
}
