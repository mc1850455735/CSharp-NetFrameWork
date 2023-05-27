using CSharpCourse_NetFrameWork.Chapter14.Example14;
using System;
using System.Windows.Forms;

namespace CSharpCourse_NetFrameWork
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Example14_04());
        }
    }
}
