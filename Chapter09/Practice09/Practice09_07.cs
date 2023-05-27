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
    public partial class Practice09_07 : Form
    {
        public Practice09_07()
        {
            InitializeComponent();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = rtxtShow.Font;
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtxtShow.Font = fontDialog1.Font;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = rtxtShow.ForeColor;
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rtxtShow.ForeColor = colorDialog1.Color;
            }
        }
    }
}
