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
    public partial class Practice09_05 : Form
    {
        public Practice09_05()
        {
            InitializeComponent();
        }

        private void Practice09_05_Load(object sender, EventArgs e)
        {

        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            Practice09_05_02 subForm = new Practice09_05_02("这是一个模态对话框");
            subForm.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Practice09_05_02 subForm = new Practice09_05_02("这是一个非模态对话框");
            subForm.Show();
        }
    }
}
