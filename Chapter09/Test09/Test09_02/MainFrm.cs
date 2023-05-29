using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourse_NetFrameWork.Test09_02
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void tsmNewUser_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.TopLevel = false;
            newUser.WindowState = FormWindowState.Maximized;
            newUser.Parent = this;
            newUser.Show();
            tssStatus.Text = "新建联系人";
        }
    }
}
