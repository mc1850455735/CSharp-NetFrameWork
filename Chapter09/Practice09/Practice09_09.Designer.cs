namespace CSharpCourse_NetFrameWork
{
    partial class Practice09_09
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.收支管理EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddExp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.基本资料DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddItems = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUser = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddExp = new System.Windows.Forms.ToolStripButton();
            this.tsbStatistics = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddItems = new System.Windows.Forms.ToolStripButton();
            this.tsbtsmUser = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.收支管理EToolStripMenuItem,
            this.基本资料DToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExit});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.系统管理ToolStripMenuItem.Text = "系统管理(&S)";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmExit.Size = new System.Drawing.Size(198, 26);
            this.tsmExit.Text = "退出(&X)";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // 收支管理EToolStripMenuItem
            // 
            this.收支管理EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddExp,
            this.tsmStatistics});
            this.收支管理EToolStripMenuItem.Name = "收支管理EToolStripMenuItem";
            this.收支管理EToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.收支管理EToolStripMenuItem.Text = "收支管理(&E)";
            // 
            // tsmAddExp
            // 
            this.tsmAddExp.Image = global::CSharpCourse_NetFrameWork.Properties.Resources.添加;
            this.tsmAddExp.Name = "tsmAddExp";
            this.tsmAddExp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmAddExp.Size = new System.Drawing.Size(228, 26);
            this.tsmAddExp.Text = "添加收支(P)";
            this.tsmAddExp.Click += new System.EventHandler(this.tsmAddExp_Click);
            // 
            // tsmStatistics
            // 
            this.tsmStatistics.Image = global::CSharpCourse_NetFrameWork.Properties.Resources.统计图;
            this.tsmStatistics.Name = "tsmStatistics";
            this.tsmStatistics.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmStatistics.Size = new System.Drawing.Size(228, 26);
            this.tsmStatistics.Text = "统计查询(&C)";
            // 
            // 基本资料DToolStripMenuItem
            // 
            this.基本资料DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddItems,
            this.tsmUser});
            this.基本资料DToolStripMenuItem.Name = "基本资料DToolStripMenuItem";
            this.基本资料DToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.基本资料DToolStripMenuItem.Text = "基本资料(&D)";
            // 
            // tsmAddItems
            // 
            this.tsmAddItems.Image = global::CSharpCourse_NetFrameWork.Properties.Resources.文件;
            this.tsmAddItems.Name = "tsmAddItems";
            this.tsmAddItems.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.tsmAddItems.Size = new System.Drawing.Size(251, 26);
            this.tsmAddItems.Text = "添加收支项目(&P)";
            // 
            // tsmUser
            // 
            this.tsmUser.Image = global::CSharpCourse_NetFrameWork.Properties.Resources.用户组;
            this.tsmUser.Name = "tsmUser";
            this.tsmUser.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.tsmUser.Size = new System.Drawing.Size(251, 26);
            this.tsmUser.Text = "用户管理(&U)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbout});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // tsmAbout
            // 
            this.tsmAbout.Image = global::CSharpCourse_NetFrameWork.Properties.Resources.信息;
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmAbout.Size = new System.Drawing.Size(200, 26);
            this.tsmAbout.Text = "关于(&A)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddExp,
            this.tsbStatistics,
            this.toolStripSeparator1,
            this.tsbAddItems,
            this.tsbtsmUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddExp
            // 
            this.tsbAddExp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddExp.Image = global::CSharpCourse_NetFrameWork.Properties.Resources.文件;
            this.tsbAddExp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddExp.Name = "tsbAddExp";
            this.tsbAddExp.Size = new System.Drawing.Size(68, 61);
            this.tsbAddExp.Text = "toolStripButton1";
            this.tsbAddExp.ToolTipText = "记录收支情况";
            this.tsbAddExp.Click += new System.EventHandler(this.tsmAddExp_Click);
            // 
            // tsbStatistics
            // 
            this.tsbStatistics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStatistics.Image = global::CSharpCourse_NetFrameWork.Properties.Resources.统计图;
            this.tsbStatistics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStatistics.Name = "tsbStatistics";
            this.tsbStatistics.Size = new System.Drawing.Size(68, 61);
            this.tsbStatistics.Text = "toolStripButton2";
            this.tsbStatistics.ToolTipText = "收支统计和查询";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 64);
            // 
            // tsbAddItems
            // 
            this.tsbAddItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddItems.Image = global::CSharpCourse_NetFrameWork.Properties.Resources.添加;
            this.tsbAddItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddItems.Name = "tsbAddItems";
            this.tsbAddItems.Size = new System.Drawing.Size(68, 61);
            this.tsbAddItems.Text = "toolStripButton3";
            this.tsbAddItems.ToolTipText = "添加收支类别";
            // 
            // tsbtsmUser
            // 
            this.tsbtsmUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtsmUser.Image = global::CSharpCourse_NetFrameWork.Properties.Resources.用户组;
            this.tsbtsmUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtsmUser.Name = "tsbtsmUser";
            this.tsbtsmUser.Size = new System.Drawing.Size(68, 61);
            this.tsbtsmUser.Text = "toolStripButton4";
            this.tsbtsmUser.ToolTipText = "用户信息管理";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tssMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Image = global::CSharpCourse_NetFrameWork.Properties.Resources.提示;
            this.tssStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(59, 20);
            this.tssStatus.Text = "就绪";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssMsg
            // 
            this.tssMsg.Name = "tssMsg";
            this.tssMsg.Size = new System.Drawing.Size(726, 20);
            this.tssMsg.Spring = true;
            this.tssMsg.Text = "请选择一个操作";
            this.tssMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Practice09_09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Practice09_09";
            this.Text = "Practice09_09";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem 收支管理EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAddExp;
        private System.Windows.Forms.ToolStripMenuItem tsmStatistics;
        private System.Windows.Forms.ToolStripMenuItem 基本资料DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAddItems;
        private System.Windows.Forms.ToolStripMenuItem tsmUser;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddExp;
        private System.Windows.Forms.ToolStripButton tsbStatistics;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAddItems;
        private System.Windows.Forms.ToolStripButton tsbtsmUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssMsg;
    }
}