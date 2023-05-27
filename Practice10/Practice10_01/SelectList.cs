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

namespace CSharpCourse_NetFrameWork.Practice10_01
{
    public partial class SelectList : Form
    {
        string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        public SelectList()
        {
            InitializeComponent();
        }

        private void SelectList_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            cboKey.Items.Clear();
            cboKey.Items.Add("收支项");
            cboKey.Items.Add("类别");
            cboKey.Items.Add("说明");
            cboKey.Items.Add("金额");
            cboKey.Items.Add("日期");
            cboKey.SelectedIndex = 0;
        }

        private void cboKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = cboKey.SelectedItem.ToString();
            txtValue1.Text = txtValue2.Text = "";
            if (key == "金额" || key == "日期")
                txtValue2.Enabled = true;
            else
                txtValue2.Enabled = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string key = cboKey.SelectedItem.ToString();
            string value1 = txtValue1.Text.Trim();
            string condition = "";

            switch (key)
            {
                case "收支项":
                    condition = string.Format("and c.ItemName like N'%{0}%'", value1);
                    break;
                case "类别":
                    condition = string.Format("and b.CategoryName like N'%{0}%'", value1);
                    break;
                case "说明":
                    condition = string.Format("and a.Explain like N'%{0}%'", value1);
                    break;
                case "金额":
                    condition = string.Format("and a.Amount between '{0}' and '{1]'", value1, 
                        txtValue2.Text.Trim());
                    break;
                case "日期":
                    condition = string.Format("and a.TradeDate between '{0}' and '{1]'", value1,
                        txtValue2.Text.Trim());
                    break;
            }

            string sql = string.Format(
                    "use testdb; " +
                    "select a.ListID as ID, c.ItemName as 收支项, b.CategoryName as 类别, " +
                    "b.IsPayout as 是否支出, a.TradeDate as 收支日期, a.Amount as 金额, " +
                    "a.Explain as 说明 " +
                    "from List as a, Category as b, Item as c " +
                    "where a.ItemID = c.ItemID and c.CategoryID = b.CategoryID " +
                    condition
                );

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvList.DataSource = ds.Tables[0];
        }
    }
}
