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
    public partial class Test08_01 : Form
    {
        int[] a = new int[10];
        delegate bool Compare(int x, int y);    // 声明委托

        // 进行排序
        void SortArray(Compare compare)
        {
            // 使用委托进行排序
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    if (compare(a[i], a[j]))
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
        }

        // 升序比较
        bool Ascending(int x, int y)
        {
            return x < y;
        }

        // 降序比较
        bool Desecding(int x, int y)
        {
            return x > y;
        }

        // 显示数组
        void display()
        {
            txtTarget.Text = "";
            foreach(int i in a)
            {
                txtTarget.Text += i + "\r\n";
            }
        }

        public Test08_01()
        {
            InitializeComponent();
        }

        private void Test08_01_Load(object sender, EventArgs e)
        {

        }

        // 使用随机类生成数组
        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            txtSource.Text = "";
            txtTarget.Text = "";
            Random random = new Random();
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(100);    // 生成随机数
                txtSource.Text += a[i] + "\r\n";
            }
        }

        private void btnAscSort_Click(object sender, EventArgs e)
        {
            SortArray(new Compare(Ascending));
            display();
        }

        private void btnDescSort_Click(object sender, EventArgs e)
        {
            SortArray(new Compare(Desecding));
            display();
        }
    }
}
