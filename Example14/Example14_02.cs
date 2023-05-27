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
    public partial class Example14_02 : Form
    {
        private Graphics g;
        private Pen p;
        private bool isMouseDown = false;
        private Point pStart, pEnd;


        private void Example14_02_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown= true;
            pStart = new Point(e.X, e.Y);
        }

        private void Example14_02_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown= false;
        }

        private void Example14_02_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMouseDown)
            {
                pEnd = new Point(e.X, e.Y);
                g.DrawLine(p, pEnd, pStart);
                pStart = pEnd;
            }
        }

        public Example14_02()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            p = new Pen(Color.Black);
            isMouseDown= false;
        }

    }
}
