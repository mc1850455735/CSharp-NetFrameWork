﻿using System;
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
    public partial class Practice09_09 : Form
    {
        public Practice09_09()
        {
            InitializeComponent();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmAddExp_Click(object sender, EventArgs e)
        {
            /*AddExpenditure addExpenditure = new AddExpenditure();
            addExpenditure.MdiParent = this;
            addExpenditure.Show();
            tssMsg.Text = addExpenditure.Text;*/
        }
    }
}
