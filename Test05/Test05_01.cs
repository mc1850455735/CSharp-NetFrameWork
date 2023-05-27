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
    public partial class Test05_01 : Form
    {
        Student stu;
        public Test05_01()
        {
            InitializeComponent();
        }

        private void btnAddPupil_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                double chinese = double.Parse(txtChinOrReq.Text);
                double math = double.Parse(txtMathOrSel.Text);
                stu = new Pupil(name, age, chinese, math);
                Show(stu.GetInfo() + "\n");
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAddJunior_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                double chinese = double.Parse(txtChinOrReq.Text);
                double math = double.Parse(txtMathOrSel.Text);
                double english = double.Parse(txtEng.Text);
                stu = new Junior(name, age, chinese, math, english);
                Show(stu.GetInfo() + "\n");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }          
        }

        private void btnAddCollegeStu_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                double required = double.Parse(txtChinOrReq.Text);
                double selected = double.Parse(txtMathOrSel.Text);
                stu = new CollegeStu(name, age, required, selected);
                Show(stu.GetInfo() + "\n");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }           
        }

        private void Show(string s)
        {
            lblShow.Text += s;
        }
    }

    public abstract class Student
    {
        protected string name;
        protected int age;
        protected static int number;
        protected Student(string name, int age) 
        {
            this.name = name;
            this.age = age;
            number++;
        }

        public string Name => name;
        public int Age => age;

        public virtual string type => "学生";

        public abstract double total();

        public virtual string GetInfo()
        {
            return string.Format("总人数{0}, 姓名{1}, 年龄{2}", number, name, age);
        }
    }

    public class Pupil : Student
    {
        protected double chinese;
        protected double math;

        public override string type => "小学生";

        public Pupil(string name, int age, double chinese, double math) : base(name, age)
        {
            this.chinese = chinese;
            this.math = math;
        }

        public override double total()
        {
            return chinese + math;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + string.Format(", {0}, {1}岁, 平均成绩为{2}", type, Age, (total() / 2));
        }

    }

    public class Junior : Student
    {
        protected double chinese;
        protected double math;
        protected double english;

        public override string type => "中学生";

        public Junior(string name, int age, double chinese, double math, double english):base(name, age)
        {
            this.chinese = chinese;
            this.math = math;
            this.english = english;
        }

        public override double total()
        {
            return chinese + math + english;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + string.Format(", {0}, {1}岁, 平均成绩为{2}", type, Age, (total() / 3));
        }

    }

    class CollegeStu : Student
    {
        protected double requiredCourseScore;
        protected double selectedCourseScore;

        public override string type => "大学生";

        public CollegeStu(string name, int age, double requiredCourseScore, double selectedCourseScore) : base(name, age)
        {
            this.requiredCourseScore = requiredCourseScore;
            this.selectedCourseScore = selectedCourseScore;
        }

        public override double total()
        {
            return requiredCourseScore + selectedCourseScore;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + string.Format(", {0}, {1}岁, 总成绩为{2}", type, Age, total()); ;
        }
    }
}
