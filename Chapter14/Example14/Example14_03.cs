using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourse_NetFrameWork.Example14
{
    public partial class Example14_03 : Form
    {
        Graphics g;
        Font font;
        Color startColor;
        Color endColor;
        public Example14_03()
        {
            InitializeComponent();
        }

        private void Example14_03_Load(object sender, EventArgs e)
        {

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if(dlgFont.ShowDialog() == DialogResult.OK)
            {
                font = dlgFont.Font;
            }
        }

        private void btnStartColor_Click(object sender, EventArgs e)
        {
            if(dlgColor.ShowDialog() == DialogResult.OK)
            {
                startColor = dlgColor.Color;
            }
        }

        private void btnEndColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                endColor = dlgColor.Color;
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            // 通过刷新面板来绘制文本
            pnlShow.Refresh();
        }

        private void pnlShow_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            // 创建一个渐变刷对象
            LinearGradientBrush lgBrush = new LinearGradientBrush(
                pnlShow.ClientRectangle, 
                startColor, endColor, 
                LinearGradientMode.Horizontal);
            StringFormat format = new StringFormat();   // 设置字符串格式
            format.Alignment = StringAlignment.Center;  // 设置在绘图区域内居中对齐
            format.FormatFlags = StringFormatFlags.LineLimit;   // 设置文本排列方式

            g.DrawString(txtSource.Text, font, lgBrush, pnlShow.ClientRectangle, format);
        }
    }
}
