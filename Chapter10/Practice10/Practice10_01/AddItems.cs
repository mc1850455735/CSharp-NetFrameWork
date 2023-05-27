using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourse_NetFrameWork
{
    public partial class AddItems : Form
    {
        string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dr;
        public AddItems()
        {
            InitializeComponent();
        }

        private void rdoExpenditure_CheckedChanged(object sender, EventArgs e)
        {
            cboCategory.Items.Clear();
            cboCategory.Items.Add("一级大类");
            string sql = "use testdb;" +
                "select * from Category where IsPayout = 1;";

            if(rdoIncome.Checked)
                sql = "use testdb;" +
                "select * from Category where IsPayout = 0;";

            try
            {
                conn.Open();
                comm.CommandText = sql;

                // 使用comm初始化抽象类dr
                dr = comm.ExecuteReader();

                // 循环读出所有类别
                while (dr.Read())
                {
                    // 数据库第一列(编号)
                    int cid = (int)dr[0];
                    string categoryname = dr["CategoryName"].ToString().Trim();
                    cboCategory.Items.Add(new Category(cid, categoryname));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            
            cboCategory.SelectedIndex = 0;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim() == "" || cboCategory.Text == "")
            {
                MessageBox.Show("请填写完整信息!", "信息不完整",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tbControl.SelectedTab = tpgAcceptInfo;
            }
        }

        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tbControl.SelectedIndex == 1)
            {
                if (txtName.Text.Trim() == "" || cboCategory.Text == "")
                {
                    MessageBox.Show("请填写完整信息!", "信息不完整",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbControl.SelectedTab = tpgProjectInfo;
                }               
                else
                {
                    rtxtShow.Clear();
                    rtxtShow.AppendText("要添加的收支项目为: ");
                    rtxtShow.AppendText(txtName.Text);
                    rtxtShow.AppendText("\n所属类别:" + cboCategory.SelectedItem.ToString());
                    if(rdoExpenditure.Checked == true)
                        rtxtShow.AppendText("\n支出类型");
                    else
                        rtxtShow.AppendText("\n收入类型");
                }
            }
        }

        private void AddItems_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            comm = new SqlCommand();
            comm.Connection = conn;

            rdoExpenditure.Checked= true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            int isPayOut = rdoExpenditure.Checked ? 1 : 0;

            int cid = cboCategory.SelectedIndex;
            string sql;
            if(cid == 0)    // 如果是一级大类, 将新建的类型添加到类型表中
            {
                sql = string.Format(@"use testdb;" + 
                    "insert into Category (CategoryName, IsPayout) " +
                    "values (N'{0}', {1})" , name, isPayOut);
            }
            else
            {   // 添加到项目表中
                Category category = cboCategory.SelectedItem as Category;
                if (category != null)
                    cid = category.CId;
                sql = string.Format(@"use testdb;" +
                    "insert into Item (ItemName, CategoryID) " +
                    "values (N'{0}', {1});", name, cid);
            }

            // 执行数据库操作
            try
            {
                conn.Open();
                comm.CommandText = sql;
                int count = comm.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("添加数据类型成功", "添加成功",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加数据类型失败", "添加失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }

        private void AddItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }

    // 收支类别类
    class Category
    {
        public int CId;
        public string CName;

        public Category(int CId, string CName)
        {
            this.CId = CId;
            this.CName = CName;
        }

        public override string ToString()
        {
            return CName;
        }
    }
}
