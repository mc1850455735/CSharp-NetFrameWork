using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourse_NetFrameWork.Example14
{
    public partial class Example14_01 : Form
    {
        private Point startPoint, endPoint;
        private Graphics g;
        private Pen p;
        private Brush b;
        private Color c;
        private int width;

        public Example14_01()
        {
            InitializeComponent();
            c = Color.FromArgb(0, 0, 0);
            width = 1;
            p = new Pen(c, width);
            g = this.CreateGraphics();
        }

        private void Example14_01_MouseUp(object sender, MouseEventArgs e)
        {
            endPoint = new Point(e.X, e.Y);
            g.DrawLine(p, startPoint, endPoint);
        }

        private void Example14_01_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = new Point(e.X, e.Y);
        }

        private void BarColor_ValueChange(object sender, EventArgs e)
        {
            c = Color.FromArgb(hsbAlpha.Value, hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
            ReDrawLine();
        }

        private void BarWidth_ValueChange(object sender, EventArgs e)
        {
            width = vsbWidth.Value;
            ReDrawLine();
        }

        private void Example14_01_Load(object sender, EventArgs e)
        {

        }

        private void ReDrawLine()
        {
            p = new Pen(c, width);
            g.Clear(this.BackColor);
            g.DrawLine(p, startPoint, endPoint);
        }
    }
}
