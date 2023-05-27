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
    public partial class Test4_1 : Form
    {
        public Test4_1() { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(int.Parse(tbX1.Text), int.Parse(tbY1.Text));
            Point p2 = new Point(int.Parse(tbX2.Text), int.Parse(tbY2.Text));
            double dist = p1.Distance(p2);

            tbResult.Text = dist.ToString();
        }
    }
    public class Point
    {
        private int _x;
        private int _y;
        public int x => _x; public int y => _y;
        public Point(int x, int y) { _x = x; _y = y; }

        public double Distance(Point p)
        {
            return Math.Sqrt((this._x - p._x) * (this._x - p._x) +
                (this._y - p._y) * (this._y - p._y));
        }
    }
}
