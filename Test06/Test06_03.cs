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
    public partial class Test06_03 : Form
    {
        StudentClass<Student> studentClass = new StudentClass<Student>(0);
        public Test06_03()
        {
            InitializeComponent();
        }

        private void Test06_03_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUniStu_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            UniversityStudent unistu = new UniversityStudent(name, age);
            studentClass.Students.Add(unistu);
        }

        private void btnAddMidStu_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            MiddenStudemt midstu = new MiddenStudemt(name, age);
            studentClass.Students.Add(midstu);
        }

        private void btnAddLitStu_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            LittleStudent litstu = new LittleStudent(name, age);
            studentClass.Students.Add(litstu);
        }

        private void btnStudy_Click(object sender, EventArgs e)
        {
            lblShow.Text += "\n" + studentClass.ToString();
        }
    }

    class Student
    {
        private string name;
        private int age;


        public Student()
        {
            this.name = "";
            this.age = 0;
        }
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string ShowStudy() { return "学生在学习"; }

        public void show() { }

        public override string ToString()
        {
            return "姓名: " + name + ", 年龄: " + age + ShowStudy();
        }
    }

    class UniversityStudent : Student
    {
        public UniversityStudent(string name, int age) : base(name, age) { }

        public override string ShowStudy()
        {
            return "大学生在学高等数学";
        }

    }

    class MiddenStudemt : Student
    {
        public MiddenStudemt(string name, int age) : base(name, age) { }
        public override string ShowStudy()
        {
            return "中学生在学等差数列";
        }
    }

    class LittleStudent : Student
    {
        public LittleStudent(string name, int age) : base(name, age) { }
        public override string ShowStudy()
        {
            return "小学生在学加减乘除";
        }
    }
    
    class StudentClass<T> where T : Student
    {
        private List<T> students;
        public List<T> Students { get { return students; } }
        
        public StudentClass()
        {
            students = new List<T>(0);
        }

        public StudentClass(int n)
        {
            students = new List<T>(n);
        }

        public StudentClass(List<T> students)
        {
            this.students = students;
        }

        public override string ToString()
        {
            string result = "";
            foreach (T student in students)
            {
                result += "\n"+student.ToString();
            }

            return result;
        }
    }
}
