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
    public partial class Test05_03 : Form
    {
        IPlayer ip;
        public Test05_03()
        {
            InitializeComponent();
        }

        private void btnMP3_Click(object sender, EventArgs e)
        {
            ip = new MP3();
            ShowClear();
            Show("已经切换为MP3模式");
        }

        private void btnAVI_Click(object sender, EventArgs e)
        {
            ip = new AVI();
            ShowClear();
            Show("已经切换为AVI模式");
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            ShowClear();
            Show(ip.Pre());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ShowClear();
            Show(ip.Next());
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            ShowClear();
            Show(ip.Play());
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            ShowClear();
            Show(ip.Pause());
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ShowClear();
            Show(ip.Stop());
        }

        void ShowClear()
        {
            lblShow.Text = string.Empty;
        }

        void Show(string s)
        {
            lblShow.Text += "\n" + s;
        }
    }

    interface IPlayer
    {
        string Play();
        string Stop();
        string Pause();
        string Pre();
        string Next();
    }

    class MP3 : IPlayer
    {
        public string Play() { return "正在播放MP3歌曲"; }
        public string Stop() { return "停止播放MP3歌曲"; }
        public string Pause() { return "暂停播放MP3歌曲"; }
        public string Pre() { return "播放上一首MP3歌曲"; }
        public string Next() { return "播放下一首MP3歌曲"; }
    }

    class AVI : IPlayer
    {
        public string Play() { return "正在播放AVI视频"; }
        public string Stop() { return "停止播放AVI视频"; }
        public string Pause() { return "暂停播放AVI视频"; }
        public string Pre() { return "播放上一首AVI视频"; }
        public string Next() { return "播放下一首AVI视频"; }
    }
}
