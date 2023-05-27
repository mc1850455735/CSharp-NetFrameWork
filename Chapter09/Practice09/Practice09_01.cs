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
    public partial class Practice09_01 : Form
    {
        public Practice09_01()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string passwordName = txtPsw.Text;
            if(userName == "admin" && passwordName == "123") {
                MessageBox.Show("欢迎进入个人理财系统!", "登陆成功",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("您输入的用户名或密码错误!", "登录失败",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtPsw.Text = string.Empty;
        }
    }
}
