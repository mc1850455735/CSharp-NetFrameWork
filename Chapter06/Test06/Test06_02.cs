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
    public partial class Test06_02 : Form
    {
        ClassList a;
        public Test06_02()
        {
            InitializeComponent();
        }

        private void Test06_02_Load(object sender, EventArgs e)
        {
            a = new ClassList(0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblText.Text = string.Empty;
        }

        private void btnSelectID_Click(object sender, EventArgs e)
        {
            Student t;
            try
            {
                t = a[txtID.Text];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
            Show(t.ShowMsg());           
        }

        private void btnSelectName_Click(object sender, EventArgs e)
        {
            string result = null;
            String s = txtName.Text;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].name == s)
                {
                    result += a[i].ShowMsg() + "\n";
                }
            }

            if (result == null)
                MessageBox.Show("找不到对应的元素");
            else
                Show(result);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(txtIndex.Text.ToString()) - 1;
                string name = txtName.Text.ToString();
                string id = txtID.Text.ToString();

                for(int i = 0; i < a.Length; i++)
                {
                    if(id == a[i].id && !(index == i))
                    {
                        MessageBox.Show("不能有重复的id");
                        return;
                    }
                }

                Student s = new Student(name, id);
                a[index] = s;
                txtNumber.Text = a.Length.ToString();
                ShowList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int index = int.Parse(txtIndex.Text.ToString()) - 1;
            try
            {
                Student t = a[index];
                Show(t.ShowMsg());
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Show(string s)
        {
            lblText.Text = s;
        }
        private void ShowList()
        {
            lblText.Text = "";
            for(int i = 0; i < a.Length; i++)
            {
                lblText.Text = "\n" + a[i].ShowMsg();
            }
        }

    }

    class Student
    {
        private string _name;
        private string _id;

        public string name => _name;
        public string id => _id;

        public Student()
        {
            _name = string.Empty;
            _id = string.Empty;
        }

        public Student(string name, string id)
        {
            _name = name;
            _id = id;
        }

        public string ShowMsg()
        {
            string name = this.name;
            string id = this.id;
            if(name == string.Empty) { name = "null"; }
            if(id == string.Empty) { id = "null"; }

            return string.Format("ID:{0}, 姓名:{1}", id, name);
        }
    }

    class ClassList
    {
        private List<Student> students;

        public ClassList(int n)
        {
            students = new List<Student>(n);
        }

        public int Length => students.Count;
        public Student this[int i]
        {
            get { return students[i]; }
            set 
            {
                if (i < 0 || i > students.Count)
                    throw
                        new Exception("你必须按顺序添加新的元素");
                else if(i == students.Count) {
                    students.Add(value);
                    return;
                }
                students[i] = value;
            }
        }

        public Student this[string id]
        {
            get
            {
                foreach(var x in students)
                {
                    if(x.id == id)
                        return x;
                }
                throw
                    new Exception("找不到对应的元素");
            }
        }
    }
}
