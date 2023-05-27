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
    public partial class Test05_02 : Form
    {
        Figure f;
        public Test05_02()
        {
            InitializeComponent();
        }

        private void Test05_02_Load(object sender, EventArgs e)
        {

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            double r = double.Parse(txtRLengthBottom.Text);
            f = new Circle(r);
            lblShow.Text = "圆面积为" + f.Area;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            double length = double.Parse(txtRLengthBottom.Text);
            double width = double.Parse(txtWidhtHeight.Text);
            f = new Rectangle(length, width);
            lblShow.Text = "矩形面积为" + f.Area;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            double height = double.Parse(txtWidhtHeight.Text);
            double bottom = double.Parse(txtRLengthBottom.Text);
            f = new Triangle(height, bottom);

            lblShow.Text = "三角形面积为" + f.Area;
        }
    }

    abstract class Figure
    {
        public abstract double Area { get; }
    }

    class Circle : Figure
    {
        private double radius;
        public double Radius => radius;
        public override double Area { get { return radius * radius * Math.PI; } }
        public Circle(double r) { radius= r; } 
    }

    class Rectangle : Figure
    {
        private double length;
        private double width;

        public override double Area => length * width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

    }

    class Triangle : Figure
    {
        private double bottom;
        private double height;

        public override double Area => height * bottom / 2;

        public Triangle(double bottom, double height)
        {
            this.bottom = bottom;
            this.height = height;
        }
    }
}
