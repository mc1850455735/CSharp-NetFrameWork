using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourse_NetFrameWork.Chapter14.Example14
{
    public partial class Example14_04 : Form
    {
        private Graphics g;
        private Pen p;
        // 两个矩形区域
        private Rectangle rect1, rect2;
        // 全局旋转和局部旋转的角度
        private float angle, langle;
        // 全局缩放和局部缩放的比例
        private float dx, dy, ldx, ldy;

        private void ngyScale_ValueChanged(object sender, EventArgs e)
        {
            dy = Convert.ToSingle(ngyScale.Value);
            this.Refresh();
        }

        private void ngxMove_ValueChanged(object sender, EventArgs e)
        {
            mx = Convert.ToSingle(ngxMove.Value);
            this.Refresh();
        }

        private void ngyMove_ValueChanged(object sender, EventArgs e)
        {
            my = Convert.ToSingle(ngyMove.Value);
            this.Refresh();
        }

        private void nlRotate_ValueChanged(object sender, EventArgs e)
        {
            langle = Convert.ToSingle(nlRotate.Value);
            this.Refresh();
        }

        private void nlxScale_ValueChanged(object sender, EventArgs e)
        {
            ldx = Convert.ToSingle(nlxScale.Value);
            this.Refresh();
        }

        private void nlyScale_ValueChanged(object sender, EventArgs e)
        {
            ldy = Convert.ToSingle(nlyScale.Value);
            this.Refresh();
        }

        private void nlxMove_ValueChanged(object sender, EventArgs e)
        {
            lmx = Convert.ToSingle(nlxMove.Value);
            this.Refresh();
        }

        private void nlyMove_ValueChanged(object sender, EventArgs e)
        {
            lmy = Convert.ToSingle(nlyMove.Value);
            this.Refresh();
        }


        private void ngxScale_ValueChanged(object sender, EventArgs e)
        {
            dx = Convert.ToSingle(ngxScale.Value);
            this.Refresh();
        }

        private void ngRotate_ValueChanged(object sender, EventArgs e)
        {
            angle = Convert.ToSingle(ngRotate.Value);
            this.Refresh();
        }

        // 全局平移和局部平移的分量
        private float mx, my, lmx, lmy;

        public Example14_04()
        {
            InitializeComponent();
            p = new Pen(Color.Black);
            rect1 = new Rectangle(0, 0, 100, 50);
            rect2 = new Rectangle(150, 0, 100, 50);
            angle = langle = 0;
            dx = dy = ldx = ldy = 1;
            mx = my = lmx = lmy =0;
        }

        private void Example14_04_Load(object sender, EventArgs e)
        {

        }

        private void Example14_04_Paint(object sender, PaintEventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(this.BackColor);        // 清除原有绘图
            g.RotateTransform(angle);       // 全局旋转
            g.ScaleTransform(dx, dy);       // 全局缩放
            g.TranslateTransform(mx, my);   // 全局移动

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(rect1);           // 在gp中以第一个矩形为依据添加椭圆
            Matrix matrix = new Matrix();
            float r = Convert.ToSingle(nlRotate.Value);
            matrix.Rotate(r);               // 为局部变形矩阵添加旋转量
            matrix.Scale(ldx, ldy);         // 为局部变形矩阵添加缩放量
            matrix.Translate(lmx, lmy);     // 为局部变形矩阵添加平移量
            gp.Transform(matrix);           // 以矩阵为依据对gp中的形状进行变化

            g.DrawPath(p, gp);
            g.DrawRectangle(p, rect2);
        }
    }
}
