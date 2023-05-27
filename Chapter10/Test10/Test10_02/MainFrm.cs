using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSharpCourse_NetFrameWork.Test10_02
{
    public partial class MainFrm : Form
    {
        string sqlConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter da;
        string sql;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sqlConnection);
            conn.Open();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            sql = "use bookshop;select a.id as ID, a.title as 书名, a.author as 作者, a.unitPrice as 价格 " +
                "from books as a;";
            da = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds);
            dgvShow.DataSource = ds.Tables[0];
        }

        private void btnUpdata_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            
            da.Update(ds);
        }

        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
