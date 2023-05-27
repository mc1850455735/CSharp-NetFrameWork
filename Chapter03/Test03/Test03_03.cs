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
    public partial class Test3_3 : Form
    {
        public Test3_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string[] s2 = new string[20];
            int n = 0;
            for(int i = 0; i < s.Length - 2; i++)
            {
                string source = s.Substring(i, 2);
                for(int j = i + 2; j < s.Length - 1; j++)
                {
                    string target = s.Substring(j, 2);
                    if(target == source)
                    {
                        if(Array.IndexOf(s2, target) == -1)
                            s2[n++] = target; break;
                    }
                }
            }

            label1.Text = String.Empty;
            label2.Text = String.Empty;
            int sum = 0;
            for(int i = 0; i < s2.Length; i++)
            {
                label1.Text += s2[i] + " ";
            }
            
            label2.Text = "一共有" + n.ToString() + "个重复字符";
            /* 中国人民永远爱中国 */
        }
    }
}
