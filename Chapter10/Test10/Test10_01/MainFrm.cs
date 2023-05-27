using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSharpCourse_NetFrameWork.Test10_01
{
    public partial class MainFrm : Form
    {
        string sqlConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dr;
        string sql;
        public MainFrm()
        {
            InitializeComponent();
            conn = new SqlConnection(sqlConnection);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            sql = "use bookshop;" +
                "select title from books;";

            conn.Open();
            comm = new SqlCommand(sql, conn);
            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                lbShow.Items.Add(dr["title"]);
            }

            conn.Close();
        }
    }
}
