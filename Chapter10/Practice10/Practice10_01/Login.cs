using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSharpCourse_NetFrameWork
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName     = txtName.Text;
            string passwordName = txtPsw.Text;

            // 数据库相关操作
            // 字符串不要忘了加@
            string connString = @";Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sc1 = new SqlConnection(connString);  // 创建Connection对象

            // sql语句
            string sql = string.Format("use testdb;select count(*) from [User] " +
                "where UserName = N'{0}' and Password = N'{1}';",
                userName, passwordName);

            try
            {
                // 打开连接
                sc1.Open();
                // 创建command对象
                SqlCommand command = new SqlCommand(sql, sc1);
                // 检测匹配
                int num = (int)command.ExecuteScalar();
                // 找到匹配的, 最多一个
                if(num == 1)
                {
                    MessageBox.Show("欢迎进入个人理财系统!", "登陆成功",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddItems addItems = new AddItems();
                    addItems.Show();
                    this.Visible = false;
                }
            }
            catch(Exception ex)
            {
                txtName.Text = string.Empty;
                txtPsw.Text = string.Empty;
                MessageBox.Show(ex.Message, "登录失败",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                // 不管登录失败或成功都要关闭数据库连接
                sc1.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtPsw.Text = string.Empty;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
