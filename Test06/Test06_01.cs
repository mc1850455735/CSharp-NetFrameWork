using System;
using System.Collections;
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
    public partial class Test06_01 : Form
    {
        ArrayList a = new ArrayList();
        public Test06_01()
        {
            InitializeComponent();
        }

        private void Test06_01_Load(object sender, EventArgs e)
        {

        }

        private void Display()
        {
            lblShow.Text = string.Empty;
            foreach(var x in a)
            {
                Teacher a = (Teacher)x;
                lblShow.Text += "\n" + a.ShowMsg();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string level = txtLevel.Text;
            Teacher t = new Teacher(name, level);
            a.Add(t);
            Display();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int index;
            try { index = int.Parse(txtIndex.Text); }
            catch { MessageBox.Show("输入格式有误,请重新输入!"); txtIndex.Text = string.Empty; return; }
            try
            {
                string name = txtName.Text;
                string level = txtLevel.Text;
                Teacher t = new Teacher(name, level);
                a.Insert(index, t);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); return; }
            Display();
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index;
            try { index = int.Parse(txtIndex.Text); }
            catch { MessageBox.Show("输入格式有误,请重新输入!"); txtIndex.Text = string.Empty; return; }
            try {
                // RemoveAt : 删除该下标上的元素
                // Remove : 删除该元素
                a.RemoveAt(index);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); return; }
            Display();
        }
    }
    class Teacher
    {
        private string name;
        private string level;
        public Teacher() { 
            name = string.Empty;
            level = string.Empty;
        }

        public Teacher(string name, string level)
        {
            this.name = name;
            this.level = level;
        }

        public string Name => name;
        public string Level => level;

        public override string ToString()
        {
            return name + ", " + level;
        }

        public string ShowMsg()
        {
            return string.Format("姓名:{0}, 职称{1}", 
                name == "" ? "null" : name, level == "" ? "null" : level);
        }
    }
    
}
