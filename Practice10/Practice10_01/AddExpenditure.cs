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
    public partial class AddExpenditure : Form
    {
        string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dr;
        public AddExpenditure()
        {
            InitializeComponent();
        }

        private void rdoExpenditure_CheckedChanged(object sender, EventArgs e)
        {
            cboCategory.Items.Clear();
            string sql = "use testdb;" +
                "select * from Category where IsPayout = 1;";

            if (rdoIncome.Checked)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                dr.Close();
                conn.Close();
            }

            cboCategory.SelectedIndex= 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int iid = 0;
            Item item = lstItem.SelectedItem as Item;
            if (item != null)
                iid = item.iid;

            decimal amount = numAmount.Value;
            DateTime date = dtpDate.Value;
            string explain = txtExplain.Text;

            string sql = string.Format("use testdb;" +
                "insert into List(ItemID, Amount, TradeDate, Explain) " +
                "values ({0}, {1}, '{2}', N'{3}');", iid, amount, date, explain);

            try
            {
                conn.Open();
                comm.CommandText = sql;
                int count = comm.ExecuteNonQuery(); // 更新命令

                if (count > 0)
                    MessageBox.Show("添加收支明细成功", "添加成功",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("添加收支明细失败", "添加失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstItem.Items.Clear();
            int cid = 0;
            Category category = cboCategory.SelectedItem as Category;
            if (category != null)
                cid = category.CId;

            // 选择指定编号的收支项
            string sql = string.Format(@"use testdb;" + 
                        "select * from Item where CategoryID = {0};", cid);           

            try
            {
                conn.Open();
                comm.CommandText = sql;
                dr = comm.ExecuteReader();

                while(dr.Read())
                {
                    int iid = (int)dr[0];
                    string iname = dr["ItemName"].ToString().Trim();
                    lstItem.Items.Add(new Item(iid, iname));
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "操作数据库出错", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                dr.Close();
                conn.Close();
            }

            cboCategory.SelectedIndex = 0;
        }

        private void AddExpenditure_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            comm = new SqlCommand();
            comm.Connection = conn;

            rdoIncome.Checked = true;
        }

        private void AddExpenditure_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void rdoIncome_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    class Item
    {
        public int iid;
        public string iname;

        public Item(int iid, string iname)
        {
            this.iid = iid;
            this.iname = iname;
        }

        public override string ToString()
        {
            return iname;
        }
    }
}
