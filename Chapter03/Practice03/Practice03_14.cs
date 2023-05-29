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
    public partial class Practice3_14 : Form
    {
        public Practice3_14()
        {
            InitializeComponent();
        }

        private void Practice3_14_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                    label1.Text += i.ToString() + " ";
                if (i % 20 == 0)
                    label1.Text += "\n";
            }
        }
    }
}
