using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourse_NetFrameWork.Test09_01
{
    public partial class Form1 : Form
    {
        Font font;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtxtShow.Font = new Font("宋体", 8);
            rtxtShow.ForeColor = Color.Black;
            cboFontSize.Items.Clear();
            for(int i = 5; i <= 72; i++)
            {
                cboFontSize.Items.Add(i.ToString());
            }
            font = rtxtShow.Font;
            cboFontSize.Text = font.Size.ToString();
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle fontStyle1, fontStyle2, fontStyle3, fontStyle4;
            fontStyle1 = FontStyle.Regular;
            fontStyle2 = FontStyle.Regular;
            fontStyle3 = FontStyle.Regular;
            fontStyle4 = FontStyle.Regular;

            if(chkStrong.Checked)
                fontStyle1 = FontStyle.Bold;
            if(chkItalic.Checked)
                fontStyle2 = FontStyle.Italic;
            if(chkUnderline.Checked)
                fontStyle3 = FontStyle.Underline;
            if (chkDeleteLine.Checked)
                fontStyle4 = FontStyle.Strikeout;

            font = new Font(font, fontStyle1 | fontStyle2 | fontStyle3 | fontStyle4);
            rtxtShow.Font = font;
        }

        private void rdoFontFamily_CheckedChanged(object sender, EventArgs e)
        {
            string fontFamily = font.FontFamily.Name;
            if(rdoSong.Checked)
                fontFamily = rdoSong.Text;
            if(rdoKai.Checked)
                fontFamily = rdoKai.Text;
            if(rdoLi.Checked)
                fontFamily = rdoLi.Text;
            if(rdoHei.Checked)
                fontFamily = rdoHei.Text;
            font = new Font(fontFamily, font.Size, font.Style);
            rtxtShow.Font = font;
        }

        private void rdoFontColor_CheckedChanged(object sender, EventArgs e)
        {
            Color color = rtxtShow.ForeColor;
            if(rdoBlack.Checked)
                color = Color.Black;
            if(rdoBlue.Checked)
                color = Color.Blue;
            if(rdoRed.Checked)
                color = Color.Red;
            if(rdoGreen.Checked)
                color = Color.Green;
            rtxtShow.ForeColor = color;
        }

        private void cboFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            float fontSize = Convert.ToSingle(cboFontSize.Text);
            font = new Font(font.FontFamily, fontSize, font.Style);
            rtxtShow.Font = font;
        }
    }
}
