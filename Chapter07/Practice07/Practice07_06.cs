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
    public partial class Practice07_06 : Form
    {
        public Practice07_06()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            float a = 0;
            try
            {
                a = float.Parse(txtNumber.Text);
                a = 1 / a;
                lblShow.Text = txtNumber.Text + "的倒数是" + a;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "无法计算"); }
        }

        private void Practice07_06_Load(object sender, EventArgs e)
        {

        }
    }
}
