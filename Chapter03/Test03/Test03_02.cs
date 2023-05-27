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
    public partial class Test3_2 : Form
    {
        struct Student
        {
            public string name;
            public double score;
        };
        int i = 0;
        Student[] s = new Student[20]; 
        public Test3_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(i <= 20)
            {
                s[i].name = textBox1.Text;
                s[i].score = Convert.ToDouble(textBox2.Text);
                i++;
            }          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student max = s[0];
            foreach(Student student in s)
            {
                if (student.score > max.score)
                    max = student;
            }
            label3.Text = max.name + "\n";
            label3.Text += max.score.ToString();
        }
    }
}
