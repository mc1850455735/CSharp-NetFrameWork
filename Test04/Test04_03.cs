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
    public partial class Test4_3 : Form
    {
        Grade g;   
        bool flag = false;
        public Test4_3()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = tbNameSearch.Text;
            int sum = 0;
            int i = g.SearchStudent(name);
            if (i == -1)
                tbDisplay.Text += "不存在该学生\n";
            else
                tbDisplay.Text += string.Format("{0}的总成绩为{1}\n", g.students[i]._name, g.students[i]._score);
        }

        private void Test4_3_Load(object sender, EventArgs e)
        {
            g = new Grade();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbNumber.Text == null)
            {
                MessageBox.Show("字符串不可以为空");
                return;
            }
            try
            {
                if (flag == false)
                {
                    int n = int.Parse(tbNumber.Text);
                    g.number = n;
                    g.students = new Student[n];
                    for(int i = 0;i < n; i++) { g.students[i] = new Student(); }
                    flag = true;
                    tbNumber.ReadOnly = true;
                    for (int i = 0; i < n; i++)
                    {
                        g.students[i]._id = i.ToString();
                        g.students[i]._name = i.ToString() ;
                        g.students[i]._chineseScore = i;
                        g.students[i]._mathScore = i;
                        g.students[i]._englishScore = i;
                    }
                }
                else
                {
                    MessageBox.Show("学生数量不能被修改");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "出现错误");
            }
            
        }

    }

    public class Student
    {
        public string _id = "";
        public string _name = "";
        public int _chineseScore;
        public int _mathScore;
        public int _englishScore;
        public int _score => _chineseScore + _mathScore + _englishScore;
    }

    public class Grade
    {
        public Student[] students;
        public int number;
        public enum Subject { CHINESE = 0, MATH = 1, ENGLISH = 2 }; 
        public Grade()
        {

        }
        public Grade(int n)
        {
            students= new Student[n];
            number = n;
        }
        public int SearchStudent(string name)
        {
            for(int i = 0; i < this.number; i++)
            {
                if (students[i]._name == name)
                    return i;
            }
            return -1;
        }

        public double AvgScore()
        {
            int sum = 0;
            for(int i = 0; i < this.number; i++)
            {
                sum += students[i]._score;
            }
            return (double)sum / this.number;
        }

        public int MaxScore(Subject model)
        {
            int max = 0;
            if(model == Subject.CHINESE) 
            { 
                for(int i = 0; i<this.number; i++) 
                    if(max < students[i]._chineseScore) 
                        max = students[i]._chineseScore; 
                return max; 
            } 
            if(model == Subject.MATH)
            {
                for (int i = 0; i < this.number; i++)
                    if (max < students[i]._mathScore)
                        max = students[i]._mathScore;
                return max;
            }
            if (model == Subject.ENGLISH)
            {
                for (int i = 0; i < this.number; i++)
                    if (max < students[i]._englishScore)
                        max = students[i]._englishScore;
                return max;
            }
            return -1;
        }

        public Student[] ThreeGoodStudent()
        {
            Student[] result = new Student[3];
            for(int i = 0; i < 3; i++)
            {
                Student max = students[0];
                for(int j = 0; j < this.number; i++)
                {
                    if(Array.IndexOf(result, students[j]) != -1 && max._score < students[j]._score)
                    {
                        max = students[j];
                    }
                }
                result[i] = max;
            }

            return result;
        }

        public Student[] NonPass(Subject model)
        {
            int num = 0;
            Student[] result;
            if(model == Subject.CHINESE)
            {
                for (int i = 0; i < this.number; i++)
                    if (students[i]._chineseScore < 60)
                        num++;
            }
            if (model == Subject.MATH)
            {
                for (int i = 0; i < this.number; i++)
                    if (students[i]._mathScore < 60)
                        num++;
            }
            if (model == Subject.ENGLISH)
            {
                for (int i = 0; i < this.number; i++)
                    if (students[i]._englishScore < 60)
                        num++;
            }

            result = new Student[num];
            int index = 0;
            if (model == Subject.CHINESE)
            {
                for (int i = 0; i < this.number; i++)
                    if (students[i]._chineseScore < 60)
                        result[index++] = students[i];
            }
            if (model == Subject.MATH)
            {
                for (int i = 0; i < this.number; i++)
                    if (students[i]._mathScore < 60)
                        result[index++] = students[i];
            }
            if (model == Subject.ENGLISH)
            {
                for (int i = 0; i < this.number; i++)
                    if (students[i]._englishScore < 60)
                        result[index++] = students[i];
            }

            return result;
        }

        public double[] ScoreRecent(Subject model)
        {
            double[] rents = new double[11];
            int[] oks = new int[11];
            if(model == Subject.CHINESE) { 
                for(int i = 0; i < this.number; i++)
                {
                    oks[students[i]._chineseScore / 10]++;
                }
                for(int i = 0; i < 11; i++)
                {
                    rents[i] = (double)oks[i] / this.number;
                }
            }
            if (model == Subject.MATH) {
                for (int i = 0; i < this.number; i++)
                {
                    oks[students[i]._mathScore / 10]++;
                }
                for (int i = 0; i < 11; i++)
                {
                    rents[i] = (double)oks[i] / this.number;
                }
            }
            if (model == Subject.ENGLISH) {
                for (int i = 0; i < this.number; i++)
                {
                    oks[students[i]._englishScore / 10]++;
                }
                for (int i = 0; i < 11; i++)
                {
                    rents[i] = (double)oks[i] / this.number;
                }
            }

            return rents;
        }
    }
}
