namespace CSharpCourse_NetFrameWork
{
    partial class Practice05_05
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
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnCommon = new System.Windows.Forms.Button();
            this.btnVIP = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(175, 68);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(109, 25);
            this.txtBalance.TabIndex = 0;
            // 
            // btnCommon
            // 
            this.btnCommon.Location = new System.Drawing.Point(303, 12);
            this.btnCommon.Name = "btnCommon";
            this.btnCommon.Size = new System.Drawing.Size(124, 34);
            this.btnCommon.TabIndex = 1;
            this.btnCommon.Text = "作为普通账户";
            this.btnCommon.UseVisualStyleBackColor = true;
            this.btnCommon.Click += new System.EventHandler(this.btnCommon_Click);
            // 
            // btnVIP
            // 
            this.btnVIP.Location = new System.Drawing.Point(303, 63);
            this.btnVIP.Name = "btnVIP";
            this.btnVIP.Size = new System.Drawing.Size(124, 34);
            this.btnVIP.TabIndex = 1;
            this.btnVIP.Text = "作为VIP账户";
            this.btnVIP.UseVisualStyleBackColor = true;
            this.btnVIP.Click += new System.EventHandler(this.btnVIP_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "存钱";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(303, 115);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(124, 34);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "取钱";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShow.Location = new System.Drawing.Point(23, 12);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(133, 137);
            this.lblShow.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(109, 25);
            this.txtName.TabIndex = 0;
            // 
            // Practice05_05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 175);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnVIP);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCommon);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBalance);
            this.Name = "Practice05_05";
            this.Text = "Test05_05";
            this.Load += new System.EventHandler(this.Practice05_05_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnCommon;
        private System.Windows.Forms.Button btnVIP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.TextBox txtName;
    }
}