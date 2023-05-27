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
    public partial class Practice05_060708 : Form
    {
        public Practice05_060708()
        {
            InitializeComponent();
        }

        private void Practice05_06_Load(object sender, EventArgs e)
        {

        }
    }

    interface IDevice
    {
        string CheckStatus();
        string Start();
        string Stop();
        string Maintain();
        string Run();
    }

    public abstract class Device : IDevice
    {
        string DeviceID;
        string DeciveName;
        string UserName;
        string Venue;
        string Date;
        public Device(string deviceID, string deciveName, string userName, string venue, string date)
        {
            DeviceID = deviceID;
            DeciveName = deciveName;
            UserName = userName;
            Venue = venue;
            Date = date;
        }

        public abstract string CheckStatus();
        public abstract string Start();
        public abstract string Stop();
        public abstract string Maintain();
        public abstract string Run();

    }

    public class Mobile : Device
    {
        public Mobile(string deviceID, string deciveName, string userName, string venue, string date) 
            : base(deviceID, deciveName, userName, venue, date) { }
        public override string CheckStatus()
        {
            return "检查手机状态";
        }
        public override string Start() 
        {
            return "手机开始运行";
        }
        public override string Stop() 
        {
            return "手机停止运行";
        }
        public override string Maintain() 
        {
            return "手机正在维修";
        }
        public override string Run() 
        {
            return "手机开机";
        }
    }
}
